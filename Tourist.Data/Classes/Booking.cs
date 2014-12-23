using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Booking : IBooking
	{

		#region Fields

		private static int mCounter = default (int);
		private int mNumber = default (int);
		private IClient mClient;
		private DateTime mBookingDateTime;
		private IBookable mBookable;
		private DateTimeRange mTimeRange;

		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; Notify( this ); }
		}

		[XmlIgnore]
		public IClient Client
		{
			get { return mClient; }

			set { mClient = value; Notify( this ); }
		}

		public DateTime BookingDateTime
		{
			get { return mBookingDateTime; }

			set { mBookingDateTime = value; Notify( this ); }
		}


		public DateTimeRange TimeRange
		{
			get { return mTimeRange; }
			set { mTimeRange = value; Notify( this ); }
		}

		[XmlIgnore]
		public IBookable Bookable
		{
			get { return mBookable; }
			set { mBookable = value; Notify( this ); }
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

		#region ISubject Observer

		public event UpdateEventHandler OnUpdate;

		public void Notify( object aData = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aData );
		}

		#endregion

	}
}
