namespace Tourist.Data.Classes
{
	public static class BasePrice
	{

		#region ROOM_BASE_PRICE

		private static double mSingle = 20.00;
		private static double mDoubleSingle = 35.00;
		private static double mDouble = 40.00;
		private static double mSuite = 50.00;
		private static double mFamilySuite = 75.00;
		private static double mMeeting = 100.00;

		public static double Single
		{
			get { return mSingle; }
			set { mSingle = value; }
		}

		public static double DoubleSingle
		{
			get { return mDoubleSingle; }
			set { mDoubleSingle = value; }
		}

		public static double Double
		{
			get { return mDouble; }
			set { mDouble = value; }
		}

		public static double Suite
		{
			get { return mSuite; }
			set { mSuite = value; }
		}

		public static double FamilySuite
		{
			get { return mFamilySuite; }
			set { mFamilySuite = value; }
		}

		public static double Meeting
		{
			get { return mMeeting; }
			set { mMeeting = value; }
		}

		#endregion

		#region ACTIVITIES_BASE_PRICE

		private static double mDiving = 30.00;
		private static double mSightSeeing = 30.00;
		private static double mGolf = 100.50;
		private static double mSkyDiving = 60.00;
		private static double mCamping = 35.00;
		private static double mBoatRide = 60.00;

		public static double Diving
		{
			get { return mDiving; }
			set { mDiving = value; }
		}

		public static double SightSeeing
		{
			get { return mSightSeeing; }
			set { mSightSeeing = value; }
		}

		public static double Golf
		{
			get { return mGolf; }
			set { mGolf = value; }
		}

		public static double SkyDiving
		{
			get { return mSkyDiving; }
			set { mSkyDiving = value; }
		}

		public static double Camping
		{
			get { return mCamping; }
			set { mCamping = value; }
		}

		public static double BoatRide
		{
			get { return mBoatRide; }
			set { mBoatRide = value; }
		}

		#endregion

		#region TRANSPORTATION_BASE_PRICE

		private static double mBus = 15.00;
		private static double mMotorist = 50.00;
		private static double mCar = 40.00;
		private static double mBicycle = 15.00;
		private static double mCableCar = 30.00;
		private static double mTuckTuck = 50.00;

		public static double Bus
		{
			get { return mBus; }
			set { mBus = value; }
		}

		public static double Motorist
		{
			get { return mMotorist; }
			set { mMotorist = value; }
		}

		public static double Car
		{
			get { return mCar; }
			set { mCar = value; }
		}

		public static double Bicycle
		{
			get { return mBicycle; }
			set { mBicycle = value; }
		}

		public static double CableCar
		{
			get { return mCableCar; }
			set { mCableCar = value; }
		}

		public static double TuckTuck
		{
			get { return mTuckTuck; }
			set { mTuckTuck = value; }
		}

		#endregion

	}
}
