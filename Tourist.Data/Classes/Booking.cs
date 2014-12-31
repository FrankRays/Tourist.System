using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Booking : IBooking
	{

		#region Fields

		private static int mCounter = default( int );
		private int mNumber = default( int );
		private IClient mClient;
		private DateTime mBookingDate;
		private DateTimeRange mTimeFrame;
		private IBookable mBookable;


		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; }
		}

		[XmlIgnore]
		public IClient Client
		{
			get { return mClient; }

			set { mClient = value; }
		}

		[XmlElement( "Client" )]
		public Client SerlializationClient
		{
			get { return Client as Client; }
			set { }
		}

		public DateTime BookingDate
		{
			get { return mBookingDate; }

			set { mBookingDate = value; }
		}

		public DateTimeRange TimeFrame
		{
			get { return mTimeFrame; }
			set { mTimeFrame = value; }
		}

		[XmlIgnore]
		public IBookable Bookable
		{
			get { return mBookable; }
			set { mBookable = value; }
		}

		[XmlElement( "Bookable" )]
		public object SerializationBookable
		{
			get
			{
				if ( Bookable is Room )
					return ( Room ) Bookable;

				if ( Bookable is Activity )
					return ( Activity ) Bookable;

				if ( Bookable is Transport )
					return ( Transport ) Bookable;

				return null;
			}
			set { }
		}

		public double TotaPrice
		{
			get { return Bookable.Price * TimeFrame.DiferenceTimeSpan( ).Days; }
			set { }
		}

		#endregion

		#region Methods

		/*
		public double TotalPrice( )
		{
			//
		}
		*/
		#endregion

		#region Constructor

		public Booking( )
		{
			Id = ++mCounter;
		}

		#endregion

	}
}
