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

		public void RepositoryAddEntity( IEntity aEntity )
		{
			//check if aEntity is null
			mData.Append(aEntity as Entity);
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
