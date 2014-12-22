using System;

namespace Tourist.Data.Interfaces
{
	public interface IContact
	{
		string Address { get; set; }
		int PhoneNumber { get; set; }
		string Email { get; set; }
	}
}
