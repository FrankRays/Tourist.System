using System;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DateTimeRange : ISubject
	{

		#region Fields

		private DateTime mStartDateTime;
		private DateTime mEndDateTime;
		

		#endregion

		#region Properties

		public DateTime StartDateTime
		{
			get { return mStartDateTime; }

			set { mStartDateTime = value; Notify( this ); }
		}

		public DateTime EndDateTime
		{
			get { return mEndDateTime; }

			set { mEndDateTime = value; Notify( this ); }
		}

		#endregion

		#region Constructor

		public DateTimeRange( ) { }

		public DateTimeRange( DateTime aStartDateTime, DateTime aEndDateTime )
		{
			StartDateTime = aStartDateTime;
			EndDateTime = aEndDateTime;
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

		public void Notify( object aData = null )
		{
			if ( OnUpdate != null ) OnUpdate( this, aData );
		}

		#endregion

	}
}
