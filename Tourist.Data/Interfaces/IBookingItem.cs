namespace Tourist.Data.Interfaces
{
	public interface IBookingItem
	{
		int Quantity { get; set; }
		IBookable Service { get; set; }
		double BookingItemPrice { get; }
	}
}
