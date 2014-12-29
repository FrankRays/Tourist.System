using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
			public ObservableCollection<Booking> Bookings = new ObservableCollection<Booking>( );

			[XmlArray( ElementName = "ClientList", Order = 3 )]
			public ObservableCollection<Client> Clients = new ObservableCollection<Client>( );

			[XmlArray( ElementName = "RoomList", Order = 4 )]
			public ObservableCollection<Room> Rooms = new ObservableCollection<Room>( );

			[XmlArray( ElementName = "ActivityList", Order = 5 )]
			public ObservableCollection<Activity> Activities = new ObservableCollection<Activity>( );

			[XmlArray( ElementName = "TransportList", Order = 6 )]
			public ObservableCollection<Transport> Transports = new ObservableCollection<Transport>( );

			[XmlArray( ElementName = "ManagersList", Order = 7 )]
			public ObservableCollection<Manager> Managers = new ObservableCollection<Manager>( );

			[XmlArray( ElementName = "EmployeesList", Order = 8 )]
			public ObservableCollection<Employer> Employees = new ObservableCollection<Employer>( );

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