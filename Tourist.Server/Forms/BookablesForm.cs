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
	public partial class BookablesForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public BookablesForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
		}

		#endregion

		#region Private Methods

		private void ServicesForm_Load( object sender, System.EventArgs e )
		{
			Shared.SetFormFullScreen( this );
		}

		private void LoadDataToGrid( )
		{
			if ( Repository.IsEmpty( "Managers" ) )
				return;

			var managersMatrix = Repository.ListToMatrix( "Managers" );

			for ( var i = 0 ; i < Repository.Count( "Managers" ) ; i++ )
			{
				RoomDataGrid.Rows.Add( );

				for ( var j = 0 ; j < RoomDataGrid.ColumnCount ; j++ )
				{
					RoomDataGrid.Rows[ i ].Cells[ j ].Value = managersMatrix[ i, j ];
				}
			}
		}

		private void AddToRepository( List<string> rowValues )
		{
			var manager = Repository.Factory.CreateObject<Manager>( );

			manager.Id = Shared.ConvertStringToInt( rowValues[ 0 ] );
			manager.FirstName = rowValues[ 1 ];
			manager.LastName = rowValues[ 2 ];
			manager.Gender = ( Gender ) Shared.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			manager.Nationality = rowValues[ 4 ];
			manager.BirthDate = Shared.ConvertStringToDateTime( rowValues[ 5 ] );
			manager.Nif = Shared.ConvertStringToInt( rowValues[ 6 ] );
			manager.Address = rowValues[ 7 ];
			manager.Phone = Shared.ConvertStringToInt( rowValues[ 8 ] );
			manager.Email = rowValues[ 9 ];
			manager.Username = rowValues[ 10 ];
			manager.Password = rowValues[ 11 ];

			Repository.Append( manager, "Managers" );
		}

		#endregion

		#region Events

		private void ManagersDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			if ( BookablesTabsControl.SelectedTab == RoomsTab )
			{

			}


		}


		private void RoomsTabData( int aRowIndex, int aColumnIndex, string aEditedValue )
		{

			var row = RoomDataGrid.Rows[ aRowIndex ];
			var mangerIndex = aRowIndex;
			int managerId;

			if ( mangerIndex <= Repository.Count( "Managers" ) - 1 )
				managerId = Repository.GetId( mangerIndex, "Managers" );
			else
				managerId = Repository.NextId( "Manager" );

			RoomDataGrid[ "IdColumn", aRowIndex ].Value = managerId;
			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( managerId, "Managers" ) )
				{
					var rowValues = Shared.RowCellValues( row );
					AddToRepository( rowValues );
					MetroMessageBox.Show( this, "Manager Added With Sucess !!!", "Metro Title",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = aEditedValue;

					switch ( aColumnIndex )
					{
						//FirstName
						case 1:
							Repository.Edit( "Manager", managerId, "FirstName", aNewValue );
							MetroMessageBox.Show( this, "Manager First Name Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Repository.Edit( "Manager", managerId, "LastName", aNewValue );
							MetroMessageBox.Show( this, "Manager Last Name Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Repository.Edit( "Manager", managerId, "Gender", aNewValue );
							MetroMessageBox.Show( this, "Manager Gender Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Repository.Edit( "Manager", managerId, "Nationality", aNewValue );
							MetroMessageBox.Show( this, "Manager Nationality Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Repository.Edit( "Manager", managerId, "BirthDate", aNewValue );
							MetroMessageBox.Show( this, "Manager Birth Date Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Repository.Edit( "Manager", managerId, "Nif", aNewValue );
							MetroMessageBox.Show( this, "Manager Nif Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Repository.Edit( "Manager", managerId, "Address", aNewValue );
							MetroMessageBox.Show( this, "Manager Address Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Repository.Edit( "Manager", managerId, "Phone", aNewValue );
							MetroMessageBox.Show( this, "Manager Phone Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Repository.Edit( "Manager", managerId, "Email", aNewValue );
							MetroMessageBox.Show( this, "Manager Email Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Username
						case 10:
							Repository.Edit( "Manager", managerId, "Username", aNewValue );
							MetroMessageBox.Show( this, "Manager Username Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Password
						case 11:
							Repository.Edit( "Manager", managerId, "Password", aNewValue );
							MetroMessageBox.Show( this, "Manager Password Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
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

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove manager at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( managerToRemove, "Managers" );
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

		private void ManagersDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = RoomDataGrid[ e.ColumnIndex, e.RowIndex ];
				RoomDataGrid.CurrentCell = cell;
				RoomDataGrid.BeginEdit( true );
			}
		}

		#endregion

	}
}
