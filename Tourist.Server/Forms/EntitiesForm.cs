using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class EntitiesForm : MetroForm
	{

		//private string mEntityName;
		//private string mEntityCity;

		public EntitiesForm( )
		{
			InitializeComponent( );
		}

		private void EntitiesForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );
			Program.repo.Load(Program.FileName);
			Program.repo.Load( );
		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		


		private void CreateEntityRow( string aName, string aCity )
		{
			IEntity entity = Repository.Instance.Factory.CreateObject<IEntity>( );
			entity.Name = aName;
			entity.City = aCity;

			Program.repo.Save(entity);
			Program.repo.Save( Program.FileName );
		}

		private void EntityDataGrid_RowValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			DataGridViewRow row = EntityDataGrid.Rows[ e.RowIndex ];

			if (row.IsNewRow) 
				return;

			bool temp = RowCellValidated(row);

			if (temp)
			{
				var buffer = GetRowCellValues(row);
				
				CreateEntityRow(buffer[0],buffer[1]);

				RowCellsErrorRemove(row);
			}
			
			/*
			DataGridViewCell entityName = row.Cells[ EntityDataGrid.Columns[ "EntityNameColunm" ].Index ];

			DataGridViewCell entityCity = row.Cells[ EntityDataGrid.Columns[ "EntityCityColunm" ].Index ];

			if (entityName.EditedFormattedValue.ToString().Length == 0)
			{
				entityName.ErrorText = "Value Not Valid!";
				EntityDataGrid.Rows[ entityName.RowIndex ].ErrorText = "Value Not Valid!";
				e.Cancel = true;
			}

			if ( entityCity.EditedFormattedValue.ToString( ).Length == 0 )
			{
				entityCity.ErrorText = "Value Not Valid!";
				EntityDataGrid.Rows[ entityCity.RowIndex ].ErrorText = "Value Not Valid!";
				e.Cancel = true;
			}
			*/

			//e.Cancel = !( CellValidating( entityName ) && CellValidating( entityCity ) );


		}

		private void RowCellsErrorRemove( DataGridViewRow rows )
		{
			for ( int i = 1 ; i < rows.Cells.Count ; i++ )
			{
				rows.Cells[i].ErrorText = string.Empty;
			}
		}

		private bool RowCellValidated( DataGridViewRow rows )
		{
			for ( int i = 1 ; i < rows.Cells.Count ; i++ )
			{
				if ( rows.Cells[ i ].EditedFormattedValue.ToString( ).Length == 0 )
				{
					rows.Cells[ i ].ErrorText = "Value Not Valid!";
					return false;
				}
			}
			return true;
		}

		private string[] GetRowCellValues(DataGridViewRow rows)
		{

			string[] buffer = new string[2];

			for ( int i = 1, j = 0 ; i < rows.Cells.Count ; i++ ,j++)
			{
				buffer[j] = rows.Cells[i].EditedFormattedValue.ToString();
			}
			return buffer;
		}

		/*
		private Boolean RowValidating( DataGridViewRow cell )
		{

			if ( cell.Value.ToString( ).Length == 0 || cell.Value == null )
			{
				cell.ErrorText = "Value Not Valid!";
				EntityDataGrid.Rows[ cell.RowIndex ].ErrorText = "Value Not Valid!";
				return false;
			}

			return true;
		}
		 */
	}
}
