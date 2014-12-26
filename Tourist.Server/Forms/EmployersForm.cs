using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class EmployersForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private readonly MetroDateTime mDateTimePicker;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public EmployersForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mDateTimePicker = new MetroDateTime( );
		}

		#endregion

		#region Private Methods

		private void EmployersForm_Load( object sender, EventArgs e )
		{
			Shared.SetFormFullScreen( this );
			LoadDataToGrid( );
		}

		private void LoadDataToGrid( )
		{
			if ( Repository.IsEmpty( "Employees" ) )
				return;

			var managersMatrix = Repository.ListToMatrix( "Employees" );

			for ( var i = 0 ; i < Repository.Count( "Employees" ) ; i++ )
			{
				EmployeesDataGrid.Rows.Add( );

				for ( var j = 0 ; j < EmployeesDataGrid.ColumnCount ; j++ )
				{
					EmployeesDataGrid.Rows[ i ].Cells[ j ].Value = managersMatrix[ i, j ];
				}
			}
		}

		private void AddToRepository( List<string> rowValues )
		{
			var employer = Repository.Factory.CreateObject<Employer>( );

			employer.Id = Shared.ConvertStringToInt( rowValues[ 0 ] );
			employer.FirstName = rowValues[ 1 ];
			employer.LastName = rowValues[ 2 ];
			employer.Gender = ( Gender ) Shared.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			employer.Nationality = rowValues[ 4 ];
			employer.BirthDate = Shared.ConvertStringToDateTime( rowValues[ 5 ] );
			employer.Nif = Shared.ConvertStringToInt( rowValues[ 6 ] );
			employer.Address = rowValues[ 7 ];
			employer.Phone = Shared.ConvertStringToInt( rowValues[ 8 ] );
			employer.Email = rowValues[ 9 ];
			employer.Username = rowValues[ 10 ];
			employer.Password = rowValues[ 11 ];

			Repository.Append( employer, "Employees" );
		}

		#endregion

		#region Events

		private void EmployeesDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			var row = EmployeesDataGrid.Rows[ e.RowIndex ];
			var mangerIndex = e.RowIndex;
			int managerId;

			if ( mangerIndex <= Repository.Count( "Employees" ) - 1 )
				managerId = Repository.GetId( mangerIndex, "Employees" );
			else
				managerId = Repository.NextId( "Employer" );

			EmployeesDataGrid[ "IdColumn", e.RowIndex ].Value = managerId;
			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( managerId, "Employees" ) )
				{
					var rowValues = Shared.RowCellValues( row );
					AddToRepository( rowValues );
					MetroMessageBox.Show( this, "Employer Added With Sucess !!!", "Metro Title",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = e.FormattedValue.ToString( );

					switch ( e.ColumnIndex )
					{
						//FirstName
						case 1:
							Repository.Edit( "Employer", managerId, "FirstName", aNewValue );
							MetroMessageBox.Show( this, "Employer First Name Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Repository.Edit( "Employer", managerId, "LastName", aNewValue );
							MetroMessageBox.Show( this, "Employer Last Name Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Repository.Edit( "Employer", managerId, "Gender", aNewValue );
							MetroMessageBox.Show( this, "Employer Gender Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Repository.Edit( "Employer", managerId, "Nationality", aNewValue );
							MetroMessageBox.Show( this, "Employer Nationality Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Repository.Edit( "Employer", managerId, "BirthDate", aNewValue );
							MetroMessageBox.Show( this, "Employer Birth Date Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Repository.Edit( "Employer", managerId, "Nif", aNewValue );
							MetroMessageBox.Show( this, "Employer Nif Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Repository.Edit( "Employer", managerId, "Address", aNewValue );
							MetroMessageBox.Show( this, "Employer Address Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Repository.Edit( "Employer", managerId, "Phone", aNewValue );
							MetroMessageBox.Show( this, "Employer Phone Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Repository.Edit( "Employer", managerId, "Email", aNewValue );
							MetroMessageBox.Show( this, "Employer Email Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Username
						case 10:
							Repository.Edit( "Employer", managerId, "Username", aNewValue );
							MetroMessageBox.Show( this, "Employer Username Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Password
						case 11:
							Repository.Edit( "Employer", managerId, "Password", aNewValue );
							MetroMessageBox.Show( this, "Employer Password Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void EmployeesDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var managerToRemove = ( IEmployer ) Repository.GetObject( removeIndex, "Employees" );

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove employer at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( managerToRemove, "Employees" );
		}

		private void EmployeesDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = EmployeesDataGrid[ e.ColumnIndex, e.RowIndex ];
				EmployeesDataGrid.CurrentCell = cell;
				EmployeesDataGrid.BeginEdit( true );
			}
		}

		private void EmployeesDataGrid_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			//BirthDateColumn
			if ( e.ColumnIndex == 5 )
			{
				//Adding DateTimePicker control into DataGridView   
				EmployeesDataGrid.Controls.Add( mDateTimePicker );

				// Setting the format (i.e. 2014-10-10)  
				mDateTimePicker.Format = DateTimePickerFormat.Short;

				// It returns the retangular area that represents the Display area for a cell  
				var aRectangle = EmployeesDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );

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
			EmployeesDataGrid.CurrentCell.Value = mDateTimePicker.Text;
		}

		private void oDateTimePicker_CloseUp( object sender, EventArgs e )
		{
			// Hiding the control after use   
			mDateTimePicker.Visible = false;
		}

		#endregion

		#region Close Events

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
			if ( !Repository.IsEmpty( "Employees" ) )
			{
				mBackOrExit = true;
				Close( );

				mMainForm.Show( );
			}
			else
			{
				MetroMessageBox.Show( this, "\n Please insert a complete row before going to next Screen.",
								"Employer Data Empty or Not complete!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		#endregion

	}
}
