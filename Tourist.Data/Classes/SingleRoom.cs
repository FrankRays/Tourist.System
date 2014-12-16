using System;
using System.Xml.Serialization;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class SingleRoom : Room
	{
		public SingleRoom( ) 
		{
			Capacity = 1;
		}
	}
}
