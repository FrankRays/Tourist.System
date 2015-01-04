using System;
using System.Globalization;
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
		private double mTotalPrice;

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

		public double TotaPrice
		{
			get
			{
				mTotalPrice = Bookable.Price * TimeFrame.DiferenceTimeSpan( ).Days;
				return mTotalPrice;
			}
			set { mTotalPrice = value; }
		}

		#endregion

		#region Constructor

		public Booking( )
		{
			Id = ++mCounter;
		}

		#endregion

		#region Serialization
		
		private object mOBookable;

		[XmlElement( "Client" )]
		public Client SerlializationClient
		{
			get { return Client as Client; }
			set { mClient = value; }
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
			set
			{
				mOBookable = value;
				CastObjectToIBookable( );
			}
		}

		private void CastObjectToIBookable( )
		{
			mBookable = ( IBookable ) mOBookable;
		}

		#endregion

		#region DisplayData

		[XmlIgnore]
		public string ClientNif
		{
			get { return Client.Nif.ToString(); }
		}

		[XmlIgnore]
		public string ClientName
		{
			get { return Client.FirstName + " " + Client.LastName; }
		}

		[XmlIgnore]
		public string BookableType
		{
			get
			{
				if (Bookable is Room)
					return "Room";

				if ( Bookable is Activity )
					return "Activity";

				if ( Bookable is Transport )
					return "Transport";

				return string.Empty;
			}
		}

		[XmlIgnore]
		public string BookableSubType
		{
			get { return Bookable.Type.ToString(); }
		}

		[XmlIgnore]
		public string BookableId
		{
			get { return Bookable.Id.ToString( ); }
		}

		[XmlIgnore]
		public string BookableDescription
		{
			get { return Bookable.Description; }
		}

		[XmlIgnore]
		public string BookableBasePrice
		{
			get { return Bookable.Price.ToString( "00.00", CultureInfo.InvariantCulture ) + " €"; }
		}

		[XmlIgnore]
		public string BookingDay
		{
			get { return BookingDate.ToString( "d" ); }
		}

		[XmlIgnore]
		public string BookingStartDate
		{
			get { return TimeFrame.StartDateTime.ToString( "d" ); }
		}

		[XmlIgnore]
		public string BookingEndDate
		{
			get { return TimeFrame.EndDateTime.ToString( "d" ); }
		}

		public string BookingTotalPrice
		{
			get { return TotaPrice.ToString( "00.00", CultureInfo.InvariantCulture ) + " €"; }
		}

		#endregion

	}
}
