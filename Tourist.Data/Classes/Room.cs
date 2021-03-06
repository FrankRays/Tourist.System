﻿using System;
using System.Xml.Serialization;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Room : IBookable
	{

		#region Fields

		private static int mCounter = 100;
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
			set { mNumber = value; }
		}

		[XmlIgnore]
		public Enum Type
		{
			get { return mType; }
			set { mType = value; }
		}

		[XmlElement( "Type" )]
		public string SerializationType
		{
			get { return Type.ToString( ); }

			set { Type = ( RoomType ) Enum.Parse( typeof( RoomType ), value ); }
		}

		public BookableState State
		{
			get { return mBookableState; }
			set { mBookableState = value; }
		}

		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value; }
		}

		public int Capacity
		{
			get { return mCapacity; }
			set { mCapacity = value; }
		}

		#endregion

		#region Constructor

		public Room( )
		{
			Id = ++mCounter;
		}

		#endregion

	}
}