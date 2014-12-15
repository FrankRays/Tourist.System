using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		private Repository repository = Repository.Instance;
		

		public LoginForm( )
		{
			InitializeComponent( );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{

			SetFormFullScreen( );

		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		
		private void OkButton_Click( object sender, EventArgs e )
		{
			MainForm main = new MainForm();
			main.Show();
		}

		
	}
}
