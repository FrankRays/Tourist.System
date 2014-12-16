using System;
using System.Data;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public abstract class Bookable : IBookable
	{

		#region Fields

		private static int mCounter = 0;
		private double mPrice;
		private string mDescription;
		private int mCapacity;
		private string mType;
		private BookableState mState;


		#endregion

		#region Properties

		public int Id { get; set; }

		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; }
		}

		public string Type
		{
			get
			{
				return GetType( ).ToString();
			}
			set { mType = value; }
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

		public BookableState State
		{
			get { return mState; }
			set { mState = value; }
		}

		#endregion

		#region Constructor

		protected Bookable( )
		{
			Id = ++mCounter;
		}

		#endregion

	}
}