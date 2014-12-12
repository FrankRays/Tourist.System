using System;
using System.Collections.Generic;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{
		public bool ServerRunning()
		{
			return true;
		}

		public List<Entity> GetEntityList()
		{
			return Repository.Instance.EntityList ;
		}
	}
}

