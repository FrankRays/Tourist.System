namespace Tourist.Data.Classes
{
	public class SingleRoom : Room
	{
		public SingleRoom(DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			TimeRange = aDateTimeRange;
			Price = UnitPrice.SingleRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 1;
		}
	}
}
