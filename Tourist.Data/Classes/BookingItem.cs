using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class BookingItem : IBookingItem
	{

		#region Fields

		private int mQuantity;
		private IBookable mService;
		private double mBookingItemPrice;

		#endregion

		#region Properties

		public int Quantity
		{
			get { return mQuantity; }
			set { mQuantity = value; }
		}

		public IBookable Service
		{
			get { return mService; }
			set { mService = value; }
		}

		public double BookingItemPrice
		{
			get { return mBookingItemPrice; }
			set { mBookingItemPrice = value; }
		}

		#endregion

		#region Constructor

		public BookingItem( IBookable aService, int aQuantity )
		{
			Service = aService;
			Quantity = aQuantity;
			BookingItemPrice = Service.Price * Quantity;
		}

		#endregion

	}
}
