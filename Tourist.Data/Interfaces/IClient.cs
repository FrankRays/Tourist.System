namespace Tourist.Data.Interfaces
{
	public interface IClient : IPersonalInformation, IContact
	{
		int Id { get; set; }
	}
}
