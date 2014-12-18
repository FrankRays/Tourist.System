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
			LoadComboBoxValues();

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

		private void LoadComboBoxValues()
		{

			List<int> nifs = mRemote.GetAllClientsNif(mEntityId);

			var bindingSource = new BindingSource { DataSource = nifs };

			ClientNifColumn.DataSource = bindingSource;

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

		/*
		private void AddBookingToRemote( string[ ] args )
		{
			var booking = mRemote.Factory.CreateObject<Booking>( );

			var nextId = mRemote.MaxBookingId( mEntityId ) + 1;

			booking.Id = nextId;

			var clientName = args[ 1 ].Split( ' ' );

			booking.IClient = mRemote.GetClientFromClientList( mEntityId, Convert.ToInt32( args[ 0 ] ) );

			booking.BookingDateTime = ConvertStringToDateTime( args[ 2 ] );

			booking.BookingItens.ElementAt( 0 ).BookAble 
			
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

			var isRowValidated = RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !mRemote.BookingAlreadyExists( mEntityId, bookingId ) )
				{
					var buffer = RowCellValues( row );

					AddBookingTomRemote( buffer );

					MetroMessageBox.Show( this, "Booking Added With Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					if ( e.ColumnIndex == BookingsDataGrid.Columns[ "GenderColumn" ].Index )
					{

						if ( BookingsDataGrid[ "GenderColumn", e.RowIndex ].FormattedValue.ToString( ) == e.FormattedValue.ToString( ) )
							return;

						mRemote.EditBookingGender( mEntityId,
													   bookingId,
													 ( Gender ) Enum.Parse( typeof( Gender ), e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "FirstNameColumn" ].Index )
					{
						mRemote.EditBookingFirstName( mEntityId, bookingId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "LastNameColumn" ].Index )
					{
						mRemote.EditBookingLastName( mEntityId, bookingId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "BirthDateColumn" ].Index )
					{
						mRemote.EditBookingBirthDate( mEntityId,
														  bookingId,
														  ConvertStringToDateTime( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "NifColumn" ].Index )
					{
						mRemote.EditBookingNif( mEntityId,
							bookingId,
							Convert.ToInt32( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "AddressColumn" ].Index )
					{
						mRemote.EditBookingAddress( mEntityId, bookingId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "PhoneColumn" ].Index )
					{
						mRemote.EditBookingPhoneNumber( mEntityId,
							bookingId,
							Convert.ToInt32( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == BookingsDataGrid.Columns[ "EmailColumn" ].Index )
					{
						mRemote.EditBookingEmail( mEntityId, bookingId, e.FormattedValue.ToString( ) );

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

			if ( !IsDateFormat( aRow.Cells[ "BirthDateColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "BirthDateColumn" ].ErrorText = "The date format is mm/dd/yy";
				return false;
			}

			if ( !IsNumeric( aRow.Cells[ "NifColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "NifColumn" ].ErrorText = "The cell is not a number";
				return false;
			}

			if ( !IsNumeric( aRow.Cells[ "PhoneColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "PhoneColumn" ].ErrorText = "The cell is not a number";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "BirthDateColumn" ] );
			CellErrorRemove( aRow.Cells[ "NifColumn" ] );
			CellErrorRemove( aRow.Cells[ "PhoneColumn" ] );


			return !cellHasError.Any( bolean => bolean );
		}

		private bool IsNumeric( string isNumber )
		{
			int retNum;

			return ( int.TryParse( isNumber, out retNum ) );
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

		 * */
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
