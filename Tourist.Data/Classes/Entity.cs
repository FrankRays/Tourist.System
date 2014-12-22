using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;
using Tourist.Data.Interfaces;

namespace Tourist.Data.Classes
{
	[Serializable]
	public class Entity : IEntity
	{

		#region Fields

		private static int mCounter = 0;
		private string mName;
		private string mAddress;
		private EntityType mEntityType;
		private int mNif;
		
		#endregion

		#region Properties
		
		public int Id { get; set; }

		public EntityType EntityType
		{
			get { return mEntityType; }
			set { mEntityType = value; }
		}

		public string Name
		{
			get { return mName; }
			set { mName = value; }
		}

		public string Address
		{
			get { return mAddress; }
			set { mAddress = value; }
		}

		public int Nif
		{
			get { return mNif; }
			set { mNif = value; }
		}
		
		#endregion

		#region Constructor

		public Entity( )
		{
			Id = ++mCounter;
		}
		
		#endregion

	}
}
