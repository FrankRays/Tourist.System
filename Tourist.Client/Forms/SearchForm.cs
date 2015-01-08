using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Tourist.Client.Properties;
using Tourist.Data.Interfaces;

namespace Tourist.Client.Forms
{
	public partial class SearchForm : MetroForm
	{

		#region Fields

		private readonly IRemote Remote;
		private readonly MainForm mMainForm;
		private readonly BindingSource mBindingSearchDataGrid;
		private readonly BindingSource mBindingSearchByComboBox;
		private readonly BindingSource mBindingSearchFilterComboBox;
		private bool mBackOrExit = default( bool );

		#endregion

		#region Constructor

		public SearchForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );
			Remote = aRemote;
			mMainForm = aForm as MainForm;
			mBindingSearchDataGrid = new BindingSource( );
			mBindingSearchByComboBox = new BindingSource( );
			mBindingSearchFilterComboBox = new BindingSource( );
			SearchParameter2.Value = DateTime.Today;
			SearchParameter3.Value = DateTime.Today.AddDays( 1 );
			SearchDataGrid.AutoGenerateColumns = false;
		}

		#endregion

		#region Events

		private void ToolsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			mBindingSearchByComboBox.DataSource = SearchLogic.SearchBy;
			SearchByComboBox.DataSource = mBindingSearchByComboBox;

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

		private void OkButton_Click( object sender, EventArgs e )
		{
			LoadSearchDataGrid( SearchByComboBox.Text, SearchFilterComboBox.Text, SearchParameter1.Text, SearchParameter2.Value.ToString( "d" ), SearchParameter3.Value.ToString( "d" ) );
		}

		private void SearchByComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			RemoveOldSeachFilterValues( );
			SearchLogic.LoadSearchFilterCombox( SearchByComboBox.Text, mBindingSearchFilterComboBox, SearchFilterComboBox );
		}

		private void SeachFilterComboBox_SelectedValueChanged( object sender, EventArgs e )
		{
			ShowSearchParameters( SearchFilterComboBox.Text );
		}

		#endregion

		#region Private Methods

		private void ShowSearchParameters( string aSearchFilter )
		{

			if ( aSearchFilter.Equals( "Nif" ) || aSearchFilter.Equals( "Phone" ) || aSearchFilter.Equals( "Email" ) )
			{
				SearchParameter1Label.Visible = true;
				SearchParameter1.Visible = true;
				SearchParameter2.Visible = false;
				SearchParameter2Label.Visible = false;
				SearchParameter3.Visible = false;
				return;
			}

			if ( aSearchFilter.Equals( "BookingDate" ) || aSearchFilter.Equals( "StartDate" ) || aSearchFilter.Equals( "EndDate" ) )
			{
				SearchParameter1.Visible = false;
				SearchParameter1Label.Visible = true;
				SearchParameter2.Visible = true;
				return;
			}

			if ( aSearchFilter.Equals( "TimeRange" ) )
			{
				SearchParameter1.Visible = false;
				SearchParameter1Label.Visible = true;
				SearchParameter2.Visible = true;
				SearchParameter2Label.Visible = true;
				SearchParameter3.Visible = true;
				return;
			}

			SearchParameter1Label.Visible = false;
			SearchParameter1.Visible = false;
			SearchParameter2.Visible = false;
			SearchParameter2Label.Visible = false;
			SearchParameter3.Visible = false;
		}

		private void LoadSearchDataGrid( string aSearchBy, string aSearchFilter, string aSearchParameter1 = null,
										string aSearchParameter2 = null, string aSearchParameter3 = null )
		{
			switch ( aSearchBy )
			{
				case "Bookings":
					RemoveOldSearchDataGridValues( );
					AddBookingsColumns( );
					mBindingSearchDataGrid.DataSource = Remote.SearchBookings( aSearchFilter, aSearchParameter1, aSearchParameter2, aSearchParameter3 );
					SearchDataGrid.DataSource = mBindingSearchDataGrid;
					break;
				case "Rooms":
					RemoveOldSearchDataGridValues( );
					AddBookablesColumns( );
					mBindingSearchDataGrid.DataSource = Remote.SearchRooms( aSearchFilter );
					SearchDataGrid.DataSource = mBindingSearchDataGrid;
					break;
				case "Activities":
					RemoveOldSearchDataGridValues( );
					AddBookablesColumns( );
					mBindingSearchDataGrid.DataSource = Remote.SearchActivities( aSearchFilter );
					SearchDataGrid.DataSource = mBindingSearchDataGrid;
					break;
				case "Transports":
					RemoveOldSearchDataGridValues( );
					AddBookablesColumns( );
					mBindingSearchDataGrid.DataSource = Remote.SearchTransports( aSearchFilter );
					SearchDataGrid.DataSource = mBindingSearchDataGrid;
					break;
				case "Clients":
					RemoveOldSearchDataGridValues( );
					AddPersonColumns( );
					mBindingSearchDataGrid.DataSource = Remote.SearchClients( aSearchFilter, aSearchParameter1 );
					SearchDataGrid.DataSource = mBindingSearchDataGrid;
					break;
			}
		}

		private void AddBookingsColumns( )
		{

			var bookingIdColumn = new DataGridViewTextBoxColumn( );
			var clientNifColumn = new DataGridViewTextBoxColumn( );
			var clientNameColumn = new DataGridViewTextBoxColumn( );
			var typeColumn = new DataGridViewTextBoxColumn( );
			var subTypeColumn = new DataGridViewTextBoxColumn( );
			var bookableIdColumn = new DataGridViewTextBoxColumn( );
			var bookableDescriptionColumn = new DataGridViewTextBoxColumn( );
			var basePriceColumn = new DataGridViewTextBoxColumn( );
			var bookingDateColumn = new DataGridViewTextBoxColumn( );
			var startDateColumn = new DataGridViewTextBoxColumn( );
			var endDateColumn = new DataGridViewTextBoxColumn( );
			var totalPriceColumn = new DataGridViewTextBoxColumn( );

			SearchDataGrid.Columns.AddRange( bookingIdColumn, clientNifColumn, clientNameColumn,
												typeColumn, subTypeColumn, bookableIdColumn,
												bookableDescriptionColumn, basePriceColumn, bookingDateColumn,
												startDateColumn, endDateColumn, totalPriceColumn );

			bookingIdColumn.HeaderText = "Booking ID";
			clientNifColumn.HeaderText = "Client Nif";
			clientNameColumn.HeaderText = "Client Name";
			typeColumn.HeaderText = "Type";
			subTypeColumn.HeaderText = "SubType";
			bookableIdColumn.HeaderText = "Bookable ID";
			bookableDescriptionColumn.HeaderText = "Bookable Description";
			basePriceColumn.HeaderText = "Base Price (€)";
			bookingDateColumn.HeaderText = "Booking Date";
			startDateColumn.HeaderText = "Start-Date";
			endDateColumn.HeaderText = "End-Date";
			totalPriceColumn.HeaderText = "Total Price (€)";

			bookingIdColumn.DataPropertyName = "Id";
			clientNifColumn.DataPropertyName = "ClientNif";
			clientNameColumn.DataPropertyName = "ClientName";
			typeColumn.DataPropertyName = "BookableType";
			subTypeColumn.DataPropertyName = "BookableSubType";
			bookableIdColumn.DataPropertyName = "BookableId";
			bookableDescriptionColumn.DataPropertyName = "BookableDescription";
			basePriceColumn.DataPropertyName = "BookableBasePrice";
			bookingDateColumn.DataPropertyName = "BookingDay";
			startDateColumn.DataPropertyName = "BookingStartDate";
			endDateColumn.DataPropertyName = "BookingEndDate";
			totalPriceColumn.DataPropertyName = "BookingTotalPrice";

			bookingIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			clientNifColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			clientNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			subTypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			bookableIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			bookableDescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			basePriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			bookingDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			startDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			endDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			totalPriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

			bookingIdColumn.MinimumWidth = 125;
			clientNifColumn.MinimumWidth = 125;
			clientNameColumn.MinimumWidth = 200;
			typeColumn.MinimumWidth = 150;
			subTypeColumn.MinimumWidth = 150;
			bookableIdColumn.MinimumWidth = 125;
			bookableDescriptionColumn.MinimumWidth = 250;
			basePriceColumn.MinimumWidth = 150;
			bookingDateColumn.MinimumWidth = 150;
			startDateColumn.MinimumWidth = 125;
			endDateColumn.MinimumWidth = 125;
			totalPriceColumn.MinimumWidth = 150;
		}

		public void AddBookablesColumns( )
		{

			var IdColumn = new DataGridViewTextBoxColumn( );
			var TypeColumn = new DataGridViewTextBoxColumn( );
			var StateColumn = new DataGridViewTextBoxColumn( );
			var DescriptionColumn = new DataGridViewTextBoxColumn( );
			var BasePriceColumn = new DataGridViewTextBoxColumn( );
			var CapacityColumn = new DataGridViewTextBoxColumn( );

			SearchDataGrid.Columns.AddRange( IdColumn, TypeColumn, StateColumn,
											 DescriptionColumn, BasePriceColumn, CapacityColumn );

			IdColumn.HeaderText = "Bookable ID";
			TypeColumn.HeaderText = "Type";
			StateColumn.HeaderText = "State";
			DescriptionColumn.HeaderText = "Description";
			BasePriceColumn.HeaderText = "Base Price (€)";
			CapacityColumn.HeaderText = "Capacity";

			IdColumn.DataPropertyName = "Id";
			TypeColumn.DataPropertyName = "SerializationType";
			StateColumn.DataPropertyName = "State";
			DescriptionColumn.DataPropertyName = "Description";
			BasePriceColumn.DataPropertyName = "Price";
			CapacityColumn.DataPropertyName = "Capacity";

			IdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			TypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			StateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			DescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			BasePriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			CapacityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

			IdColumn.MinimumWidth = 125;
			TypeColumn.MinimumWidth = 125;
			StateColumn.MinimumWidth = 125;
			DescriptionColumn.MinimumWidth = 250;
			BasePriceColumn.MinimumWidth = 150;
			CapacityColumn.MinimumWidth = 125;
		}

		public void AddPersonColumns( )
		{
			var IdColumn = new DataGridViewTextBoxColumn( );
			var FirstNameColumn = new DataGridViewTextBoxColumn( );
			var LastNameColumn = new DataGridViewTextBoxColumn( );
			var NationalityColumn = new DataGridViewTextBoxColumn( );
			var BirthDateColumn = new DataGridViewTextBoxColumn( );
			var GenderColumn = new DataGridViewTextBoxColumn( );
			var NifColumn = new DataGridViewTextBoxColumn( );
			var AddressColumn = new DataGridViewTextBoxColumn( );
			var PhoneColumn = new DataGridViewTextBoxColumn( );
			var EmailColumn = new DataGridViewTextBoxColumn( );

			SearchDataGrid.Columns.AddRange( IdColumn, NifColumn, FirstNameColumn,
											 LastNameColumn, NationalityColumn, BirthDateColumn,
											 GenderColumn, AddressColumn,
											 PhoneColumn, EmailColumn );

			IdColumn.HeaderText = "ID";
			FirstNameColumn.HeaderText = "First Name";
			LastNameColumn.HeaderText = "Last Name";
			NationalityColumn.HeaderText = "Nationality";
			BirthDateColumn.HeaderText = "Birth Date";
			GenderColumn.HeaderText = "Gender";
			NifColumn.HeaderText = "Nif";
			AddressColumn.HeaderText = "Address";
			PhoneColumn.HeaderText = "Phone";
			EmailColumn.HeaderText = "Email";

			IdColumn.DataPropertyName = "Id";
			FirstNameColumn.DataPropertyName = "FirstName";
			LastNameColumn.DataPropertyName = "LastName";
			GenderColumn.DataPropertyName = "Gender";
			NationalityColumn.DataPropertyName = "Nationality";
			BirthDateColumn.DataPropertyName = "BirthDate";
			NifColumn.DataPropertyName = "Nif";
			AddressColumn.DataPropertyName = "Address";
			PhoneColumn.DataPropertyName = "Phone";
			EmailColumn.DataPropertyName = "Email";

			IdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			FirstNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			LastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			NationalityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			BirthDateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			GenderColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			NifColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			AddressColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			PhoneColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
			EmailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

			IdColumn.MinimumWidth = 125;
			FirstNameColumn.MinimumWidth = 150;
			LastNameColumn.MinimumWidth = 150;
			NationalityColumn.MinimumWidth = 150;
			BirthDateColumn.MinimumWidth = 125;
			GenderColumn.MinimumWidth = 125;
			NifColumn.MinimumWidth = 125;
			AddressColumn.MinimumWidth = 150;
			PhoneColumn.MinimumWidth = 125;
			EmailColumn.MinimumWidth = 200;

		}

		private void RemoveOldSeachFilterValues( )
		{
			mBindingSearchFilterComboBox.DataSource = null;
		}

		private void RemoveOldSearchDataGridValues( )
		{
			SearchDataGrid.Columns.Clear( );
		}

		#endregion

	}
}
