﻿using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Client.Forms
{
	public partial class DisponibilityForm : MetroForm
	{
		public DisponibilityForm( )
		{
			InitializeComponent( );
		}

		private void DisponibilityForm_Load( object sender, System.EventArgs e )
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



	}
}
