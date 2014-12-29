using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;

namespace Tourist.Client.Forms
{
	public partial class BookingsForm : MetroForm
	{
		
		private readonly MainForm mMainForm;
		private readonly IRemote Remote;
		private bool mBackOrExit = default( bool );

		public BookingsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );

			mMainForm = aForm as MainForm;
			Remote = aRemote;
		}

		private void BookingsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );

		}

		#region Close Events

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Properties.Resources.ExitMessage,
				Properties.Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

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

		#endregion

	}
}
