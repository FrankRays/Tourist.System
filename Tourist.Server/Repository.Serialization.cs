﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Serialization

		static private Data mData = new Data( );

		[Serializable, XmlRoot( "Repository" )]
		public class Data
		{
			[XmlArray( ElementName = "EntityList", Order = 1 )]
			public readonly List<Entity> EntityList = new List<Entity>( );

			public void Append( Entity aEntity )
			{
				if ( mData.EntityList.Contains( aEntity ) ) return;

				mData.EntityList.Add( aEntity );
			}

			public void Remove( Entity aEntity )
			{
				if ( !mData.EntityList.Contains( aEntity ) ) return;

				mData.EntityList.Remove( aEntity );
			}
		}

		public void Save( string aFileName )
		{
			var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );

			using ( Stream stream = new FileStream( aFileName, FileMode.Create, FileAccess.Write, FileShare.None ) )
			{
				formatter.Serialize( stream, mData );
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

		//Necessary to pass a List of IEntities in order to save the data
		public void Save( List<IEntity> entities )
		{
			foreach ( var entity in entities )
			{
				entity.OnSaveLoad = true;

				foreach ( var booking in entity.Bookings )
				{
					booking.OnSaveLoad = true;

					foreach ( var bookingItem in booking.BookingItens )
					{
						bookingItem.OnSaveLoad = true;
					}
				}

				mData.EntityList.Add( entity as Entity );
			}
		}

		public void Save( IEntity entity )
		{
			entity.OnSaveLoad = true;	
			mData.EntityList.Add( entity as Entity );
			
		}

		//From Client to Server
		public void Save( List<Entity> entities )
		{
			foreach ( var entity in entities )
			{
				entity.OnSaveLoad = true;

				foreach ( var booking in entity.BookingsList )
				{
					booking.OnSaveLoad = true;

					foreach ( var bookingItem in booking.BookingItensList )
					{
						bookingItem.OnSaveLoad = true;
					}
				}

				mData.EntityList.Add( entity );
			}
		}

		public void Load( )
		{
			foreach ( var entity in mData.EntityList )
			{
				entity.OnSaveLoad = false;

				foreach ( var booking in entity.BookingsList )
				{
					booking.OnSaveLoad = false;
					booking.IClient = booking.Client;

					//clean
					booking.Client = null;

					foreach ( var bookingItem in booking.BookingItensList )
					{
						bookingItem.OnSaveLoad = false;
						bookingItem.BookAble = bookingItem.Bookable;
						//clean
						bookingItem.Bookable = null;

						booking.Append( bookingItem );
					}

					//Clean
					booking.BookingItensList = new List<BookingItem>( );

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

				// empty the lists for each entity
				entity.BookingsList = new List<Booking>( );
				entity.BookablesList = new List<Bookable>( );
				entity.ClientsList = new List<Client>( );
				entity.EmployersList = new List<Employer>( );
			}
		}

		public List<Entity> EntityList
		{
			get { return mData.EntityList; }
		}

		#endregion
	}
}
