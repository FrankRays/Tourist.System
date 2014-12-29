using System.Windows.Forms;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{

		bool ServerRunning( );
		Factory Factory { get; }
		int Count( string aList );
		bool IsEmpty( string aList );
		bool ExistingId( int aId, string aList );
		bool CheckLogin( string aUsername, string aPassword, string aType );
		Session ClientLoginSession { get; }
		string[ , ] ListToMatrix( string aList );
		void Append( object aObject, string aList );
		void Remove( object aObject, string aList );
		void Remove( int aIndex, string aList );
		int GetId( int aIndex, string aList );
		object GetObject( int aIndex, string aList );
		int NextId( string aType );
		void Edit( string aType, int aId, string aPropertie, string aNewValue );
	}
}
