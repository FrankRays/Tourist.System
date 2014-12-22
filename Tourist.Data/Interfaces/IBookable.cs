namespace Tourist.Data.Interfaces
{
    public interface IBookable
    {
		int Id { get; set; }
		string Name { get; set; }
		string Type { get; set; }
		double Price { get; set; }
		int Capacity { get; set; }
		BookableState State { get; set; }
	}
}
