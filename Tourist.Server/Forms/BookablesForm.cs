using System;
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
		private readonly Repository repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );
		private readonly int mEntityId;

		public BookablesForm( Form aForm, int aEntityId )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
		}

		private void ServicesForm_Load( object sender, System.EventArgs e )
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

		private void BookablesForm_RowsValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			if ( ServicesTabsControl.SelectedTab == RoomsTab )
			{
				var row = RoomDataGrid.Rows[ e.RowIndex ];

				var bookableIndex = e.RowIndex;

				int bookableId;

				if ( repository.IsRoomBookablesIndexValid( mEntityId, bookableIndex ) )
				{
					bookableId = repository.GetRoomId( mEntityId, bookableIndex );
				}
				else
				{
					bookableId = repository.MaxRoomBookablesId( mEntityId ) + 1;
				}

				RoomDataGrid[ "IdColumn", e.RowIndex ].Value = bookableId;

				switch ( RoomDataGrid[ "TypeColumn", e.RowIndex ].FormattedValue.ToString() )
				{
					case "SingleRoom":
						RoomDataGrid["CapacityColumn", e.RowIndex].Value = 1;
						break;
					case "DoubleSingleRoom":
						RoomDataGrid[ "CapacityColumn", e.RowIndex ].Value = 2;
						break;
					case "DoubleRoom":
						RoomDataGrid[ "CapacityColumn", e.RowIndex ].Value = 2;
						break;
					case "SuiteRoom":
						RoomDataGrid[ "CapacityColumn", e.RowIndex ].Value = 2;
						break;
					case "FamilySuiteRoom":
						RoomDataGrid[ "CapacityColumn", e.RowIndex ].Value = 4;
						break;
					case "MeetingRoom":
						RoomDataGrid[ "CapacityColumn", e.RowIndex ].Value = 50;
						break;
					default:
						return;
				}

				var isRowValidated = RowCellsValidated( row );

				if ( isRowValidated )
				{
					if ( !repository.RoomBookablesAlreadyExists( mEntityId, bookableId ) )
					{
						var buffer = RowCellValues( row );

						AddRoomToRepository( buffer );

						//MetroMessageBox.Show( this, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OK, MessageBoxIcon.Information );
					}
					else
					{
						if ( e.ColumnIndex == RoomDataGrid.Columns[ "TypeColumn" ].Index )
						{
							repository.EditRoomBookableType( mEntityId,
															 bookableId, Type.GetType( e.FormattedValue.ToString( ) ).Name );

						}
						else if ( e.ColumnIndex == RoomDataGrid.Columns[ "DescriptionColumn" ].Index )
						{
							repository.EditRoomBookableDescription( mEntityId, bookableId, e.FormattedValue.ToString( ) );

						}
						else if ( e.ColumnIndex == RoomDataGrid.Columns[ "PriceColumn" ].Index )
						{
							repository.EditRoomBookablePrice( mEntityId,
															  bookableId, Convert.ToInt32( e.FormattedValue.ToString( ) ) );

						}

						else if ( e.ColumnIndex == RoomDataGrid.Columns[ "StateColumn" ].Index )
						{
							repository.EditRoomBookableState( mEntityId,
															  bookableId,
							( BookableState ) Enum.Parse( typeof( BookableState ), e.FormattedValue.ToString( ) ) );

						}
					}
				}
			}
		}

		private void BookablesForm_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var removeIndex = e.RowIndex;

			var aRow = RoomDataGrid.Rows[ e.RowIndex ];

			repository.RemoveRoomBookableOfEntity( mEntityId, removeIndex );
		}

		private void LoadDataToGrid( )
		{
			if ( repository.IsEmpty( ) )
				return;

			if ( repository.IsRoomBookablesListEmpty( mEntityId ) )
				return;

			var bookablesMatrix = repository.RoomBookablesListToMatrix( mEntityId, RoomDataGrid.ColumnCount );

			for ( var i = 0 ; i < repository.RoomBookablesListCount( mEntityId ) ; i++ )
			{
				RoomDataGrid.Rows.Add( );

				for ( var j = 0 ; j < RoomDataGrid.ColumnCount ; j++ )
				{
					RoomDataGrid.Rows[ i ].Cells[ j ].Value = bookablesMatrix[ i, j ];
				}
			}
		}

		private void AddRoomToRepository( string[ ] args )
		{

			IBookable bookable;

			switch ( args[ 0 ] )
			{
				case "SingleRoom":
					bookable = repository.Factory.CreateObject<SingleRoom>( );
					break;
				case "DoubleSingleRoom":
					bookable = repository.Factory.CreateObject<DoubleSingleRoom>( );
					break;
				case "DoubleRoom":
					bookable = repository.Factory.CreateObject<DoubleRoom>( );
					break;
				case "SuiteRoom":
					bookable = repository.Factory.CreateObject<SuiteRoom>( );
					break;
				case "FamilySuiteRoom":
					bookable = repository.Factory.CreateObject<FamilySuiteRoom>( );
					break;
				case "MeetingRoom":
					bookable = repository.Factory.CreateObject<MeetingRoom>( );
					break;
				default:
					return;
			}

			var nextId = repository.MaxEmployerId( mEntityId ) + 1;

			bookable.Id = nextId;
			bookable.Type =
			bookable.Description = args[ 1 ];
			bookable.Price = Convert.ToInt32( args[ 2 ] );
			bookable.Capacity = Convert.ToInt32( args[ 3 ] );
			bookable.State = ( BookableState ) Enum.Parse( typeof( BookableState ), args[ 4 ] );


			repository.AddRoomBookableToEntity( mEntityId, bookable );
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

			if ( !IsNumeric( aRow.Cells[ "PriceColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "PriceColumn" ].ErrorText = "The cell is not a number";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "PriceColumn" ] );

			/*
			if ( !IsNumeric( aRow.Cells[ "CapacityColumn" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "CapacityColumn" ].ErrorText = "The cell is not a number";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "CapacityColumn" ] );
			*/

			return !cellHasError.Any( bolean => bolean );
		}

		private string[ ] RowCellValues( DataGridViewRow rows )
		{
			var buffer = new string[ 6 ];

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
	}
}
