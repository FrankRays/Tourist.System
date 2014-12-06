namespace Tourist.Data.Classes
{
	public class MotoristTransportation : Transportation
	{
		public MotoristTransportation( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Motorist Transportation";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.MotoristTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 5;
		}
	}
}
