namespace Tourist.Data.Classes
{
	public class BicycleTransportation : Transportation
	{
		public BicycleTransportation( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Bicycle Transportation ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.BicycleTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 1;
		}
	}
}