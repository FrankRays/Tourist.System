using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm : MetroForm
	{
		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		public ClientsForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
		}

		private void ClientsForm_Load( object sender, System.EventArgs e )
		{
			Shared.SetFormFullScreen(this);
			LoadDataToGrid();
		}

		private void LoadDataToGrid( )
		{
			if ( Repository.IsEmpty( "Clients" ) )
				return;

			var clientsMatrix = Repository.ListToMatrix( "Clients" );

			for ( var i = 0 ; i < Repository.Count( "Clients" ) ; i++ )
			{
				ClientsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ClientsDataGrid.ColumnCount ; j++ )
				{
					ClientsDataGrid.Rows[ i ].Cells[ j ].Value = clientsMatrix[ i, j ];
				}
			}
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
