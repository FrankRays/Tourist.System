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
			//RepositoryLoadTest();


			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new LoginForm( ) );
		}

		static void RepositorySaveTest( )
		{

			var entities = new List<IEntity>();

			var entity = repo.Factory.CreateEntity();
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

			var client = repo.Factory.CreateClient( );
			client.FirstName = "Fabio";
			client.LastName = "Nobrega";
			client.Gender = GenderEnum.Male;
			client.BirthDate = new DateTime( 1987, 5, 13 );
			client.Nif = 000000000;
			client.Address = "Caminho das Preces";
			client.PhoneNumber = 930000000;
			client.Email = "fabio@super.com";

			var singleRoom = repo.Factory.CreateSingleRoom( );
			singleRoom.TimeRange = new DateTimeRange( );
			singleRoom.TimeRange.StartDateTime = DateTime.Today;
			singleRoom.TimeRange.EndDateTime = DateTime.Today.AddDays( 1 );

			singleRoom.Price = UnitPrice.SingleRoom * singleRoom.TimeRange.DiferenceTimeSpan( ).Days;

			var bookingItem = repo.Factory.CreateBookingItem( );
			bookingItem.BookAble = singleRoom;

			var booking = repo.Factory.CreateBooking( );
			booking.Clientt = client;
			booking.BookingDateTime = DateTime.Today;
			booking.Append( bookingItem );


			entity.Append( booking );
			entity.Append( singleRoom );
			entity.Append( client );
			entity.Append( employer );


			entities.Add(entity);

			repo.Save(entities);

			repo.Save( FileName );


		}

		static void RepositoryLoadTest( )
		{
			repo.Load( FileName );
			repo.Load();
		}

	}
}
