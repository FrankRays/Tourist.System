namespace Tourist.Data.Classes
{
	public class BusTransportation : Transportation
	{
		public BusTransportation( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Bus Transportation ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.BusTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 30;
		}
	}
}