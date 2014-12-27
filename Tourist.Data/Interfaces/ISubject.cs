namespace Tourist.Data.Interfaces
{
	public delegate void UpdateEventHandler( ISubject aSubject, string aPropertie );
	
	public interface ISubject
	{
		event UpdateEventHandler OnUpdate;

		void Notify( string aPropertie );
	}
}
