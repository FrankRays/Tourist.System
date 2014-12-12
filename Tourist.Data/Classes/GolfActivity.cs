using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class GolfActivity : Activity
	{
		public GolfActivity( ) 
		{
			MaxNumberOfPersons = 5;
		}
	}
}