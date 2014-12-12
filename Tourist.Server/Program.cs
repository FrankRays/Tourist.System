using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using Tourist.Data.Classes;
using Tourist.Data.Interfaces;
using Tourist.Server.Forms;

namespace Tourist.Server
{
	static class Program
	{

		public const string FileName = @"..\..\Repository.xml";

		public static Repository repo = Repository.Instance;

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

			// Associate the class HelloServer with the URI "Tourist.Server"
			RemotingConfiguration.RegisterWellKnownServiceType(
				typeof( Remote ),  //type
				"Tourist.Server",  //uri
				WellKnownObjectMode.Singleton ); //mode

			/*
			if ( File.Exists( FileName ) )
			{
				Repository.Instance.Load( FileName );
				Repository.Instance.Load( );
				// por enquanto mas fica so numa funcao	
			}
			*/
			
			//RepositorySaveTest();
			RepositoryLoadTest( );

			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( ) );
		}

		static void RepositorySaveTest( )
		{

			var entities = new List<IEntity>( );

			var entity = repo.Factory.CreateEntity( );
			entity.Name = "Hotel Porto Bay";
			entity.City = "Porto";

			var employer = repo.Factory.CreateEmployer( );
			employer.FirstName = "Jonas";
			employer.LastName = "Rebo";
			employer.Gender = GenderEnum.Male;
			employer.BirthDate = new DateTime( 1987, 6, 13 );
			employer.Address = "Caminho das Lonas";
			employer.PhoneNumber = 931111111;
			employer.Email = "jonas@super.com";

			var client1 = repo.Factory.CreateClient( );
			client1.FirstName = "Fabio";
			client1.LastName = "Nobrega";
			client1.Gender = GenderEnum.Male;
			client1.BirthDate = new DateTime( 1987, 5, 13 );
			client1.Nif = 000000000;
			client1.Address = "Caminho das Preces";
			client1.PhoneNumber = 930000000;
			client1.Email = "fabio@super.com";

			var client2 = repo.Factory.CreateClient( );
			client2.FirstName = "Joao";
			client2.LastName = "Nobrega";
			client2.Gender = GenderEnum.Male;
			client2.BirthDate = new DateTime( 1975, 5, 15 );
			client2.Nif = 000000001;
			client2.Address = "Caminho das Preces";
			client2.PhoneNumber = 931111111;
			client2.Email = "joao@super.com";

			var singleRoom = repo.Factory.CreateDoubleRoom( );
			singleRoom.TimeRange = new DateTimeRange( );
			singleRoom.TimeRange.StartDateTime = DateTime.Today;
			singleRoom.TimeRange.EndDateTime = DateTime.Today.AddDays( 1 );

			singleRoom.Price = UnitPrice.SingleRoom * singleRoom.TimeRange.DiferenceTimeSpan( ).Days;

			var bookingItem = repo.Factory.CreateBookingItem( );
			bookingItem.BookAble = singleRoom;

			var booking = repo.Factory.CreateBooking( );
			booking.IClient = client1;
			booking.BookingDateTime = DateTime.Today;
			booking.Append( bookingItem );


			entity.Append( booking );
			entity.Append( singleRoom );
			entity.Append( client1 );
			entity.Append( client2 );
			entity.Append( employer );

			entities.Add( entity );

			repo.Save( entities );

			repo.Save( FileName );


		}

		static void RepositoryLoadTest( )
		{
			repo.Load( FileName );
			repo.Load( );
		}

	}
}
