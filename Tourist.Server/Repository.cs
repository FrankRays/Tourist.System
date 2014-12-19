using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MetroFramework.Drawing;
using Microsoft.Win32;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Fields

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

		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( ) { }

		private Repository( ) { }

		public static Repository Instance
		{
			get { return mInstance; }
		}

		#endregion

		#region LoginForm Methods

		public List<string> EntityNameList( )
		{
			return mData.EntityList.Select( entity => entity.Name ).ToList( );
		}

		public int GetEntityId( string aName )
		{
			return ( from entity in mData.EntityList where entity.Name == aName select entity.Id ).FirstOrDefault( );
		}

		#endregion

		#region EntityForm Methods

		public int Count( )
		{
			return mData.EntityList.Count;
		}

		public bool IsEmpty( )
		{
			return ( mData.EntityList.Count == 0 );
		}

		public int MaxEntityId( )
		{
			if ( IsEmpty( ) )
				return 0;

			var Ids = mData.EntityList.Select( entity => entity.Id ).ToList( );

			return Ids.Max( );
		}

		public void AddEntity( IEntity aEntity )
		{
			aEntity.OnSaveLoad = true;
			mData.Append( aEntity as Entity );

			Save( FileName );
		}

		public void EditEntityType( int aId, EntityType aType )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.EntityType = aType;
				Save( FileName );
				return;
			}


		}

		public void EditEntityName( int aId, string aName )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Name = aName;
				Save( FileName );
				return;
			}

		}

		public void EditEntityAddress( int aId, string aAddress )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Address = aAddress;
				Save( FileName );
				return;
			}
		}

		public void EditEntityNif( int aId, int aNif )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Nif = aNif;
				Save( FileName );
				return;
			}
		}

		public int GetEntityId( int index )
		{
			return mData.EntityList.ElementAt( index ).Id;
		}

		public bool IsEntityListIndexValid( int index )
		{
			if ( IsEmpty( ) )
				return false;

			return ( index <= Count( ) - 1 );
		}

		public void RemoveEntity( int index )
		{
			var aId = mData.EntityList.ElementAt( index ).Id;

			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				mData.EntityList.Remove( entity );
				Save( FileName );
				return;
			}
		}

		public bool EntityAlreadyExists( int aId )
		{
			return mData.EntityList.Any( entity => entity.Id == aId );
		}

		public string[ , ] EntitiesListToMatrix( int columnsCount )
		{
			int rowsCount = Count( );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).EntityType.ToString( );
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Name;
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Nif.ToString( );
					j++;
				}
			}

			return matrix;
		}

		#endregion

		#region EmployersForm Methods

		public bool IsEmployersListEmpty( int aEntityId )
		{
			var entity = GetEntity( aEntityId );

			if ( !entity.Employers.Any( ) )
				return true;

			return false;
		}

		public int EmployersListCount( int aEntityId )
		{
			var temp = 0;

			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				temp = entity.Employers.Count( );
			}

			return temp;
		}

		public bool IsEmployersListIndexValid( int aEntityId, int aIndex )
		{
			if ( IsEmployersListEmpty( aEntityId ) )
				return false;

			return ( aIndex <= EmployersListCount( aEntityId ) - 1 );
		}

		public Entity GetEntity( int aEntityId )
		{
			if ( !EntityAlreadyExists( aEntityId ) ) return null;

			return mData.EntityList.FirstOrDefault( entity => entity.Id == aEntityId );
		}

		public int GetEmployerId( int aEntityId, int aIndex )
		{
			var entity = GetEntity( aEntityId );

			return entity.Employers.ElementAt( aIndex ).Id;
		}

		public int MaxEmployerId( int aEntityId )
		{
			if ( IsEmployersListEmpty( aEntityId ) )
				return 0;

			var entity = GetEntity( aEntityId );

			var Ids = entity.Employers.Select( employer => employer.Id ).ToList( );

			return Ids.Max( );
		}

		public bool EmployerAlreadyExists( int aEntityId, int aEmployerId )
		{
			var entity = GetEntity( aEntityId );

			return entity.Employers.Any( employer => employer.Id == aEmployerId );
		}

		public string[ , ] EmployersListToMatrix( int aEntityId, int columnsCount )
		{

			var entity = GetEntity( aEntityId );

			var rowsCount = EmployersListCount( aEntityId );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Gender.ToString( );
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).FirstName;
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).LastName;
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).BirthDate.Date.ToString( "d" );
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).PhoneNumber.ToString( );
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Email;
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Username;
					j++;
					matrix[ i, j ] = entity.Employers.ElementAt( i ).Password;
					j++;
				}
			}

			return matrix;
		}

		public void AddEmployerToEntity( int aEntityId, IEmployer aEmployer )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				entity.OnSaveLoad = true;
				entity.Append( aEmployer as Employer );
				Save( FileName );
				CleanEntityTemporaryLists( entity );
				entity.OnSaveLoad = false;
				return;
			}
		}

		public void RemoveEmployerOfEntity( int aEntityId, int aIndex )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					if ( !( aIndex > EmployersListCount( aEntityId ) - 1 ) )
					{
						entity.OnSaveLoad = true;
						var employer = entity.Employers.ElementAt( aIndex );

						entity.Remove( employer );

						Save( FileName );
						CleanEntityTemporaryLists( entity );
						entity.OnSaveLoad = false;
						return;
					}
				}
			}
		}

		public void EditEmployerGender( int aEntityId, int aEmployerId, Gender aGender )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.Gender = aGender;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}
					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerFirstName( int aEntityId, int aEmployerId, string aFirstName )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.FirstName = aFirstName;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerLastName( int aEntityId, int aEmployerId, string aLastName )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.LastName = aLastName;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerBirthDate( int aEntityId, int aEmployerId, DateTime aBirthDate )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.BirthDate = aBirthDate;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerAddress( int aEntityId, int aEmployerId, string aAddress )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.Address = aAddress;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = true;
					return;
				}
			}
		}

		public void EditEmployerPhoneNumber( int aEntityId, int aEmployerId, int aPhoneNumber )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.PhoneNumber = aPhoneNumber;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerEmail( int aEntityId, int aEmployerId, string aEmail )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.Email = aEmail;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerUsername( int aEntityId, int aEmployerId, string aUsername )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.Username = aUsername;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditEmployerPassword( int aEntityId, int aEmployerId, string aPassword )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var employer in entity.Employers.Where( employer => employer.Id == aEmployerId ) )
					{
						employer.Password = aPassword;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		#endregion

		#region BookablesForm RoomTab Methods

		public bool IsRoomBookablesListEmpty( int aEntityId )
		{
			var entity = GetEntity( aEntityId );

			return ( !entity.Bookables.OfType<Room>( ).Any( ) );
		}

		//beak point para testar
		public int RoomBookablesListCount( int aEntityId )
		{
			var entity = GetEntity( aEntityId );

			return entity.Bookables.OfType<Room>( ).Count( );
		}

		public bool IsRoomBookablesIndexValid( int aEntityId, int aIndex )
		{
			if ( IsRoomBookablesListEmpty( aEntityId ) )
				return false;

			return ( aIndex <= RoomBookablesListCount( aEntityId ) - 1 );
		}

		// Retorna a ordem de criação do objecto
		
		public int GetRoomId( int aEntityId, int aIndex )
		{
			var entity = GetEntity( aEntityId );

			return entity.Bookables.ElementAt( aIndex ).Id;
		}
		
		/*
		public int GetRoomId( int aEntityId ) 
		{
			var entity = GetEntity( aEntityId );
			
			foreach (var bookable in entity.Bookables)
			{
				switch ( bookable.Type )
				{
					case "SingleRoom":
						var temp1 = ( SingleRoom ) bookable;
						return temp1.Id;
					case "DoubleSingleRoom":
						var temp2 = ( DoubleSingleRoom ) bookable;
						return temp2.Id;
					case "DoubleRoom":
						var temp3 = ( DoubleRoom ) bookable;
						return temp3.Id;
					case "SuiteRoom":
						var temp4 = ( SuiteRoom ) bookable;
						return temp4.Id;
					case "FamilySuiteRoom":
						var temp5 = ( FamilySuiteRoom ) bookable;
						return temp5.Id;
					case "MeetingRoom":
						var temp6 = ( MeetingRoom ) bookable;
						return temp6.Id;
					default:
						return 0;
				}
			}
			return 0;
		}
		
	 */
		public int GetRoomId( Bookable aBookable )
		{
			switch ( aBookable.Type )
			{
				case "SingleRoom":
					var temp1 = ( SingleRoom ) aBookable;
					return temp1.Id;
				case "DoubleSingleRoom":
					var temp2 = ( DoubleSingleRoom ) aBookable;
					return temp2.Id;
				case "DoubleRoom":
					var temp3 = ( DoubleRoom ) aBookable;
					return temp3.Id;
				case "SuiteRoom":
					var temp4 = ( SuiteRoom ) aBookable;
					return temp4.Id;
				case "FamilySuiteRoom":
					var temp5 = ( FamilySuiteRoom ) aBookable;
					return temp5.Id;
				case "MeetingRoom":
					var temp6 = ( MeetingRoom ) aBookable;
					return temp6.Id;
				default:
					return 0;
			}
		}
		
		public int MaxRoomBookablesId( int aEntityId )
		{
			if ( IsRoomBookablesListEmpty( aEntityId ) )
				return 0;

			var entity = GetEntity( aEntityId );

			var ids = entity.Bookables.OfType<Room>( ).Select( bookable => bookable.Id ).ToList( );

			return ids.Max( );
		}

		/*
		public bool RoomBookablesAlreadyExists( int aEntityId, int aBookableId )
		{
			var entity = GetEntity( aEntityId );

			foreach ( var bookable in entity.Bookables )
			{
				if ( bookable.Type == "SingleRoom" || 
					bookable.Type == "DoubleSingleRoom" || 
					bookable.Type == "DoubleRoom" || 
					bookable.Type == "SuiteRoom" || 
					bookable.Type == "FamilySuiteRoom" ||
					bookable.Type == "MeetingRoom" )
				{
					if ( GetRoomId( bookable as Bookable ) == aBookableId )
					{
						return true;
					}
				}
			}

			return false;
		}
		*/

		public bool RoomBookablesAlreadyExists(int aEntityId, int aBookableId)
		{
			var entity = GetEntity( aEntityId );

			foreach ( var bookable in entity.Bookables )
			{
				if ( bookable is Room && bookable.Id == aBookableId )
				{
					return true;
				}
			}

			return false;
		}

		public string[ , ] RoomBookablesListToMatrix( int aEntityId, int columnsCount )
		{
			var entity = GetEntity( aEntityId );

			var rowsCount = RoomBookablesListCount( aEntityId );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = GetRoomId( entity.Bookables.ElementAt( i ) as Bookable ).ToString( );
					j++;
					matrix[ i, j ] = entity.Bookables.ElementAt( i ).Type.ToString( );
					j++;
					matrix[ i, j ] = entity.Bookables.ElementAt( i ).Description;
					j++;
					matrix[ i, j ] = entity.Bookables.ElementAt( i ).Price.ToString( );
					j++;
					matrix[ i, j ] = entity.Bookables.ElementAt( i ).Capacity.ToString( );
					j++;
					matrix[ i, j ] = entity.Bookables.ElementAt( i ).State.ToString( );
					j++;
				}
			}

			return matrix;
		}

		public void AddRoomBookableToEntity( int aEntityId, IBookable aBookable )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				entity.OnSaveLoad = true;
				entity.Append( aBookable as Room );
				Save( FileName );
				CleanEntityTemporaryLists( entity );
				entity.OnSaveLoad = false;
				return;
			}
		}

		public void RemoveRoomBookableOfEntity( int aEntityId, int aIndex )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					if ( !( aIndex > RoomBookablesListCount( aEntityId ) - 1 ) )
					{
						entity.OnSaveLoad = true;
						var bookable = entity.Bookables.ElementAt( aIndex );
						entity.Remove( bookable );
						Save( FileName );
						CleanEntityTemporaryLists( entity );
						entity.OnSaveLoad = false;
						return;
					}
				}
			}
		}

		public void EditRoomBookableType( int aEntityId, int aBookableId, string aType )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var bookable in entity.Bookables.Where( bookable => GetRoomId(bookable as Bookable) == aBookableId ) )
					{

						var newBookable = bookable as Bookable;
						
						newBookable.Type = aType;

						switch ( aType )
						{
							case "SingleRoom":
								newBookable = bookable as SingleRoom;
								break;
							case "DoubleSingleRoom":
								newBookable = bookable as DoubleSingleRoom;
								break;
							case "DoubleRoom":
								newBookable = bookable as DoubleRoom;
								break;
							case "SuiteRoom":
								newBookable = bookable as SuiteRoom;
								break;
							case "FamilySuiteRoom":
								newBookable = bookable as FamilySuiteRoom;
								break;
							case "MeetingRoom":
								newBookable = bookable as MeetingRoom;
								break;
							default:
								return;
						}

						
						//newBookable.Type = aType;

						entity.Remove( bookable );
						
						entity.Append( newBookable );

						Save( FileName );
						CleanEntityTemporaryLists( entity );
						entity.OnSaveLoad = false;
						return;
					}
				}
			}
		}

		public void EditRoomBookableDescription( int aEntityId, int aBookableId, string aDescription )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var bookable in entity.Bookables.Where( bookable => bookable.Id == aBookableId ) )
					{
						bookable.Description = aDescription;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditRoomBookablePrice( int aEntityId, int aBookableId, int aPrice )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var bookable in entity.Bookables.Where( bookable => bookable.Id == aBookableId ) )
					{
						bookable.Price = aPrice;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditRoomBookableCapacity( int aEntityId, int aBookableId, int aCapacity )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var bookable in entity.Bookables.Where( bookable => bookable.Id == aBookableId ) )
					{
						bookable.Capacity = aCapacity;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditRoomBookableState( int aEntityId, int aBookableId, BookableState aState )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var bookable in entity.Bookables.Where( bookable => bookable.Id == aBookableId ) )
					{
						bookable.State = aState;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = true;
					return;
				}
			}
		}

		#endregion

		#region ClientsForm Methods

		public bool IsClientListEmpty( int aEntityId )
		{
			var entity = GetEntity( aEntityId );

			if ( !entity.Clients.Any( ) )
				return true;

			return false;
		}

		public int ClientsListCount( int aEntityId )
		{
			var temp = 0;

			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				temp = entity.Clients.Count( );
			}

			return temp;
		}

		public bool IsClientsListIndexValid( int aEntityId, int aIndex )
		{
			if ( IsClientListEmpty( aEntityId ) )
				return false;

			return ( aIndex <= ClientsListCount( aEntityId ) - 1 );
		}

		public int GetClientId( int aEntityId, int aIndex )
		{
			var entity = GetEntity( aEntityId );

			return entity.Clients.ElementAt( aIndex ).Id;
		}

		public int MaxClientId( int aEntityId )
		{
			if ( IsClientListEmpty( aEntityId ) )
				return 0;

			var entity = GetEntity( aEntityId );

			var Ids = entity.Clients.Select( Client => Client.Id ).ToList( );

			return Ids.Max( );
		}

		public bool ClientAlreadyExists( int aEntityId, int aClientId )
		{
			var entity = GetEntity( aEntityId );

			return entity.Clients.Any( Client => Client.Id == aClientId );
		}

		public string[ , ] ClientsListToMatrix( int aEntityId, int columnsCount )
		{

			var entity = GetEntity( aEntityId );

			var rowsCount = ClientsListCount( aEntityId );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = entity.Clients.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).Gender.ToString( );
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).FirstName;
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).LastName;
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).BirthDate.Date.ToString( "d" );
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).Nif.ToString( );
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).PhoneNumber.ToString( );
					j++;
					matrix[ i, j ] = entity.Clients.ElementAt( i ).Email;
					j++;
				}
			}

			return matrix;
		}

		public void AddClientToEntity( int aEntityId, IClient aClient )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				entity.OnSaveLoad = true;
				entity.Append( aClient as Client );
				Save( FileName );
				CleanEntityTemporaryLists( entity );
				entity.OnSaveLoad = false;
				return;
			}
		}

		public void RemoveClientOfEntity( int aEntityId, int aIndex )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					if ( !( aIndex > ClientsListCount( aEntityId ) - 1 ) )
					{
						entity.OnSaveLoad = true;
						var client = entity.Clients.ElementAt( aIndex );
						entity.Remove( client );
						Save( FileName );
						CleanEntityTemporaryLists( entity );
						entity.OnSaveLoad = false;
						return;
					}
				}
			}
		}

		public void EditClientGender( int aEntityId, int aClientId, Gender aGender )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.Gender = aGender;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientFirstName( int aEntityId, int aClientId, string aFirstName )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.FirstName = aFirstName;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientLastName( int aEntityId, int aClientId, string aLastName )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.LastName = aLastName;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientBirthDate( int aEntityId, int aClientId, DateTime aBirthDate )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.BirthDate = aBirthDate;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientNif( int aEntityId, int aClientId, int aNif )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.Nif = aNif;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientAddress( int aEntityId, int aClientId, string aAddress )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.Address = aAddress;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = true;
					return;
				}
			}
		}

		public void EditClientPhoneNumber( int aEntityId, int aClientId, int aPhoneNumber )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.PhoneNumber = aPhoneNumber;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditClientEmail( int aEntityId, int aClientId, string aEmail )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var client in entity.Clients.Where( client => client.Id == aClientId ) )
					{
						client.Email = aEmail;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}


		#endregion

		#region BookingForm Methods

		public bool IsBookingListEmpty( int aEntityId )
		{
			var entity = GetEntity( aEntityId );

			if ( !entity.Bookings.Any( ) )
				return true;

			return false;
		}

		public int BookingListCount( int aEntityId )
		{
			var temp = 0;

			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				temp = entity.Bookings.Count( );
			}

			return temp;
		}

		public bool IsBookingListIndexValid( int aEntityId, int aIndex )
		{
			if ( IsBookingListEmpty( aEntityId ) )
				return false;

			return ( aIndex <= BookingListCount( aEntityId ) - 1 );
		}

		public int GetBookingId( int aEntityId, int aIndex )
		{
			var entity = GetEntity( aEntityId );

			return entity.Bookings.ElementAt( aIndex ).Id;
		}

		public int MaxBookingId( int aEntityId )
		{
			if ( IsBookingListEmpty( aEntityId ) )
				return 0;

			var entity = GetEntity( aEntityId );

			var ids = entity.Bookings.Select( booking => booking.Id ).ToList( );

			return ids.Max( );
		}

		public bool BookingAlreadyExists( int aEntityId, int aBookingId )
		{
			var entity = GetEntity( aEntityId );

			return entity.Bookings.Any( booking => booking.Id == aBookingId );
		}

		public IClient GetClientFromClientList(int aEntityId, int aClientNif)
		{
			foreach (var entity in mData.EntityList)
			{
				if (entity.Id == aEntityId)
				{
					foreach (var client in entity.Clients)
					{
						if (client.Nif == aClientNif)
							return client;
					}
				}

			}

			return null;
		}

		public List<int> GetAllClientsNif(int aEntityId)
		{

			var nifs = new List<int>();

			foreach (var entity in mData.EntityList)
			{
				if (entity.Id == aEntityId)
				{
					foreach (var client in entity.Clients)
					{
						nifs.Add(client.Nif);
					}
				}
			}

			return nifs;
		}

		public string GetClientFullName(int aEntityId, int aNif)
		{
			string fullName = "";
			
			foreach (var entity in mData.EntityList)
			{
				if (entity.Id == aEntityId)
				{
					foreach (var client in entity.Clients)
					{
						if (client.Nif == aNif)
						{
							fullName = client.FirstName + " " + client.LastName;
							return fullName;
						}
					}

				}

			}
			
			return fullName;
		}

		public IBookable GetBookableFromBookablesList(int aEntityId, int aBookableId)
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					foreach ( var bookable in entity.Bookables )
					{
						if (bookable.Id == aBookableId)
						{
							return bookable;
						}
					}
				}
			}

			return null;
		}

		public string[ , ] BookingsListToMatrix( int aEntityId, int columnsCount )
		{

			var entity = GetEntity( aEntityId );

			var rowsCount = BookingListCount( aEntityId );

			var matrix = new string[ rowsCount, columnsCount ];

			for ( var i = 0 ; i < rowsCount ; i++ )
			{
				for ( var j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).IClient.Nif.ToString( );
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).IClient.FirstName + " " + entity.Bookings.ElementAt( i ).IClient.LastName;
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).BookingDateTime.ToString( "d" );
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).BookingItens.ElementAt( 0 ).BookAble.Type;
					j++;
					matrix[i, j] = entity.Bookings.ElementAt(i).BookingItens.ElementAt(0).BookAble.Price.ToString();
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).TimeRange.StartDateTime.ToString( "d" );
					j++;
					matrix[ i, j ] = entity.Bookings.ElementAt( i ).TimeRange.EndDateTime.ToString( "d" );
					j++;
					matrix[i, j] = (entity.Bookings.ElementAt(i).TimeRange.DiferenceTimeSpan().Days *
									entity.Bookings.ElementAt(i).BookingItens.ElementAt(0).BookAble.Price).ToString();
					j++;
				}
			}

			return matrix;
		}

		public void AddBookingToEntity( int aEntityId, IBooking aBooking )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{
				entity.OnSaveLoad = true;
				entity.Append( aBooking );
				Save( FileName );
				aBooking.OnSaveLoad = false;
				CleanEntityTemporaryLists( entity );
				entity.OnSaveLoad = false;
				return;
			}
		}

		public void RemoveBookingOfEntity( int aEntityId, int aBookingId )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					foreach (var booking in entity.Bookings)
					{
						if (booking.Id == aBookingId)
						{
							entity.OnSaveLoad = true;
							booking.OnSaveLoad = true;
							entity.Remove( booking );
							Save( FileName );
							booking.OnSaveLoad = false;
							CleanEntityTemporaryLists( entity );
							entity.OnSaveLoad = false;
							return;
						}
					}
				}
			}
		}

		public List<string> GetAllBookables(int aEntity)
		{
			List<string> bookables = new List<string>();

			foreach (var entity in mData.EntityList)
			{
				foreach (var bookable in entity.Bookables)
				{
					bookables.Add(bookable.Id + "-" + bookable.Type);
				}
			}

			return bookables;
		}

		public void EditBookingCheckOutInDate( int aEntityId, int aBookingId, DateTime aCheckInOutDate, string aGridHeader)
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var booking in entity.Bookings.Where( booking => booking.Id == aBookingId ) )
					{
						booking.OnSaveLoad = true;

						if (aGridHeader.Equals("Check-In-Date"))
							booking.TimeRange.StartDateTime = aCheckInOutDate;
						else
							booking.TimeRange.EndDateTime = aCheckInOutDate;

						Save( FileName );
						CleanEntityTemporaryLists( entity );

						booking.OnSaveLoad = false;
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		public void EditBookingClientNif( int aEntityId, int aBookingId, int aNif )
		{
			foreach ( var entity in mData.EntityList )
			{
				if ( entity.Id == aEntityId )
				{
					entity.OnSaveLoad = true;

					foreach ( var booking in entity.Bookings.Where( booking => booking.Id == aBookingId ) )
					{
						booking.OnSaveLoad = true;
						booking.IClient.Nif = aNif;
						Save( FileName );
						CleanEntityTemporaryLists( entity );
						//var book = (Booking) booking;
						//book.BookingItensList = new List<BookingItem>();
						//book.Client = 
						booking.OnSaveLoad = false;
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}

		#endregion



		private void CleanEntityTemporaryLists( Entity aEntity )
		{
			aEntity.TempBookingsList = new List<Booking>( );
			aEntity.TempClientsList = new List<Client>( );
			aEntity.TempBookablesList = new List<Bookable>( );
			aEntity.TempEmployersList = new List<Employer>( );
		}
		/*
		public Entity SearchByEntityId( int aEntityId )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Id == aEntityId );
		}

		public Entity SearchByEntityName( string aEntityName )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Name == aEntityName );
		}

		public Entity SearchByEntityAddress( string aEntityAddress)
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Address == aEntityAddress );
		}

		public Entity SearchByEntityType( EntityType aEntityType )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.EntityType == aEntityType );
		}
		
		public Entity SearchByEntityNif( int aEntityNif )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Nif == aEntityNif );
		}
		
		*/

	}
}
