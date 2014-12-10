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
			
			//serialization
			mSBookings = new List<Booking>();
			mSClients = new List<Client>();
			mSBookables = new List<Bookable>();
			mSEmployers = new List<Employer>();
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

		private List<Booking> mSBookings;
		private List<Client> mSClients;
		private List<Bookable> mSBookables;
		private List<Employer> mSEmployers;

		
		//teste se os Bookings for vazio 
		public List<Booking> BookingsList
		{
			get
			{
				/* Para o Save
				foreach (var item in Bookings)
				{
					mSBookings.Add(item as Booking);
				}
				*/
				
				return mSBookings;
			}

			set
			{
				mSBookings = value;

				foreach (var item in BookingsList)
				{
					Append(item);
				}
				
			} 
		}

		public List<Client> ClientsList
		{
			get
			{
				foreach (var item in Clients)
				{
					mSClients.Add(item as Client);
				}

				return mSClients;
			}

			set
			{
				mSClients = value;
				
				foreach ( var item in ClientsList )
				{
					Append( item );
				}
			}

		}

		public List<Bookable> BookablesList
		{
			get
			{
				foreach ( var item in Bookables)
				{
					
					mSBookables.Add(item as SingleRoom); //funciona 
				}

				return mSBookables;
			}

			set
			{
				mSBookables = value;

				foreach ( var item in Bookables )
				{
					Append( item );
				}
			}
		}

		public List<Employer> EmployersList
		{
			get
			{	
				foreach ( var item in Employers )
				{

					mSEmployers.Add( item as Employer );
				}

				return mSEmployers;
			}

			set
			{
				mSEmployers = value;
				
				foreach ( var item in Employers )
				{
					Append(item);
				}
			}

		}

		#endregion

	}
}
