﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Tourist.Server.Properties;

namespace Tourist.Server.Forms
{
	public partial class NotifyForm : MetroForm
	{

		#region Fields

		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public NotifyForm( Form aForm )
		{
			mMainForm = aForm as MainForm;
			InitializeComponent( );
		}

		#endregion

		#region Events

		private void NotifyForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
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

		#endregion

	}
}
