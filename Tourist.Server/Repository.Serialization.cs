using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Tourist.Data.Classes;

namespace Tourist.Server
{
	public sealed partial class Repository
	{
		#region Serialization

		private static Data mData = new Data( );

		public Data MData
		{
			get { return mData; }
		}

		[Serializable, XmlRoot( "Repository" )]
		public class Data
		{
			[XmlElement( Order = 1 )]
			public Entity Entity = new Entity( );

			[XmlArray( ElementName = "BookingList", Order = 2 )]
			public List<Booking> Bookings = new List<Booking>( );

			[XmlArray( ElementName = "ClientList", Order = 3 )]
			public List<Client> Clients = new List<Client>( );

			[XmlArray( ElementName = "RoomList", Order = 4 )]
			public List<Room> Rooms = new List<Room>( );

			[XmlArray( ElementName = "ActivityList", Order = 5 )]
			public List<Activity> Activities = new List<Activity>( );

			[XmlArray( ElementName = "TransportList", Order = 6 )]
			public List<Transport> Transports = new List<Transport>( );

			[XmlArray( ElementName = "ManagersList", Order = 7 )]
			public List<Manager> Managers = new List<Manager>( );

			[XmlArray( ElementName = "EmployeesList", Order = 8 )]
			public List<Employer> Employees = new List<Employer>( );

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

		#endregion
	}
}