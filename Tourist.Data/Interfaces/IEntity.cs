using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tourist.Data.Interfaces
{
	public interface IEntity
	{
		string Name { get; set; }
		string City { get; set; }
		
		IEnumerable<IBooking> Bookings { get; }
		void Append( IBooking aItem );
		void Remove( IBooking aItem );

		IEnumerable<IBookable> Bookables { get; set; }
		void Append( IBookable aItem );
		void Remove( IBookable aItem );

		// Todos os empregados
		IEnumerable<IEmployer> Employers { get; set; }
		void Append( IEmployer aItem );
		void Remove( IEmployer aItem );
		
		
	}
}
