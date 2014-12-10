using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server.Forms
{
	public partial class EntitiesForm : MetroForm
	{
		public EntitiesForm( )
		{
			InitializeComponent( );
		}

		private void EntitiesForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen();

		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void CreateEntityRow(string aName, string aCity)
		{
			IEntity entity = Repository.Instance.Factory.CreateObject<IEntity>();
			entity.Name = aName;
			entity.City = aCity;

			EntityDataGrid.Rows.Add(entity.Id, aName, aCity);
			//falta guardar no repositorio, ver a Api com os eventos para adiconar, editar e remover;
		}



	}
}
