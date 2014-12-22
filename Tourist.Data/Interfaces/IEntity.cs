namespace Tourist.Data.Interfaces
{
	public interface IEntity : IContact
	{
		int Id { get; set; }
		
		EntityType EntityType { get; set; }
		string Name { get; set; }
		int Nif { get; set; }

		
	}
}
