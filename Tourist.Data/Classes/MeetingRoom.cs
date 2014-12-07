namespace Tourist.Data.Classes
{
	public class MeetingRoom : Room
	{
		public MeetingRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			TimeRange = aDateTimeRange;
			Price = UnitPrice.MeetingRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 50;
		}
	}
}