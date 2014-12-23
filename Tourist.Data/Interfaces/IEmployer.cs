using System;

namespace Tourist.Data.Interfaces
{
	public interface IEmployer : IPersonalInformation, IContact, ISubject
	{
		int Id { get; set; }
		string Username { get; set; }
		string Password { get; set; }
	}
}