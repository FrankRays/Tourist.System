using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class Client : IClient
	{
		#region Fields

		private static int counter = 0;

		private string mFirstName;
		private string mLastName;
		private DateTime mBirthDate;
		private GenderEnum mGender;
		private int mNif;
		private string mAddress;
		private int mPhoneNumber;
		private string mEmail;

		#endregion

		#region Properties

		public int Id { get; private set; }

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

		public int Nif
		{
			get { return mNif; }
			set { mNif = value; }
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

		#endregion

		#region Constructors

		//pode ficar vazio e depois usa-se os sets
		public Client( ) { }

		public Client( string aFirstName, string aLastName, DateTime aBirthDate, GenderEnum aGender,
						 int aPhoneNumber, string aEmail, string aAddress )
		{
			Id = ++counter;

			FirstName = aFirstName;
			LastName = aLastName;
			BirthDate = aBirthDate;
			Gender = aGender;
			Address = aAddress;
			PhoneNumber = aPhoneNumber;
			Email = aEmail;

		}

		#endregion
	}
}
