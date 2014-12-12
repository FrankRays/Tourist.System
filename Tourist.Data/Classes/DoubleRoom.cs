using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DoubleRoom : Room
	{
		public DoubleRoom( ) 
		{
			MaxNumberOfPersons = 2;
		}
	}
}