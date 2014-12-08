namespace Tourist.Server
{
	partial class Repository
	{
		
		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( ) { }

		private Repository( ) { }

		public Repository Instance
		{
			get { return mInstance; }
		}

		#endregion
		
	}
}
