﻿using System;
using System.Globalization;
using System.Linq;
using Tourist.Data.Classes;
using Tourist.Data.Enums;
using Tourist.Data.Shared;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( )
		{
		}

		private Repository( )
		{
		}

		public static Repository Instance
		{
			get { return mInstance; }
		}

		#endregion

		//Made Factory Static 
		#region Factory

		private static readonly Factory mFactory = new Factory( );

		public readonly string FileName = @"..\..\Repository.xml";

		public static Factory Factory
		{
			get { return mFactory; }
		}

		public Type[ ] GetTypes( )
		{
			if ( Factory == null ) return null;
			return Factory.GetTypes( );
		}

		#endregion

		#region Login Session

		private static readonly Session mServerLoginSession = Factory.CreateObject<Session>( );
		private static readonly Session mClientLoginSession = Factory.CreateObject<Session>( );

		public static Session ServerLoginSession
		{
			get { return mServerLoginSession; }
		}

		public static Session ClientLoginSession
		{
			get { return mClientLoginSession; }
		}

		#endregion

		#region Count && Bool Methods

		public int Count( string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					return mData.Bookings.Count;
				case "Clients":
					return mData.Clients.Count;
				case "Rooms":
					return mData.Rooms.Count;
				case "Activities":
					return mData.Activities.Count;
				case "Transports":
					return mData.Transports.Count;
				case "Managers":
					return mData.Managers.Count;
				case "Employees":
					return mData.Employees.Count;
				default:
					return 0;
			}
		}

		public bool IsEmpty( string aList )
		{
			switch ( aList )
			{
				case "Entity":
					if ( string.IsNullOrEmpty( mData.Entity.Name ) ||
						 string.IsNullOrEmpty( mData.Entity.EntityType.ToString( ) ) ||
						 string.IsNullOrEmpty( mData.Entity.Address ) ||
						 string.IsNullOrEmpty( mData.Entity.Nif.ToString( ) ) ||
						 string.IsNullOrEmpty( mData.Entity.Phone.ToString( ) ) ||
						 string.IsNullOrEmpty( mData.Entity.Email ) )
					{
						return true;
					}
					return false;
				case "Bookings":
					return Count( aList ) == 0;
				case "Clients":
					return Count( aList ) == 0;
				case "Rooms":
					return Count( aList ) == 0;
				case "Activities":
					return Count( aList ) == 0;
				case "Transports":
					return Count( aList ) == 0;
				case "Managers":
					return Count( aList ) == 0;
				case "Employees":
					return Count( aList ) == 0;
				default:
					return false;
			}
		}

		public bool ExistingId( int aId, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					return mData.Bookings.Any( booking => booking.Id == aId );
				case "Clients":
					return mData.Clients.Any( client => client.Id == aId );
				case "Rooms":
					return mData.Rooms.Any( room => room.Id == aId );
				case "Activities":
					return mData.Activities.Any( activity => activity.Id == aId );
				case "Transports":
					return mData.Transports.Any( transport => transport.Id == aId );
				case "Managers":
					return mData.Managers.Any( manager => manager.Id == aId );
				case "Employees":
					return mData.Employees.Any( employer => employer.Id == aId );
				default:
					return false;
			}
		}

		public bool CheckLogin( string aUsername, string aPassword, string aType )
		{
			switch ( aType )
			{
				case "Server":
					foreach ( var manager in mData.Managers )
					{
						if ( manager.Username.Equals( aUsername ) && manager.Password.Equals( aPassword ) )
						{
							ServerLoginSession.Id = manager.Id;
							ServerLoginSession.Username = aUsername;
							ServerLoginSession.Password = aPassword;
							return true;
						}
					}
					return false;
				case "Client":
					foreach ( var employer in mData.Employees )
					{
						if ( employer.Username.Equals( aUsername ) && employer.Password.Equals( aPassword ) )
						{
							ClientLoginSession.Id = employer.Id;
							ClientLoginSession.Username = aUsername;
							ClientLoginSession.Password = aPassword;
							return true;
						}
					}
					return false;
				default:
					return false;
			}
		}

		public bool RefreshGrid { get; set; }

		#endregion

		#region LoadDataToForm Methods

		public string[ , ] ListToMatrix( string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					break;
				case "Clients":
					return ListToMatrixClients( );
				case "Rooms":
					return ListToMatrixRooms( );
				case "Activities":
					return ListToMatrixActivities( );
				case "Transports":
					return ListToMatrixTransports( );
				case "Managers":
					return ListToMatrixManagers( );
				case "Employees":
					return ListToMatrixEmployees( );
				default:
					return null;
			}

			return null;
		}

		private int ObjectNumberOfProperties( string aType )
		{
			switch ( aType )
			{
				case "Booking":
					return typeof( Booking ).GetProperties( ).Length;
				case "Client":
					return typeof( Client ).GetProperties( ).Length;
				case "Room":
					return typeof( Room ).GetProperties( ).Length;
				case "Activity":
					return typeof( Activity ).GetProperties( ).Length;
				case "Transport":
					return typeof( Transport ).GetProperties( ).Length;
				case "Manager":
					return typeof( Manager ).GetProperties( ).Length;
				case "Employer":
					return typeof( Employer ).GetProperties( ).Length;
				default:
					return 0;
			}
		}

		private string[ , ] ListToMatrixClients( )
		{
			int rowsCount = Count( "Clients" );
			int columnsCount = ObjectNumberOfProperties( "Client" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).FirstName;
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).LastName;
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Gender.ToString( );
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Nationality;
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).BirthDate.ToString( "d" );
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Nif.ToString( );
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Phone.ToString( );
					j++;
					matrix[ i, j ] = mData.Clients.ElementAt( i ).Email;
					j++;
				}
			}

			return matrix;
		}

		private string[ , ] ListToMatrixRooms( )
		{
			int rowsCount = Count( "Rooms" );
			// has an adicional property because of the serializationl
			int columnsCount = ObjectNumberOfProperties( "Room" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount - 1 ; )
				{
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).Type.ToString( );
					j++;
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).State.ToString( );
					j++;
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).Description;
					j++;
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).Capacity.ToString( );
					j++;
					matrix[ i, j ] = mData.Rooms.ElementAt( i ).Price.ToString( "0.00", CultureInfo.InvariantCulture );
					j++;
				}
			}

			return matrix;
		}

		private string[ , ] ListToMatrixActivities( )
		{
			int rowsCount = Count( "Activities" );
			// has an adicional property for the serialization 
			int columnsCount = ObjectNumberOfProperties( "Activity" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount - 1 ; )
				{
					matrix[ i, j ] = mData.Activities.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Activities.ElementAt( i ).Type.ToString( );
					j++;
					matrix[ i, j ] = mData.Activities.ElementAt( i ).State.ToString( );
					j++;
					matrix[ i, j ] = mData.Activities.ElementAt( i ).Description;
					j++;
					matrix[ i, j ] = mData.Activities.ElementAt( i ).Capacity.ToString( );
					j++;
					matrix[ i, j ] = mData.Activities.ElementAt( i ).Price.ToString( "0.00", CultureInfo.InvariantCulture );
					j++;
				}
			}

			return matrix;
		}

		private string[ , ] ListToMatrixTransports( )
		{
			int rowsCount = Count( "Transports" );
			// has an adicional property for the serialization
			int columnsCount = ObjectNumberOfProperties( "Transport" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount - 1 ; )
				{
					matrix[ i, j ] = mData.Transports.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Transports.ElementAt( i ).Type.ToString( );
					j++;
					matrix[ i, j ] = mData.Transports.ElementAt( i ).State.ToString( );
					j++;
					matrix[ i, j ] = mData.Transports.ElementAt( i ).Description;
					j++;
					matrix[ i, j ] = mData.Transports.ElementAt( i ).Capacity.ToString( );
					j++;
					matrix[ i, j ] = mData.Transports.ElementAt( i ).Price.ToString( "0.00", CultureInfo.InvariantCulture );
					j++;
				}
			}

			return matrix;
		}

		private string[ , ] ListToMatrixManagers( )
		{
			int rowsCount = Count( "Managers" );
			int columnsCount = ObjectNumberOfProperties( "Manager" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).FirstName;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).LastName;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Gender.ToString( );
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Nationality;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).BirthDate.ToString( "d" );
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Nif.ToString( );
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Phone.ToString( );
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Email;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Username;
					j++;
					matrix[ i, j ] = mData.Managers.ElementAt( i ).Password;
					j++;
				}
			}

			return matrix;
		}

		private string[ , ] ListToMatrixEmployees( )
		{

			int rowsCount = Count( "Employees" );
			int columnsCount = ObjectNumberOfProperties( "Employer" );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).FirstName;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).LastName;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Gender.ToString( );
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Nationality;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).BirthDate.ToString( "d" );
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Nif.ToString( );
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Phone.ToString( );
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Email;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Username;
					j++;
					matrix[ i, j ] = mData.Employees.ElementAt( i ).Password;
					j++;
				}
			}

			return matrix;
		}

		#endregion

		#region Append Remove Get/Set Methods

		public void SetEntity( byte[ ] aImageBuffer, EntityType aEntityType, string aName, int aNif,
																		string aAddress, int aPhone, string aEmail )
		{
			mData.Entity.LogoBuffer = aImageBuffer;
			mData.Entity.EntityType = aEntityType;
			mData.Entity.Name = aName;
			mData.Entity.Nif = aNif;
			mData.Entity.Address = aAddress;
			mData.Entity.Phone = aPhone;
			mData.Entity.Email = aEmail;
		}

		public void Append( object aObject, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					if ( mData.Bookings.Contains( aObject as Booking ) ) return;
					mData.Bookings.Add( aObject as Booking );
					Save( FileName );
					return;
				case "Clients":
					if ( mData.Clients.Contains( aObject as Client ) ) return;
					mData.Clients.Add( aObject as Client );
					Save( FileName );
					RefreshGrid = true;
					return;
				case "Rooms":
					if ( mData.Rooms.Contains( aObject as Room ) ) return;
					mData.Rooms.Add( aObject as Room );
					Save( FileName );
					return;
				case "Activities":
					if ( mData.Activities.Contains( aObject as Activity ) ) return;
					mData.Activities.Add( aObject as Activity );
					Save( FileName );
					return;
				case "Transports":
					if ( mData.Transports.Contains( aObject as Transport ) ) return;
					mData.Transports.Add( aObject as Transport );
					Save( FileName );
					return;
				case "Managers":
					if ( mData.Managers.Contains( aObject as Manager ) ) return;
					mData.Managers.Add( aObject as Manager );
					Save( FileName );
					return;
				case "Employees":
					if ( mData.Employees.Contains( aObject as Employer ) ) return;
					mData.Employees.Add( aObject as Employer );
					Save( FileName );
					return;
				default:
					return;
			}

		}

		public void Remove( object aObject, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					if ( !mData.Bookings.Contains( aObject as Booking ) ) return;
					mData.Bookings.Remove( aObject as Booking );
					Save( FileName );
					return;
				case "Clients":
					if ( !mData.Clients.Contains( aObject as Client ) ) return;
					mData.Clients.Remove( aObject as Client );
					Save( FileName );
					return;
				case "Rooms":
					if ( !mData.Rooms.Contains( aObject as Room ) ) return;
					mData.Rooms.Remove( aObject as Room );
					Save( FileName );
					return;
				case "Activities":
					if ( !mData.Activities.Contains( aObject as Activity ) ) return;
					mData.Activities.Remove( aObject as Activity );
					Save( FileName );
					return;
				case "Transports":
					if ( !mData.Transports.Contains( aObject as Transport ) ) return;
					mData.Transports.Remove( aObject as Transport );
					Save( FileName );
					return;
				case "Managers":
					if ( !mData.Managers.Contains( aObject as Manager ) ) return;
					mData.Managers.Remove( aObject as Manager );
					Save( FileName );
					return;
				case "Employees":
					if ( !mData.Employees.Contains( aObject as Employer ) ) return;
					mData.Employees.Remove( aObject as Employer );
					Save( FileName );
					return;
				default:
					return;
			}
		}



		/*
		public void Remove( int aId, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					foreach (var booking in mData.Bookings.Where(booking => booking.Id == aId))
					{
						mData.Bookings.Remove( booking );
						Save( FileName );
						return;
					}
					return;
				case "Clients":
					foreach (var client in mData.Clients.Where(client => client.Id == aId))
					{
						mData.Clients.Remove(client);
						Save(FileName);
						return;
					}
					return;
				case "Rooms":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
					{ 
						mData.Rooms.Remove( room );
						Save( FileName );
						return;
					}
					return;
				case "Activities":
					foreach (var activity in mData.Activities.Where(activity => activity.Id == aId))
					{
						mData.Activities.Remove( activity );
						Save( FileName );
						return;
					}
					return;
				case "Transports":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
					{ 
						mData.Transports.Remove( transport );
						Save( FileName );
						return;
					}
					return;
				case "Managers":
					foreach (var manager in mData.Managers.Where(manager => manager.Id == aId))
					{
						mData.Managers.Remove( manager );
						Save( FileName );
						return;
					}	
					return;
				case "Employees":
					foreach (var employer in mData.Employees.Where(employer => employer.Id == aId))
					{
						mData.Employees.Remove( employer );
						Save( FileName );
						return;
					}
					return;
				default:
					return;
			}
		}

		 */

		public void Remove( int aIndex, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					if ( !IsEmpty( "Bookings" ) || aIndex <= Count( "Bookings" ) - 1 )
					{
						mData.Bookings.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				case "Clients":
					if ( !IsEmpty( "Clients" ) || aIndex <= Count( "Clients" ) - 1 )
					{
						mData.Clients.RemoveAt( aIndex );
						Save( FileName );
						RefreshGrid = true;
						return;
					}
					return;
				case "Rooms":
					if ( !IsEmpty( "Rooms" ) || aIndex <= Count( "Rooms" ) - 1 )
					{
						mData.Rooms.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				case "Activities":
					if ( !IsEmpty( "Activities" ) || aIndex <= Count( "Activities" ) - 1 )
					{
						mData.Activities.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				case "Transports":
					if ( !IsEmpty( "Transports" ) || aIndex <= Count( "Transports" ) - 1 )
					{
						mData.Transports.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				case "Managers":
					if ( !IsEmpty( "Managers" ) || aIndex <= Count( "Managers" ) - 1 )
					{
						mData.Managers.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				case "Employees":
					if ( !IsEmpty( "Employees" ) || aIndex <= Count( "Employees" ) - 1 )
					{
						mData.Employees.RemoveAt( aIndex );
						Save( FileName );
						return;
					}
					return;
				default:
					return;
			}
		}


		public int GetId( int aIndex, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					return mData.Bookings[ aIndex ].Id;
				case "Clients":
					return mData.Clients[ aIndex ].Id;
				case "Rooms":
					return mData.Rooms[ aIndex ].Id;
				case "Activities":
					return mData.Activities[ aIndex ].Id;
				case "Transports":
					return mData.Transports[ aIndex ].Id;
				case "Managers":
					return mData.Managers[ aIndex ].Id;
				case "Employees":
					return mData.Employees[ aIndex ].Id;
				default:
					return 0;
			}
		}

		public object GetObject( int aIndex, string aList )
		{
			switch ( aList )
			{
				case "Bookings":
					return mData.Bookings[ aIndex ];
				case "Clients":
					return mData.Clients[ aIndex ];
				case "Rooms":
					return mData.Rooms[ aIndex ];
				case "Activitys":
					return mData.Activities[ aIndex ];
				case "Transports":
					return mData.Transports[ aIndex ];
				case "Managers":
					return mData.Managers[ aIndex ];
				case "Employees":
					return mData.Employees[ aIndex ];
				default:
					return null;
			}
		}

		public int NextId( string aType )
		{
			switch ( aType )
			{
				case "Booking":
					if ( IsEmpty( "Bookings" ) ) return 1;
					return mData.Bookings.Select( booking => booking.Id ).ToList( ).Max( ) + 1;
				case "Client":
					if ( IsEmpty( "Clients" ) ) return 1;
					return mData.Clients.Select( client => client.Id ).ToList( ).Max( ) + 1;
				case "Room":
					if ( IsEmpty( "Rooms" ) ) return 1;
					return mData.Rooms.Select( room => room.Id ).ToList( ).Max( ) + 1;
				case "Activity":
					if ( IsEmpty( "Activities" ) ) return 1;
					return mData.Activities.Select( activity => activity.Id ).ToList( ).Max( ) + 1;
				case "Transport":
					if ( IsEmpty( "Transports" ) ) return 1;
					return mData.Transports.Select( transport => transport.Id ).ToList( ).Max( ) + 1;
				case "Manager":
					if ( IsEmpty( "Managers" ) ) return 1;
					return mData.Managers.Select( manager => manager.Id ).ToList( ).Max( ) + 1;
				case "Employer":
					if ( IsEmpty( "Employees" ) ) return 1;
					return mData.Employees.Select( manager => manager.Id ).ToList( ).Max( ) + 1;
				default:
					return 0;
			}
		}

		private Client GetClientByNif( int aNif )
		{
			return mData.Clients.FirstOrDefault( client => client.Nif == aNif );
		}

		#endregion

		#region Edit Methods

		public void Edit( string aType, int aId, string aPropertie, string aNewValue )
		{
			switch ( aType )
			{
				case "Booking":
					EditBooking( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Client":
					EditClient( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Room":
					EditRoom( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Activity":
					EditActivity( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Transport":
					EditTransport( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Manager":
					EditManager( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				case "Employer":
					EditEmployer( aId, aPropertie, aNewValue );
					Save( FileName );
					return;
				default:
					return;
			}
		}

		#region Private Edit Methods

		private void EditBooking( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "Client":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aId ) )
						booking.Client = GetClientByNif( SharedMethods.ConvertStringToInt( aNewValue ) );
					return;
				case "Bookable":
					TypeOf( aNewValue, aId );
					return;
				case "StartDate":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aId ) )
						booking.TimeFrame.StartDateTime = SharedMethods.ConvertStringToDateTime( aNewValue );
					return;
				case "EndDate":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aId ) )
						booking.TimeFrame.EndDateTime = SharedMethods.ConvertStringToDateTime( aNewValue );
					return;
				default:
					return;
			}
		}


		private void TypeOf( string aType, int aBookingId )
		{
			switch ( aType )
			{
				case "Single":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "DoubleSingle":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "Double":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "Suite":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "FamilySuite":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "Meeting":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "RoomType" );
					return;
				case "BoatRide":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "Golf":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "Camping":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "Diving":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "SightSeeing":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "SkyDiving":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "ActivityType" );
					return;
				case "TuckTuck":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				case "CableCar":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				case "Bicycle":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				case "Car":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				case "Bus":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				case "Motorist":
					foreach ( var booking in mData.Bookings.Where( booking => booking.Id == aBookingId ) )
						booking.Bookable.Type = SharedMethods.ConvertStringToEnum( aType, "TransportType" );
					return;
				default:
					return;
			}
		}

		private void EditClient( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "FirstName":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.FirstName = aNewValue;
					return;
				case "LastName":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.LastName = aNewValue;
					return;
				case "Gender":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( aNewValue, "Gender" );
					return;
				case "Nationality":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.Nationality = aNewValue;
					return;
				case "BirthDate":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.BirthDate = SharedMethods.ConvertStringToDateTime( aNewValue );
					return;
				case "Address":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.Address = aNewValue;
					return;
				case "Phone":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.Phone = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Email":
					foreach ( var client in mData.Clients.Where( client => client.Id == aId ) )
						client.Email = aNewValue;
					return;
				default:
					return;
			}
		}

		private void EditRoom( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "Type":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
						room.Type = ( RoomType ) SharedMethods.ConvertStringToEnum( aNewValue, "RoomType" );
					return;
				case "BookableState":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
						room.State = ( BookableState ) SharedMethods.ConvertStringToEnum( aNewValue, "BookableState" );
					return;
				case "Description":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
						room.Description = aNewValue;
					return;
				case "Capacity":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
						room.Capacity = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Price":
					foreach ( var room in mData.Rooms.Where( room => room.Id == aId ) )
						room.Price = SharedMethods.ConvertStringToDouble( aNewValue );
					return;
				default:
					return;
			}
		}

		private void EditActivity( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "Type":
					foreach ( var activity in mData.Activities.Where( activity => activity.Id == aId ) )
						activity.Type = ( ActivityType ) SharedMethods.ConvertStringToEnum( aNewValue, "ActivityType" );
					return;
				case "BookableState":
					foreach ( var activity in mData.Activities.Where( activity => activity.Id == aId ) )
						activity.State = ( BookableState ) SharedMethods.ConvertStringToEnum( aNewValue, "BookableState" );
					return;
				case "Description":
					foreach ( var activity in mData.Activities.Where( activity => activity.Id == aId ) )
						activity.Description = aNewValue;
					return;
				case "Capacity":
					foreach ( var activity in mData.Activities.Where( activity => activity.Id == aId ) )
						activity.Capacity = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Price":
					foreach ( var activity in mData.Activities.Where( activity => activity.Id == aId ) )
						activity.Price = SharedMethods.ConvertStringToDouble( aNewValue );
					return;
				default:
					return;
			}
		}

		private void EditTransport( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "Type":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
						transport.Type = ( TransportType ) SharedMethods.ConvertStringToEnum( aNewValue, "TransportType" );
					return;
				case "BookableState":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
						transport.State = ( BookableState ) SharedMethods.ConvertStringToEnum( aNewValue, "BookableState" );
					return;
				case "Description":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
						transport.Description = aNewValue;
					return;
				case "Capacity":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
						transport.Capacity = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Price":
					foreach ( var transport in mData.Transports.Where( transport => transport.Id == aId ) )
						transport.Price = SharedMethods.ConvertStringToDouble( aNewValue );
					return;
				default:
					return;
			}
		}

		private void EditManager( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "FirstName":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.FirstName = aNewValue;
					return;
				case "LastName":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.LastName = aNewValue;
					return;
				case "Gender":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( aNewValue, "Gender" );
					return;
				case "Nationality":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Nationality = aNewValue;
					return;
				case "BirthDate":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.BirthDate = SharedMethods.ConvertStringToDateTime( aNewValue );
					return;
				case "Address":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Address = aNewValue;
					return;
				case "Phone":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Phone = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Email":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Email = aNewValue;
					return;
				case "Username":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Username = aNewValue;
					return;
				case "Password":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Password = aNewValue;
					return;
				default:
					return;
			}
		}

		private void EditEmployer( int aId, string aPropertie, string aNewValue )
		{
			switch ( aPropertie )
			{
				case "FirstName":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.FirstName = aNewValue;
					return;
				case "LastName":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.LastName = aNewValue;
					return;
				case "Gender":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( aNewValue, "Gender" );
					return;
				case "Nationality":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Nationality = aNewValue;
					return;
				case "BirthDate":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.BirthDate = SharedMethods.ConvertStringToDateTime( aNewValue );
					return;
				case "Address":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Address = aNewValue;
					return;
				case "Phone":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Phone = SharedMethods.ConvertStringToInt( aNewValue );
					return;
				case "Email":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Email = aNewValue;
					return;
				case "Username":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Username = aNewValue;
					return;
				case "Password":
					foreach ( var employer in mData.Employees.Where( employer => employer.Id == aId ) )
						employer.Password = aNewValue;
					return;
				default:
					return;
			}
		}

		#endregion

		#endregion

	}
}