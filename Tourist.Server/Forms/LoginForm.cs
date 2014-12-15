using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		private readonly Repository repository = Repository.Instance;
		private readonly MainForm mMainForm;

		public LoginForm( )
		{
			mMainForm = new MainForm(this);
			InitializeComponent( );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{

			ShowLoginFormOrEntityForm( );
			SetFormFullScreen( );

		}

		private void SetFormFullScreen( )
		{
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}


		private void OkButton_Click( object sender, EventArgs e )
		{
			Hide( );
			
			mMainForm.Show();
		}


		private void LoadEntityDataComboBox( )
		{


		}

		private void ShowLoginFormOrEntityForm( )
		{
			if ( !repository.IsEmpty( ) ) return;

			Hide( );
			
			mMainForm.EntityForm.Show();
		}

		private void LoginForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			
			// nao é preciso no login
			
		}

		private void ExitButton_Click( object sender, EventArgs e )
		{
			
			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?", "Login Cancel Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( dialogResult != DialogResult.No )
				Application.Exit( );
		}

	}
}
