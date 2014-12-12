using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using Tourist.Client.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;

namespace Tourist.Client
{
	static class Program
	{
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

			// Create a transparent proxy "obj" for the remote object
			IRemote Remote = ( IRemote ) Activator.GetObject(
				typeof( IRemote ), // Remote object type
				"tcp://localhost:3000/Tourist.Server" ); // Remote object URL

			List<Entity> test = Remote.GetEntityList( );

			try
			{
				Remote.ServerRunning( );
			}
			catch ( Exception )
			{
				MessageBox.Show( string.Format( "Server not found! Please check your internet connection." ) );
				return;
			}
			
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm() );
		}
	}
}
