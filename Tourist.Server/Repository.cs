using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
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
		/*
		public void SaveEntity(IEntity aEntity)
		{
			aEntity.OnSaveLoad = true;

			mData.DataEntityList.Add( aEntity as Entity );
		}

		public Entity LoadEntity(int EntityId)
		{
			foreach (var entity in mData.DataEntityList)
			{
				if (entity.Id == EntityId)
				{
					List<Booking> temp = entity.BookingsList;
					
					foreach (var item in temp)
					{
						entity.Append(item);
					}
					
					return entity;
				}
			}
			
			return null;
		}
		*/

		public void Save( string aFileName )
		{
			try
			{
				var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );

				using ( Stream stream = new FileStream( aFileName, FileMode.Create, FileAccess.Write, FileShare.None ) )
				{
					formatter.Serialize( stream, mData );
				}

			}
			catch ( Exception e )
			{
				Debug.WriteLine( e.ToString( ) );
			}

		}

		public void Load( string aFileName )
		{
			var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );

			using ( Stream stream = File.OpenRead( aFileName ) )
			{
				mData = formatter.Deserialize( stream ) as Data;
			}
		}


		public void Save( List<IEntity> entities )
		{
			foreach ( var entity in entities )
			{
				entity.OnSaveLoad = true;

				mData.DataEntityList.Add( entity as Entity );
			}
		}

		public void Load( )
		{
			foreach ( var entity in mData.DataEntityList )
			{
				entity.OnSaveLoad = false;

				foreach ( var booking in entity.BookingsList )
				{
					entity.Append( booking );
				}

				foreach ( var bookable in entity.BookablesList )
				{
					entity.Append( bookable );
				}

				foreach ( var client in entity.ClientsList )
				{
					entity.Append( client );
				}

				foreach ( var employer in entity.EmployersList )
				{
					entity.Append( employer );
				}
			}
		}
	}
}
