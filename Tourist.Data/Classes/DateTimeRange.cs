using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DateTimeRange 
	{

		#region Fields

		private DateTime mCheckInDate;
		private DateTime mCheckOutDate;
		

		#endregion

		#region Properties

		public DateTime StartDateTime
		{
			get { return mCheckInDate; }

			set { mCheckInDate = value; }
		}

		public DateTime EndDateTime
		{
			get { return mCheckOutDate; }

			set { mCheckOutDate = value;  }
		}

		#endregion

		#region Constructor

		public DateTimeRange( ) { }

		public DateTimeRange( DateTime aCheckInDate, DateTime aCheckOutDate )
		{
			StartDateTime = aCheckInDate;
			EndDateTime = aCheckOutDate;
		}

		#endregion

		#region Methods

		public TimeSpan DiferenceTimeSpan( )
		{
			return ( EndDateTime - StartDateTime );
		}

		#endregion

	}
}
