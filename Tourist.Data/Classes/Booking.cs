using System;
using System.Collections.Generic;
using System.Linq;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class Booking : IBooking
	{

		#region Fields

		private static int counter = 0;
		private IClient mClient;
		private DateTime mBookingDateTime;
		private IEnumerable<IBookingItem> mBookingItems;

		#endregion

		#region Properties

		public int Id { get; private set; }

		public IClient Client
		{
			get { return mClient; }

			private set { mClient = value; }
		}

		public DateTime BookingDateTime
		{
			get { return mBookingDateTime; }

			set { mBookingDateTime = value; }
		}

		public IEnumerable<IBookingItem> BookingItens
		{
			get { return mBookingItems; }

			private set { mBookingItems = value; }
		}

		#endregion

		#region Methods

		public void Append( IBookingItem aItem )
		{
			System.Diagnostics.Trace.Assert( !BookingItens.Contains( aItem ) );
			if ( BookingItens.Contains( aItem ) ) return;
			( ( ICollection<IBookingItem> ) BookingItens ).Add( aItem );
		}

		public void Remove( IBookingItem aItem )
		{
			System.Diagnostics.Trace.Assert( !BookingItens.Contains( aItem ) );
			if ( !BookingItens.Contains( aItem ) ) return;
			( ( ICollection<IBookingItem> ) BookingItens ).Remove( aItem );
		}

		public double TotalPrice( )
		{

			//pode ser feito em apenas uma linha 
			//return BookingItens.Sum( aItem => aItem.BookingItemPrice );

			double temp = 0.00;

			foreach ( var aItem in BookingItens )
			{
				temp += aItem.BookingItemPrice;
			}

			return temp;
		}

		#endregion

		#region Constructor

		public Booking( )
		{
			Id = ++counter;
			BookingItens = new List<IBookingItem>( );
		}

		public Booking(IClient aClient)
		{
			Id = ++counter;

			Client = aClient;			
			BookingItens = new List<IBookingItem>( );
		}

		#endregion

	}
}
