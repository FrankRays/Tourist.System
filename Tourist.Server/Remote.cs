using System;
using System.Runtime.Remoting.Lifetime;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	[Serializable]
	public class Remote : MarshalByRefObject, IRemote
	{
		private readonly Factory mFactory = new Factory();

		public Factory Factory
		{
			get { return mFactory; }
		}

		public bool ServerRunning()
		{
			return true;
		}

		public override Object InitializeLifetimeService()
		{
			var lease = (ILease) base.InitializeLifetimeService();

			// Normally, the initial lease time would be much longer.
			// It is shortened here for demonstration purposes.
			if (lease.CurrentState == LeaseState.Initial)
			{
				lease.InitialLeaseTime = TimeSpan.FromSeconds(3);
				lease.SponsorshipTimeout = TimeSpan.FromSeconds(10);
				lease.RenewOnCallTime = TimeSpan.FromSeconds(2);
			}
			return lease;
		}
	}
}