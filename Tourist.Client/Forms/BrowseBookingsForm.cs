using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class BrowseBookingsForm : MetroForm
	{

		#region Fields

		private readonly MainForm MainForm;
		private readonly IRemote Remote;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public BrowseBookingsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );
			MainForm = aForm as MainForm;
			Remote = aRemote;
		}

		#endregion

		#region Events

		private void BookingsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{
			var dialog = MessageBox.Show( this, Resources.RemoveString,
			Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if ( dialog == DialogResult.No )
			{
				ReLoadDataToGrid( );
				return;
			}
			var removeIndex = e.RowIndex;

			Remote.Remove( removeIndex, "Bookings" );
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Resources.ExitMessage,
				Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

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
			MainForm.Show( );
		}

		#endregion

		#region Private Methods

		private void BrowseBookingsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
		}

		private void LoadDataToGrid( )
		{
			if ( Remote.IsEmpty( "Bookings" ) )
				return;

			var roomMatrix = Remote.ListToMatrix( "Bookings" );

			for ( var i = 0 ; i < Remote.Count( "Bookings" ) ; i++ )
			{
				BookingsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < BookingsDataGrid.ColumnCount ; j++ )
				{
					BookingsDataGrid.Rows[ i ].Cells[ j ].Value = roomMatrix[ i, j ];
				}
			}
		}

		private void ReLoadDataToGrid( )
		{
			SharedMethods.ClearDataGrid( BookingsDataGrid );
			LoadDataToGrid( );
		}

		#endregion

	}
}
