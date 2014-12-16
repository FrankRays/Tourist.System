using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm : MetroForm
	{

		private MainForm mMainForm;
		private IRemote mRemote;
		private int mEntityId;
		private bool mBackOrExit = default( bool );


		public ClientsForm( Form aForm )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
			mRemote = mMainForm.Remote;
		}

		private void ClientsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );
			LoadDataToGrid( );
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

		private void LoadDataToGrid( )
		{
			if ( mRemote.IsRepositoryEmpty( ) )
				return;

			if ( mRemote.IsClientListEmpty( mEntityId ) )
				return;

			var clientsMatrix = mRemote.ClientsListToMatrix( mEntityId, ClientsDataGrid.ColumnCount );

			for ( var i = 0 ; i < mRemote.ClientsListCount( mEntityId ) ; i++ )
			{
				ClientsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ClientsDataGrid.ColumnCount ; j++ )
				{
					ClientsDataGrid.Rows[ i ].Cells[ j ].Value = clientsMatrix[ i, j ];
				}
			}
		}

		private void AddClientTomRemote( string[ ] args )
		{
			var client = mRemote.GetFactory( ).CreateClient( );

			var nextId = mRemote.MaxClientId( mEntityId ) + 1;

			client.Id = nextId;

			client.Gender = ( Gender ) Enum.Parse( typeof( Gender ), args[ 0 ] );
			client.FirstName = args[ 1 ];
			client.LastName = args[ 2 ];
			client.BirthDate = ConvertStringToDateTime( args[ 3 ] );
			client.Nif = Convert.ToInt32( args[ 4 ] );
			client.Address = args[ 5 ];
			client.PhoneNumber = Convert.ToInt32( args[ 6 ] );
			client.Email = args[ 7 ];

			mRemote.AddClientToEntity( mEntityId, client );
		}

		private void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
		}

		private void ClientsDataGrid_RowsValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			var row = ClientsDataGrid.Rows[ e.RowIndex ];

			var clientIndex = e.RowIndex;

			int clientId;

			if ( mRemote.IsClientsListIndexValid( mEntityId, clientIndex ) )
			{
				clientId = mRemote.GetClientId( mEntityId, clientIndex );
			}
			else
			{
				clientId = mRemote.MaxClientId( mEntityId ) + 1;
			}

			ClientsDataGrid[ "IdColumn", e.RowIndex ].Value = clientId;

			var isRowValidated = RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !mRemote.ClientAlreadyExists( mEntityId, clientId ) )
				{
					var buffer = RowCellValues( row );

					AddClientTomRemote( buffer );

					MetroMessageBox.Show( this, "Client Added With Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					if ( e.ColumnIndex == ClientsDataGrid.Columns[ "GenderColumn" ].Index )
					{

						if ( ClientsDataGrid[ "GenderColumn", e.RowIndex ].FormattedValue.ToString( ) == e.FormattedValue.ToString( ) )
							return;

						mRemote.EditClientGender( mEntityId,
													   clientId,
													 ( Gender ) Enum.Parse( typeof( Gender ), e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "FirstNameColumn" ].Index )
					{
						mRemote.EditClientFirstName( mEntityId, clientId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "LastNameColumn" ].Index )
					{
						mRemote.EditClientLastName( mEntityId, clientId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "BirthDateColumn" ].Index )
					{
						mRemote.EditClientBirthDate( mEntityId,
														  clientId,
														  ConvertStringToDateTime( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "NifColumn" ].Index )
					{
						mRemote.EditClientNif( mEntityId,
							clientId,
							Convert.ToInt32( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "AddressColumn" ].Index )
					{
						mRemote.EditClientAddress( mEntityId, clientId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "PhoneColumn" ].Index )
					{
						mRemote.EditClientPhoneNumber( mEntityId,
							clientId,
							Convert.ToInt32( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == ClientsDataGrid.Columns[ "EmailColumn" ].Index )
					{
						mRemote.EditClientEmail( mEntityId, clientId, e.FormattedValue.ToString( ) );

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

		private string[ ] RowCellValues( DataGridViewRow rows )
		{
			var buffer = new string[ 8 ];

			for ( int i = 1, j = 0 ; i < rows.Cells.Count ; i++, j++ )
			{
				buffer[ j ] = rows.Cells[ i ].EditedFormattedValue.ToString( );
			}
			return buffer;
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

		private void ClientsDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove client at row number " + ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if (dialog == DialogResult.No)
				return;

			mRemote.RemoveClientOfEntity( mEntityId, removeIndex );

			MetroMessageBox.Show( this, "Client at row number " + ( e.RowIndex + 1 ) + " removed with Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
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