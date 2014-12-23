using System;

namespace Tourist.Data.Interfaces
{
	public interface IContact
	{
		string Address { get; set; }
		int Phone { get; set; }
		string Email { get; set; }
	}
}
