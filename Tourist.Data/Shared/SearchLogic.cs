using System.Collections.Generic;
using System.Windows.Forms;

namespace Tourist.Data.Shared
{
	public static class SearchLogic
	{

		#region Fields

		private static List<string> mSearchBy = new List<string> { "Bookings","Rooms", "Activities", "Transports", 
																   "Clients", "Employees", "Managers" };
		private static List<string> mSearchFilterBookings = new List<string> { "Nif", "BookingDate", 
																			   "StartDate", "EndDate", "TimeRange" };
		private static List<string> mSearchFilterRoom = new List<string> { "Single", "Double", "DoubleSingle", 
																		   "Suite", "FamiliySuite", "Meeting" };
		private static List<string> mSearchFilterActivities = new List<string> { "BoatRide", "Golf", "Camping", 
																				 "Diving", "SightSeeing", "SkyDiving" };
		private static List<string> mSearchFilterTransports = new List<string> { "TuckTuck", "CableCar", "Bicycle", 
																				 "Car", "Bus", "Motorist" };
		private static List<string> mSearchFilterPersons = new List<string> { "Nif", "Phone", "Email" };

		#endregion

		#region Properties

		public static List<string> SearchBy
		{
			get { return mSearchBy; }
			set { mSearchBy = value; }
		}

		public static List<string> SearchFilterBookings
		{
			get { return mSearchFilterBookings; }
			set { mSearchFilterBookings = value; }
		}

		public static List<string> SearchFilterRoom
		{
			get { return mSearchFilterRoom; }
			set { mSearchFilterRoom = value; }
		}

		public static List<string> SearchFilterActivities
		{
			get { return mSearchFilterActivities; }
			set { mSearchFilterActivities = value; }
		}

		public static List<string> SearchFilterTransports
		{
			get { return mSearchFilterTransports; }
			set { mSearchFilterTransports = value; }
		}

		public static List<string> SearchFilterPersons
		{
			get { return mSearchFilterPersons; }
			set { mSearchFilterPersons = value; }
		}

		#endregion

		#region Methods

		public static void LoadSearchFilterCombox( string aSearchBy, BindingSource aBindingSource, ComboBox aComboBox )
		{
			switch ( aSearchBy )
			{

				case "Bookings":
					aBindingSource.DataSource = mSearchFilterBookings;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Rooms":
					aBindingSource.DataSource = mSearchFilterRoom;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Activities":
					aBindingSource.DataSource = mSearchFilterActivities;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Transports":
					aBindingSource.DataSource = mSearchFilterTransports;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Clients":
					aBindingSource.DataSource = mSearchFilterPersons;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Managers":
					aBindingSource.DataSource = mSearchFilterPersons;
					aComboBox.DataSource = aBindingSource;
					break;
				case "Employees":
					aBindingSource.DataSource = mSearchFilterPersons;
					aComboBox.DataSource = aBindingSource;
					break;
			}
		}


		#endregion

	}
}
