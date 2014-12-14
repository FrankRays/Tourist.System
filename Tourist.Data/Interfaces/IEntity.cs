using System.Collections.Generic;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IEntity
	{

		int Id { get; set; }

		EntityType EntityType { get; set; }
		string Name { get; set; }
		string Address { get; set; }
		int Nif { get; set; }
		
		IEnumerable<IBooking> Bookings { get; }
		void Append( IBooking aItem );
		void Remove( IBooking aItem );

		IEnumerable<IClient> Clients { get; set; }
		void Append( IClient aItem );
		void Remove( IClient aItem );

		IEnumerable<IBookable> Bookables { get; set; }
		void Append( IBookable aItem );
		void Remove( IBookable aItem );

		IEnumerable<IEmployer> Employers { get; set; }
		void Append( IEmployer aItem );
		void Remove( IEmployer aItem );

		//for serialization
		bool OnSaveLoad { get; set; }

	}
}
