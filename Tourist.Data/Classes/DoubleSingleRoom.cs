namespace Tourist.Data.Classes
{
	public class DoubleSingleRoom : Room
	{
		public DoubleSingleRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Double Single Room";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.DoubleSingleRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 2;
		}
	}
}
