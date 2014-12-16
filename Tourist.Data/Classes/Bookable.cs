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