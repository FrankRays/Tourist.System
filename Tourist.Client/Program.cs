using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using Tourist.Client.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Client
{
	static class Program
	{

		public static string ConfigFileName = "Tourist.Client.exe.config";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			// Create an active tcp port
			TcpChannel channel = new TcpChannel( );

			// Tell the remoting system to use the channel
			ChannelServices.RegisterChannel( channel, false );

			RemotingConfiguration.Configure( ConfigFileName, false );

			// Create a transparent proxy "obj" for the remote object
			IRemote Remote = ( IRemote ) Activator.GetObject(
				typeof( IRemote ), // Remote object type
				//"tcp://10.2.5.225:3000/Tourist.Server" );
				"tcp://localhost:3000/Tourist.Server" ); // Remote object URL

			try
			{
				Remote.ServerRunning( );
			}
			catch ( Exception )
			{
				MessageBox.Show( "Server not found !!! Please check if server is running or your internet connection.", "NETWORKING ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( Remote ) );
		}
	}
}
