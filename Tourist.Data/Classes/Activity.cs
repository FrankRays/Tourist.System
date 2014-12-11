using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public abstract class Activity : Bookable
	{

		#region Fields

		private static int mCounter = 0;

		#endregion

		#region Properties

		public new int Id { get; set; }

		#endregion

		#region Constructor

		protected Activity()
		{
			Id = ++mCounter;
		}

		#endregion
	}
}