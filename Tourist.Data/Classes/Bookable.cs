using System;
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
		private DateTimeRange mTimeRange;
		private int mMaxNumberOfPersons;

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
			get { return GetType( ).ToString( ); }
		}

		public double Price
		{
			get { return mPrice; }
			set { mPrice = value; }
		}

		public DateTimeRange TimeRange
		{
			get { return mTimeRange; }
			set { mTimeRange = value; }
		}

		public int MaxNumberOfPersons
		{
			get { return mMaxNumberOfPersons; }
			set { mMaxNumberOfPersons = value; }
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