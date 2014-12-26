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

		#region Private Methods

		private void EmployersForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
		}

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

		#region Events

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
					MessageBox.Show( this, "Manager Added With Sucess !!!", "Operation Sucessfull",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = e.FormattedValue.ToString( );

					switch ( e.ColumnIndex )
					{
						//FirstName
						case 1:
							Repository.Edit( "Manager", managerId, "FirstName", aNewValue );
							MessageBox.Show( this, "Manager First Name Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Repository.Edit( "Manager", managerId, "LastName", aNewValue );
							MessageBox.Show( this, "Manager Last Name Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Repository.Edit( "Manager", managerId, "Gender", aNewValue );
							MessageBox.Show( this, "Manager Gender Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Repository.Edit( "Manager", managerId, "Nationality", aNewValue );
							MessageBox.Show( this, "Manager Nationality Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Repository.Edit( "Manager", managerId, "BirthDate", aNewValue );
							MessageBox.Show( this, "Manager Birth Date Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Repository.Edit( "Manager", managerId, "Nif", aNewValue );
							MessageBox.Show( this, "Manager Nif Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Repository.Edit( "Manager", managerId, "Address", aNewValue );
							MessageBox.Show( this, "Manager Address Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Repository.Edit( "Manager", managerId, "Phone", aNewValue );
							MessageBox.Show( this, "Manager Phone Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Repository.Edit( "Manager", managerId, "Email", aNewValue );
							MessageBox.Show( this, "Manager Email Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Username
						case 10:
							Repository.Edit( "Manager", managerId, "Username", aNewValue );
							MessageBox.Show( this, "Manager Username Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Password
						case 11:
							Repository.Edit( "Manager", managerId, "Password", aNewValue );
							MessageBox.Show( this, "Manager Password Edited With Sucess !!!",
															"Operation Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void ManagersDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var managerToRemove = ( IManager ) Repository.GetObject( removeIndex, "Managers" );

			DialogResult dialog = MessageBox.Show( this, "Are you sure you want to remove manager at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Operation Sucessfull", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( managerToRemove, "Managers" );
		}

		private void ManagersDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = ManagersDataGrid[ e.ColumnIndex, e.RowIndex ];
				ManagersDataGrid.CurrentCell = cell;
				ManagersDataGrid.BeginEdit( true );
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
			ManagersDataGrid.CurrentCell.Value = mDateTimePicker.Text;
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

			var dialogResult = MessageBox.Show( this, "\n Are you sure you want to exit the application?",
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
				MessageBox.Show( this, "\n Please insert a complete row before going to next Screen.",
								"Manager Data Empty or Not complete!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		#endregion

	}
}

