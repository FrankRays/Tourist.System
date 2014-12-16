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
		private DateTimeRange mTimeRange;

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
		public IEnumerable<IBookingItem> BookingItens
		{
			get { return mBookingItems; }

			private set { mBookingItems = value; }
		}

		public DateTimeRange TimeRange
		{
			get { return mTimeRange; }
			set { mTimeRange = value; }
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
			Id = ++mCounter;
			BookingItens = new List<IBookingItem>( );
			BookingItensList = new List<BookingItem>( );
		}

		public Booking( IClient aClient )
		{
			Id = ++mCounter;

			IClient = aClient;
			BookingItens = new List<IBookingItem>( );
		}

		#endregion

		#region Seralization

		private List<BookingItem> mSBookingItems;
		private Client mSClient;
		private bool mSaveLoad = default( bool );


		public List<BookingItem> BookingItensList
		{
			get
			{
				if ( OnSaveLoad )
				{
					foreach ( var item in BookingItens )
					{
						mSBookingItems.Add( item as BookingItem );
					}
				}

				return mSBookingItems;
			}

			set { mSBookingItems = value; }

		}

		public Client Client
		{
			get
			{
				if ( OnSaveLoad )
					mSClient = ( Client ) mClient;

				return mSClient;
			}
			set { mSClient = value; }
		}

		[XmlIgnore]
		public bool OnSaveLoad
		{
			get { return mSaveLoad; }
			set { mSaveLoad = value; }
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
