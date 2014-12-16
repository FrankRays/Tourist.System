using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class BookingsForm: MetroForm
	{
		private MainForm mMainForm;
		private int mEntityId;
		private bool mBackOrExit = default( bool );

		public BookingsForm(Form aForm )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
		}

		private void BookingsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen();
			
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

		private void metroGrid3_CellContentClick( object sender, DataGridViewCellEventArgs e )
		{

		}

		private void HeaderPanel_Paint( object sender, PaintEventArgs e )
		{

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
