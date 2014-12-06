using System;

namespace Tourist.Data.Classes
{
	public class DateTimeRange
	{

		#region Fields&Properties

		public DateTime StartDateTime { get; set; }
		public DateTime EndDateTime { get; set; }

		#endregion

		#region Constructor

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
