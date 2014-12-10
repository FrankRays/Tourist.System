using System;
using System.Xml;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Fields

		private readonly Factory mFactory = new Factory( );

		public Factory Factory
		{
			get { return mFactory; }
		}

		#endregion
		
		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( ) { }

		private Repository( ) { }

		public static Repository Instance
		{
			get { return mInstance; }
		}

		#endregion


		public Type[ ] GetTypes( )
		{
			if ( Factory == null ) return null;
			return Factory.GetTypes( );
		}

		//Metodos para Criar/Editar/Apagar e colocar as listas encapsuladas no objecto mData

		public void AddEntity(IEntity aEntity)
		{
			mData.DataEntityList.Add( aEntity as Entity );
		}

		public Entity GetEntity(int EntityId)
		{
			foreach (var entity in mData.DataEntityList)
			{
				if (entity.Id == EntityId)
				{
					foreach (var item in entity.BookingsList)
					{
						entity.Append(item);
						
					}
					
					return entity;
				}
			}
			
			return null;
		}

	}
}
