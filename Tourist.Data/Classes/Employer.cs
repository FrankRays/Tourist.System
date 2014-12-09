using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class Employer : IEmployer
	{
		#region Fields

		private static int mCounter = 0;

		private string mFirstName;
		private string mLastName;
		private DateTime mBirthDate;
		private GenderEnum mGender;
		private string mAddress;
		private int mPhoneNumber;
		private string mEmail;
		private string mUsername;
		private string mPassword;

		#endregion

		#region Properties

		public int Id
		{
			get { return mCounter; }

			set { }
		}

		public string FirstName
		{
			get { return mFirstName; }
			set { mFirstName = value; }
		}

		public string LastName
		{
			get { return mLastName; }
			set { mLastName = value; }
		}

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = value; }
		}

		public GenderEnum Gender
		{
			get { return mGender; }
			set { mGender = value; }
		}

		public string Address
		{
			get { return mAddress; }
			set { mAddress = value; }
		}

		public int PhoneNumber
		{
			get { return mPhoneNumber; }
			set { mPhoneNumber = value; }
		}

		public string Email
		{
			get { return mEmail; }
			set { mEmail = value; }
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

		#endregion

		#region Constructors

		public Employer( )
		{
			++mCounter;
		}

		public Employer( string aFirstName, string aLastName, DateTime aBirthDate, GenderEnum aGender,
			int aPhoneNumber, string aEmail, string aAddress, string aUsername, string aPassword )
		{
			++mCounter;

			FirstName = aFirstName;
			LastName = aLastName;
			BirthDate = aBirthDate;
			Gender = aGender;
			Address = aAddress;
			PhoneNumber = aPhoneNumber;
			Email = aEmail;
			Username = aUsername;
			Password = aPassword;
		}

		#endregion

	}
}