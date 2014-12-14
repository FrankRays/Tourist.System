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

		public void AddEntityToRepository( IEntity aEntity )
		{
			aEntity.OnSaveLoad = true;
			mData.Append(aEntity as Entity);
		}

		public int RepositoryEntityCount( )
		{
			return mData.EntityList.Count;
		}

		public string[ , ] EntitiesListToMatrix(int columnsCount)
		{
			int rowsCount = mData.EntityList.Count;

			var matrix = new string[rowsCount, columnsCount ];

			for ( int i = 0 ; i < rowsCount ; i++ )
			{
				for ( int j = 0 ; j < columnsCount ; )
				{
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Id.ToString( );
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).Name;
					j++;
					matrix[ i, j ] = mData.EntityList.ElementAt( i ).City;
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

		public void EditEntityName(int aId, string aName)
		{
			foreach (var entity in mData.EntityList.Where(entity => entity.Id == aId))
			{
				entity.Name = aName;
			}
		}

		public void EditEntityCity( int aId, string aCity )
		{
			foreach ( var entity in mData.EntityList.Where( entity => entity.Id == aId ) )
			{
				entity.City = aCity;
			}
		}


		public Entity SearchByEntityId( int aEntityId )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Id == aEntityId );
		}

		public Entity SearchByEntityName( string aEntityName )
		{
			return mData.EntityList.FirstOrDefault( entity => entity.Name == aEntityName );
		}

		public Entity SearchByEntityCity( string aEntityCity)
		{
			return mData.EntityList.FirstOrDefault( entity => entity.City == aEntityCity );
		}




	}
}
