using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IBookingItem
	{
		int Quantity { get; set; }
		IBookable IBookable { get; set; }
		double BookingItemPrice { get; }
		Bookable Bookable { get; set; }
	}
}
