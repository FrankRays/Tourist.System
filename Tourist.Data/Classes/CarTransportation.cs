namespace Tourist.Data.Classes
{
	public class CarTransportation : Transportation
	{
		public CarTransportation( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Car Transportation ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.CarTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 5;
		}
	}
}