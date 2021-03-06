﻿using System;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Factory : IFactory
	{

		#region Methods

		public Type[ ] GetTypes( )
		{
			return new[ ]
			{
				typeof (Entity),	typeof (Booking),		typeof (Client), 
				typeof(Room),		typeof (Activity),		typeof (Transport),	
				typeof (Employer),	typeof (Manager),		typeof (DateTimeRange),
 			    typeof(EntityType), typeof(BookableState),	typeof(Gender), 
				typeof(RoomType),	typeof(ActivityType),	typeof(TransportType)		
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

		public IBookable CreateRoom( )
		{
			return new Room( );
		}

		public IBookable CreateActivity( )
		{
			return new Activity( );
		}

		public IBookable CreateTransport( )
		{
			return new Transport( );
		}

		public DateTimeRange CreateDateTimeRange( )
		{
			return new DateTimeRange( );
		}

		public Session CreateSession( )
		{
			return new Session( );
		}

		public object CreateObject( string aType )
		{
			switch ( aType )
			{
				case "Entity":
					return CreateEntity( );
				case "Booking":
					return CreateBooking( );
				case "Client":
					return CreateClient( );
				case "Employer":
					return CreateEmployer( );
				case "Manager":
					return CreateManager( );
				case "DateTimeRange":
					return CreateDateTimeRange( );
				case "Room":
					return CreateRoom( );
				case "Activity":
					return CreateActivity( );
				case "Transport":
					return CreateTransport( );
				case "Session":
					return CreateSession( );
				default:
					return null;
			}
		}

		public T CreateObject<T>( )
		{
			return Cast<T>( CreateObject( typeof( T ).Name ) );
		}

		public static T Cast<T>( object o )
		{
			return ( T ) o;
		}

		#endregion

	}

}