using System;
using System.Runtime.Remoting.Lifetime;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{
		private readonly Factory mFactory = new Factory( );
		private readonly Repository Repository = Repository.Instance;

		public Factory Factory
		{
			get { return mFactory; }
		}

		public bool ServerRunning( )
		{
			return true;
		}

		/*
		public override Object InitializeLifetimeService( )
		{
			var lease = ( ILease ) base.InitializeLifetimeService( );

			// Normally, the initial lease time would be much longer.
			// It is shortened here for demonstration purposes.
			if ( lease.CurrentState == LeaseState.Initial )
			{
				lease.InitialLeaseTime = TimeSpan.FromSeconds( 3 );
				lease.SponsorshipTimeout = TimeSpan.FromSeconds( 10 );
				lease.RenewOnCallTime = TimeSpan.FromSeconds( 2 );
			}
			return lease;
		}
		*/
		
		//Wrapper Repository Methods 
		
		public int Count( string aList )
		{
			return Repository.Count( aList );
		}

		public bool IsEmpty( string aList )
		{
			return Repository.IsEmpty( aList );
		}

		public bool ExistingId( int aId, string aList )
		{
			return Repository.ExistingId( aId, aList );
		}

		public string[ , ] ListToMatrix( string aList )
		{
			return Repository.ListToMatrix( aList );
		}

		public void Append( object aObject, string aList )
		{
			Repository.Append( aObject, aList );
		}

		public void Remove( object aObject, string aList )
		{
			Repository.Remove( aObject, aList );
		}

		public int GetId( int aIndex, string aList )
		{
			return Repository.GetId( aIndex, aList );
		}

		public object GetObject( int aIndex, string aList )
		{
			return Repository.GetObject( aIndex, aList );
		}

		public int NextId( string aType )
		{
			return Repository.NextId( aType );
		}

		public void Edit( string aType, int aId, string aPropertie, string aNewValue )
		{
			Repository.Edit( aType, aId, aPropertie, aNewValue );
		}

	}
}