using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Transitions;

namespace Tourist.Server.Forms
{
	public partial class MainForm : MetroForm
	{

		#region Fields

		private LoginForm mLoginForm;
		private EntityForm mEntityForm;
		private EmployersForm mEmployersForm;
		private ServicesForm mServicesForm;
		private ClientsForm mClientsForm;
		private DisponibilityForm mDisponibilityForm;
		private ReportsForm mReportsForm;
		private NotifyForm mNotifyForm;
		// backup form
		private ToolsForm mToolsForm;
		private HelpForm mHelpForm;

		#endregion

		#region Properties
		
		public LoginForm LoginForm
		{
			get { return mLoginForm; }
			set { mLoginForm = value; }
		}

		public EntityForm EntityForm
		{
			get { return mEntityForm; }
			set { mEntityForm = value; }
		}

		public EmployersForm EmployersForm
		{
			get { return mEmployersForm; }
			set { mEmployersForm = value; }
		}

		public ServicesForm ServicesForm
		{
			get { return mServicesForm; }
			set { mServicesForm = value; }
		}

		public ClientsForm ClientsForm
		{
			get { return mClientsForm; }
			set { mClientsForm = value; }
		}

		public DisponibilityForm DisponibilityForm
		{
			get { return mDisponibilityForm; }
			set { mDisponibilityForm = value; }
		}

		public ReportsForm ReportsForm
		{
			get { return mReportsForm; }
			set { mReportsForm = value; }
		}

		public NotifyForm NotifyForm
		{
			get { return mNotifyForm; }
			set { mNotifyForm = value; }
		}

		public ToolsForm ToolsForm
		{
			get { return mToolsForm; }
			set { mToolsForm = value; }
		}

		public HelpForm HelpForm
		{
			get { return mHelpForm; }
			set { mHelpForm = value; }
		}

		#endregion

		public MainForm( Form aForm )
		{
			mLoginForm = aForm as LoginForm;
			mEntityForm = new EntityForm(this);
			mEmployersForm = new EmployersForm(this);
			mServicesForm = new ServicesForm(this);
			mClientsForm = new ClientsForm(this);
			mDisponibilityForm = new DisponibilityForm(this);
			mReportsForm =new ReportsForm(this);
			mNotifyForm = new NotifyForm(this);
			// backup form
			mToolsForm = new ToolsForm(this);
			mHelpForm = new HelpForm(this);


			//this.ShowInTaskbar = false;
			InitializeComponent( );

		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			SetFullScreen( );
			TimerClock.Start( );//conta segundos relogio

		}

		private void SetFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
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

				Transition transition = new Transition( new TransitionType_Linear( 750 ) );
				transition.add( SideBarPanel, "Left", ( Width - SideBarPanel.Width ) );
				transition.run( );
			}
			else
			{
				SideBarPanel.Visible = false;

				Transition transition = new Transition( new TransitionType_Linear( 1 ) );
				transition.add( SideBarPanel, "Left", ( Width - 1 ) );
				transition.run( );
			}
		}

		private void EntityTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mEntityForm.Show( );
		}

		private void EmployersTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mEmployersForm.Show( );
		}

		private void ServicesTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mServicesForm.Show( );
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mClientsForm.Show( );
		}

		private void DisponibilityTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mDisponibilityForm.Show( );
		}

		private void ReportsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mReportsForm.Show( );
		}

		private void NotifyTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mNotifyForm.Show( );
		}

		private void BackupTile_Click( object sender, EventArgs e )
		{
			BackupFile.ShowDialog();
		}

		private void ToolsTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mToolsForm.Show( );
		}

		private void HelpTile_Click( object sender, EventArgs e )
		{
			Hide( );
			mHelpForm.Show( );
		}

		private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			// se precisar grava os dados antes de sair 

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?", "Login Cancel Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( dialogResult == DialogResult.No )
				return;

			Application.Exit( );
		}

		private void BackupFile_OK( object sender, System.ComponentModel.CancelEventArgs e )
		{
			// se houver tempo
		}

	
	}
}
