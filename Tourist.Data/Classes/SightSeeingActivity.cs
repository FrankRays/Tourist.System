using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class SightSeeingActivity : Activity
	{
		public SightSeeingActivity( )
		{
			MaxNumberOfPersons = 10;
		}
	}
}