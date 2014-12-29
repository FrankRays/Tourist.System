using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

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

		#region Events

		private void EmployersForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
		}

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
			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( managerId, "Employees" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues );
					MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.AddString, 
					Properties.Resources.OperationSucessfull,MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = e.FormattedValue.ToString( );

					switch ( e.ColumnIndex )
					{
						//FirstName
						case 1:
							Repository.Edit( "Employer", managerId, "FirstName", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.FirstNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Repository.Edit( "Employer", managerId, "LastName", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.LastNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Repository.Edit( "Employer", managerId, "Gender", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.GenderEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Repository.Edit( "Employer", managerId, "Nationality", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.NationalityEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Repository.Edit( "Employer", managerId, "BirthDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.BirthDateEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Repository.Edit( "Employer", managerId, "Nif", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.NifEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Repository.Edit( "Employer", managerId, "Address", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.AddressEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Repository.Edit( "Employer", managerId, "Phone", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.PhoneEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Repository.Edit( "Employer", managerId, "Email", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.EmailEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Username
						case 10:
							Repository.Edit( "Employer", managerId, "Username", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.UsernameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Password
						case 11:
							Repository.Edit( "Employer", managerId, "Password", aNewValue );
							MessageBox.Show( this, Properties.Resources.EmployerString + Properties.Resources.PasswordEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
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

			DialogResult dialog = MessageBox.Show( this, Properties.Resources.RemoveString, Properties.Resources.RemoveTitle, 
			MessageBoxButtons.YesNo, MessageBoxIcon.Information );

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
				var aRectangle = EmployeesDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );

				EmployeesDataGrid.Controls.Add(mDateTimePicker);
				mDateTimePicker.Format = DateTimePickerFormat.Short;
				mDateTimePicker.Size = new Size( aRectangle.Width, aRectangle.Height );
				mDateTimePicker.Location = new Point(aRectangle.X, aRectangle.Y);
				mDateTimePicker.CloseUp += oDateTimePicker_CloseUp;
				mDateTimePicker.TextChanged += dateTimePicker_OnTextChange;
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
			if ( !Repository.IsEmpty( "Employees" ) )
			{
				mBackOrExit = true;
				Close( );

				mMainForm.Show( );
			}
			else
			{
				MessageBox.Show( this, Properties.Resources.CompleteRow, Properties.Resources.CompleteRowTitle, 
				MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		#endregion

		#region Private Methods

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

			employer.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
			employer.FirstName = rowValues[ 1 ];
			employer.LastName = rowValues[ 2 ];
			employer.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			employer.Nationality = rowValues[ 4 ];
			employer.BirthDate = SharedMethods.ConvertStringToDateTime( rowValues[ 5 ] );
			employer.Nif = SharedMethods.ConvertStringToInt( rowValues[ 6 ] );
			employer.Address = rowValues[ 7 ];
			employer.Phone = SharedMethods.ConvertStringToInt( rowValues[ 8 ] );
			employer.Email = rowValues[ 9 ];
			employer.Username = rowValues[ 10 ];
			employer.Password = rowValues[ 11 ];

			Repository.Append( employer, "Employees" );
		}

		#endregion

	}
}
