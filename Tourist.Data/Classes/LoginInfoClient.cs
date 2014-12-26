namespace Tourist.Data.Classes
{
	public static class LoginInfoClient
	{
		private static int mId;
		private static string mUsername;
		private static string mPassword;

		public static int Id
		{
			get { return mId; }
			set { mId = value; }
		}

		public static string Username
		{
			get { return mUsername; }
			set { mUsername = value; }
		}

		public static string Password
		{
			get { return mPassword; }
			set { mPassword = value; }
		}
	}
}