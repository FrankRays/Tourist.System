using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{

		bool ServerRunning( );
		Factory GetFactory();

		#region LoginForm Methods
		
		List<Entity> GetRepositoryEntityList( );
		bool IsRepositoryEmpty( );
		List<string> GetEntityNameList( );
		int GetEntityId( string aEntityName );
		
		#endregion
		
		#region ClientsForm Methods

		bool IsClientListEmpty( int aEntityId );
		int ClientsListCount( int aEntityId );
		bool IsClientsListIndexValid( int aEntityId, int aIndex );
		int GetClientId( int aEntityId, int aIndex );
		int MaxClientId( int aEntityId );
		bool ClientAlreadyExists( int aEntityId, int aClientId );
		string[ , ] ClientsListToMatrix( int aEntityId, int columnsCount );
		void AddClientToEntity( int aEntityId, IClient aClient );
		void RemoveClientOfEntity( int aEntityId, int aIndex );
		void EditClientGender( int aEntityId, int aClientId, Gender aGender );
		void EditClientFirstName( int aEntityId, int aClientId, string aFirstName );
		void EditClientLastName( int aEntityId, int aClientId, string aLastName );
		void EditClientBirthDate( int aEntityId, int aClientId, DateTime aBirthDate );
		void EditClientNif( int aEntityId, int aClientId, int aNif );
		void EditClientAddress( int aEntityId, int aClientId, string aAddress );
		void EditClientPhoneNumber( int aEntityId, int aClientId, int aPhoneNumber );
		void EditClientEmail( int aEntityId, int aClientId, string aEmail );
		
		#endregion


	}
}
