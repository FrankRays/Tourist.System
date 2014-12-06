namespace Tourist.Data.Classes
{
	public class CampingActivity : Activities
	{
		public CampingActivity( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Camping ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.CampingActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}