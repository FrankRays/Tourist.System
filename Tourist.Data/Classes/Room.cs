using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Room : Bookable
	{

		#region Fields

		private static int mCounter = 0;

		#endregion

		#region Properties

		public new int Id { get; set; }

		#endregion

		#region Constructor

		public Room()
		{
			Id = ++mCounter;

		}

		#endregion

	}
}