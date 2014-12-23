namespace Tourist.Data.Interfaces
{
	public interface IEntity : IContact, ISubject
	{
		int Id { get; set; }
		EnumEntityType EntityType { get; set; }
		string Name { get; set; }
		int Nif { get; set; }
	}
}
