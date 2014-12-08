using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tourist.Data.Classes;

namespace Tourist.Server
{
	partial class Repository
	{
		static private Data mData = new Data( );

		[Serializable, XmlRoot("Repository")]
		public class Data
		{

			public List<Booking> DataBookingsList;
			public List<Client> DataBookablesList;
			//public List<Bookable> DataBookablesList;
			public List<Employer> DataBookingsList;



		}


		/*	
		public void Load( string aConnection )
		{
			var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );
			using ( Stream stream = File.OpenRead( aConnection ) )
			{
				mData = formatter.Deserialize( stream ) as Data;
			}
		}

		public void Save( string aConnection )
		{
			var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );
			using ( Stream stream = new FileStream( aConnection, FileMode.Create, FileAccess.Write, FileShare.None ) )
			{
				formatter.Serialize( stream, mData );
			}
		}
		*/


	}
}
