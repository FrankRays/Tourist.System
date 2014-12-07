using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
    public interface IBookable
    {
		int Id { get;}
		double Price { get; set; }
		DateTimeRange TimeRange { get; set; }
		int MaxNumberOfPersons { get; set; } 
	}
}
