using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class BookingItem : IBookingItem
	{
		#region Fields

		private int mQuantity;
		private IBookable mBookable;

		#endregion

		#region Properties

		public int Quantity
		{
			get { return mQuantity; }
			set { mQuantity = value; }
		}

		[XmlIgnore]
		public IBookable IBookable
		{
			get { return mBookable; }
			set { mBookable = value; }
		}

		public double BookingItemPrice
		{
			get { return ( IBookable.Price * Quantity ); }
		}

		#endregion

		#region Constructor

		public BookingItem( )
		{
			Quantity = 1;

		}

		public BookingItem( IBookable aService, int aQuantity )
		{
			IBookable = aService;
			Quantity = aQuantity;
		}

		#endregion

		#region Serialization

		private Bookable mSBookable;

		public Bookable Bookable
		{
			get
			{
				mSBookable = mBookable as Bookable;
				return mSBookable;
			}

			set { mSBookable = value; }
		}

		#endregion

	}
}
