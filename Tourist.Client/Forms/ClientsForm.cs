using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Client.Forms
{
	public partial class ClientsForm : MetroForm
	{

		private MainForm mMainForm;
		private IRemote mRemote;
		private int mEntityId;
		private bool mBackOrExit = default( bool );


		public ClientsForm( Form aForm )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
			mRemote = mMainForm.Remote;
		}

		private void ClientsForm_Load( object sender, System.EventArgs e )
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

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}
	}
}