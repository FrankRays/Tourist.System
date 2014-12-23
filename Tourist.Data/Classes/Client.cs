using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Client : IClient
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

		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; Notify( this ); }
		}

		public string FirstName
		{
			get { return mFirstName; }
			set { mFirstName = value; Notify( this ); }
		}

		public string LastName
		{
			get { return mLastName; }
			set { mLastName = value; Notify( this ); }
		}

		public string Nationality
		{
			get { return mNationality; }
			set { mNationality = value; Notify( this ); }
		}

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = value; Notify( this ); }
		}

		public Gender Gender
		{
			get { return mGender; }
			set { mGender = value; Notify( this ); }
		}

		public int Nif
		{
			get { return mNif; }
			set { mNif = value; Notify( this ); }
		}

		public string Address
		{
			get { return mAddress; }
			set { mAddress = value; Notify( this ); }
		}

		public int Phone
		{
			get { return mPhoneNumber; }
			set { mPhoneNumber = value; Notify( this ); }
		}

		public string Email
		{
			get { return mEmail; }
			set { mEmail = value; Notify( this ); }
		}

		#endregion

		#region Constructors

		//pode ficar vazio e depois usa-se os sets
		public Client()
		{
			Id = ++mCounter;
		}

		#endregion

		#region ISubject Observer

		public event UpdateEventHandler OnUpdate;

		public void Notify( object aData = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aData );
		}

		#endregion

	}
}
