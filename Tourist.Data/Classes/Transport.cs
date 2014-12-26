using System;
using System.Xml.Serialization;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Transport : IBookable
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
			set { mNumber = value; Notify( this ); }
		}

		[XmlIgnore]
		public Enum Type
		{
			get { return mType; }
			set { mType = value; Notify( this ); }
		}

		[XmlElement( "Type" )]
		public string SerializationType
		{
			get { return Type.ToString( ); }

			set { Type = ( TransportType ) Enum.Parse( typeof( TransportType ), value ); }
		}

		public BookableState State
		{
			get { return mBookableState; }
			set { mBookableState = value; Notify( this ); }
		}

		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; Notify( this ); }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value; Notify( this ); }
		}

		public int Capacity
		{
			get { return mCapacity; }
			set { mCapacity = value; Notify( this ); }
		}

		#endregion

		#region Constructor

		public Transport( )
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