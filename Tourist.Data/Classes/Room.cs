using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public abstract class Room : IBookable
	{

		#region Fields

		private static int mCounter = 0;
		private double mPrice;
		private DateTimeRange mTimeRange;
		private int mMaxNumberOfPersons;

		#endregion

		#region Properties

		public int Id { get; private set; }

		public string Type
		{
			get { return GetType( ).ToString( ); }
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

		protected Room( DateTimeRange aDateTimeRange )
		{
			Id = ++mCounter;
			Price = 0.00;
			TimeRange = aDateTimeRange;
			MaxNumberOfPersons = 0;
		}

		#endregion

	}
}