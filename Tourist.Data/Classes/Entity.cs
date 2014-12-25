using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Entity : IEntity
	{

		#region Fields

		private static int mCounter = default( int );
		private int mNumber = default (int);
		private byte[ ] mLogoBuffer;
		private EntityType mEntityType;
		private string mName;
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

		public byte[ ] LogoBuffer
		{
			get { return mLogoBuffer; }
			set { mLogoBuffer = value; Notify( this ); }
		}

		public EntityType EntityType
		{
			get { return mEntityType; }
			set { mEntityType = value; Notify( this ); }
		}

		public string Name
		{
			get { return mName; }
			set { mName = value; Notify( this ); }
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

		#region Constructor

		public Entity( )
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
