using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class LoginForm : MetroForm
	{

		private IRemote Remote;
		private readonly MainForm mMainForm;

		public LoginForm( IRemote aRemote )
		{
			InitializeComponent( );
			Remote = aRemote;
			mMainForm = new MainForm( this, Remote );
		}

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen(this);
			
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, Resources.ExitMessage,
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
				Close();
			}
			else 
			{
				LoginErrorChecking( );
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

				if ( Remote.CheckLogin( UsernameTextBox.Text, PasswordTextBox.Text, "Client" ) )
				{
					//entra
					MessageBox.Show( Resources.LoginSucessfullMessage + " " + LoginInfoClient.Username,
								Resources.LoginSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
					Hide( );
					mMainForm.Show( );
				}
				else
				{
					MessageBox.Show( Resources.LoginErrorMessage +" "+LoginInfoClient.Username, Resources.LoginError, 
																			  MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
		}
	}
}
