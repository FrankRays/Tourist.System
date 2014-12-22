using System;

namespace Tourist.Data.Interfaces
{
	public interface IFactory
	{
		object CreateObject( string aType );
		T CreateObject<T>( );
		Type[ ] GetTypes( );
	}
}
