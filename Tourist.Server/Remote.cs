using System;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
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

		public override object InitializeLifetimeService( )
		{

			return null;
			/*
			ILease lease = ( ILease ) base.InitializeLifetimeService( );

			if ( lease.CurrentState == LeaseState.Initial )
			{
				// set times very short for demonstration purposes
				lease.InitialLeaseTime = TimeSpan.FromMinutes( 30 );
				lease.SponsorshipTimeout = TimeSpan.FromMinutes( 30 );
				lease.RenewOnCallTime = TimeSpan.FromMinutes( 1 );
			}
			return lease;
			 * */
		}
		
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

		public bool CheckLogin(string aUsername, string aPassword, string aType)
		{
		
			return Repository.CheckLogin(aUsername, aPassword, aType);
		}

		public Session ClientLoginSession { get { return Repository.ClientLoginSession; } }

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

		public void Remove( int aIndex, string aList )
		{
			Repository.Remove( aIndex, aList );
		}

		public int GetId( int aIndex, string aList )
		{
			return Repository.GetId( aIndex, aList );
		}

		public object GetObject( int aIndex, string aList )
		{
			return Repository.Instance.GetObject( aIndex, aList );
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