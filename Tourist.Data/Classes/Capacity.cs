namespace Tourist.Data.Classes
{
	public static class Capacity
	{

		#region ROOM_CAPACITY

		private static int mSingleCapacity = 1;
		private static int mDoubleSingleCapacity = 2;
		private static int mDoubleCapacity = 2;
		private static int mSuiteCapacity = 2;
		private static int mFamilySuiteCapacity = 4;
		private static int mMeetingCapacity = 50;

		public static int Single
		{
			get { return mSingleCapacity; }
			set { mSingleCapacity = value; }
		}

		public static int DoubleSingle
		{
			get { return mDoubleSingleCapacity; }
			set { mDoubleSingleCapacity = value; }
		}

		public static int Double
		{
			get { return mDoubleCapacity; }
			set { mDoubleCapacity = value; }
		}

		public static int Suite
		{
			get { return mSuiteCapacity; }
			set { mSuiteCapacity = value; }
		}

		public static int FamilySuite
		{
			get { return mFamilySuiteCapacity; }
			set { mFamilySuiteCapacity = value; }
		}

		public static int Meeting
		{
			get { return mMeetingCapacity; }
			set { mMeetingCapacity = value; }
		}

		#endregion

		#region ACTIVITIES_CAPACITY

		private static int mDivingCapacity = 2;
		private static int mSightSeeingCapacity = 15;
		private static int mGolfCapacity = 4;
		private static int mSkyDivingCapacity = 2;
		private static int mCampingCapacity = 10;
		private static int mBoatRideCapacity = 15;

		public static int Diving
		{
			get { return mDivingCapacity; }
			set { mDivingCapacity = value; }
		}

		public static int SightSeeing
		{
			get { return mSightSeeingCapacity; }
			set { mSightSeeingCapacity = value; }
		}

		public static int Golf
		{
			get { return mGolfCapacity; }
			set { mGolfCapacity = value; }
		}

		public static int SkyDiving
		{
			get { return mSkyDivingCapacity; }
			set { mSkyDivingCapacity = value; }
		}

		public static int Camping
		{
			get { return mCampingCapacity; }
			set { mCampingCapacity = value; }
		}

		public static int BoatRide
		{
			get { return mBoatRideCapacity; }
			set { mBoatRideCapacity = value; }
		}

		#endregion

		#region TRANSPORT_CAPACITY

		private static int mBusCapacity = 30;
		private static int mMotoristCapacity = 4;
		private static int mCarCapacity = 5;
		private static int mBicycleCapacity = 1;
		private static int mCableCarCapacity = 10;
		private static int mTuckTuckCapacity = 4;

		public static int Bus
		{
			get { return mBusCapacity; }
			set { mBusCapacity = value; }
		}

		public static int Motorist
		{
			get { return mMotoristCapacity; }
			set { mMotoristCapacity = value; }
		}

		public static int Car
		{
			get { return mCarCapacity; }
			set { mCarCapacity = value; }
		}

		public static int Bicycle
		{
			get { return mBicycleCapacity; }
			set { mBicycleCapacity = value; }
		}

		public static int CableCar
		{
			get { return mCableCarCapacity; }
			set { mCableCarCapacity = value; }
		}

		public static int TuckTuck
		{
			get { return mTuckTuckCapacity; }
			set { mTuckTuckCapacity = value; }
		}

		#endregion

	}
}
