using System;
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

		#region Methods
		
		public Type[ ] GetTypes( )
		{
			if ( Factory == null ) return null;
			return Factory.GetTypes( );
		}
		#endregion

		public void AddEntity( IEntity aEntity )
		{
			aEntity.OnSaveLoad = true;
			mData.Append(aEntity as Entity);
		}

		public int Count( )
		{
			return mData.EntityList.Count;
		}

		public bool IsEmpty( )
		{
			return (mData.EntityList.Count == 0);
		}


		public string[ , ] EntitiesListToMatrix(int columnsCount)
		{
			int rowsCount = Count();

			var matrix = new string[rowsCount, columnsCount ];

			for ( int i = 0 ; i < rowsCount ; i++ )
			{
				for ( int j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).EntityType.ToString();
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Name;
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Address;
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Nif.ToString();
					j++;
				}
			}

			return matrix;
		}

		public bool EntityAlreadyExists( int aId )
		{
			if (mData.EntityList.Any(entity => entity.Id == aId))
			{
				return true;
			}
			
			return false;
		}

		public void EditEntityType( int aId, EntityType aType )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.EntityType = aType;
			}
		}

		public void EditEntityName(int aId, string aName)
		{
			foreach (var entity in mData.EntityList.Where(entity => entity.Id == aId))
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
