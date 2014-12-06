namespace Tourist.Data.Classes
{
	public class MeetingRoom : Room
	{
		public MeetingRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Meeting Room";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.MeetingRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 50;
		}
	}
}