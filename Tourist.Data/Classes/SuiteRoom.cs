namespace Tourist.Data.Classes
{
	public class SuiteRoom : Room
	{
		public SuiteRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			TimeRange = aDateTimeRange;
			Price = UnitPrice.SuiteRoom * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 2;
		}
	}
}