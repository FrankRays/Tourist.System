﻿using System;
using System.Collections.Generic;

namespace Tourist.Data.Interfaces
{
	public interface IBooking
	{
		int Id { get; set; }
		IClient IClient { get; set; } //set alterado
		DateTime BookingDateTime { get; set; }
		IEnumerable<IBookingItem> BookingItens { get; }
		void Append( IBookingItem aItem );
		void Remove( IBookingItem aItem );

		//serialization
		bool OnSaveLoad { get; set; }

	}
}
