using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;


namespace Tourist.Client.Forms
{
	public partial class LoginForm : MetroForm
	{
		public LoginForm( )
		{
			InitializeComponent( );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{

			SetFormFullScreen( );
			//SetTitlePanelPosition();
			//Resize += LoginForm_Resize ;
			
		}

		/* Teste de evento 
		private void LoginForm_Resize(object sender, EventArgs e)
		{
			if ( WindowState == FormWindowState.Maximized )
			{
				TitlePanel.Width = Screen.PrimaryScreen.Bounds.Width;
			}
			
		}
		 */

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		//so para teste
		private void OkButton_Click( object sender, EventArgs e )
		{
			MainForm main = new MainForm( );
			main.Show( );
			// Hide();
		}

	
	}
}
