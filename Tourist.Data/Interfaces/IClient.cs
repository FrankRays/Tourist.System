using System;

namespace Tourist.Data.Interfaces
{
	public interface IClient
	{
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		DateTime BirthDate { get; set; }
		Gender Gender { get; set; }
		int Nif { get; set; }
		string Address { get; set; }
		int PhoneNumber { get; set; }
		string Email { get; set; }
	}
}
