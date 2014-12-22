using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public sealed partial class Repository
	{
		
		#region Serialization

		private static Data mData = new Data();

		public Data MData
		{
			get { return mData; }
		}

		[Serializable, XmlRoot("Repository")]
		public class Data
		{
			[XmlElement( Order = 1 )]
			public Entity Entity = new Entity();

			[XmlArray( ElementName = "BookingList", Order = 2 )]
			public readonly List<Booking> Bookings = new List<Booking>( );

			[XmlArray( ElementName = "ClientList", Order = 3 )]
			public readonly List<Client> Clients = new List<Client>( );

			[XmlArray( ElementName = "RoomList", Order = 4 )]
			public readonly List<Room> Rooms = new List<Room>( );

			[XmlArray( ElementName = "ActivityList", Order = 5 )]
			public readonly List<Activity> Activities = new List<Activity>();

			[XmlArray( ElementName = "TransportList", Order = 6 )]
			public readonly List<Transport> Transports = new List<Transport>( );

			[XmlArray( ElementName = "ManagersList", Order = 7 )]
			public readonly List<Manager> Managers = new List<Manager>( );

			[XmlArray( ElementName = "EmployeesList", Order = 8 )]
			public readonly List<Employer> Employees = new List<Employer>();

		
			public void SetEntityProperties( byte[] aImageBuffer, 
								   EntityType aEntityType, 
								   string aName , 
								   int aNif, 
								   string aAddress,
								   int aPhone, 
								   string aEmail )
			{
				Entity.ImageBuffer = aImageBuffer;
				Entity.EntityType = aEntityType;
				Entity.Name = aName;
				Entity.Nif = aNif;
				Entity.Address = aAddress;
				Entity.PhoneNumber = aPhone;
				Entity.Email = aEmail;
			}

			public void Append(IBooking aItem)
			{
				if (mData.Bookings.Contains(aItem as Booking)) return;
				mData.Bookings.Add(aItem as Booking);
			}

			public void Remove(IBooking aItem)
			{
				if (!mData.Bookings.Contains(aItem as Booking)) return;
				mData.Bookings.Remove(aItem as Booking);
			}

			public void Append(IClient aItem)
			{
				if (mData.Clients.Contains(aItem as Client)) return;
				mData.Clients.Add(aItem as Client);
			}

			public void Remove(IClient aItem)
			{
				if (!mData.Clients.Contains(aItem as Client)) return;
				mData.Clients.Remove(aItem as Client);
			}

			public void Append(IBookable aItem, string aType)
			{
				switch (aType)
				{
					case "Room":
						if (mData.Rooms.Contains(aItem as Room)) return;
						mData.Rooms.Add(aItem as Room);
						break;
					case "Activity":
						if (mData.Activities.Contains(aItem as Activity)) return;
						mData.Activities.Add(aItem as Activity);
						break;
					case "Transport":
						if (mData.Transports.Contains(aItem as Transport)) return;
						mData.Transports.Add(aItem as Transport);
						break;
					default:
						return;
				}
			}

			public void Remove(IBookable aItem, string aType)
			{
				switch (aType)
				{
					case "Room":
						if (!mData.Rooms.Contains(aItem as Room)) return;
						mData.Rooms.Remove(aItem as Room);
						break;
					case "Activity":
						if (!mData.Activities.Contains(aItem as Activity)) return;
						mData.Activities.Remove(aItem as Activity);
						break;
					case "Trasnport":
						if (!mData.Transports.Contains(aItem as Transport)) return;
						mData.Transports.Remove(aItem as Transport);
						break;
					default:
						return;
				}
			}

			public void Append(IManager aItem)
			{
				if (mData.Managers.Contains(aItem as Manager)) return;
				mData.Managers.Add(aItem as Manager);
			}

			public void Remove(IManager aItem)
			{
				if (!mData.Managers.Contains(aItem as Manager)) return;
				mData.Managers.Remove(aItem as Manager);
			}

			public void Append(IEmployer aItem)
			{
				if (mData.Employees.Contains(aItem as Employer)) return;
				mData.Employees.Add(aItem as Employer);
			}

			public void Remove(IEmployer aItem)
			{
				if (!mData.Employees.Contains(aItem as Employer)) return;
				mData.Employees.Remove(aItem as Employer);
			}
		}

		public void Save(string aFileName)
		{
			var formatter = new XmlSerializer(typeof (Data), GetTypes());

			using (Stream stream = new FileStream(aFileName, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				formatter.Serialize(stream, mData);
			}
		}

		public void Load(string aFileName)
		{
			var formatter = new XmlSerializer(typeof (Data), GetTypes());

			using (Stream stream = File.OpenRead(aFileName))
			{
				mData = formatter.Deserialize(stream) as Data;
			}
		}

		#endregion
	}
}