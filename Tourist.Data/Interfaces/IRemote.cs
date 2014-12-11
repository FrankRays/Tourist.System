using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourist.Data.Classes;

namespace Tourist.Data.Interfaces
{
	public interface IRemote
	{

		bool ServerRunning();

		List<Entity> EntityList { get;} 
		
		// metodos para adicionar, editar e remover nao esquecer ( Save e Load )

	}
}
