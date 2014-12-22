using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;
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
			/*
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
			*/
			/*
			if ( File.Exists( FileName ) )
			{
				Repository.Instance.Load( FileName );
				// por enquanto mas fica so numa funcao	
			}
			*/
			
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( ) );
		}
		
		/*
		private static void RepositorySaveTest( )
		{
			
			repository.MData.SetEntityProperties("Porto Bay", EntityType.Hotel, 123456789,"Rua do Sabao");

			var room = repository.Factory.CreateObject<Room>( );

			room.Name = "SingleRoom";
			room.Type = "SingleRoom";
			room.State = BookableState.Available;
			room.Price = BasePrice.SingleRoom;
			room.Capacity = 1;


			var client = repository.Factory.CreateObject<Client>( );

			client.FirstName = "Fabio";
			client.LastName = "Nobrega";
			client.Gender = Gender.Male;
			client.Nationality = "Portuguese";
			client.BirthDate = new DateTime( 2000, 05, 10 );
			client.Nif = 123456789;
			client.Address = "Rua da avo";
			client.PhoneNumber = 960000000;
			client.Email = "fabio@gmail.com";

			var manager = repository.Factory.CreateObject<Manager>( );

			manager.FirstName = "JOAO";
			manager.LastName = "Ras";
			manager.Gender = Gender.Male;
			manager.Nationality = "Portuguese";
			manager.BirthDate = new DateTime( 2000, 05, 10 );
			manager.Nif = 123456789;
			manager.Address = "Rua da avo";
			manager.PhoneNumber = 960000000;
			manager.Email = "joao@gmail.com";
			manager.Username = "joao";
			manager.Password = "123456";


			var employer = repository.Factory.CreateObject<Employer>( );

			employer.FirstName = "jonas";
			employer.LastName = "Rastas";
			employer.Gender = Gender.Male;
			employer.Nationality = "Portuguese";
			employer.BirthDate = new DateTime( 2000, 05, 10 );
			employer.Nif = 123456789;
			employer.Address = "Rua da avo";
			employer.PhoneNumber = 960000000;
			employer.Email = "fabio@gmail.com";
			employer.Username = "jonas";
			employer.Password = "123456";

			var booking = repository.Factory.CreateObject<Booking>( );

			booking.Client = client;
			booking.Bookable = room;
			booking.BookingDateTime = DateTime.Now.Date;
			booking.TimeRange = new DateTimeRange( DateTime.Now, DateTime.Now.AddDays( 1 ) );


			repository.MData.Append( booking );
			repository.MData.Append( client );
			repository.MData.Append( employer );
			repository.MData.Append( manager );
			repository.MData.Append( room, "Room" );


			repository.Save( FileName );
		}
	
		private static void RepositoryLoadTest( )
		{
			repository.Load( FileName );
		}
		*/
	}
}
