using System.Collections.Generic;
using Tourist.Data.Interfaces;

namespace Tourist.Client
{
	public class CacheRemoteLogin : ILogin
	{
		private readonly Dictionary<string, string> Cache = new Dictionary<string, string>( );

		private ILogin Login { get; set; }

		public CacheRemoteLogin( ILogin aLogin )
		{
			Login = aLogin;
		}

		public bool Authentication( string aUsername, string aPassword )
		{
			if ( !Cache.ContainsKey( aUsername ) )
			{
				if ( !Login.Authentication( aUsername, aPassword ) )
					return false;

				Cache.Add( aUsername, aPassword );
				return true;
			}

			return Cache[ aUsername ] == aPassword;
		}
	}
}
