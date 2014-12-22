using System;
using Tourist.Data.Classes;

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

		#region Methods

		public bool RepositoryHasAEntity( )
		{
			if ( string.IsNullOrEmpty( mData.Entity.Name )						&&
				 string.IsNullOrEmpty( mData.Entity.EntityType.ToString( ) )	&&
				 string.IsNullOrEmpty( mData.Entity.Address )					&&
				 string.IsNullOrEmpty( mData.Entity.Nif.ToString( ) )			&&
				 string.IsNullOrEmpty( mData.Entity.PhoneNumber.ToString( ) )	&&
				 string.IsNullOrEmpty( mData.Entity.Email ) )
			{
				return true;
			}

			return false;
		}

		public bool RepositoryHasAManager()
		{
			return mData.Managers.Count != 0;
		}

		public bool RepositoryHasAEmployer( )
		{
			return mData.Employees.Count != 0;
		}

		#endregion
	}
}