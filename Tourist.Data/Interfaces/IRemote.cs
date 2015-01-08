using System.Collections.Generic;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{
		bool ServerRunning( );
		Factory Factory { get; }
		Entity Entity { get; }
		Session ClientLoginSession { get; set; }
		int Count( string aList );
		int CountBooked( string aType );
		bool IsEmpty( string aList );
		bool ExistingId( int aId, string aList );
		bool CheckLogin( string aUsername, string aPassword, string aType );
		bool IsNotBookedAlredy(int aBookableId, string aBookableSubType, DateTimeRange aTimeFrame);
		string[ , ] ListToMatrix( string aList );
		void Append( object aObject, string aList );
		void Remove( int aIndex, string aList );
		int GetId( int aIndex, string aList );
		object GetObject( int aIndex, string aList );
		Client GetClientByNif( int aNif );
		IBookable GetBookable( string aType, int aId );
		List<string> ClientsNifList( );
		List<string> BookableSubTypesList(string aType);
		List<string> GetBooKablesIds( string aType, string aSubType );
		double GetBasePrice( string aType );
		string GetBookableDescription( int aId, string aType );
		int NextId( string aType );
		void Edit( string aType, int aId, string aPropertie, string aNewValue );
	}
}
