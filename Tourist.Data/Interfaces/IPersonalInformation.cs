using System;
using Tourist.Data.Enums;

namespace Tourist.Data.Interfaces
{
	public interface IPersonalInformation
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		Gender Gender { get; set; }
		string Nationality { get; set; } 
		DateTime BirthDate { get; set; }
		int Nif { get; set; }	
	}
}
