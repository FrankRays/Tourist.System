using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	public abstract class Transport : Bookable
	{

		#region Fields

		private static int mCounter = 0;

		#endregion

		#region Properties

		public new int Id { get; set; }

		#endregion

		#region Constructor

		protected Transport()
		{
			Id = ++mCounter;
		}

		#endregion

	}
}