using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class PaymentsForm: MetroForm
	{
		private readonly IRemote Remote;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );
		
		public PaymentsForm(Form aForm, IRemote aRemote )
		{
			InitializeComponent( );
			
			mMainForm = aForm as MainForm;
			Remote = aRemote;
		}

		private void PaymentsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen(this);
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
			mMainForm.Show( );
		}

	}
}
