using System;
using System.Collections.Generic;
using System.Linq;
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

		public List<string> EntityNameList()
		{
			return mData.EntityList.Select(entity => entity.Name).ToList();
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

		public bool ValidIndex( int index )
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

		#region EmployersForms Methods


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
