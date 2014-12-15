using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		private readonly Repository repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mLoginFormOrEntityForm = default( bool );
		private int mEntityId = 0;

		public LoginForm( )
		{
			mMainForm = new MainForm( this );
			InitializeComponent( );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SetFormFullScreen( );
			mLoginFormOrEntityForm = CanLoadEntityNamesComboBox( );
		}

		private void SetFormFullScreen( )
		{
			
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );

			FormBorderStyle = FormBorderStyle.None;
			Focus();

		}

		private void OkButton_Click( object sender, EventArgs e )
		{
			ShowLoginFormOrEntityForm( );
		}

		private bool CanLoadEntityNamesComboBox( )
		{

			if ( repository.IsEmpty( ) )
				return false;

			var bindingSource = new BindingSource { DataSource = repository.EntityNameList( ) };

			EntityNameCombox.DataSource = bindingSource;

			return true;
		}

		private void ShowLoginFormOrEntityForm( )
		{
			if ( mLoginFormOrEntityForm )
			{
				Hide( );
				mMainForm.Show( );
			}
			else
			{
				Hide( );
				var entityForm = new EntityForm( this );
				entityForm.Show( );
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
	}
}
