namespace Tourist.Data.Interfaces
{
	public delegate void UpdateEventHandler( ISubject aSubject, object aData );
	
	public interface ISubject
	{
		event UpdateEventHandler OnUpdate;

		void Notify( object aData );
	}
}
