using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{

		bool ServerRunning( );
		
		Factory Factory { get; }
		

	}
}
