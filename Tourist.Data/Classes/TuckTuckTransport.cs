using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class TuckTuckTransport : Transport
	{
		public TuckTuckTransport( )
		{
			MaxNumberOfPersons = 20;
		}
	}
}