using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class Entity : IEntity
	{

		#region Fields

		private static int mCounter = 0;
		private string mName;
		private string mCity;
		private IEnumerable<IBooking> mBookings;
		private IEnumerable<IBookable> mBookables;
		private IEnumerable<IEmployer> mEmployers;

		#endregion

		#region Properties

		public int Id { get; private set; }

		public string Name
		{
			get { return mName; }
			set { mName = value; }
		}

		public string City
		{
			get { return mCity; }
			set { mCity = value; }
		}

		public IEnumerable<IBooking> Bookings
		{
			get { return mBookings; }
			private set { mBookings = value; }
		}

		public IEnumerable<IBookable> Bookables
		{
			get { return mBookables; }
			set { mBookables = value; }
		}

		public IEnumerable<IEmployer> Employers
		{
			get { return mEmployers; }
			set { mEmployers = value; }
		}

		#endregion

		#region Methods

		public void Append( IBooking aItem )
		{
			Trace.Assert( !Bookings.Contains( aItem ) );
			if ( Bookings.Contains( aItem ) ) return;
			( ( ICollection<IBooking> ) Bookings ).Add( aItem );
		}

		public void Remove( IBooking aItem )
		{
			Trace.Assert( !Bookings.Contains( aItem ) );
			if ( !Bookings.Contains( aItem ) ) return;
			( ( ICollection<IBooking> ) Bookings ).Remove( aItem );
		}

		public void Append( IBookable aItem )
		{
			Trace.Assert( !Bookables.Contains( aItem ) );
			if ( Bookables.Contains( aItem ) ) return;
			( ( ICollection<IBookable> ) Bookables ).Add( aItem );
		}

		public void Remove( IBookable aItem )
		{
			Trace.Assert( !Bookables.Contains( aItem ) );
			if ( !Bookables.Contains( aItem ) ) return;
			( ( ICollection<IBookable> ) Bookables ).Remove( aItem );
		}

		public void Append( IEmployer aItem )
		{
			Trace.Assert( !Employers.Contains( aItem ) );
			if ( Employers.Contains( aItem ) ) return;
			( ( ICollection<IEmployer> ) Employers ).Add( aItem );
		}

		public void Remove( IEmployer aItem )
		{
			Trace.Assert( !Employers.Contains( aItem ) );
			if ( !Employers.Contains( aItem ) ) return;
			( ( ICollection<IEmployer> ) Employers ).Remove( aItem );
		}

		#endregion

		#region Constructor

		public Entity()
		{
			Id = ++mCounter;

			Bookings = new List<IBooking>( );
			Bookables = new List<IBookable>( );
			Employers = new List<IEmployer>( );
		}

		public Entity(string aName, string aCity )
		{
			Id = ++mCounter;

			Name = aName;
			City = aCity;

			Bookings = new List<IBooking>( );
			Bookables = new List<IBookable>( );
			Employers = new List<IEmployer>( );
		}

		#endregion

	}
}
