namespace Tourist.Data.Classes
{
	public class CableCarTransportation : Transportation
	{
		public CableCarTransportation( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Cable Car Transportation ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.CableCarTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 10;
		}
	}
}