using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public abstract class Transportation : IBookable
	{
		
		#region Fields

		private static int mCounter = 0;
		private string mName;
		private double mPrice;
		private DateTimeRange mTimeRange;
		private int mMaxNumberOfPersons;

		#endregion

		#region Properties

		public int Id { get; private set; }

		public string Name
		{
			get { return mName; }
			set { mName = value; }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value; }
		}

		public DateTimeRange TimeRange
		{
			get { return mTimeRange; }
			set { mTimeRange = value; }
		}

		public int MaxNumberOfPersons
		{
			get { return mMaxNumberOfPersons; }
			set { MaxNumberOfPersons = value; }
		}

		#endregion

		#region Constructor

		protected Transportation( DateTimeRange aDateTimeRange )
		{
			Id = ++mCounter;
			Name = "Service Name";
			Price = 0.00;
			TimeRange = aDateTimeRange;
			MaxNumberOfPersons = 0;
		}

		#endregion

	}
}
