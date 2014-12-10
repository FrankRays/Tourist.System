using System;
using System.Collections.Generic;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public class Factory : IFactory
	{

		public Type[ ] GetTypes( )
		{
			return new[ ]
			{
				typeof (Entity), typeof (Booking), typeof (BookingItem), typeof (Client), typeof (Employer), typeof (DateTimeRange),typeof(Bookable),
				typeof (Activity),typeof(Room),typeof (SingleRoom), typeof (DoubleRoom), typeof (DoubleSingleRoom), typeof (SuiteRoom),
				typeof (FamilySuiteRoom),
				typeof (MeetingRoom), typeof (Activity), typeof (BoatRideActivity), typeof (GolfActivity), typeof (CampingActivity),
				typeof (SkyDivingActivity), typeof (SightSeeingActivity), typeof (DivingActivity), typeof (Transport),
				typeof (TuckTuckTransport),
				typeof (CableCarTransport), typeof (BicycleTransport), typeof (CarTransport), typeof (BusTransport),
				typeof (MotoristTransport),typeof (List<Booking>),typeof (List<Bookable>),typeof (List<Client>),typeof (List<Employer>),typeof (List<Entity>)
			};
		}

		public IEntity CreateEntity( )
		{
			return new Entity( );
		}

		public IBooking CreateBooking( )
		{
			return new Booking( );
		}

		public IBookingItem CreateBookingItem( )
		{
			return new BookingItem( );
		}

		public IClient CreateClient( )
		{
			return new Client( );
		}

		public IEmployer CreateEmployer( )
		{
			return new Employer( );
		}

		public IEmployer CreateManager( )
		{
			return new Manager( );
		}

		//CreateRoom

		public IBookable CreateSingleRoom( )
		{
			return new SingleRoom( );
		}

		public IBookable CreateDoubleSingleRoom( )
		{
			return new DoubleSingleRoom( );
		}

		public IBookable CreateDoubleRoom( )
		{
			return new DoubleRoom( );
		}

		public IBookable CreateSuiteRoom( )
		{
			return new SuiteRoom( );
		}

		public IBookable CreateFamilySuiteRoom( )
		{
			return new FamilySuiteRoom( );
		}

		public IBookable CreateMeetingRoom( )
		{
			return new MeetingRoom( );
		}

		//CreateActivities

		public IBookable CreateBoatRideActivity( )
		{
			return new BoatRideActivity( );
		}

		public IBookable CreateGolfActivity( )
		{
			return new GolfActivity( );
		}

		public IBookable CreateCampingActivity( )
		{
			return new CampingActivity( );
		}

		public IBookable CreateSkyDivingActivity( )
		{
			return new SkyDivingActivity( );
		}

		public IBookable CreateSightSeeingActivity( )
		{
			return new SightSeeingActivity( );
		}

		public IBookable CreateDivingActivity( )
		{
			return new DivingActivity( );
		}

		//CreateTransport

		public IBookable CreateTuckTuckTransport( )
		{
			return new TuckTuckTransport( );
		}

		public IBookable CreateCableCarTransport( )
		{
			return new CableCarTransport( );
		}

		public IBookable CreateBicycleTransport( )
		{
			return new BicycleTransport( );
		}

		public IBookable CreateCarTransport( )
		{
			return new CarTransport( );
		}

		public IBookable CreateBusTransport( )
		{
			return new BusTransport( );
		}

		public IBookable CreateMotoristTransport( )
		{
			return new MotoristTransport( );
		}

		public object CreateObject( string aType )
		{
			switch ( aType )
			{
				case "Entity":
					return CreateEntity( );
				case "Booking":
					return CreateBooking( );
				case "BookingItem":
					return CreateBookingItem( );
				case "Client":
					return CreateClient( );
				case "Employer":
					return CreateEmployer( );
				case "Manager":
					return CreateManager( );
				//Bookable Room
				case "SingleRoom":
					return CreateSingleRoom( );
				case "DoubleSingleRoom":
					return CreateDoubleSingleRoom( );
				case "DoubleRoom":
					return CreateDoubleRoom( );
				case "SuiteRoom":
					return CreateSuiteRoom( );
				case "FamilySuiteRoom":
					return CreateFamilySuiteRoom( );
				case "MeetingRoom":
					return CreateMeetingRoom( );
				//Bookable Activity
				case "BoatRideActivity":
					return CreateBoatRideActivity( );
				case "GolfActivity":
					return CreateGolfActivity( );
				case "CampingActivity":
					return CreateCampingActivity( );
				case "SkyDivingActivity":
					return CreateSkyDivingActivity( );
				case "SightSeeyingActivity":
					return CreateSightSeeingActivity( );
				case "DivingActivity":
					return CreateDivingActivity( );
				//Bookable Transport
				case "TuckTuckTransport":
					return CreateTuckTuckTransport( );
				case "CacleCarTransport":
					return CreateCableCarTransport( );
				case "BicycleTransport":
					return CreateBicycleTransport( );
				case "CarTransport":
					return CreateCarTransport( );
				case "BusTransport":
					return CreateBusTransport( );
				case "MotorisTransport":
					return CreateMotoristTransport( );

				default:
					return null;
			}
		}

		/// <summary>
		/// Create an object based on a given interface type  
		/// </summary>
		/// <remarks>This method assumes that interface type name starts with a 'I'</remarks>
		/// <typeparam name="T">the interface type</typeparam>
		/// <returns>An object that implements the given interface type</returns>
		public T CreateObject<T>( )
		{
			return Cast<T>( CreateObject( typeof( T ).Name.Substring( 1 ) ) );
		}

		public static T Cast<T>( object o )
		{
			return ( T ) o;
		}

	}

}