namespace Tourist.Data.Classes
{
	public class TuckTuckTransportation : Transportation
	{
		public TuckTuckTransportation(DateTimeRange aDateTimeRange) : base(aDateTimeRange)
		{
			Name = "Tuck Tuck Transportation ";
			TimeRange = aDateTimeRange;
			Price = UnitPrice.TuckTuckTransportation * TimeRange.DiferenceTimeSpan( ).Days;
			MaxNumberOfPersons = 20;
		}
	}
}