using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using Tourist.Data.Classes;

namespace Tourist.Server
{
	public sealed partial class Repository
	{
		static private Data mData = new Data( );

		[Serializable, XmlRoot("Repository")]
		public class Data
		{

			[XmlArray( ElementName = "EntityList", Order = 1 )]
			public List<Entity> DataEntityList = new List<Entity>();

			//public readonly List<Booking> DataBookingList = new List<Entity>( );
		}

	}
}
