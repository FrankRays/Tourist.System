using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Booking : IBooking
	{
		
		#region Fields

		private static int mCounter = 0;
		private IClient mClient;
		private DateTime mBookingDateTime;
		private IEnumerable<IBookingItem> mBookingItems;
		

		#endregion

		#region Properties

		public int Id { get; set; }

		[XmlIgnore]
		public IClient IClient
		{
			get { return mClient; }

			set { mClient = value; }
		}

		public DateTime BookingDateTime
		{
			get { return mBookingDateTime; }

			set { mBookingDateTime = value; }
		}
		
		[XmlIgnore]
		public IEnumerable<IBookingItem> IBookingItens
		{
			get { return mBookingItems; }

			private set { mBookingItems = value; }
		}

		#endregion

		#region Methods

		public void Append( IBookingItem aItem )
		{
			System.Diagnostics.Trace.Assert( !IBookingItens.Contains( aItem ) );
			if ( IBookingItens.Contains( aItem ) ) return;
			( ( ICollection<IBookingItem> ) IBookingItens ).Add( aItem );
		}

		public void Remove( IBookingItem aItem )
		{
			System.Diagnostics.Trace.Assert( !IBookingItens.Contains( aItem ) );
			if ( !IBookingItens.Contains( aItem ) ) return;
			( ( ICollection<IBookingItem> ) IBookingItens ).Remove( aItem );
		}

		public double TotalPrice( )
		{

			//pode ser feito em apenas uma linha 
			//return BookingItens.Sum( aItem => aItem.BookingItemPrice );

			double temp = 0.00;

			foreach ( var aItem in IBookingItens )
			{
				temp += aItem.BookingItemPrice;
			}

			return temp;
		}

		#endregion

		#region Constructor

		public Booking( )
		{
			Id = ++mCounter;
			IBookingItens = new List<IBookingItem>( );
			BookingItensList = new List<BookingItem>( );
		}

		public Booking(IClient aClient)
		{
			Id = ++mCounter;

			IClient = aClient;			
			IBookingItens = new List<IBookingItem>( );
		}

		#endregion

		#region Seralization

		private List<BookingItem> mSBookingItems;
		private Client mSClient;

		public List<BookingItem> BookingItensList
		{
			get
			{
				foreach (var item in IBookingItens)
				{
					mSBookingItems.Add(item as BookingItem);
				}

				return mSBookingItems;
			}
			set { mSBookingItems = value; }

		}

		public Client Client
		{
			get
			{
				mSClient = (Client) mClient;
				return mSClient;
			}
			set { mSClient = value; }
		}

		/*
		public int BookingId
		{
			get { return mCounter; }
		}
		*/
		#endregion

	}
}
