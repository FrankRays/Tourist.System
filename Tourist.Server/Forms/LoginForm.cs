using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private CacheServerLogin Cache;

		#endregion

		#region Constructor

		public LoginForm( )
		{
			InitializeComponent( );
			mMainForm = new MainForm( this );
			Repository.Login = new ServerLogin();
			Cache = new CacheServerLogin( Repository.Login );
		}

		#endregion

		#region Events

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadEntityLogo( );
		}

		private void OkButton_Click( object sender, EventArgs e )
		{

			if ( Repository.IsEmpty( "Entity" ) )
			{
				Hide( );
				var entityForm = new EntityForm( mMainForm );
				entityForm.Show( );
			}
			else if ( Repository.IsEmpty( "Managers" ) )
			{
				Hide( );
				var managerForm = new ManagersForm( mMainForm );
				managerForm.Show( );
			}
			else if ( !Repository.IsEmpty( "Managers" ) && Repository.IsEmpty( "Employees" ) )
			{
				Hide( );
				var employersForm = new EmployersForm( mMainForm );
				employersForm.Show( );
			}
			else if ( !Repository.IsEmpty( "Managers" ) && !Repository.IsEmpty( "Employees" ) )
			{
				LoginErrorChecking( );
			}
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Properties.Resources.ExitMessage,
			Properties.Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
		}

		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close( );
		}

		#endregion

		#region Private Methods

		private void LoadEntityLogo( )
		{
			var buffer = Repository.MData.Entity.LogoBuffer;

			if ( buffer != null )
			{
				LogoPicBox.Image = SharedMethods.ByteArrayToImage( buffer );
			}
		}

		private void LoginErrorChecking( )
		{

			if ( string.IsNullOrEmpty( UsernameTextBox.Text ) && string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, "Error the username field can't be empty." );
				ErrorProvider.SetIconPadding( UsernameTextBox, -25 );
				ErrorProvider.SetError( PasswordTextBox, "Error the password field can't be empty." );
				ErrorProvider.SetIconPadding( PasswordTextBox, -25 );
				return;
			}

			if ( string.IsNullOrEmpty( UsernameTextBox.Text ) && !string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, "Error the username field can't be empty." );
				ErrorProvider.SetIconPadding( UsernameTextBox, -25 );
				return;
			}

			if ( !string.IsNullOrEmpty( UsernameTextBox.Text ) && string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{

				ErrorProvider.SetError( PasswordTextBox, "Error the password field can't be empty." );
				ErrorProvider.SetIconPadding( PasswordTextBox, -25 );
				return;
			}

			if ( !string.IsNullOrEmpty( UsernameTextBox.Text ) && !string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, "" );
				ErrorProvider.SetError( PasswordTextBox, "" );

				
				if ( Cache.Authentication( UsernameTextBox.Text, PasswordTextBox.Text ) )
				{
					MessageBox.Show( Properties.Resources.WelcomeString + UsernameTextBox.Text +
					" !", Properties.Resources.LoginSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
					Hide( );
					mMainForm.Show( );
				}
				else
				{
					MessageBox.Show( Properties.Resources.LoginErrorMessage, Properties.Resources.LoginError,
					MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
		}

		public void CleanForm( )
		{
			UsernameTextBox.Text = string.Empty;
			PasswordTextBox.Text = string.Empty;
		}

		#endregion

	}
}
