using System.Xml.Serialization;

namespace Tourist.Data.Classes
{
	
	public class SingleRoom : Room
	{
		public SingleRoom( ) 
		{
			MaxNumberOfPersons = 1;
		}
	}
}
