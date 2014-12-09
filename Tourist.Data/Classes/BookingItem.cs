using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{

	public class BookingItem : IBookingItem
	{

		#region Fields

		private int mQuantity;
		private IBookable mService;

		#endregion

		#region Properties

		public int Quantity
		{
			get { return mQuantity; }
			set { mQuantity = value; }
		}

		[XmlIgnore]
		public IBookable BookAble
		{
			get { return mService; }
			set { mService = value; }
		}

		public double BookingItemPrice
		{
			get { return ( BookAble.Price * Quantity ); }
		}

		#endregion

		#region Constructor

		public BookingItem( )
		{
			Quantity = 1;
		}

		public BookingItem( IBookable aService, int aQuantity )
		{
			BookAble = aService;
			Quantity = aQuantity;
		}

		#endregion

		#region Serialization

		public Bookable Bookable
		{
			get { return ( mService as Bookable ); }

			set { }
		}

		#endregion

	}
}
