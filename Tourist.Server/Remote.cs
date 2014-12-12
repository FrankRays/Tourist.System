using System;
using System.Collections.Generic;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{
		public bool ServerRunning( )
		{
			return true;
		}

		List<Entity> IRemote.GetRepositoryEntities()
		{
			return Repository.Instance.EntityList;
		}

		public void SaveToRepository(List<Entity> entities)
		{
			Repository.Instance.Save( entities );
			Repository.Instance.Save(Program.FileName);
		}

	}
}

