using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class EmployersForm : MetroForm
	{
		private readonly MainForm mMainForm;
		private readonly Repository repository = Repository.Instance;
		private bool mBackOrExit = default( bool );

		public EmployersForm( Form aForm )
		{
			mMainForm = aForm as MainForm;
			InitializeComponent( );
		}

		private void EmployersForm_Load( object sender, System.EventArgs e )
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

		private void LoadDataToGrid( )
		{
			if ( repository.IsEmpty( ) )
				return;

			var entitiesMatrix = repository.EntitiesListToMatrix( EmployersDataGrid.ColumnCount );

			for ( int i = 0 ; i < repository.Count( ) ; i++ )
			{
				EmployersDataGrid.Rows.Add( );

				for ( int j = 0 ; j < EmployersDataGrid.ColumnCount ; j++ )
				{
					EmployersDataGrid.Rows[ i ].Cells[ j ].Value = entitiesMatrix[ i, j ];
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

		private void EmployersDataGrid_RowValidating( object sender, DataGridViewCellCancelEventArgs e )
		{

		}
	}
}
