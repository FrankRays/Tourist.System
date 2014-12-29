using System;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Employer : IEmployer
	{
		#region Fields

		private static int mCounter = default( int );
		private int mNumber = default (int);
		private string mFirstName;
		private string mLastName;
		private Gender mGender;
		private string mNationality;
		private DateTime mBirthDate;
		private int mNif;
		private string mAddress;
		private int mPhoneNumber;
		private string mEmail;
		private string mUsername;
		private string mPassword;

		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value;  }
		}

		public string FirstName
		{
			get { return mFirstName; }
			set { mFirstName = value;  }
		}

		public string LastName
		{
			get { return mLastName; }
			set { mLastName = value;  }
		}

		public Gender Gender
		{
			get { return mGender; }
			set { mGender = value; }
		}
		
		public string Nationality
		{
			get { return mNationality; }
			set { mNationality = value;  }
		}

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = value; }
		}

		public int Nif
		{
			get { return mNif; }
			set { mNif = value;  }
		}

		public string Address
		{
			get { return mAddress; }
			set { mAddress = value;  }
		}

		public int Phone
		{
			get { return mPhoneNumber; }
			set { mPhoneNumber = value;  }
		}

		public string Email
		{
			get { return mEmail; }
			set { mEmail = value;  }
		}

		public string Username
		{
			get { return mUsername; }
			set { mUsername = value;  }
		}

		public string Password
		{
			get { return mPassword; }
			set { mPassword = value;  }
		}

		#endregion

		#region Constructors

		public Employer( )
		{
			Id = ++mCounter;
		}

		#endregion

	}
}