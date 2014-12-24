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
			LoadDataToGrid();


		}

		private void LoadDataToGrid( )
		{

			if ( BookablesTabsControl.SelectedTab == RoomsTab )
			{
				if ( Repository.IsEmpty( "Rooms" ) )
					return;

				var roomMatrix = Repository.ListToMatrix( "Rooms" );

				for ( var i = 0 ; i < Repository.Count( "Rooms" ) ; i++ )
				{
					RoomDataGrid.Rows.Add( );

					for ( var j = 0 ; j < RoomDataGrid.ColumnCount ; j++ )
					{
						RoomDataGrid.Rows[ i ].Cells[ j ].Value = roomMatrix[ i, j ];
					}
				}
			}
			else if (BookablesTabsControl.SelectedTab == ActivitiesTab)
			{
				if ( Repository.IsEmpty( "Activities" ) )
					return;

				var activityMatrix = Repository.ListToMatrix( "Activities" );

				for ( var i = 0 ; i < Repository.Count( "Activities" ) ; i++ )
				{
					ActivitiesDataGrid.Rows.Add( );

					for ( var j = 0 ; j < ActivitiesDataGrid.ColumnCount ; j++ )
					{
						ActivitiesDataGrid.Rows[ i ].Cells[ j ].Value = activityMatrix[ i, j ];
					}
				}
			}
			else
			{
				if ( Repository.IsEmpty( "Transports" ) )
					return;

				var transportMatrix = Repository.ListToMatrix( "Transports" );

				for ( var i = 0 ; i < Repository.Count( "Transports" ) ; i++ )
				{
					TransportsDataGrid.Rows.Add( );

					for ( var j = 0 ; j < TransportsDataGrid.ColumnCount ; j++ )
					{
						TransportsDataGrid.Rows[ i ].Cells[ j ].Value = transportMatrix[ i, j ];
					}
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

		#region Rooms Events

		private void RoomsDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			if ( BookablesTabsControl.SelectedTab == RoomsTab )
			{
				RoomsTabData(e.RowIndex, e.ColumnIndex, e.FormattedValue.ToString());
			}

		}

		private void RoomsTabData( int aRowIndex, int aColumnIndex, string aEditedValue )
		{

			var row = RoomDataGrid.Rows[ aRowIndex ];
			var roomIndex = aRowIndex;
			int roomId;

			if ( roomIndex <= Repository.Count( "Rooms" ) - 1 )
				roomId = Repository.GetId( roomIndex, "Rooms" );
			else
				roomId = Repository.NextId( "Rooms" );

			RoomDataGrid[ "IdColumn", aRowIndex ].Value = roomId;

			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( roomId, "Rooms" ) )
				{
					var rowValues = Shared.RowCellValues( row );
					AddToRepository( rowValues );
					MetroMessageBox.Show( this, "Room Added With Sucess !!!", "Metro Title",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = aEditedValue;

					switch ( aColumnIndex )
					{
						//RoomType
						case 1:
							Repository.Edit( "Room", roomId, "Type", aNewValue );
							MetroMessageBox.Show( this, "Room Type edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Room", roomId, "Description", aNewValue );
							MetroMessageBox.Show( this, "Room description edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 4:
							Repository.Edit( "Room", roomId, "StartDate", aNewValue );
							MetroMessageBox.Show( this, "Room State Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void RoomsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var roomToRemove = ( IBookable ) Repository.GetObject( removeIndex, "Rooms" );

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove room at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( roomToRemove, "Rooms" );
		}

		private void RoomsDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = RoomDataGrid[ e.ColumnIndex, e.RowIndex ];
				RoomDataGrid.CurrentCell = cell;
				RoomDataGrid.BeginEdit( true );
			}
		}

		#endregion

		#region Activities Events

		private void ActivitiesDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			if ( BookablesTabsControl.SelectedTab == ActivitiesTab )
			{
				ActivitiesTabData( e.RowIndex, e.ColumnIndex, e.FormattedValue.ToString( ) );
			}

		}

		private void ActivitiesTabData( int aRowIndex, int aColumnIndex, string aEditedValue )
		{

			var row = ActivitiesDataGrid.Rows[ aRowIndex ];
			var activityIndex = aRowIndex;
			int activityId;

			if ( activityIndex <= Repository.Count( "Activities" ) - 1 )
				activityId = Repository.GetId( activityIndex, "Activities" );
			else
				activityId = Repository.NextId( "Activities" );

			ActivitiesDataGrid[ "IdColumn", aRowIndex ].Value = activityId;

			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( activityId, "Activities" ) )
				{
					var rowValues = Shared.RowCellValues( row );
					AddToRepository( rowValues );
					MetroMessageBox.Show( this, "Activity Added With Sucess !!!", "Metro Title",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = aEditedValue;

					switch ( aColumnIndex )
					{
						//ActivityType
						case 1:
							Repository.Edit( "Activity", activityId, "Type", aNewValue );
							MetroMessageBox.Show( this, "Activity Type edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Activity", activityId, "Description", aNewValue );
							MetroMessageBox.Show( this, "Activity description edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 4:
							Repository.Edit( "Activity", activityId, "StartDate", aNewValue );
							MetroMessageBox.Show( this, "Activity State Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void ActivitiesDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var activityToRemove = ( IBookable ) Repository.GetObject( removeIndex, "Activities" );

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove activity at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( activityToRemove, "Activities" );
		}

		private void ActivitiesDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = ActivitiesDataGrid[ e.ColumnIndex, e.RowIndex ];
				ActivitiesDataGrid.CurrentCell = cell;
				ActivitiesDataGrid.BeginEdit( true );
			}
		}

		#endregion

		#region Transports Events

		private void TransportsDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			if ( BookablesTabsControl.SelectedTab == TransportsTab )
			{
				TransportsTabData( e.RowIndex, e.ColumnIndex, e.FormattedValue.ToString( ) );
			}

		}

		private void TransportsTabData( int aRowIndex, int aColumnIndex, string aEditedValue )
		{

			var row = TransportsDataGrid.Rows[ aRowIndex ];
			var transportIndex = aRowIndex;
			int transportId;

			if ( transportIndex <= Repository.Count( "Transports" ) - 1 )
				transportId = Repository.GetId( transportIndex, "Transports" );
			else
				transportId = Repository.NextId( "Transports" );

			TransportsDataGrid[ "IdColumn", aRowIndex ].Value = transportId;

			var isRowValidated = Shared.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( transportId, "Rooms" ) )
				{
					var rowValues = Shared.RowCellValues( row );
					AddToRepository( rowValues );
					MetroMessageBox.Show( this, "Transport Added With Sucess !!!", "Metro Title",
																			MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = aEditedValue;

					switch ( aColumnIndex )
					{
						//TransportType
						case 1:
							Repository.Edit( "Transport", transportId, "Type", aNewValue );
							MetroMessageBox.Show( this, "Transport Type edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Transport", transportId, "Description", aNewValue );
							MetroMessageBox.Show( this, "Transport description edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 4:
							Repository.Edit( "Transport", transportId, "StartDate", aNewValue );
							MetroMessageBox.Show( this, "Transport State Edited With Sucess !!!",
															"Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void TransportsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var transportToRemove = ( IBookable ) Repository.GetObject( removeIndex, "Transports" );

			DialogResult dialog = MetroMessageBox.Show( this, "Are you sure you want to remove transport at row number " +
							   ( e.RowIndex + 1 ) + " ?", "Metro Title", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
				return;

			Repository.Remove( transportToRemove, "Transports" );
		}

		private void TransportsDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				DataGridViewCell cell = TransportsDataGrid[ e.ColumnIndex, e.RowIndex ];
				TransportsDataGrid.CurrentCell = cell;
				TransportsDataGrid.BeginEdit( true );
			}
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
				System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}

		#endregion

	}
}
