using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class FamilySuiteRoom : Room
	{
		public FamilySuiteRoom( ) 
		{
			MaxNumberOfPersons = 4;
		}
	}
}