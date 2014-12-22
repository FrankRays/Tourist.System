using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Activity : IBookable
	{

		#region Fields

		private static int mCounter = 0;
		private string mName;
		private string mType;
		private double mPrice;
		private int mCapacity;
		private BookableState mBookableState;

		#endregion

		#region Properties

		public int Id { get; set; }

		public string Name
		{
			get { return mName; }
			set { mName = value; }
		}

		public string Type
		{
			get { return mType; }
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
			get { return mBookableState; }
			set { mBookableState = value; }
		}

		#endregion

		#region Constructor

		public Activity()
		{
			Id = ++mCounter;
		}

		#endregion
	}
}