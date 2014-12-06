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
		IBooking Bookings { get; set; }
		IBookable Bookables { get; set; }
		IPartner Partners { get; set; }
		IEmployer Employers { get; set; }
		IManager Managers { get; set; }
	}
}
