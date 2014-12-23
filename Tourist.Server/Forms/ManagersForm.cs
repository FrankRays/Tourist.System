using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class ManagersForm : MetroForm
	{

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );
		private MetroDateTime mDateTimePicker;

		public ManagersForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mDateTimePicker = new MetroDateTime( );
		}

		private void EmployersForm_Load( object sender, EventArgs e )
		{
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
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			if ( ! Repository.IsManagersEmpty() )
			{
				if ( ! Repository.IsManagersEmpty( ) && Repository.IsEmployeesEmpty( ) )
				{
					mBackOrExit = true;
					Close( );

					var employersForm = new EmployersForm( mMainForm );
					employersForm.Show( );
				}
				else
				{
					mBackOrExit = true;
					Close( );

					mMainForm.Show( );
				}
			}
		}

		private void ManagersDataGrid_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			//BirthDateColumn
			if ( e.ColumnIndex == 5 )
			{
				//Adding DateTimePicker control into DataGridView   
				ManagersDataGrid.Controls.Add( mDateTimePicker );

				// Setting the format (i.e. 2014-10-10)  
				mDateTimePicker.Format = DateTimePickerFormat.Short;

				// It returns the retangular area that represents the Display area for a cell  
				var aRectangle = ManagersDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );

				//Setting area for DateTimePicker Control  
				mDateTimePicker.Size = new Size( aRectangle.Width, aRectangle.Height );

				// Setting Location  
				mDateTimePicker.Location = new Point( aRectangle.X, aRectangle.Y );

				// An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
				mDateTimePicker.CloseUp += oDateTimePicker_CloseUp;

				// An event attached to dateTimePicker Control which is fired when any date is selected  
				mDateTimePicker.TextChanged += dateTimePicker_OnTextChange;

				// Now make it visible  
				mDateTimePicker.Visible = true;
			}

		}

		private void dateTimePicker_OnTextChange( object sender, EventArgs e )
		{
			// Saving the 'Selected Date on Calendar' into DataGridView current cell  
			ManagersDataGrid.CurrentCell.Value = mDateTimePicker.Text.ToString( );
		}

		private void oDateTimePicker_CloseUp( object sender, EventArgs e )
		{
			// Hiding the control after use   
			mDateTimePicker.Visible = false;
		}

		private void LoadDataToGrid( )
		{

			if ( Repository.IsManagersEmpty() )
				return;

			var bindingSource = new BindingSource { DataSource = Repository.MData.Managers};

			ManagersDataGrid.DataSource = bindingSource;

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

		private void EmployersDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove employer at row number " + ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			repository.RemoveEmployerOfEntity( removeIndex );
			
		}

		private void EmployersDataGrid_RowValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			var row = ManagersDataGrid.Rows[ e.RowIndex ];

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

					MetroMessageBox.Show( this, "Employer Added With Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
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

