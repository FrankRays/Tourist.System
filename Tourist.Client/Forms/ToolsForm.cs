using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Client.Forms
{
	public partial class ToolsForm : MetroForm
	{
		private readonly IRemote Remote;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		public ToolsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			Remote = aRemote;
		}

		private void ToolsForm_Load( object sender, System.EventArgs e )
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

			var dialogResult = MessageBox.Show( this, "\n Are you sure you want to exit the application?",
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
