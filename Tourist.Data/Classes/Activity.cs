using System;
using System.Xml.Serialization;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Activity : IBookable
	{

		#region Fields

		private static int mCounter = default( int );
		private int mNumber = default( int );
		private Enum mType;
		private BookableState mBookableState;
		private string mDescription;
		private double mPrice;
		private int mCapacity;
		
		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; Notify( "Id" ); }
		}

		[XmlIgnore]
		public Enum Type
		{
			get { return mType; }
			set { mType = value; Notify( "Type" ); }
		}

		[XmlElement( "Type" )]
		public string SerializationType
		{
			get { return Type.ToString( ); }

			set { Type = ( ActivityType ) Enum.Parse( typeof( ActivityType ), value ); }
		}

		public BookableState State
		{
			get { return mBookableState; }
			set { mBookableState = value; Notify( "State" ); }
		}

		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; Notify( "Description" ); }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value;  Notify("Price"); }
		}

		public int Capacity
		{
			get { return mCapacity; }
			set { mCapacity = value; Notify( "Capacity" ); }
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

		public void Notify( string aPropertie = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aPropertie );
		}

		#endregion
	}
}