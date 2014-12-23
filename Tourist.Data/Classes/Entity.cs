using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Entity : IEntity
	{

		#region Fields

		private static int mCounter = 0;
		private byte[ ] mLogoBuffer;
		private EntityType mEntityType;
		private string mName;
		private int mNif;
		private string mAddress;
		private int mPhoneNumber;
		private string mEmail;

		#endregion

		#region Properties

		public int Id { get; set; }

		public byte[ ] LogoBuffer
		{
			get { return mLogoBuffer; }
			set { mLogoBuffer = value; }
		}

		public EntityType EntityType
		{
			get { return mEntityType; }
			set { mEntityType = value; }
		}

		public string Name
		{
			get { return mName; }
			set { mName = value; }
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

		#region Constructor

		public Entity( )
		{
			Id = ++mCounter;
		}

		#endregion

	}
}
