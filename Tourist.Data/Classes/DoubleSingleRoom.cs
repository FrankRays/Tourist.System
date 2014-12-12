using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DoubleSingleRoom : Room
	{
		public DoubleSingleRoom( )
		{
			MaxNumberOfPersons = 2;
		}
	}
}
