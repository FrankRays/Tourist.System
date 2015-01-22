using System;
using Tourist.Data.Interfaces;

namespace Tourist.Client
{
	[Serializable]
	public class RemoteLogin : ILogin
	{
		private IRemote Remote { get; set; }

		public RemoteLogin( IRemote aRemote )
		{
			Remote = aRemote;
		}

		public bool Authentication( string aUsername, string aPassword )
		{
			return Remote.CheckLogin( aUsername, aPassword );
		}
	}
}
