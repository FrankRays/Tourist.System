namespace Tourist.Data.Classes
{
	public class GolfActivity : Activities
	{
		public GolfActivity( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Golf ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.GolfActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}