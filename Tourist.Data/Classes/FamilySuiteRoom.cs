namespace Tourist.Data.Classes
{
	public class FamilySuiteRoom : Room
	{
		public FamilySuiteRoom( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Family Suite Room";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.FamilySuiteRoom * TimeRange.DiferenceTimeSpan( ).Days ;
			MaxNumberOfPersons = 5;
		}
	}
}