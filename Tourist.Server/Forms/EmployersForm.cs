using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class EmployersForm : MetroForm
	{
		private readonly MainForm mMainForm;
		private readonly Repository repository = Repository.Instance;
		private bool mBackOrExit = default( bool );
		private readonly int mEntityId;

		public EmployersForm( Form aForm )
		{

			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
		}

		private void EmployersForm_Load( object sender, EventArgs e )
		{
			LoadDataToGrid( );
			SetFormFullScreen( );
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
			if ( repository.IsEmpty( ) )
				return;

			if ( repository.IsEmployersListEmpty( mEntityId ) )
				return;

			var employersMatrix = repository.EmployersListToMatrix( mEntityId, EmployersDataGrid.ColumnCount );

			for ( var i = 0 ; i < repository.EmployersListCount( mEntityId ) ; i++ )
			{
				EmployersDataGrid.Rows.Add( );

				for ( var j = 0 ; j < EmployersDataGrid.ColumnCount ; j++ )
				{
					EmployersDataGrid.Rows[ i ].Cells[ j ].Value = employersMatrix[ i, j ];
				}
			}
		}

		private void AddEmployerToRepository( string[ ] args )
		{
			var employer = repository.Factory.CreateEmployer( );

			var nextId = repository.MaxEmployerId( mEntityId ) + 1;

			employer.Id = nextId;

			employer.Gender = ( Gender ) Enum.Parse( typeof( Gender ), args[ 0 ] );
			employer.FirstName = args[ 1 ];
			employer.LastName = args[ 2 ];
			employer.BirthDate = ConvertStringToDateTime( args[ 3 ] );
			employer.Address = args[ 4 ];
			employer.PhoneNumber = Convert.ToInt32( args[ 5 ] );
			employer.Email = args[ 6 ];
			employer.Username = args[ 7 ];
			employer.Password = args[ 8 ];

			repository.AddEmployerToEntity( mEntityId, employer );
		}

		private void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
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

			CellErrorRemove( aRow.Cells[ "BirthDateColumn" ] );


			if ( !IsNumeric( aRow.Cells[ "PhoneColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "PhoneColumn" ].ErrorText = "The cell is not a number";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "PhoneColumn" ] );


			return !cellHasError.Any( bolean => bolean );
		}

		private string[ ] RowCellValues( DataGridViewRow rows )
		{
			var buffer = new string[ 9 ];

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

		private void EmployersDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var aRow = EmployersDataGrid.Rows[ e.RowIndex ];

			
			repository.RemoveEmployerOfEntity( mEntityId, removeIndex );
			
			/*
			else
			{
				if ( aRow.IsNewRow )
					return;

				for ( int i = 1 ; i < aRow.Cells.Count ; i++ )
				{
					CellErrorRemove( aRow.Cells[ i ] );
				}

				EmployersDataGrid.Rows.Remove( aRow );
			}
			*/
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

		private void EmployersDataGrid_RowValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			var row = EmployersDataGrid.Rows[ e.RowIndex ];

			var employerIndex = e.RowIndex;

			int employerId;

			if ( repository.IsEmployersListIndexValid( mEntityId, employerIndex ) )
			{
				employerId = repository.GetEmployerId( mEntityId, employerIndex );
			}
			else
			{
				employerId = repository.MaxEmployerId( mEntityId ) + 1;
			}

			EmployersDataGrid[ "IdColumn", e.RowIndex ].Value = employerId;

			var isRowValidated = RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !repository.EmployerAlreadyExists( mEntityId, employerId ) )
				{
					var buffer = RowCellValues( row );

					AddEmployerToRepository( buffer );

					//MetroMessageBox.Show( this, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					if ( e.ColumnIndex == EmployersDataGrid.Columns[ "GenderColumn" ].Index )
					{

						if (EmployersDataGrid["GenderColumn", e.RowIndex].FormattedValue.ToString() == e.FormattedValue.ToString())
							return;

						repository.EditEmployerGender( mEntityId,
													   employerId,
													 ( Gender ) Enum.Parse( typeof( Gender ), e.FormattedValue.ToString( ) ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "FirstNameColumn" ].Index )
					{
						repository.EditEmployerFirstName( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "LastNameColumn" ].Index )
					{
						repository.EditEmployerLastName( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "BirthDateColumn" ].Index )
					{
						repository.EditEmployerBirthDate( mEntityId,
														  employerId,
														  ConvertStringToDateTime( e.FormattedValue.ToString( ) ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "AddressColumn" ].Index )
					{
						repository.EditEmployerAddress( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "PhoneColumn" ].Index )
					{
						repository.EditEmployerPhoneNumber( mEntityId,
															employerId,
															Convert.ToInt32( e.FormattedValue.ToString( ) ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "EmailColumn" ].Index )
					{
						repository.EditEmployerEmail( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "UsernameColumn" ].Index )
					{
						repository.EditEmployerUsername( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "PasswordColumn" ].Index )
					{
						repository.EditEmployerPassword( mEntityId, employerId, e.FormattedValue.ToString( ) );
						
					}
				}
			}
		}
	}
}
