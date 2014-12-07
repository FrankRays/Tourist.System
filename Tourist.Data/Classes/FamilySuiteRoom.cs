namespace Tourist.Data.Classes
{
	public class FamilySuiteRoom : Room
	{
		public FamilySuiteRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			TimeRange = aDateTimeRange;
			Price = UnitPrice.FamilySuiteRoom * TimeRange.DiferenceTimeSpan( ).Days ;
			MaxNumberOfPersons = 5;
		}
	}
}