﻿using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Manager : IManager
	{
		#region Fields

		private static int mCounter = 0;

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

		public int Id { get; set; }

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

		public string Nationality
		{
			get { return mNationality; }
			set { mNationality = value; }
		}

		public Gender Gender
		{
			get { return mGender; }
			set { mGender = value; }
		}

		public DateTime BirthDate
		{
			get { return mBirthDate; }
			set { mBirthDate = value; }
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

		public Manager( )
		{
			Id = ++mCounter;
		}

		#endregion
	}
}
