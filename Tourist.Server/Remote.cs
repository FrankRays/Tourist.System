using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{

		private readonly Factory mFactory = new Factory( );

		public Factory Factory
		{
			get { return mFactory; }
		}

		public override Object InitializeLifetimeService( )
		{
			ILease lease = ( ILease ) base.InitializeLifetimeService( );

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

		public bool ServerRunning( )
		{
			return true;
		}

		public List<Entity> GetRepositoryEntityList( )
		{
			return Repository.Instance.EntityList;
		}

		public bool IsRepositoryEmpty( )
		{
			return Repository.Instance.IsEmpty( );
		}

		public List<string> GetEntityNameList( )
		{
			return Repository.Instance.EntityNameList( );
		}

		public int GetEntityId( string aEntityName )
		{
			return Repository.Instance.GetEntityId( aEntityName );
		}

		#region ClientsForm Methods

		public bool IsClientListEmpty( int aEntityId )
		{
			return Repository.Instance.IsBookingListEmpty( aEntityId );
		}

		public int ClientsListCount( int aEntityId )
		{
			return Repository.Instance.BookingListCount( aEntityId );
		}

		public bool IsClientsListIndexValid( int aEntityId, int aIndex )
		{
			return Repository.Instance.IsClientsListIndexValid( aEntityId, aIndex );
		}

		public int GetClientId( int aEntityId, int aIndex )
		{
			return Repository.Instance.GetClientId( aEntityId, aIndex );
		}

		public int MaxClientId( int aEntityId )
		{
			return Repository.Instance.MaxClientId( aEntityId );
		}

		public bool ClientAlreadyExists( int aEntityId, int aClientId )
		{
			return Repository.Instance.ClientAlreadyExists( aEntityId, aClientId );
		}

		public string[ , ] ClientsListToMatrix( int aEntityId, int columnsCount )
		{
			return Repository.Instance.ClientsListToMatrix( aEntityId, columnsCount );
		}

		public void AddClientToEntity( int aEntityId, IClient aClient )
		{
			Repository.Instance.AddClientToEntity( aEntityId, aClient );
		}

		public void RemoveClientOfEntity( int aEntityId, int aIndex )
		{
			Repository.Instance.RemoveClientOfEntity( aEntityId, aIndex );
		}

		public void EditClientGender( int aEntityId, int aClientId, Gender aGender )
		{
			Repository.Instance.EditClientGender( aEntityId, aClientId, aGender );
		}

		public void EditClientFirstName( int aEntityId, int aClientId, string aFirstName )
		{
			Repository.Instance.EditClientFirstName( aEntityId, aClientId, aFirstName );
		}

		public void EditClientLastName( int aEntityId, int aClientId, string aLastName )
		{
			Repository.Instance.EditClientLastName( aEntityId, aClientId, aLastName );
		}

		public void EditClientBirthDate( int aEntityId, int aClientId, DateTime aBirthDate )
		{
			Repository.Instance.EditClientBirthDate( aEntityId, aClientId, aBirthDate );
		}

		public void EditClientNif( int aEntityId, int aClientId, int aNif )
		{
			Repository.Instance.EditClientNif( aEntityId, aClientId, aNif );
		}

		public void EditClientAddress( int aEntityId, int aClientId, string aAddress )
		{
			Repository.Instance.EditClientAddress( aEntityId, aClientId, aAddress );
		}

		public void EditClientPhoneNumber( int aEntityId, int aClientId, int aPhoneNumber )
		{
			Repository.Instance.EditClientPhoneNumber( aEntityId, aClientId, aPhoneNumber );
		}

		public void EditClientEmail( int aEntityId, int aClientId, string aEmail )
		{
			Repository.Instance.EditClientEmail( aEntityId, aClientId, aEmail );

		}

		#endregion

		#region BookingForm Methods

		public bool IsBookingListEmpty( int aEntityId )
		{
			return Repository.Instance.IsBookingListEmpty( aEntityId );
		}

		public int BookingListCount( int aEntityId )
		{
			return Repository.Instance.BookingListCount( aEntityId );
		}

		public bool IsBookingListIndexValid( int aEntityId, int aIndex )
		{
			return Repository.Instance.IsBookingListIndexValid( aEntityId, aIndex );
		}

		public int GetBookingId( int aEntityId, int aIndex )
		{
			return Repository.Instance.GetBookingId( aEntityId, aIndex );
		}

		public int MaxBookingId( int aEntityId )
		{
			return Repository.Instance.MaxBookingId( aEntityId );
		}

		public bool BookingAlreadyExists( int aEntityId, int aBookingId )
		{
			return Repository.Instance.BookingAlreadyExists( aEntityId, aBookingId );
		}

		public string[ , ] BookingsListToMatrix( int aEntityId, int columnsCount )
		{
			return Repository.Instance.BookingsListToMatrix( aEntityId, columnsCount );
		}

		public IClient GetClientFromClientList( int aEntityId, int aClientNif )
		{
			return Repository.Instance.GetClientFromClientList( aEntityId, aClientNif );
		}

		public List<int> GetAllClientsNif(int aEntityId)
		{
			return Repository.Instance.GetAllClientsNif(aEntityId);
		}

		public string GetClientFullName(int aEntityId, int aNif)
		{
			return Repository.Instance.GetClientFullName(aEntityId, aNif);
		}

		public void AddBookingToEntity( int aEntityId, IBooking aBooking )
		{
			Repository.Instance.AddBookingToEntity( aEntityId, aBooking );
		}

		public void RemoveBookingOfEntity( int aEntityId, int aIndex )
		{
			Repository.Instance.RemoveBookingOfEntity( aEntityId, aIndex );
		}

		public void EditBookingCheckOutInDate( int aEntityId, int aBookingId, DateTime aCheckInOutDate, string aGridHeader )
		{
			Repository.Instance.EditBookingCheckOutInDate( aEntityId, aBookingId, aCheckInOutDate, aGridHeader );
		}

		public void EditBookingClientNif( int aEntityId, int aBookingId, int aNif )
		{
			Repository.Instance.EditBookingClientNif( aEntityId, aBookingId, aNif );
		}

		#endregion

	}
}

