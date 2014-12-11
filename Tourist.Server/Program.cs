using System;
using System.Collections.Generic;
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

			//RepositorySaveTest();
			RepositoryLoadTest();


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

			var singleRoom = repo.Factory.CreateDoubleRoom();
			singleRoom.TimeRange = new DateTimeRange( );
			singleRoom.TimeRange.StartDateTime = DateTime.Today;
			singleRoom.TimeRange.EndDateTime = DateTime.Today.AddDays( 1 );

			singleRoom.Price = UnitPrice.SingleRoom * singleRoom.TimeRange.DiferenceTimeSpan( ).Days;

			var bookingItem = repo.Factory.CreateBookingItem( );
			bookingItem.BookAble = singleRoom;

			var booking = repo.Factory.CreateBooking( );
			booking.Clientt = client1;
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
