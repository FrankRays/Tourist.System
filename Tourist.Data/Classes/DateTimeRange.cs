using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DateTimeRange : ISubject
	{

		#region Fields

		private DateTime mCheckInDate;
		private DateTime mCheckOutDate;
		

		#endregion

		#region Properties

		public DateTime StartDateTime
		{
			get { return mCheckInDate; }

			set { mCheckInDate = value; Notify( "CheckInDate" ); }
		}

		public DateTime EndDateTime
		{
			get { return mCheckOutDate; }

			set { mCheckOutDate = value; Notify( "CheckOutDate" ); }
		}

		#endregion

		#region Constructor

		public DateTimeRange( ) { }

		public DateTimeRange( DateTime aCheckInDate, DateTime aCheckOutDate )
		{
			StartDateTime = aCheckInDate;
			EndDateTime = aCheckOutDate;
		}

		#endregion

		#region Methods

		public TimeSpan DiferenceTimeSpan( )
		{
			return ( EndDateTime - StartDateTime );
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
