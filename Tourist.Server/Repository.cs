using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

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

		#region Factory

		private readonly Factory mFactory = new Factory( );

		public readonly string FileName = @"..\..\Repository.xml";

		public Factory Factory
		{
			get { return mFactory; }
		}

		public Type[ ] GetTypes( )
		{
			if ( Factory == null ) return null;
			return Factory.GetTypes( );
		}

		#endregion

		#region Repository Methods

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
					if ( string.IsNullOrEmpty( mData.Entity.Name ) &&
						string.IsNullOrEmpty( mData.Entity.EntityType.ToString( ) ) &&
						string.IsNullOrEmpty( mData.Entity.Address ) &&
						string.IsNullOrEmpty( mData.Entity.Nif.ToString( ) ) &&
						string.IsNullOrEmpty( mData.Entity.PhoneNumber.ToString( ) ) &&
						string.IsNullOrEmpty( mData.Entity.Email ) )
					{
						return false;
					}
					return true;
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

		public void SetEntity( byte[ ] aImageBuffer, EntityType aEntityType, string aName, int aNif,
																		string aAddress, int aPhone, string aEmail )
		{
			mData.Entity.LogoBuffer = aImageBuffer;
			mData.Entity.EntityType = aEntityType;
			mData.Entity.Name = aName;
			mData.Entity.Nif = aNif;
			mData.Entity.Address = aAddress;
			mData.Entity.PhoneNumber = aPhone;
			mData.Entity.Email = aEmail;
		}

		public void Append( object aObject, string aType )
		{
			switch ( aType )
			{
				case "Booking":
					if ( mData.Bookings.Contains( aObject as Booking ) ) return;
					mData.Bookings.Add( aObject as Booking );
					return;
				case "Client":
					if ( mData.Clients.Contains( aObject as Client ) ) return;
					mData.Clients.Add( aObject as Client );
					return;
				case "Room":
					if ( mData.Rooms.Contains( aObject as Room ) ) return;
					mData.Rooms.Add( aObject as Room );
					return;
				case "Activity":
					if ( mData.Activities.Contains( aObject as Activity ) ) return;
					mData.Activities.Add( aObject as Activity );
					return;
				case "Transport":
					if ( mData.Transports.Contains( aObject as Transport ) ) return;
					mData.Transports.Add( aObject as Transport );
					return;
				case "Manager":
					if ( mData.Managers.Contains( aObject as Manager ) ) return;
					mData.Managers.Add( aObject as Manager );
					return;
				case "Employer":
					if ( mData.Employees.Contains( aObject as Employer ) ) return;
					mData.Employees.Add( aObject as Employer );
					return;
				default:
					return;
			}
		}

		public void Remove( object aObject, string aType )
		{
			switch ( aType )
			{
				case "Booking":
					if ( !mData.Bookings.Contains( aObject as Booking ) ) return;
					mData.Bookings.Add( aObject as Booking );
					return;
				case "Client":
					if ( !mData.Clients.Contains( aObject as Client ) ) return;
					mData.Clients.Add( aObject as Client );
					return;
				case "Room":
					if ( !mData.Rooms.Contains( aObject as Room ) ) return;
					mData.Rooms.Add( aObject as Room );
					return;
				case "Activity":
					if ( !mData.Activities.Contains( aObject as Activity ) ) return;
					mData.Activities.Add( aObject as Activity );
					return;
				case "Transport":
					if ( !mData.Transports.Contains( aObject as Transport ) ) return;
					mData.Transports.Add( aObject as Transport );
					return;
				case "Manager":
					if ( !mData.Managers.Contains( aObject as Manager ) ) return;
					mData.Managers.Add( aObject as Manager );
					return;
				case "Employer":
					if ( !mData.Employees.Contains( aObject as Employer ) ) return;
					mData.Employees.Add( aObject as Employer );
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
					if ( IsEmpty( "Room" ) ) return 1;
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

		public void EditManager( int aId, string aEditedCell )
		{
			switch ( aEditedCell )
			{
				case "FirstName":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.FirstName = aEditedCell;
					return;
				case "LastName":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.LastName = aEditedCell;
					return;
				case "Gender":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Gender = ( Gender ) Shared.ConvertStringToEnum( aEditedCell, "Gender" );
					return;
				case "Nationality":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Nationality = aEditedCell;
					return;
				case "BirthDate":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.BirthDate = Shared.ConvertStringToDateTime( aEditedCell );
					return;
				case "Address":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Address = aEditedCell;
					return;
				case "Phone":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.PhoneNumber = Shared.ConvertStringToInt( aEditedCell );
					return;
				case "Email":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Email = aEditedCell ;
					return;
				case "Username":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Username = aEditedCell ;
					return;
				case "Password":
					foreach ( var manager in mData.Managers.Where( manager => manager.Id == aId ) )
						manager.Password = aEditedCell ;
					return;
				default:
					return;
			}
		}


		#endregion
	}
}