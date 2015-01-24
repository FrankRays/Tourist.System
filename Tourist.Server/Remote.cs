using System;
using System.Collections.Generic;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{

		#region Fields

		private readonly Factory mFactory = new Factory( );
		private readonly Repository Repository = Repository.Instance;

		public Factory Factory
		{
			get { return mFactory; }
		}

		#endregion

		#region Methods

		public bool ServerRunning( )
		{
			return true;
		}

		public override object InitializeLifetimeService( )
		{
			return null;
		}

		//Wrapper Repository Methods 

		public Entity Entity
		{
			get { return Repository.MData.Entity; }
		}

		public int Count( string aList )
		{
			return Repository.Count( aList );
		}

		public int CountBooked( string aType )
		{
			return Repository.CountBooked( aType );
		}

		public bool IsEmpty( string aList )
		{
			return Repository.IsEmpty( aList );
		}

		public bool ExistingId( int aId, string aList )
		{
			return Repository.ExistingId( aId, aList );
		}

		public bool CheckLogin( string aUsername, string aPassword)
		{
			return Repository.CheckRemoteLogin( aUsername, aPassword);
		}

		public bool IsNotBookedAlredy( int aBookableId, string aBookableSubType, DateTimeRange aTimeFrame )
		{
			return Repository.IsNotBookedAlredy( aBookableId, aBookableSubType, aTimeFrame );
		}

		public Session ClientLoginSession
		{
			get { return Repository.ClientLoginSession; }
			set { Repository.ClientLoginSession = value; }
		}

		public string[ , ] ListToMatrix( string aList )
		{
			return Repository.ListToMatrix( aList );
		}

		public void Append( object aObject, string aList )
		{
			Repository.Append( aObject, aList );
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

		public Client GetClientByNif( int aNif )
		{
			return Repository.GetClientByNif( aNif );
		}

		public List<string> ClientsNifList( )
		{
			return Repository.ClientsNifList( );
		}

		public List<string> GetBooKablesIds( string aType, string aSubType )
		{
			return Repository.GetBooKablesIds( aType, aSubType );
		}

		public List<string> BookableSubTypesList( string aType )
		{
			return Repository.BookableSubTypesList( aType );
		}

		public string GetBookableDescription( int aId, string aType )
		{
			return Repository.GetBookableDescription( aId, aType );
		}

		public double GetBasePrice( string aType )
		{
			return Repository.BookableBasePrice( aType );
		}

		public IBookable GetBookable( string aType, int aId )
		{
			return Repository.GetBookable( aType, aId );
		}

		public int MaxBookingId
		{
			get { return Repository.MaxBookingId; }
			set { Repository.MaxBookingId = value; }
		}

		public List<Booking> SearchBookings( string aSearchFilter, string aSearchParameter1 = null,
			string aSearchParameter2 = null, string aSearchParameter3 = null )
		{
			return Repository.SearchBookings( aSearchFilter, aSearchParameter1, aSearchParameter2, aSearchParameter3 );
		}

		public List<Room> SearchRooms( string aSearchFilter )
		{
			return Repository.SearchRooms( aSearchFilter );
		}

		public List<Activity> SearchActivities( string aSearchFilter )
		{
			return Repository.SearchActivities( aSearchFilter );
		}

		public List<Transport> SearchTransports( string aSearchFilter )
		{
			return Repository.SearchTransports( aSearchFilter );
		}

		public List<Client> SearchClients( string aSearchFilter, string aSearchParameter1 )
		{
			return Repository.SearchClients( aSearchFilter, aSearchParameter1 );
		}

		#endregion

	}
}