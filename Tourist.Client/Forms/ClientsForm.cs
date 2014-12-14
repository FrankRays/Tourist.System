using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm: MetroForm
	{

		private int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
		private int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;


		public ClientsForm( )
		{
			InitializeComponent( );
		}

		private void ClientsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen();
			//RescaleScreenItens();
		}

		private void SetFormFullScreen( )
		{
			Location = new Point( 0, 0 );
			Size = new Size( ScreenWidth, ScreenHeight );
		}
		
	}
}
