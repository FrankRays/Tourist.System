using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class EntitiesForm : MetroForm
	{

		private readonly Repository repository = Repository.Instance;

		public EntitiesForm( )
		{
			InitializeComponent( );
		}

		private void EntitiesForm_Load( object sender, EventArgs e )
		{
			SetFormFullScreen( );
			LoadDataToGrid( );
		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void LoadDataToGrid( )
		{
			if ( repository.EntityListIsEmpty( ) )
				return;

			var entitiesMatrix = repository.EntitiesListToMatrix( EntityDataGrid.ColumnCount );

			for ( int i = 0 ; i < repository.EntityListCount( ) ; i++ )
			{
				EntityDataGrid.Rows.Add( );

				for ( int j = 0 ; j < EntityDataGrid.ColumnCount ; j++ )
				{
					EntityDataGrid.Rows[ i ].Cells[ j ].Value = entitiesMatrix[ i, j ];
				}
			}
		}

		private void EntityDataGrid_RowValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{
			DataGridViewRow row = EntityDataGrid.Rows[ e.RowIndex ];

			int entityId = e.RowIndex + 1;

			EntityDataGrid[ "EntityIdColunm", e.RowIndex ].Value = entityId;

			bool isRowValidated = RowCellsValidated( row );

			if ( row.IsNewRow )
				return;

			if ( isRowValidated )
			{
				if ( !repository.EntityAlreadyExists( entityId ) )
				{
					var buffer = RowCellValues( row );

					AddEntityToRepository( buffer );
				}
				else
				{
					if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityTypeColumn" ].Index )
					{
						repository.EditEntityType( entityId, ( EntityType ) Enum.Parse( typeof( EntityType ), e.FormattedValue.ToString( ) ) );
					}
					else if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityNameColunm" ].Index )
					{
						repository.EditEntityName( entityId, e.FormattedValue.ToString( ) );
					}
					else if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityAddressColunm" ].Index )
					{
						repository.EditEntityAddress( entityId, e.FormattedValue.ToString( ) );
					}
					else if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityNifColunm" ].Index )
					{
						repository.EditEntityNif( entityId, Convert.ToInt32( e.FormattedValue.ToString( ) ) );
					}
				}

				// gravar sempre que possivel porque pode acontecer falhar a energia
				repository.Save( Program.FileName );
			}
		}

		private void AddEntityToRepository( string[ ] args )
		{
			IEntity entity = repository.Factory.CreateObject<IEntity>( );
			entity.EntityType = ( EntityType ) Enum.Parse( typeof( EntityType ), args[ 0 ] );
			entity.Name = args[ 1 ];
			entity.Address = args[ 2 ];
			entity.Nif = Convert.ToInt32( args[ 3 ] );

			// so adiciona no repositorio
			repository.AddEntity( entity );
		}

		private void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
		}

		private bool RowCellsValidated( DataGridViewRow aRow )
		{

			var cellHasError = new bool[ aRow.Cells.Count ];

			for ( int i = 0 ; i < aRow.Cells.Count - 1 ; i++ )
			{
				cellHasError[ i ] = false;
			}

			for ( int i = 1 ; i < aRow.Cells.Count ; i++ )
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

			// testar se o nif contem apenas numeros
			if ( !IsNumeric( aRow.Cells[ "EntityNifColunm" ].EditedFormattedValue.ToString( ) ) )
			{
				aRow.Cells[ "EntityNifColunm" ].ErrorText = "The cell is not a number";
				return false;
			}

			CellErrorRemove( aRow.Cells[ "EntityNifColunm" ] );

			return !cellHasError.Any( bolean => bolean );
		}

		private string[ ] RowCellValues( DataGridViewRow rows )
		{
			var buffer = new string[ 4 ];

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

		private void EntityDataGrid_RowsRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var entityId = e.RowIndex + 1;

			repository.RemoveEntity( entityId );
		}
	}
}
