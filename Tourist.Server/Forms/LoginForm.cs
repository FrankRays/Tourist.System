using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		#region Fields
		
		private readonly Repository Repository = Repository.Instance;
		private MainForm mMainForm;
		private bool mLoginFormOrEntityForm = default( bool );
		private int mEntityId = default( int );

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
			Shared.SetFormFullScreen(this);
		}

		#endregion

		#region Events

		private void OkButton_Click( object sender, EventArgs e )
		{
			Hide( );

			if ( Repository.IsEmpty( "Entity" ) )
			{
				var entityForm = new EntityForm( mMainForm );
				entityForm.Show( );
			}
			else if ( Repository.IsEmpty( "Managers" ) )
			{
				var managerForm = new ManagersForm( mMainForm );
				managerForm.Show( );
			}
			else if ( !Repository.IsEmpty( "Managers" ) && Repository.IsEmpty( "Employees" ) )
			{
				var employersForm = new EmployersForm( mMainForm );
				employersForm.Show( );
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

		
		#endregion

	}
}
