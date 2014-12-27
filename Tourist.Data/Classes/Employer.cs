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
			set { mNumber = value; Notify( "Id" ); }
		}

		public string FirstName
		{
			get { return mFirstName; }
			set { mFirstName = value; Notify( "FirstName" ); }
		}

		public string LastName
		{
			get { return mLastName; }
			set { mLastName = value; Notify( "LastName" ); }
		}

		public Gender Gender
		{
			get { return mGender; }
			set { mGender = value; Notify( "Gender" ); }
		}
		
		public string Nationality
		{
			get { return mNationality; }
			set { mNationality = value; Notify( "Nationality" ); }
		}

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = value; Notify( "BirthDate" ); }
		}

		public int Nif
		{
			get { return mNif; }
			set { mNif = value; Notify( "Nif" ); }
		}

		public string Address
		{
			get { return mAddress; }
			set { mAddress = value; Notify( "Address" ); }
		}

		public int Phone
		{
			get { return mPhoneNumber; }
			set { mPhoneNumber = value; Notify( "Phone" ); }
		}

		public string Email
		{
			get { return mEmail; }
			set { mEmail = value; Notify( "Email" ); }
		}

		public string Username
		{
			get { return mUsername; }
			set { mUsername = value; Notify( "Username" ); }
		}

		public string Password
		{
			get { return mPassword; }
			set { mPassword = value; Notify( "Password" ); }
		}

		#endregion

		#region Constructors

		public Employer( )
		{
			Id = ++mCounter;
		}

		#endregion

		#region ISubject Observer

		public event UpdateEventHandler OnUpdate;

		public void Notify( string aPropertie = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aPropertie );
		}

		#endregion

	}
}