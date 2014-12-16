using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class BicycleTransport : Transport
	{
		public BicycleTransport( )
		{
			Capacity = 1;	
		}
	}
}