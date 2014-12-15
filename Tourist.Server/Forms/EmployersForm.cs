﻿using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class EmployersForm : MetroForm
	{
		public EmployersForm( )
		{
			InitializeComponent( );
		}

		private void EmployersForm_Load( object sender, System.EventArgs e )
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
	}
}
