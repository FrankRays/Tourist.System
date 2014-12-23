using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Classes;
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
			Shared.SetFormFullScreen( this );
			LoadDataToGrid( );
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
			if ( !Repository.IsEmpty( "Managers" ) )
			{
				if ( !Repository.IsEmpty( "Managers" ) && Repository.IsEmpty( "Employees" ) )
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

		private void LoadDataToGrid( )
		{

			if ( Repository.IsEmpty( "Managers" ) )
				return;

			var bindingSource = new BindingSource { DataSource = Repository.MData.Managers };

			ManagersDataGrid.DataSource = bindingSource;

		}

		private void AddToRepository( List<string> rowValues )
		{
			var manager = Repository.Factory.CreateObject<Manager>( );

			var nextId = Repository.NextId( "Manager" );

			manager.Id = nextId;

			manager.FirstName = rowValues[ 1 ];
			manager.LastName = rowValues[ 2 ];
			manager.Gender = ( Gender ) Shared.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			manager.Nationality = rowValues[ 4 ];
			manager.BirthDate = Shared.ConvertStringToDateTime( rowValues[ 5 ] );
			manager.Nif = Shared.ConvertStringToInt( rowValues[ 6 ] );
			manager.Address = rowValues[ 7 ];
			manager.PhoneNumber = Shared.ConvertStringToInt( rowValues[ 8 ] );
			manager.Email = rowValues[ 9 ];
			manager.Username = rowValues[ 10 ];
			manager.Password = rowValues[ 11 ];

			Repository.Append( manager, "Manager" );
		}

		private void ManagersDataGrid_RowValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			var row = ManagersDataGrid.Rows[ e.RowIndex ];

			var mangerIndex = e.RowIndex;

			int managerId;

			if ( mangerIndex <= Repository.Count( "Managers" ) - 1 )
			{
				managerId = Repository.GetId( mangerIndex, "Managers" );
			}
			else
			{
				managerId = Repository.NextId( "Managers" );
			}

			ManagersDataGrid[ "IdColumn", e.RowIndex ].Value = managerId;

			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( managerId, "Managers" ) )
				{
					var rowValues = Shared.RowCellValues( row );

					AddToRepository( rowValues );

					MetroMessageBox.Show( this, "Employer Added With Sucess !!!", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					if ( e.ColumnIndex == EmployersDataGrid.Columns[ "GenderColumn" ].Index )
					{

						if ( EmployersDataGrid[ "GenderColumn", e.RowIndex ].FormattedValue.ToString( ) == e.FormattedValue.ToString( ) )
							return;

						Repository.EditEmployerGender( mEntityId,
													   managerId,
													 ( Gender ) Enum.Parse( typeof( Gender ), e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "FirstNameColumn" ].Index )
					{
						Repository.EditEmployerFirstName( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "LastNameColumn" ].Index )
					{
						Repository.EditEmployerLastName( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "BirthDateColumn" ].Index )
					{
						Repository.EditEmployerBirthDate( mEntityId,
														  managerId,
														  ConvertStringToDateTime( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "AddressColumn" ].Index )
					{
						Repository.EditEmployerAddress( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "PhoneColumn" ].Index )
					{
						Repository.EditEmployerPhoneNumber( mEntityId,
															managerId,
															Convert.ToInt32( e.FormattedValue.ToString( ) ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "EmailColumn" ].Index )
					{
						Repository.EditEmployerEmail( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "UsernameColumn" ].Index )
					{
						Repository.EditEmployerUsername( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
					else if ( e.ColumnIndex == EmployersDataGrid.Columns[ "PasswordColumn" ].Index )
					{
						Repository.EditEmployerPassword( mEntityId, managerId, e.FormattedValue.ToString( ) );

					}
				}
			}
		}

		private void ManagersDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove employer at row number " + ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.RemoveEmployerOfEntity( removeIndex );

		}

		#region DataPicker Events

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

		#endregion
	}
}

