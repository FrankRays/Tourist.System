using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;


namespace Tourist.Server.Forms
{
	public partial class LoginForm : MetroForm
	{

		private IRemote mRemote;
		private MainForm mMainForm;
		private bool mLoginFormOrEntityForm = default( bool );
		private int mEntityId = default( int );

		public LoginForm( IRemote aRemote )
		{
			InitializeComponent( );
			mRemote = aRemote;
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
			Focus( );

		}

		private bool CanLoadEntityNamesComboBox( )
		{

			if ( mRemote.IsRepositoryEmpty() )
				return false;

			var bindingSource = new BindingSource { DataSource = mRemote.GetEntityNameList() };

			EntityNameCombox.DataSource = bindingSource;

			return true;
		}

		private void ShowMainForm( )
		{

			var selectedItem = EntityNameCombox.SelectedItem;
			mEntityId = mRemote.GetEntityId( selectedItem.ToString( ) );
			mMainForm = new MainForm( this, mRemote, mEntityId );
			Hide( );
			mMainForm.Show( );
			
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

		private void OkButton_Click( object sender, EventArgs e )
		{
			ShowMainForm( );
		}
		
		private void ExitButton_Click( object sender, EventArgs e )
		{
			Close( );
		}
	}
}
