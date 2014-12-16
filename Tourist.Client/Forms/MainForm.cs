using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Interfaces;
using Transitions;

namespace Tourist.Server.Forms
{
	public partial class MainForm : MetroForm
	{

		private LoginForm mLoginForm;
		private IRemote mRemote;
		private int mEntityId;

		public IRemote Remote
		{
			get { return mRemote; }
		}

		public int EntityId
		{
			get { return mEntityId; }
		}

		public MainForm( Form aForm, IRemote aRemote, int aEntityId )
		{
			InitializeComponent( );

			mLoginForm = aForm as LoginForm;
			mRemote = aRemote;
			mEntityId = aEntityId;
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			SetFullScreen( );
			TimerClock.Start( );
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
			BookingsForm booking = new BookingsForm( this );
			booking.Show( );
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var clients = new ClientsForm( this );
			clients.Show( );
		}

		private void DisponibilityTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var disponibility = new DisponibilityForm( this );
			disponibility.Show( );

		}

		private void PaymentsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			var payementForm = new PaymentsForm( this );
			payementForm.Show( );
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
