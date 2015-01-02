using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Shared;

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

		#region Rooms Events

		private void RoomsDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			var row = RoomDataGrid.Rows[ e.RowIndex ];
			var roomIndex = e.RowIndex;
			var aNewValue = e.FormattedValue.ToString( );
			int roomId;

			if ( roomIndex <= Repository.Count( "Rooms" ) - 1 )
				roomId = Repository.GetId( roomIndex, "Rooms" );
			else
				roomId = Repository.NextId( "Room" );

			RoomDataGrid[ "R_IdColumn", e.RowIndex ].Value = roomId;

			AutoFillPriceAndCapacity( aNewValue, e.RowIndex );

			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( roomId, "Rooms" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues, "Room" );
					MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.AddString,
					Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					switch ( e.ColumnIndex )
					{
						//RoomType
						case 1:
							Repository.Edit( "Room", roomId, "Type", aNewValue );
							Repository.Edit( "Room", roomId, "Capacity", RoomDataGrid[ "R_CapacityColumn", e.RowIndex ].Value.ToString( ) );
							Repository.Edit( "Room", roomId, "Price", RoomDataGrid[ "R_PriceColumn", e.RowIndex ].Value.ToString( ) );
							MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.TypeEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 2:
							Repository.Edit( "Room", roomId, "State", aNewValue );
							MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.StateEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Room", roomId, "Description", aNewValue );
							MessageBox.Show( this, Properties.Resources.RoomString + Properties.Resources.DescriptionEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		// falta atualizar para a novo metodo remove do repositorio
		private void RoomsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
			{
				ReLoadDataToGrid( RoomDataGrid );
				return;
			}

			var removeIndex = e.RowIndex;

			Repository.Remove( removeIndex, "Rooms" );
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

			var row = ActivitiesDataGrid.Rows[ e.RowIndex ];
			var activityIndex = e.RowIndex;
			var aNewValue = e.FormattedValue.ToString( );
			int activityId;

			if ( activityIndex <= Repository.Count( "Activities" ) - 1 )
				activityId = Repository.GetId( activityIndex, "Activities" );
			else
				activityId = Repository.NextId( "Activity" );

			ActivitiesDataGrid[ "A_IdColumn", e.RowIndex ].Value = activityId;

			AutoFillPriceAndCapacity( aNewValue, e.RowIndex );

			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( activityId, "Activities" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues, "Activity" );
					MessageBox.Show( this, Properties.Resources.ActivityString + Properties.Resources.AddString,
					Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					switch ( e.ColumnIndex )
					{
						//ActivityType
						case 1:
							Repository.Edit( "Activity", activityId, "Type", aNewValue );
							Repository.Edit( "Activity", activityId, "Capacity", ActivitiesDataGrid[ "A_CapacityColumn", e.RowIndex ].Value.ToString( ) );
							Repository.Edit( "Activity", activityId, "Price", ActivitiesDataGrid[ "A_PriceColumn", e.RowIndex ].Value.ToString( ) );
							MessageBox.Show( this, Properties.Resources.ActivityString + Properties.Resources.TypeEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 2:
							Repository.Edit( "Activity", activityId, "State", aNewValue );
							MessageBox.Show( this, Properties.Resources.ActivityString + Properties.Resources.StateEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Activity", activityId, "Description", aNewValue );
							MessageBox.Show( this, Properties.Resources.ActivityString + Properties.Resources.DescriptionEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void ActivitiesDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
			{
				ReLoadDataToGrid( ActivitiesDataGrid );
				return;
			}

			var removeIndex = e.RowIndex;

			Repository.Remove( removeIndex, "Activities" );
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

			var row = TransportsDataGrid.Rows[ e.RowIndex ];
			var transportIndex = e.RowIndex;
			var aNewValue = e.FormattedValue.ToString( );
			int transportId;

			if ( transportIndex <= Repository.Count( "Transports" ) - 1 )
				transportId = Repository.GetId( transportIndex, "Transports" );
			else
				transportId = Repository.NextId( "Transport" );

			TransportsDataGrid[ "T_IdColumn", e.RowIndex ].Value = transportId;

			AutoFillPriceAndCapacity( aNewValue, e.RowIndex );

			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Repository.ExistingId( transportId, "Transports" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues, "Transport" );
					MessageBox.Show( this, Properties.Resources.TransportString + Properties.Resources.AddString,
					Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					switch ( e.ColumnIndex )
					{
						//TransportType
						case 1:
							Repository.Edit( "Transport", transportId, "Type", aNewValue );
							Repository.Edit( "Transport", transportId, "Capacity", TransportsDataGrid[ "T_CapacityColumn", e.RowIndex ].Value.ToString( ) );
							Repository.Edit( "Transport", transportId, "Price", TransportsDataGrid[ "T_PriceColumn", e.RowIndex ].Value.ToString( ) );
							MessageBox.Show( this, Properties.Resources.TransportString + Properties.Resources.TypeEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//state
						case 4:
							Repository.Edit( "Transport", transportId, "StartDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.TransportString + Properties.Resources.StateEditedString,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Description
						case 3:
							Repository.Edit( "Transport", transportId, "Description", aNewValue );
							MessageBox.Show( this, Properties.Resources.TransportString + Properties.Resources.DescriptionEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void TransportsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
			{
				ReLoadDataToGrid( TransportsDataGrid );
				return;
			}

			var removeIndex = e.RowIndex;

			Repository.Remove( removeIndex, "Transports" );
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

		#region Private Methods

		private void ServicesForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
			//BookablesTabsControl.SelectedTab = RoomsTab;
		}

		private void LoadDataToGrid( )
		{
			LoadRoomsDataToGrid( );
			LoadActivitiesDataToGrid( );
			LoadTransportsDataToGrid( );
		}

		private void ReLoadDataToGrid( DataGridView aDataGridView )
		{
			SharedMethods.ClearDataGrid( aDataGridView );
			LoadDataToGrid( );
		}

		private void LoadRoomsDataToGrid( )
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

		private void LoadActivitiesDataToGrid( )
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

		private void LoadTransportsDataToGrid( )
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

		private void AddToRepository( List<string> rowValues, string aType )
		{
			switch ( aType )
			{
				case "Room":
					var room = Repository.Factory.CreateObject<Room>( );
					room.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
					room.Type = ( RoomType ) SharedMethods.ConvertStringToEnum( rowValues[ 1 ], "RoomType" );
					room.State = ( BookableState ) SharedMethods.ConvertStringToEnum( rowValues[ 2 ], "BookableState" );
					room.Description = rowValues[ 3 ];
					room.Capacity = SharedMethods.ConvertStringToInt( rowValues[ 4 ] );
					room.Price = SharedMethods.ConvertStringToDouble( rowValues[ 5 ] );
					Repository.Append( room, "Rooms" );
					return;
				case "Activity":
					var activity = Repository.Factory.CreateObject<Activity>( );
					activity.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
					activity.Type = ( ActivityType ) SharedMethods.ConvertStringToEnum( rowValues[ 1 ], "ActivityType" );
					activity.State = ( BookableState ) SharedMethods.ConvertStringToEnum( rowValues[ 2 ], "BookableState" );
					activity.Description = rowValues[ 3 ];
					activity.Capacity = SharedMethods.ConvertStringToInt( rowValues[ 4 ] );
					activity.Price = SharedMethods.ConvertStringToDouble( rowValues[ 5 ] );
					Repository.Append( activity, "Activities" );
					return;
				case "Transport":
					var transport = Repository.Factory.CreateObject<Transport>( );
					transport.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
					transport.Type = ( TransportType ) SharedMethods.ConvertStringToEnum( rowValues[ 1 ], "TransportType" );
					transport.State = ( BookableState ) SharedMethods.ConvertStringToEnum( rowValues[ 2 ], "BookableState" );
					transport.Description = rowValues[ 3 ];
					transport.Capacity = SharedMethods.ConvertStringToInt( rowValues[ 4 ] );
					transport.Price = SharedMethods.ConvertStringToDouble( rowValues[ 5 ] );
					Repository.Append( transport, "Transports" );
					return;
				default:
					return;
			}
		}

		private void AutoFillPriceAndCapacity( string aType, int aRowIndex )
		{
			switch ( aType )
			{
				case "Single":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.Single;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.Single.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "DoubleSingle":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.DoubleSingle;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.DoubleSingle.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Double":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.Double;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.Double.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Suite":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.Suite;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.Suite.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "FamilySuite":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.FamilySuite;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.FamilySuite.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Meeting":
					RoomDataGrid[ "R_CapacityColumn", aRowIndex ].Value = Capacity.Meeting;
					RoomDataGrid[ "R_PriceColumn", aRowIndex ].Value =
														BasePrice.Meeting.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "BoatRide":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.BoatRide;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.BoatRide.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Golf":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.Golf;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.Golf.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Camping":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.Camping;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.Camping.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Diving":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.Diving;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.Diving.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "SightSeeing":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.SightSeeing;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.SightSeeing.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "SkyDiving":
					ActivitiesDataGrid[ "A_CapacityColumn", aRowIndex ].Value = Capacity.SkyDiving;
					ActivitiesDataGrid[ "A_PriceColumn", aRowIndex ].Value =
														BasePrice.SkyDiving.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "TuckTuck":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.TuckTuck;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.TuckTuck.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "CableCar":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.CableCar;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.CableCar.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Bicycle":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.Bicycle;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.Bicycle.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Car":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.Car;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.Car.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Bus":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.Bus;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.Bus.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				case "Motorist":
					TransportsDataGrid[ "T_CapacityColumn", aRowIndex ].Value = Capacity.Motorist;
					TransportsDataGrid[ "T_PriceColumn", aRowIndex ].Value =
														BasePrice.Motorist.ToString( "0.00", CultureInfo.InvariantCulture );
					return;
				default:
					return;
			}
		}

		#endregion

		#region Close Events

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
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}

		#endregion

	}
}
