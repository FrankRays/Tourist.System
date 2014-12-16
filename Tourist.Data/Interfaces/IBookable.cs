using System;
using System.Data;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
    public interface IBookable
    {
		int Id { get; set; }
		string Description { get; set; }
		string Type { get; set; }
		double Price { get; set; }
		int Capacity { get; set; }
		BookableState State { get; set; }
	}

	public enum BookableState
	{
		Available, Unavailable
	}
}
