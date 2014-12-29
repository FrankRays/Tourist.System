using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Session
	{
		//more data if needed
		private int mId;
		private string mUsername;
		private string mPassword;

		public int Id
		{
			get { return mId; }
			set { mId = value; }
		}

		public string Username
		{
			get { return mUsername; }
			set { mUsername = value; }
		}

		public string Password
		{
			get { return mPassword; }
			set { mPassword = value; }
		}
	}
}
