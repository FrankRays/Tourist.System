using System;

namespace Tourist.Data.Classes
{
	public class DateTimeRange
	{

		#region Fields

		private DateTime mStartDateTime;
		private DateTime mEndDateTime;

		#endregion
		
		#region Properties
		
		public DateTime StartDateTime
		{
			get { return mStartDateTime; }

			set { mStartDateTime = value; }
		}

		public DateTime EndDateTime
		{
			get { return mEndDateTime; }

			set { mEndDateTime = value; }
		}

		#endregion

		#region Constructor

		public DateTimeRange( ) { }

		public DateTimeRange( DateTime aStartDateTime, DateTime aEndDateTime )
		{
			StartDateTime = aStartDateTime;
			EndDateTime = aEndDateTime;
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
