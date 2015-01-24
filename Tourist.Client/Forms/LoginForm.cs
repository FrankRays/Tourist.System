using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class LoginForm : MetroForm
	{

		#region Fields

		private readonly IRemote Remote;
		private readonly MainForm mMainForm;
		private readonly CacheRemoteLogin Cache;

		#endregion

		#region Constructor

		public LoginForm( IRemote aRemote )
		{
			InitializeComponent( );
			Remote = aRemote;
			mMainForm = new MainForm( this, Remote );
			Cache = new CacheRemoteLogin( new RemoteLogin( Remote ) );
		}

		#endregion

		#region Events

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadEntityLogo( );
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Resources.ExitMessage,
				Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
		}

		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close( );
		}

		private void OkButton_Click( object sender, EventArgs e )
		{

			if ( Remote.IsEmpty( "Employees" ) )
			{
				MessageBox.Show( Resources.EmployeesListEmptyMessage,
						Resources.EmployeesListEmpty, MessageBoxButtons.OK, MessageBoxIcon.Information );
				Close( );
			}
			else
			{
				LoginErrorChecking( );
			}
		}

		#endregion

		#region Private Methods

		private void LoadEntityLogo( )
		{
			var buffer = Remote.Entity.LogoBuffer;

			if ( buffer != null )
			{
				LogoPicBox.Image = SharedMethods.ByteArrayToImage( buffer );
			}
		}

		private void LoginErrorChecking( )
		{
			if ( string.IsNullOrEmpty( UsernameTextBox.Text ) && string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, Resources.UsernameEmpty );
				ErrorProvider.SetIconPadding( UsernameTextBox, -25 );
				ErrorProvider.SetError( PasswordTextBox, Resources.PasswordEmpty );
				ErrorProvider.SetIconPadding( PasswordTextBox, -25 );
				return;
			}
			if ( string.IsNullOrEmpty( UsernameTextBox.Text ) && !string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, Resources.UsernameEmpty );
				ErrorProvider.SetIconPadding( UsernameTextBox, -25 );
				return;
			}
			if ( !string.IsNullOrEmpty( UsernameTextBox.Text ) && string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{

				ErrorProvider.SetError( PasswordTextBox, Resources.PasswordEmpty );
				ErrorProvider.SetIconPadding( PasswordTextBox, -25 );
				return;
			}
			if ( !string.IsNullOrEmpty( UsernameTextBox.Text ) && !string.IsNullOrEmpty( PasswordTextBox.Text ) )
			{
				ErrorProvider.SetError( UsernameTextBox, "" );
				ErrorProvider.SetError( PasswordTextBox, "" );

				if ( Cache.Authentication( UsernameTextBox.Text, PasswordTextBox.Text ) )
				{
					//entra
					MessageBox.Show( Resources.LoginSucessfullMessage + UsernameTextBox.Text,
								Resources.LoginSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
					Hide( );
					mMainForm.Show( );
				}
				else
				{
					MessageBox.Show( Resources.LoginErrorMessage, Resources.LoginError,
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
