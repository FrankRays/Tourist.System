using System;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using Tourist.Server.Forms;

namespace Tourist.Server
{
	static class Program
	{

		#region Fields
		
		public static readonly Repository repository = Repository.Instance;
		public static string FileName = repository.FileName;

		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			
			TcpChannel channel = new TcpChannel( 3000 );
			ChannelServices.RegisterChannel( channel, false );

			//"Tourist.Server"
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof( Remote ),  //type
				"Tourist.Server",  //uri
				WellKnownObjectMode.Singleton ); //mode
			
			if ( File.Exists( FileName ) )
			{
				Repository.Instance.Load( FileName );
			}
			
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( ) );
		}
	}
}
