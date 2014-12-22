namespace Tourist.Data.Interfaces
{
	public interface IEntity
	{
		int Id { get; set; }
		EntityType EntityType { get; set; }
		string Name { get; set; }
		string Address { get; set; }
		int Nif { get; set; }
	}
}
