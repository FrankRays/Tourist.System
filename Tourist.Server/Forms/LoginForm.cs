using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		private readonly Repository Repository = Repository.Instance;
		private MainForm mMainForm;
		private bool mLoginFormOrEntityForm = default( bool );
		private int mEntityId = default( int );


		public LoginForm( )
		{
			InitializeComponent( );
			mMainForm = new MainForm( this );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SetFormFullScreen( );
		}

		private void SetFormFullScreen( )
		{

			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );

			FormBorderStyle = FormBorderStyle.None;
			Focus( );

		}

		private void OkButton_Click( object sender, EventArgs e )
		{
			Hide( );

			if (!Repository.RepositoryHasEntity())
			{
				var entityForm = new EntityForm(mMainForm);
				entityForm.Show();
			}
			else
			{
				mMainForm.Show( );
			}		
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
		}

		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close( );
		}

		private void LoginForm_VisibilityChange( object sender, EventArgs e )
		{

		}
	}
}
