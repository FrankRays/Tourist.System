using System;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public abstract class Room : Bookable
	{

		#region Fields

		private static int mCounter = 0;

		#endregion

		#region Properties

		public new int Id { get; set; }

		#endregion

		#region Constructor

		protected Room()
		{
			Id = ++mCounter;

		}

		#endregion

	}
}