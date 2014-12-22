using System;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IBooking
	{
		int Id { get; set; }
		IClient Client { get; set; } //set alterado
		DateTime BookingDateTime { get; set; }
		DateTimeRange TimeRange { get; set; }
		IBookable Bookable { get; set; }
	}
}
