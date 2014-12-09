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

			[XmlArray( ElementName = "Entity", Order = 1 )]
			public readonly List<Entity> DataEntityList = new List<Entity>();

		}

		public void Load( string aFileName )
		{
			var formatter = new XmlSerializer( typeof( Data ), GetTypes( ) );
			using ( Stream stream = File.OpenRead( aFileName ) )
			{
				mData = formatter.Deserialize( stream ) as Data;
			}
		}

		public void Save( string aFileName )
		{
			try
			{
				var formatter = new XmlSerializer(typeof (Data),GetTypes());
				
				using ( Stream stream = new FileStream( aFileName, FileMode.Create, FileAccess.Write, FileShare.None ) )
				{
					formatter.Serialize( stream, mData );
				}	
				
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.ToString());
			}
			
		}
		


	}
}
