using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class CableCarTransport : Transport
	{
		public CableCarTransport( )
		{		
			Capacity = 10;
		}
	}
}