using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist.Data.Interfaces
{
	public interface IFactory
	{
		object CreateObject( string aType );

		/// <summary>
		/// Create an object based on a given interface type  
		/// </summary>
		/// <remarks>This method assumes that interface type name starts with a 'I'</remarks>
		/// <typeparam name="T">the interface type</typeparam>
		/// <returns>An object that implements the given interface type</returns>
		T CreateObject<T>( );

		Type[ ] GetTypes( );
	}
}
