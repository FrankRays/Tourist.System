using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Client.Properties;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;
using Transitions;

namespace Tourist.Client.Forms
{
	public partial class MainForm : MetroForm
	{

		#region Fields

		private readonly LoginForm mLoginForm;
		private readonly IRemote Remote;
		private bool mBackOrExit;

		#endregion

		#region Constructor

		public MainForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );
			mLoginForm = aForm as LoginForm;
			Remote = aRemote;
			mBackOrExit = default( bool );
		}

		#endregion

		#region Events

		private void MainForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			TimerClock.Start( );
		}

		private void TimerClock_Tick( object sender, EventArgs e )
		{
			SharedMethods.TimerClockAnimation( ClockLabel, AmPmLabel, DayNumberLabel,
												DayOfWeekLabel, MonthNameLabel, YearLabel );
		}

		private void BodyPanel_MouseMove( object sender, MouseEventArgs e )
		{

			int x = SideBarPanel.Location.X - SideBarPanel.Width;
			// como esta escondido é preciso subtrarir o width do panel
			int y = SideBarPanel.Location.Y;

			if ( x <= e.X || ( x <= e.X && y <= e.Y ) )
			{
				SideBarPanel.Visible = true;

				Transition t = new Transition( new TransitionType_Linear( 750 ) );
				t.add( SideBarPanel, "Left", ( Width - SideBarPanel.Width ) );
				t.run( );

			}
			else
			{
				SideBarPanel.Visible = false;

				Transition t = new Transition( new TransitionType_Linear( 1 ) );
				t.add( SideBarPanel, "Left", ( Width - 1 ) );
				t.run( );
			}
		}

		private void BookingsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			BookingsForm booking = new BookingsForm( this, Remote );
			booking.Show( );
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var clients = new ClientsForm( this, Remote );
			clients.Show( );
		}

		private void DisponibilityTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var disponibilityForm = new BrowseBookings( this, Remote );
			disponibilityForm.Show( );
		}

		private void PaymentsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var payementForm = new PaymentsForm( this, Remote );
			payementForm.Show( );
		}

		private void ToolsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var toolsForm = new ToolsForm( this, Remote );
			toolsForm.Show( );
		}

		private void HelpTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var helpForm = new HelpForm( this, Remote );
			helpForm.Show( );

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

		private void LogoffTile_Click( object sender, EventArgs e )
		{

			if ( MessageBox.Show( this, Resources.LogOutString, Resources.LogOutTitle,
				 MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk ) == DialogResult.No )
				return;

			mBackOrExit = true;
			Hide( );
			Remote.ClientLoginSession = new Session( );
			mLoginForm.CleanForm( );
			mLoginForm.Show( );
		}

		#endregion

	}
}
