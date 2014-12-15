using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Classes;

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

			//ShowLoginFormOrEntityForm( );
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

			Hide();
			
			mMainForm.EntityForm.Show();
		}


		protected override void OnFormClosing(FormClosingEventArgs e)
		{

			base.OnFormClosing(e);

			var dialogResult = MetroMessageBox.Show(this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

			if (e.CloseReason == CloseReason.WindowsShutDown) return;

			// Confirm user wants to close
			switch (dialogResult)
			{
				case DialogResult.No:
					e.Cancel = true;
					break;
				default:
					break;
			}
		}


		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
