namespace Tourist.Data.Interfaces
{
	public interface IBookingItem
	{
		int Quantity { get; set; }
		IBookable BookAble { get; set; }
		double BookingItemPrice { get; }
	}
}
