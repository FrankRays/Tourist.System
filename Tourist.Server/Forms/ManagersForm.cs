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
	public partial class ManagersForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private readonly MetroDateTime mDateTimePicker;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public ManagersForm( Form aForm )
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

		private void ManagersDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			var row = ManagersDataGrid.Rows[ e.RowIndex ];
			var mangerIndex = e.RowIndex;
			int managerId;

			if ( mangerIndex <= Repository.Count( "Managers" ) - 1 )
				managerId = Repository.GetId( mangerIndex, "Managers" );
			else
				managerId = Repository.NextId( "Manager" );

			ManagersDataGrid[ "IdColumn", e.RowIndex ].Value = managerId;
			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( managerId, "Managers" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues );
					MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.AddString, 
						Properties.Resources.OperationSucessfull,MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = e.FormattedValue.ToString( );

					switch ( e.ColumnIndex )
					{
						//FirstName
						case 1:
							Repository.Edit( "Manager", managerId, "FirstName", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.FirstNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Repository.Edit( "Manager", managerId, "LastName", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.LastNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Repository.Edit( "Manager", managerId, "Gender", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.GenderEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Repository.Edit( "Manager", managerId, "Nationality", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.NationalityEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Repository.Edit( "Manager", managerId, "BirthDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.BirthDateEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Repository.Edit( "Manager", managerId, "Nif", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.NifEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Repository.Edit( "Manager", managerId, "Address", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.AddressEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Repository.Edit( "Manager", managerId, "Phone", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.PhoneEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Repository.Edit( "Manager", managerId, "Email", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.EmailEdited,
											Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Username
						case 10:
							Repository.Edit( "Manager", managerId, "Username", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.UsernameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Password
						case 11:
							Repository.Edit( "Manager", managerId, "Password", aNewValue );
							MessageBox.Show( this, Properties.Resources.ManagerString + Properties.Resources.PasswordEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void ManagersDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			var removeIndex = e.RowIndex;

			Repository.Remove( removeIndex, "Manager" );
		}

		private void ManagersDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				var cell = ManagersDataGrid[ e.ColumnIndex, e.RowIndex ];
				ManagersDataGrid.CurrentCell = cell;
				ManagersDataGrid.BeginEdit( true );
			}
		}

		private void ManagersDataGrid_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			//BirthDateColumn
			if ( e.ColumnIndex == 5 )
			{
				var aRectangle = ManagersDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );
				
				ManagersDataGrid.Controls.Add( mDateTimePicker );
				mDateTimePicker.Format = DateTimePickerFormat.Short;
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
			ManagersDataGrid.CurrentCell.Value = mDateTimePicker.Text;
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
			if ( !Repository.IsEmpty( "Managers" ) )
			{
				if ( Repository.IsEmpty( "Employees" ) )
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
			else
			{
				MessageBox.Show( this, Properties.Resources.CompleteRow,Properties.Resources.CompleteRowTitle, 
				MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		#endregion

		#region Private Methods

		private void LoadDataToGrid( )
		{
			if ( Repository.IsEmpty( "Managers" ) )
				return;

			var managersMatrix = Repository.ListToMatrix( "Managers" );

			for ( var i = 0 ; i < Repository.Count( "Managers" ) ; i++ )
			{
				ManagersDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ManagersDataGrid.ColumnCount ; j++ )
				{
					ManagersDataGrid.Rows[ i ].Cells[ j ].Value = managersMatrix[ i, j ];
				}
			}
		}

		private void AddToRepository( List<string> rowValues )
		{
			var manager = Repository.Factory.CreateObject<Manager>( );

			manager.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
			manager.FirstName = rowValues[ 1 ];
			manager.LastName = rowValues[ 2 ];
			manager.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			manager.Nationality = rowValues[ 4 ];
			manager.BirthDate = SharedMethods.ConvertStringToDateTime( rowValues[ 5 ] );
			manager.Nif = SharedMethods.ConvertStringToInt( rowValues[ 6 ] );
			manager.Address = rowValues[ 7 ];
			manager.Phone = SharedMethods.ConvertStringToInt( rowValues[ 8 ] );
			manager.Email = rowValues[ 9 ];
			manager.Username = rowValues[ 10 ];
			manager.Password = rowValues[ 11 ];

			Repository.Append( manager, "Managers" );
		}

		#endregion

	}
}

