using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class DivingActivity : Activity
	{
		public DivingActivity( ) 
		{
			MaxNumberOfPersons = 2;
		}
	}
}