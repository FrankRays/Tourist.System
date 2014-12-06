namespace Tourist.Data.Classes
{
	public class SkyDivingActivity : Activities
	{
		public SkyDivingActivity( DateTimeRange aDateTimeRange ) : base( aDateTimeRange )
		{
			Name = "Sky Diving";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.SkyDivingActivity * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 3;
		}
	}
}