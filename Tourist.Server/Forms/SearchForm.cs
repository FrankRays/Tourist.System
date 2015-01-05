using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Tourist.Server.Properties;

namespace Tourist.Server.Forms
{
	public partial class SearchForm : MetroForm
	{
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );
		private readonly BindingSource mBindingSearchBy;
		private readonly BindingSource mBindingSearchFilter;
		private readonly List<string> mSearchByList;
		private readonly List<string> mSearchFilterBookings;
		private readonly List<string> mSearchFilterRoom;
		private readonly List<string> mSearchFilterActivities;
		private readonly List<string> mSearchFilterTransports;
		private readonly List<string> mSearchFilterPersons;


		public SearchForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			mBindingSearchBy = new BindingSource( );
			mBindingSearchFilter = new BindingSource( );
			mSearchByList = new List<string> { "Rooms", "Activities", "Transports", "Clients", "Employees", "Managers" };
			//mSearchFilterBookings = new List<string> { "Nif", "Type", "SubType" };
			mSearchFilterRoom = new List<string> { "Single", "Double", "DoubleSingle", "Suite", "FamiliySuite", "Meeting" };
			mSearchFilterActivities = new List<string> { "BoatRide", "Golf", "Camping", "Diving", "SightSeeing", "SkyDiving" };
			mSearchFilterTransports = new List<string> { "TuckTuck", "CableCar", "Bicycle", "Car", "Bus", "Motorist" };
			mSearchFilterPersons = new List<string> { "Nif", "Phone", "Email" };
		}

		private void ToolsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			mBindingSearchBy.DataSource = mSearchByList;
			SearchByComboBox.DataSource = mBindingSearchBy;
		}

		private void LoadSearchFilterValues( string aSearchBy )
		{
			switch ( aSearchBy )
			{

				/*
				case "Bookings":
					mBindingSearchFilter.DataSource = mSearchFilterBookings;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				 */
				case "Rooms":
					mBindingSearchFilter.DataSource = mSearchFilterRoom;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				case "Activities":
					mBindingSearchFilter.DataSource = mSearchFilterActivities;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				case "Transports":
					mBindingSearchFilter.DataSource = mSearchFilterTransports;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				case "Clients":
					mBindingSearchFilter.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				case "Managers":
					mBindingSearchFilter.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
				case "Employees":
					mBindingSearchFilter.DataSource = mSearchFilterPersons;
					SeachFilterComboBox.DataSource = mBindingSearchFilter;
					break;
			}
		}

		private void ShowSearchTextBox( string aSearchFilter )
		{
			if ( aSearchFilter.Equals( "Nif" ) || aSearchFilter.Equals( "Phone" ) || aSearchFilter.Equals( "Email" ) )
			{
				SearchParameterLabel.Visible = true;
				SearchParameterTextBox.Visible = true;
			}
			else
			{
				SearchParameterLabel.Visible = false;
				SearchParameterTextBox.Visible = false;
			}
		}

		private void LoadSearchDataGrid( string aSearchBy, string aSearchFilter, string aSearchParameter )
		{

			switch ( aSearchBy )
			{
				case "Bookings":
					break;
				case "Rooms":
					break;
				case "Activities":
					break;
				case "Transports":
					break;
				case "Clients":
					break;
				case "Managers":
					break;
				case "Employees":
					break;
			}

		}

		/*
		private void AddColumnsToSearchDataGrid( string aSearchBy, string aSearchFilter, string aSearchParameter )
		{

			
			var col3 = new DataGridViewTextBoxColumn( );
			var col4 = new DataGridViewCheckBoxColumn( );

			col3.HeaderText = "Column3";
			col3.Name = "Column3";

			col4.HeaderText = "Column4";
			col4.Name = "Column4";

			dataGridView1.Columns.AddRange( new DataGridViewColumn[ ] { col3, col4 } );
		}
		*/


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

		private void OkButton_Click( object sender, EventArgs e )
		{
			// Show data if exists
		}

		private void SearchByComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			CleanOldSeachFilterValues( );
			LoadSearchFilterValues( SearchByComboBox.Text );
		}

		private void CleanOldSeachFilterValues( )
		{
			mBindingSearchFilter.DataSource = null;
		}

		private void SeachFilterComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			ShowSearchTextBox( SeachFilterComboBox.Text );
		}

	}
}
