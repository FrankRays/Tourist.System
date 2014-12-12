using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class SuiteRoom : Room
	{
		public SuiteRoom( )
		{
			MaxNumberOfPersons = 2;
		}
	}
}