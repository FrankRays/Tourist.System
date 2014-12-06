using System;
using System.Windows.Forms;
using Tourist.Server.Forms;

namespace Tourist.Server
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( )
		{

			//int width = Screen.PrimaryScreen.WorkingArea.Width;
			//int height = Screen.PrimaryScreen.WorkingArea.Height;
			
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( ) );
			
		}
	}
}
