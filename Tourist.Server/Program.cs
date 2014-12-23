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

		public static readonly Repository repository = Repository.Instance;

		public static string ConfigFileName = "Tourist.Server.exe.config";

		public static string FileName = repository.FileName;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			//Create the tcp channel
			TcpChannel channel = new TcpChannel( 3000 );

			// Lets the remoting system use the socket
			ChannelServices.RegisterChannel( channel, false );

			RemotingConfiguration.Configure( ConfigFileName , false );

			// Associate the class HelloServer with the URI "Tourist.Server"
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
