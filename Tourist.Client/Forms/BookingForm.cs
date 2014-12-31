using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class BookingsForm : MetroForm
	{

		private readonly MainForm MainForm;
		private readonly IRemote Remote;
		private readonly MetroDateTime mDateTimePicker;
		private readonly BindingSource mNifsbBindingSource;
		private readonly BindingSource mIdBindingSource;
		private bool mBackOrExit = default( bool );
		
		

		public BookingsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );

			MainForm = aForm as MainForm;
			Remote = aRemote;
			mDateTimePicker = new MetroDateTime();
			mNifsbBindingSource = new BindingSource( );
			mIdBindingSource = new BindingSource( );
		}

		private void BookingsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			NifComboBoxLoad( );
			LoadDataToGrids( );
		}


		private void NifComboBoxLoad( )
		{
			mNifsbBindingSource.DataSource = Remote.ClientsNifList( );
			R_ClientNifColumn.DataSource = mNifsbBindingSource;
			A_ClientNifColumn.DataSource = mNifsbBindingSource;
			T_ClientNifColumn.DataSource = mNifsbBindingSource;
		}

		private void LoadDataToGrids( )
		{
			LoadRoomsDataToGrid( );
			LoadActivitiesDataToGrid( );
			LoadTransportsDataToGrid( );
		}

		private void LoadRoomsDataToGrid( )
		{
			if ( Remote.IsEmpty( "Bookings" ) )
				return;

			var roomMatrix = Remote.ListToMatrix( "Bookings", "Room" );

			for ( var i = 0 ; i < Remote.Count( "Bookings" ) ; i++ )
			{
				RoomBookingsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < RoomBookingsDataGrid.ColumnCount ; j++ )
				{
					RoomBookingsDataGrid.Rows[ i ].Cells[ j ].Value = roomMatrix[ i, j ];
				}
			}
		}

		private void LoadActivitiesDataToGrid( )
		{

			if ( Remote.IsEmpty( "Bookings" ) )
				return;

			var activityMatrix = Remote.ListToMatrix( "Bookings", "Activity" );

			for ( var i = 0 ; i < Remote.Count( "Activities" ) ; i++ )
			{
				ActivitiesBookingDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ActivitiesBookingDataGrid.ColumnCount ; j++ )
				{
					ActivitiesBookingDataGrid.Rows[ i ].Cells[ j ].Value = activityMatrix[ i, j ];
				}
			}
		}

		private void LoadTransportsDataToGrid( )
		{

			if ( Remote.IsEmpty( "Bookings" ) )
				return;

			var transportMatrix = Remote.ListToMatrix( "Bookings", "Transport" );

			for ( var i = 0 ; i < Remote.Count( "Bookings" ) ; i++ )
			{
				TransportBookingsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < TransportBookingsDataGrid.ColumnCount ; j++ )
				{
					TransportBookingsDataGrid.Rows[ i ].Cells[ j ].Value = transportMatrix[ i, j ];
				}
			}
		}

		private void AddToRepository( List<string> rowValues )
		{
			var booking = Remote.Factory.CreateObject<Booking>( );
			booking.Client = Remote.GetClientByNif( SharedMethods.ConvertStringToInt( rowValues[ 1 ] ) );
			booking.Bookable = Remote.GetBookable( rowValues[ 3 ], SharedMethods.ConvertStringToInt( rowValues[ 4 ] ) );
			booking.BookingDate = SharedMethods.ConvertStringToDateTime( rowValues[ 7 ] );
			booking.TimeFrame.StartDateTime = SharedMethods.ConvertStringToDateTime( rowValues[ 8 ] );
			booking.TimeFrame.EndDateTime = SharedMethods.ConvertStringToDateTime( rowValues[ 9 ] );
			booking.TotaPrice = SharedMethods.ConvertStringToDouble( rowValues[ 10 ] );
			Remote.Append( booking, "Bookings" );
		}

		#region Rooms Events

		private void RoomBookingsDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			
			var row = RoomBookingsDataGrid.Rows[ e.RowIndex ];
			var roomBookingIndex = e.RowIndex;
			var aNewValue = e.FormattedValue.ToString( );
			int bookingId;
			var clientNif = RoomBookingsDataGrid[ "R_ClientNifColumn", e.RowIndex ].Value.ToString( );
			var roomType = RoomBookingsDataGrid[ "R_TypeColumn", e.RowIndex ].Value.ToString( );
			var roomId = RoomBookingsDataGrid[ "R_RoomIdColumn", e.RowIndex ].Value.ToString( );
			var checkInDate = RoomBookingsDataGrid[ "R_CheckInDateColumn", e.RowIndex ].Value.ToString( ); 
			var checkOutDate = RoomBookingsDataGrid[ "R_CheckOutDateColumn", e.RowIndex ].Value.ToString( );

			if ( roomBookingIndex <= Remote.Count( "Bookings" ) - 1 )
				bookingId = Remote.GetId( roomBookingIndex, "Bookings" );
			else
				bookingId = Remote.NextId( "Booking" );

			RoomBookingsDataGrid[ "R_IdColumn", e.RowIndex ].Value = bookingId;
			RoomBookingsDataGrid[ "R_BookingDateColumn", e.RowIndex ].Value = DateTime.Now.Date.ToString( "d" );

			if ( !string.IsNullOrEmpty( clientNif ) )
			{
				var client = Remote.GetClientByNif( SharedMethods.ConvertStringToInt( clientNif ) );
				RoomBookingsDataGrid[ "R_ClientName", e.RowIndex ].Value = client.FirstName + " " + client.LastName;
			}

			if ( !string.IsNullOrEmpty( roomType ) )
			{
				mIdBindingSource.DataSource = Remote.GetBooKablesIds("Room", roomType);
				R_RoomIdColumn.DataSource = mIdBindingSource;
				RoomBookingsDataGrid[ "R_BasePriceColumn", e.RowIndex ].Value = 
				Remote.GetBasePrice( roomType ).ToString( "0.00", CultureInfo.InvariantCulture );

			}

			if ( !string.IsNullOrEmpty( roomId ) )
			{
				RoomBookingsDataGrid[ "R_DescriptionColumn", e.RowIndex ].Value =
				Remote.GetBookableDescription( SharedMethods.ConvertStringToInt( roomId ), roomType );
			}

			if ( !string.IsNullOrEmpty( checkInDate ) && !string.IsNullOrEmpty( checkOutDate ) && !string.IsNullOrEmpty( roomType ) )
			{
				var dtr = new DateTimeRange();

				dtr.StartDateTime = SharedMethods.ConvertStringToDateTime(checkInDate);
				dtr.EndDateTime = SharedMethods.ConvertStringToDateTime(checkOutDate);
			
				RoomBookingsDataGrid["R_TotalPriceColumn", e.RowIndex].Value =
				(Remote.GetBasePrice(roomType)*dtr.DiferenceTimeSpan().Days).ToString("0.00", CultureInfo.InvariantCulture);

			}

			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Remote.ExistingId( bookingId, "Rooms" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues );
					MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.AddString,
					Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
					RoomBookingsDataGrid["R_TypeColumn", e.RowIndex].ReadOnly = true;
					RoomBookingsDataGrid[ "R_RoomIdColumn", e.RowIndex ].ReadOnly = true;

				}
				else
				{
					switch ( e.ColumnIndex )
					{
						//Client Nif
						case 1:
							Remote.Edit( "Booking", bookingId, "Client", aNewValue );
							MessageBox.Show( this, Properties.Resources.BookingString + Properties.Resources.TypeEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//check in
						case 8:
							Remote.Edit( "Booking", bookingId, "StartDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.DescriptionEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//checkout
						case 9:
							Remote.Edit( "Room", bookingId, "EndDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.DescriptionEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		// falta atualizar para a novo metodo remove do repositorio
		private void RoomBookingsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			var removeIndex = e.RowIndex;

			Remote.Remove( removeIndex, "Bookings" );
		}

		private void RoomBookingsDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = RoomBookingsDataGrid[ e.ColumnIndex, e.RowIndex ];
				RoomBookingsDataGrid.CurrentCell = cell;
				RoomBookingsDataGrid.BeginEdit( true );
			}
		}

		#endregion
	
		private void RoomBookingsDataGrid_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			//BirthDateColumn
			if ( e.ColumnIndex == 5 )
			{
				RoomBookingsDataGrid.Controls.Add( mDateTimePicker );
				mDateTimePicker.Format = DateTimePickerFormat.Short;
				var aRectangle = RoomBookingsDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );
				mDateTimePicker.Size = new Size( aRectangle.Width, aRectangle.Height );
				mDateTimePicker.Location = new Point( aRectangle.X, aRectangle.Y );
				mDateTimePicker.CloseUp += oDateTimePicker_CloseUp;
				mDateTimePicker.TextChanged += dateTimePicker_OnTextChange;
				mDateTimePicker.Visible = true;
			}
		}

		private void dateTimePicker_OnTextChange( object sender, EventArgs e )
		{
			// Saving the 'Selected Date on Calendar' into DataGridView current cell  
			RoomBookingsDataGrid.CurrentCell.Value = mDateTimePicker.Text;
		}

		private void oDateTimePicker_CloseUp( object sender, EventArgs e )
		{
			// Hiding the control after use   
			mDateTimePicker.Visible = false;
		}
		#region Close Events

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Properties.Resources.ExitMessage,
				Properties.Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			MainForm.Show( );
		}

		#endregion

	}
}
