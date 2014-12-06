namespace Tourist.Data.Classes
{
	public class SingleRoom : Room
	{
		public SingleRoom(DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Single Room";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.SingleRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 1;
		}
	}
}
