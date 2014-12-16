using System;
using System.Collections.Generic;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IBooking
	{
		int Id { get; set; }
		IClient IClient { get; set; } //set alterado
		DateTime BookingDateTime { get; set; }
		IEnumerable<IBookingItem> BookingItens { get; }
		DateTimeRange TimeRange { get; set; }
		void Append( IBookingItem aItem );
		void Remove( IBookingItem aItem );

		//serialization
		bool OnSaveLoad { get; set; }

	}
}
