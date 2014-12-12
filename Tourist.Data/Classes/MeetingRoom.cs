using System;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class MeetingRoom : Room
	{
		public MeetingRoom( )
		{
			MaxNumberOfPersons = 50;
		}
	}
}