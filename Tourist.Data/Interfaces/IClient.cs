using System;

namespace Tourist.Data.Interfaces
{
	public interface IClient : IPersonalInformation,IContact,ISubject
	{
		int Id { get; set; }
	}
}
