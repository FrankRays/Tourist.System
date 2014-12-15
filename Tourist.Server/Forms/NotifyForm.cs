using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class NotifyForm : MetroForm
	{
		private readonly MainForm mMainForm;

		public NotifyForm( Form aForm )
		{
			mMainForm = aForm as MainForm;
			InitializeComponent( );
		}

		private void NotifyForm_Load( object sender, System.EventArgs e )
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

		private void NotifyForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			// se precisar grava os dados antes de sair 

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?", "Login Cancel Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( dialogResult == DialogResult.No )
				return;

			Application.Exit( );
		}
	}
}
