using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Transitions;

namespace Tourist.Server.Forms
{
	public partial class MainForm : MetroForm
	{

		#region Fields
		
		private LoginForm mLoginForm;

		public LoginForm LoginForm
		{
			get { return mLoginForm; }
			set { mLoginForm = value; }
		}
		
		#endregion

		#region Constructor
		
		public MainForm( Form aForm )
		{
			InitializeComponent( );
			LoginForm = aForm as LoginForm;
		}

		#endregion

		#region Events
		
		private void MainForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen(this);
			TimerClock.Start( );//conta segundos relogio
		}

		private void TimerClock_Tick( object sender, EventArgs e )
		{
			SharedMethods.TimerClockAnimation( ClockLabel, AmPmLabel, DayNumberLabel,
												DayOfWeekLabel, MonthNameLabel, YearLabel );
		}

		private void BodyPanel_MouseMove( object sender, MouseEventArgs e )
		{

			var x = SideBarPanel.Location.X - SideBarPanel.Width;
			// como esta escondido é preciso subtrair o width do panel
			var y = SideBarPanel.Location.Y;

			if ( x <= e.X || ( x <= e.X && y <= e.Y ) )
			{
				SideBarPanel.Visible = true;

				var transition = new Transition( new TransitionType_Linear( 750 ) );
				transition.add( SideBarPanel, "Left", ( Width - SideBarPanel.Width ) );
				transition.run( );
			}
			else
			{
				SideBarPanel.Visible = false;

				var transition = new Transition( new TransitionType_Linear( 1 ) );
				transition.add( SideBarPanel, "Left", ( Width - 1 ) );
				transition.run( );
			}
		}

		private void EntityTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var entityForm = new EntityForm( this );
			entityForm.Show( );
		}

		private void EmployersTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var employersForm = new EmployersForm( this );
			employersForm.Show( );
		}

		private void ServicesTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var servicesForm = new BookablesForm( this );
			servicesForm.Show( );
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var clientsForm = new ClientsForm( this );
			clientsForm.Show( );
		}

		private void ManagersTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var managersForm = new ManagersForm( this );
			managersForm.Show();
		}

		private void DisponibilityTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var disponibilityForm = new DisponibilityForm( this );
			disponibilityForm.Show( );
		}

		private void ReportsTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var reportsForm = new ReportsForm( this );
			reportsForm.Show( );
		}

		private void NotifyTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var notifyForm = new NotifyForm( this );
			notifyForm.Show( );
		}

		private void BackupTile_Click( object sender, EventArgs e )
		{
			BackupFile.ShowDialog( );
		}

		private void ToolsTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var toolsForm = new ToolsForm( this );
			toolsForm.Show( );
		}

		private void HelpTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var helpForm = new HelpForm( this );
			helpForm.Show( );

		}

		private void BackupFile_OK( object sender, CancelEventArgs e )
		{
			// se houver tempo
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Properties.Resources.ExitMessage,
				Properties.Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		#endregion

	}
}
