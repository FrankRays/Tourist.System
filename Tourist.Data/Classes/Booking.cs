using System;
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
		private IBookable mBookable;
		private DateTimeRange mTimeRange;

		#endregion

		#region Properties

		public int Id { get; set; }

		[XmlIgnore]
		public IClient Client
		{
			get { return mClient; }

			set { mClient = value; }
		}

		public DateTime BookingDateTime
		{
			get { return mBookingDateTime; }

			set { mBookingDateTime = value; }
		}


		public DateTimeRange TimeRange
		{
			get { return mTimeRange; }
			set { mTimeRange = value; }
		}

		[XmlIgnore]
		public IBookable Bookable
		{
			get { return mBookable; }
			set { mBookable = value; }
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
