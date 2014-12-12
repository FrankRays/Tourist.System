using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class BusTransport : Transport
	{
		public BusTransport( )
		{
			MaxNumberOfPersons = 30;
		}
	}
}