using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Transitions;

namespace Tourist.Server.Forms
{
	public partial class MainForm : MetroForm
	{
		private int mEntityId = default( int );

		public int EntityId
		{
			get { return mEntityId; }
			private set { mEntityId = value; }
		}

		public MainForm( Form aForm, int entityId )
		{
			InitializeComponent( );

			EntityId = entityId;
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			SetFullScreen( );
			TimerClock.Start( );//conta segundos relogio
		}

		private void SetFullScreen( )
		{
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );

			FormBorderStyle = FormBorderStyle.None;
			Focus( );
		}

		private void TimerClock_Tick( object sender, EventArgs e )
		{
			ClockLabel.Text = DateTime.Now.ToString( "HH:mm:ss" );

			if ( DateTime.Now.Hour >= 12 && DateTime.Now.Minute >= 0 )
				AmPmLabel.Text = "PM";
			else
				AmPmLabel.Text = "AM";

			if ( DateTime.Today.Day < 10 )
				DayNumberLabel.Text = "0" + DateTime.Today.Day;
			else
				DayNumberLabel.Text = DateTime.Today.Day.ToString( );

			DayOfWeekLabel.Text = DateTime.Today.DayOfWeek.ToString( );
			MonthNameLabel.Text = MonthsName( DateTime.Today.Month );
			YearLabel.Text = DateTime.Today.Year.ToString( );

		}

		private string MonthsName( int aMonth )
		{
			switch ( aMonth )
			{
				case 1: return "January";
				case 2: return "February";
				case 3: return "March";
				case 4: return "April";
				case 5: return "May";
				case 6: return "June";
				case 7: return "July";
				case 8: return "August";
				case 9: return "September";
				case 10: return "October";
				case 11: return "November";
				case 12: return "December";
				default: return "Error";
			}
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

			var servicesForm = new ServicesForm( this );
			servicesForm.Show( );
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			Hide( );

			var clientsForm = new ClientsForm( this );
			clientsForm.Show( );
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

		private void BackupFile_OK( object sender, System.ComponentModel.CancelEventArgs e )
		{
			// se houver tempo
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
		}

	}
}
