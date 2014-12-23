using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Activity : IBookable
	{

		#region Fields

		private static int mCounter = default( int );
		private int mNumber = default( int );
		private string mName;
		private string mType;
		private double mPrice;
		private int mCapacity;
		private BookableState mBookableState;

		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; Notify( this ); }
		}

		public string Name
		{
			get { return mName; }
			set { mName = value; Notify( this ); }
		}

		public string Type
		{
			get { return mType; }
			set { mType = value; Notify( this ); }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value;  Notify(this); }
		}

		public int Capacity
		{
			get { return mCapacity; }
			set { mCapacity = value; Notify( this ); }
		}

		public BookableState State
		{
			get { return mBookableState; }
			set { mBookableState = value; Notify( this ); }
		}

		#endregion

		#region Constructor

		public Activity( )
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