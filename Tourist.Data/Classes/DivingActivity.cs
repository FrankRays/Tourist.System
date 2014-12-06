namespace Tourist.Data.Classes
{
	public class DivingActivity : Activities
	{
		public DivingActivity( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Diving ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.DivingActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}