namespace Tourist.Data.Classes
{
	public class SightSeeingWalkActivity : Activities
	{
		public SightSeeingWalkActivity( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Camping ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.SightSeeingActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}