using System.Collections.Generic;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{

		bool ServerRunning();

		List<Entity> GetRepositoryEntities();

		void SaveToRepository(List<Entity> entities);
		// metodos para adicionar, editar e remover nao esquecer ( Save e Load )

	}
}
