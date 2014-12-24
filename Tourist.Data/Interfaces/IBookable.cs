using System;

namespace Tourist.Data.Interfaces
{
    public interface IBookable : ISubject
    {
		int Id { get; set; }

		Enum Type { get; set; }
		BookableState State { get; set; }
		string Description { get; set; }
		double Price { get; set; }
		int Capacity { get; set; }
		
	}
}
