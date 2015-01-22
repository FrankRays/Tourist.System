using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public class ServerLogin : ILogin
	{
		public bool Authentication( string aUsername, string aPassword )
		{
			return Repository.Instance.CheckServerLogin( aUsername, aPassword );
		}
	}
}
