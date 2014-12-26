using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Shared;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private MainForm mMainForm;

		#endregion

		#region Constructor

		public LoginForm( )
		{
			InitializeComponent( );
			mMainForm = new MainForm( this );
		}

		#endregion

		#region Private Methods

		private void LoginForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
		}

		#endregion

		#region Events

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

				if (Repository.CheckLogin(UsernameTextBox.Text, PasswordTextBox.Text, "Server"))
				{
					//entra
					MessageBox.Show( "Welcome " + LoginInfoServer.Username + " !", "Login Successful !!!", MessageBoxButtons.OK, MessageBoxIcon.Information );
					Hide( );
					mMainForm.Show();
				}
				else
				{
					MessageBox.Show( "Error !!! Check your username or password.", "Login Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
		}

		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close( );
		}


		#endregion

	}
}
