using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class CarTransport : Transport
	{
		public CarTransport( ) 
		{
			MaxNumberOfPersons = 5;
		}
	}
}