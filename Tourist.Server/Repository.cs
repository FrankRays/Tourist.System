using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Fields

		private readonly Factory mFactory = new Factory( );

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
		}

		public void EditEntityType( int aId, EntityType aType )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.EntityType = aType;
			}
		}

		public void EditEntityName( int aId, string aName )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Name = aName;
			}
		}

		public void EditEntityAddress( int aId, string aAddress )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Address = aAddress;
			}
		}

		public void EditEntityNif( int aId, int aNif )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.Nif = aNif;
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
				Save( Program.FileName );
				entity.OnSaveLoad = false;
				return;
			}
		}

		public void RemoveEmployerOfEntity( int aEntityId, int aIndex )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aEntityId ) )
			{

				entity.OnSaveLoad = true;
				var employersList = entity.Employers.ToList( );
				var employer = employersList.ElementAt( aIndex );
				employersList.Remove( employer );
				entity.Employers = employersList;
				Save( Program.FileName );
				entity.OnSaveLoad = false;
				return;
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
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
						Save( Program.FileName );
					}

					entity.OnSaveLoad = false;
					return;
				}
			}
		}


		#endregion

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
