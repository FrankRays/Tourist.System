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
		private DateTime mBookingDate;
		private DateTimeRange mTimeFrame;
		private IBookable mBookable;
		

		#endregion

		#region Properties

		public int Id
		{
			get { return mNumber; }
			set { mNumber = value; Notify( "Id" ); }
		}

		[XmlIgnore]
		public IClient Client
		{
			get { return mClient; }

			set { mClient = value; Notify( "Client" ); }
		}

		public DateTime BookingDate
		{
			get { return mBookingDate; }

			set { mBookingDate = value; Notify( "BookingDate" ); }
		}

		public DateTimeRange TimeFrame
		{
			get { return mTimeFrame; }
			set { mTimeFrame = value; Notify( "TimeRange" ); }
		}

		[XmlIgnore]
		public IBookable Bookable
		{
			get { return mBookable; }
			set { mBookable = value; Notify( "Bookable" ); }
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

		public void Notify( string aPropertie = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aPropertie );
		}

		#endregion

	}
}
