using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm : MetroForm
	{
		private readonly MainForm mMainForm;
		private readonly Repository repository = Repository.Instance;
		private readonly int mEntityId;
		private bool mBackOrExit = default( bool );

		public ClientsForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mEntityId = mMainForm.EntityId;
		}

		private void ClientsForm_Load( object sender, System.EventArgs e )
		{
			SetFormFullScreen( );
			LoadDataToGrid();
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

		private void LoadDataToGrid( )
		{
			if ( repository.IsEmpty( ) )
				return;

			if ( repository.IsClientListEmpty( mEntityId ) )
				return;

			var clientsMatrix = repository.ClientsListToMatrix( mEntityId, ClientsDataGrid.ColumnCount );

			for ( var i = 0 ; i < repository.ClientsListCount( mEntityId ) ; i++ )
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
