namespace Tourist.Data.Classes
{
	public static class UnitPrice
	{

		#region ROOM_UNIT_PRICE

		private static double mSingleRoom = 20.00;
		private static double mDoubleSingleRoom = 35.00;
		private static double mDoubleRoom = 40.00;
		private static double mSuiteRoom = 50.00;
		private static double mFamilySuiteRoom = 75.00;
		private static double mMeetingRoom = 100.00;

		public static double SingleRoom
		{
			get { return mSingleRoom; }
			set { mSingleRoom = value; }
		}

		public static double DoubleSingleRoom
		{
			get { return mDoubleSingleRoom; }
			set { mDoubleSingleRoom = value; }
		}

		public static double DoubleRoom
		{
			get { return mDoubleRoom; }
			set { mDoubleRoom = value; }
		}

		public static double SuiteRoom
		{
			get { return mSuiteRoom; }
			set { mSuiteRoom = value; }
		}

		public static double FamilySuiteRoom
		{
			get { return mFamilySuiteRoom; }
			set { mFamilySuiteRoom = value; }
		}

		public static double MeetingRoom
		{
			get { return mMeetingRoom; }
			set { mMeetingRoom = value; }
		}

		#endregion

		#region ACTIVITIES_UNIT_PRICE

		private static double mDivingActivity = 30.00;
		private static double mSightSeeingActivity = 30.00;
		private static double mGolfActivity = 100.00;
		private static double mSkyDivingActivity = 60.00;
		private static double mCampingActivity = 35.00;
		private static double mBoatRideActivity = 60.00;

		public static double DivingActivity
		{
			get { return mDivingActivity; }
			set { mDivingActivity = value; }
		}

		public static double SightSeeingActivity
		{
			get { return mSightSeeingActivity; }
			set { mSightSeeingActivity = value; }
		}

		public static double GolfActivity
		{
			get { return mGolfActivity; }
			set { mGolfActivity = value; }
		}

		public static double SkyDivingActivity
		{
			get { return mSkyDivingActivity; }
			set { mSkyDivingActivity = value; }
		}

		public static double CampingActivity
		{
			get { return mCampingActivity; }
			set { mCampingActivity = value; }
		}

		public static double BoatRideActivity
		{
			get { return mBoatRideActivity; }
			set { mBoatRideActivity = value; }
		}

		#endregion

		#region TRANSPORTATION_UNIT_PRICE

		private static double mBusTransportation = 15.00;
		private static double mMotoristTransportation = 50.00;
		private static double mCarTransportation = 40.00;
		private static double mBicycleTransportation = 15.00;
		private static double mCableCarTransportation = 30.00;
		private static double mTuckTuckTransportation = 50.00;

		public static double BusTransportation
		{
			get { return mBusTransportation; }
			set { mBusTransportation = value; }
		}

		public static double MotoristTransportation
		{
			get { return mMotoristTransportation; }
			set { mMotoristTransportation = value; }
		}

		public static double CarTransportation
		{
			get { return mCarTransportation; }
			set { mCarTransportation = value; }
		}

		public static double BicycleTransportation
		{
			get { return mBicycleTransportation; }
			set { mBicycleTransportation = value; }
		}

		public static double CableCarTransportation
		{
			get { return mCableCarTransportation; }
			set { mCableCarTransportation = value; }
		}

		public static double TuckTuckTransportation
		{
			get { return mTuckTuckTransportation; }
			set { mTuckTuckTransportation = value; }
		}

		#endregion

	}
}
