using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Tourist.Server.Properties;

namespace Tourist.Server.Forms
{
	public partial class SearchForm : MetroForm
	{
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );
		private readonly BindingSource mBindingSource;
		//private readonly List<string> mSearchFilterBookings;
		private readonly List<string> mSearchFilterBookables;
		private readonly List<string> mSearchFilterPersons;

		public SearchForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mBindingSource = new BindingSource();
			mSearchFilterBookables = new List<string> { "Subtypes","State","Price" };
			mSearchFilterPersons = new List<string> {"Nif", "Phone", "Email"};
		}

		private void ToolsForm_Load( object sender, System.EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
		}

		private void LoadSearchFilterValues( string aSearchBy )
		{
			switch (aSearchBy)
			{
		
				case "Bookings":
					break;
				case "Bookables":
					mBindingSource.DataSource = mSearchFilterBookables;
					SeachFilterComboBox.DataSource = mBindingSource;
					break;
				case "Clients":
					mBindingSource.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSource;
					break;
				case "Managers":
					mBindingSource.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSource;
					break;
				case "Employees":
					mBindingSource.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSource;
					break;			
			}
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

		private void OkButton_Click( object sender, System.EventArgs e )
		{
			// Show data if exists
		}

		private void SearchByComboBox_SelectedValueChanged( object sender, System.EventArgs e )
		{
			CleanOldSeachFilterValues();
			LoadSearchFilterValues(SearchByComboBox.Text);
		}

		private void CleanOldSeachFilterValues()
		{
			mBindingSource.DataSource = null;
		}

	}
}
