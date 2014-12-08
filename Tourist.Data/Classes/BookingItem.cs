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

		public IBookable Service
		{
			get { return mService; }
			set { mService = value; }
		}

		public double BookingItemPrice
		{
			get { return (Service.Price*Quantity); }
		}

		#endregion

		#region Constructor

		public BookingItem( ) { }

		public BookingItem(IBookable aService, int aQuantity)
		{
			Service = aService;
			Quantity = aQuantity;
		}
		
		#endregion

	}
}
