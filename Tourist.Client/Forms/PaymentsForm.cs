using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class PaymentsForm: MetroForm
	{
		private MainForm mMainForm;
		private int mEntityId;
		private bool mBackOrExit = default( bool );
		
		public PaymentsForm(Form aForm )
		{
			InitializeComponent( );
			
			mMainForm = aForm as MainForm;
		}

		private void PaymentsForm_Load( object sender, System.EventArgs e )
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



	}
}
