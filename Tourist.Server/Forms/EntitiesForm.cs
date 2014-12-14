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
	public partial class EntitiesForm : MetroForm
	{

		private Repository Repository = Repository.Instance;

		public EntitiesForm( )
		{
			InitializeComponent( );
		}

		private void EntitiesForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );
			LoadEntitiesFromRepository( );

		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void LoadEntitiesFromRepository( )
		{
			var entitiesMatrix = Repository.EntitiesListToMatrix( EntityDataGrid.ColumnCount );

			for ( int i = 0 ; i < Repository.RepositoryEntityCount( ) ; i++ )
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

			if ( row.IsNewRow )
				return;

			bool canAddOrEditEntity = RowCellsValidated( row );

			if ( canAddOrEditEntity )
			{

				if ( !Repository.EntityAlreadyExists( entityId ) )
				{
					var buffer = RowCellValues( row );

					CreateEntityRow( buffer[ 0 ], buffer[ 1 ] );

					RowCellsErrorRemove( row );

				}
				else
				{
					if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityNameColunm" ].Index )
					{
						Repository.EditEntityName( entityId, e.FormattedValue.ToString( ) );
					}
					else if ( e.ColumnIndex == EntityDataGrid.Columns[ "EntityCityColunm" ].Index )
					{
						Repository.EditEntityCity( entityId, e.FormattedValue.ToString( ) );
					}
				}

				Repository.Save( Program.FileName );
			}
		}

		private void CreateEntityRow( string aName, string aCity )
		{
			IEntity entity = Repository.Factory.CreateObject<IEntity>( );
			entity.Name = aName;
			entity.City = aCity;

			// so adiciona no repositorio
			Repository.AddEntityToRepository( entity );

			// so faz save quando carrega num botao , exit, back, home
			//Program.repo.Save( entity );
			//Program.repo.Save( Program.FileName );
		}

		private void RowCellsErrorRemove( DataGridViewRow rows )
		{
			for ( int i = 1 ; i < rows.Cells.Count ; i++ )
			{
				rows.Cells[ i ].ErrorText = string.Empty;
			}
		}

		private bool RowCellsValidated( DataGridViewRow rows )
		{
			for ( int i = 1 ; i < rows.Cells.Count ; i++ )
			{
				if ( rows.Cells[ i ].EditedFormattedValue.ToString( ).Length == 0 )
				{
					rows.Cells[ i ].ErrorText = "This Cell can´t be empty!";
					return false;
				}
			}
			return true;
		}

		private string[ ] RowCellValues( DataGridViewRow rows )
		{

			var buffer = new string[ 2 ];

			for ( int i = 1, j = 0 ; i < rows.Cells.Count ; i++, j++ )
			{
				buffer[ j ] = rows.Cells[ i ].EditedFormattedValue.ToString( );
			}
			return buffer;
		}

	}
}
