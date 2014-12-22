using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Client.Forms
{
	public partial class BookingsForm : MetroForm
	{
		private MainForm mMainForm;
		private IRemote mRemote;
		private int mEntityId;
		private bool mBackOrExit = default( bool );

		public BookingsForm( Form aForm )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
			mRemote = mMainForm.Remote;
		}

		private void BookingsForm_Load( object sender, EventArgs e )
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
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}

		private void HeaderPanel_Paint( object sender, PaintEventArgs e )
		{

		}

		private void BackPanel_Paint( object sender, PaintEventArgs e )
		{

		}

		private void TitleLabel_Click( object sender, EventArgs e )
		{

		}

		private void SubTitleLabel_Click( object sender, EventArgs e )
		{

		}

	}
}
