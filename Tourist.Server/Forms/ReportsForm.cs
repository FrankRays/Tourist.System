using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class ReportsForm : MetroForm
	{
		private readonly MainForm mMainForm;

		public ReportsForm( Form aForm )
		{
			mMainForm = aForm as MainForm;
			InitializeComponent( );
		}

		private void ReportsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );

		}

		private void SetFormFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			Hide( );
			mMainForm.Show( );
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			// Confirm user wants to close
			switch ( dialogResult )
			{
				case DialogResult.No:
					e.Cancel = true;
					//Application.Exit();
					break;
				default:
					System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
					break;
			}
		}

	}
}
