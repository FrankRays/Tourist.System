using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;
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
		private IEnumerable<IClient> mClients;
		private IEnumerable<IBookable> mBookables;
		private IEnumerable<IEmployer> mEmployers;

		#endregion

		#region Properties

		public int Id
		{
			get { return mCounter; } 
			
			set { }
		}

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

		[XmlIgnore]
		public IEnumerable<IBooking> Bookings
		{
			get { return mBookings; }
			private set { mBookings = value; }
		}

		[XmlIgnore]
		public IEnumerable<IClient> Clients
		{
			get { return mClients; }
			set { mClients = value; }
		}

		[XmlIgnore]
		public IEnumerable<IBookable> Bookables
		{
			get { return mBookables; }
			set { mBookables = value; }
		}

		[XmlIgnore]
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

		public void Append( IClient aItem )
		{
			Trace.Assert( !Clients.Contains( aItem ) );
			if ( Clients.Contains( aItem ) ) return;
			( ( ICollection<IClient> ) Clients ).Add( aItem );
		}

		public void Remove( IClient aItem )
		{
			Trace.Assert( !Clients.Contains( aItem ) );
			if ( !Clients.Contains( aItem ) ) return;
			( ( ICollection<IClient> ) Clients ).Remove( aItem );
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

		public Entity( )
		{
			++mCounter;

			Bookings = new List<IBooking>( );
			Clients = new List<IClient>( );
			Bookables = new List<IBookable>( );
			Employers = new List<IEmployer>( );
		}

		public Entity( string aName, string aCity )
		{
			++mCounter;

			Name = aName;
			City = aCity;

			Bookings = new List<IBooking>( );
			Clients = new List<IClient>( );
			Bookables = new List<IBookable>( );
			Employers = new List<IEmployer>( );
		}

		#endregion

		#region Serialization

		public List<Booking> BookingsList
		{
			get
			{
				List<Booking> temp = new List<Booking>();

				foreach (var item in Bookings)
				{
					temp.Add(item as Booking);
				}

				return temp;
			}
		
		}

		public List<Client> ClientsList
		{
			get
			{
				List<Client> temp = new List<Client>();

				foreach (var item in Clients)
				{
					temp.Add(item as Client);
				}

				return temp;
			}
		
		}

		public List<Bookable> BookablesList
		{
			get
			{
				List<Bookable> temp = new List<Bookable>( );

				foreach ( var item in Bookables)
				{
					
					temp.Add(item as SingleRoom); //funciona 
				}

				return temp;
			}	
		}

		public List<Employer> EmployersList
		{
			get
			{
				List<Employer> temp = new List<Employer>( );

				foreach ( var item in Employers )
				{

					temp.Add( item as Employer );
				}

				return temp;
			}
		}

		/*
		[XmlIgnore]
		public List<Bookings> SerializableEmployers
		{
			get { return mEmployers; }
			
		}
		*/
		
		#endregion

	}
}
