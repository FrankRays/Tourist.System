namespace Tourist.Data.Classes
{
	public class BoatRideActivity : Activities
	{
		public BoatRideActivity(DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Boat Ride";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.BoatRideActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}
