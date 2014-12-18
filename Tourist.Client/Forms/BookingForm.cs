using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class BookingsForm : MetroForm
	{
		private MainForm mMainForm;
		private IRemote mRemote;
		private int mEntityId;
		private bool mBackOrExit = default( bool );

		public BookingsForm( Form aForm )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
			mRemote = mMainForm.Remote;
		}

		private void BookingsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );
			LoadComboBoxValues( );

		}

		private void SetFormFullScreen( )
		{
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );

			FormBorderStyle = FormBorderStyle.None;
			Focus( );
		}

		private void LoadComboBoxValues( )
		{
			List<int> nifs = mRemote.GetAllClientsNif( mEntityId );
			List<string> bookables = mRemote.GetAllBookables( mEntityId );

			var bindingSource1 = new BindingSource { DataSource = nifs };
			var bindingSource2 = new BindingSource { DataSource = bookables };

			ClientNifColumn.DataSource = bindingSource1;
			ServiceColumn.DataSource = bindingSource2;

		}

		private void LoadDataToGrid( )
		{
			if ( mRemote.IsRepositoryEmpty( ) )
				return;

			if ( mRemote.IsBookingListEmpty( mEntityId ) )
				return;

			var bookingsMatrix = mRemote.BookingsListToMatrix( mEntityId, BookingsDataGrid.ColumnCount );

			for ( var i = 0 ; i < mRemote.BookingListCount( mEntityId ) ; i++ )
			{
				BookingsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < BookingsDataGrid.ColumnCount ; j++ )
				{
					BookingsDataGrid.Rows[ i ].Cells[ j ].Value = bookingsMatrix[ i, j ];
				}
			}
		}

		private void AddBookingToRemote( string[ ] args )
		{
			var booking = mRemote.Factory.CreateObject<Booking>( );

			var nextId = mRemote.MaxBookingId( mEntityId ) + 1;

			booking.Id = nextId;

			var bookable = args[ 3 ].Split( '-' );

			booking.IClient = mRemote.GetClientFromClientList( mEntityId, Convert.ToInt32( args[ 0 ] ) );

			booking.BookingDateTime = ConvertStringToDateTime( args[ 2 ] );

			booking.BookingItens.ElementAt( 0 ).BookAble = mRemote.GetBookableFromBookablesList( mEntityId, Convert.ToInt32( bookable[ 0 ] ) );

			booking.TimeRange.StartDateTime = ConvertStringToDateTime( args[ 5 ] );
			booking.TimeRange.EndDateTime = ConvertStringToDateTime( args[ 6 ] );

			mRemote.AddBookingToEntity( mEntityId, booking );
		}

		private string[ ] RowCellValues( DataGridViewRow rows )
		{
			var buffer = new string[ 8 ];

			for ( int i = 1, j = 0 ; i < rows.Cells.Count ; i++, j++ )
			{
				buffer[ j ] = rows.Cells[ i ].EditedFormattedValue.ToString( );
			}
			return buffer;
		}

		private void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
		}

		private void BookingsDataGrid_RowsValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			var row = BookingsDataGrid.Rows[ e.RowIndex ];

			var bookingIndex = e.RowIndex;

			var bookable = BookingsDataGrid["ServiceColumn", e.RowIndex].Value.ToString().Split('-');

			int bookingId;

			if ( mRemote.IsBookingListIndexValid( mEntityId, bookingIndex ) )
			{
				bookingId = mRemote.GetBookingId( mEntityId, bookingIndex );
			}
			else
			{
				bookingId = mRemote.MaxBookingId( mEntityId ) + 1;
			}

			BookingsDataGrid[ "IdColumn", e.RowIndex ].Value = bookingId;
			
			BookingsDataGrid["ClientNameColumn", e.RowIndex].Value = mRemote.GetClientFullName(mEntityId,
			Convert.ToInt32(BookingsDataGrid["ClientNameColumn", e.RowIndex].FormattedValue.ToString()));
			
			BookingsDataGrid[ "BookingDateColumn", e.RowIndex ].Value = DateTime.Now.ToString("d");

			BookingsDataGrid["UnitPriceColumn", e.RowIndex].Value =
				mRemote.GetBookableFromBookablesList(mEntityId,Convert.ToInt32(bookable[0])).Type;

			if ( ! (string.IsNullOrEmpty(BookingsDataGrid["CheckInDateColumn", e.RowIndex].Value.ToString()) &&
			       string.IsNullOrEmpty(BookingsDataGrid["CheckOutDateColumn", e.RowIndex].Value.ToString())))
			{
				DateTimeRange dtr = new DateTimeRange();

				dtr.StartDateTime = ConvertStringToDateTime(BookingsDataGrid["CheckInDateColumn", e.RowIndex].Value.ToString());
				dtr.StartDateTime = ConvertStringToDateTime(BookingsDataGrid["CheckOutDateColumn", e.RowIndex].Value.ToString());

				var days = dtr.DiferenceTimeSpan().Days;

				BookingsDataGrid["TotalPriceColumn", e.RowIndex].Value =
					Convert.ToInt32(BookingsDataGrid["UnitPriceColumn", e.RowIndex].Value.ToString())*days;

			}
			else
			{
				BookingsDataGrid["TotalPriceColumn", e.RowIndex].Value = 0;
			}

			var isRowValidated = RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !mRemote.BookingAlreadyExists( mEntityId, bookingId ) )
				{
					var buffer = RowCellValues( row );

					AddBookingToRemote( buffer );

					MetroMessageBox.Show( this, "Booking Added With Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					if ( e.ColumnIndex == BookingsDataGrid.Columns[ "CheckInDateColumn" ].Index ) 
					{

						mRemote.EditBookingCheckOutInDate( mEntityId,
													       bookingId,
														   ConvertStringToDateTime( e.FormattedValue.ToString( ) ), "Check-In-Date" );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "CheckOutDateColumn" ].Index )
					{

						mRemote.EditBookingCheckOutInDate( mEntityId,
														   bookingId,
														   ConvertStringToDateTime( e.FormattedValue.ToString( ) ), "Check-Out-Date" );
					}
				}
			}
		}


		private bool RowCellsValidated( DataGridViewRow aRow )
		{

			var cellHasError = new bool[ aRow.Cells.Count ];

			for ( var i = 0 ; i < aRow.Cells.Count - 1 ; i++ )
			{
				cellHasError[ i ] = false;
			}

			for ( var i = 1 ; i < aRow.Cells.Count ; i++ )
			{
				if ( aRow.Cells[ i ].EditedFormattedValue.ToString( ).Length == 0 )
				{
					aRow.Cells[ i ].ErrorText = "This Cell can´t be empty!";

					cellHasError[ i - 1 ] = true;
				}
				else
				{
					CellErrorRemove( aRow.Cells[ i ] );
				}
			}

			if ( !IsDateFormat( aRow.Cells[ "CheckInColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "CheckInColumn" ].ErrorText = "The date format is mm/dd/yy";
				return false;
			}

			if ( !IsDateFormat( aRow.Cells[ "CheckOutColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "CheckOutColumn" ].ErrorText = "The date format is mm/dd/yy";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "CheckInColumn" ] );
			CellErrorRemove( aRow.Cells[ "CheckOutColumn" ] );

			return !cellHasError.Any( bolean => bolean );
		}


		private bool IsDateFormat( string aDate )
		{
			return CheckDateStringFormat( aDate );
		}

		private bool CheckDateStringFormat( string aDate )
		{
			var date = aDate.Split( '/' );

			if ( date.Length == 3 )
			{
				var day = date[ 0 ];
				var month = date[ 1 ];
				var year = date[ 2 ];

				return ( Convert.ToInt32( day ) >= 1 && Convert.ToInt32( day ) <= 31 ) &&
					   ( Convert.ToInt32( month ) >= 1 && Convert.ToInt32( month ) <= 12 ) &&
					   ( Convert.ToInt32( year ) >= 1900 );
			}

			return false;
		}

		private DateTime ConvertStringToDateTime( string aDate )
		{
			try
			{
				var convertedDate = Convert.ToDateTime( aDate );

				return convertedDate;
			}
			catch ( FormatException )
			{
				Console.WriteLine( "'{0}' is not in the proper format.", aDate );
			}

			return new DateTime( );
		}

		private void BookingsDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove Booking at row number " + ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			mRemote.RemoveBookingOfEntity( mEntityId, removeIndex );

			MetroMessageBox.Show( this, "Booking at row number " + ( e.RowIndex + 1 ) + " removed with Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}


		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}

	}
}
