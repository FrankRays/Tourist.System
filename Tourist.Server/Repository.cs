using System;
using Tourist.Data.Classes;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( )
		{
		}

		private Repository( )
		{
		}

		public static Repository Instance
		{
			get { return mInstance; }
		}

		#endregion
		
		#region Fields

		private readonly Factory mFactory = new Factory();

		public readonly string FileName = @"..\..\Repository.xml";

		public Factory Factory
		{
			get { return mFactory; }
		}

		public Type[] GetTypes()
		{
			if (Factory == null) return null;
			return Factory.GetTypes();
		}

		#endregion	
	}
}