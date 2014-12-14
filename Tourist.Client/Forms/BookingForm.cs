﻿using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class BookingsForm: MetroForm
	{
		public BookingsForm( )
		{
			InitializeComponent( );
		}

		private void BookingsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen();
			
			ClientsTabsControl.BackColor = Color.FromArgb( 0, 174, 219 );
			ClientsTabsControl.ForeColor = Color.FromArgb( 255, 255, 255 );

			
		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void metroGrid3_CellContentClick( object sender, DataGridViewCellEventArgs e )
		{

		}



	}
}
