namespace Tourist.Data.Classes
{
	public class DoubleRoom : Room
	{
		public DoubleRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			TimeRange = aDateTimeRange;
			Price = UnitPrice.DoubleRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 2;
		}
	}
}