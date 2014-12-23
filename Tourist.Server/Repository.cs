using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Tourist.Data.Classes;

namespace Tourist.Server
{
	public sealed partial class Repository
	{

		#region Singleton usage: Repository.Instance

		private static readonly Repository mInstance = new Repository( );

		static Repository( )
		{
		}

		private Repository( )
		{
		}

		public static Repository Instance
		{
			get { return mInstance; }
		}

		#endregion

		#region Factory

		private readonly Factory mFactory = new Factory( );

		public readonly string FileName = @"..\..\Repository.xml";

		public Factory Factory
		{
			get { return mFactory; }
		}

		public Type[ ] GetTypes( )
		{
			if ( Factory == null ) return null;
			return Factory.GetTypes( );
		}

		#endregion

		#region Generic Methods

		public byte[ ] ImageToByteArray( Image aImage )
		{
			MemoryStream ms = new MemoryStream( );
			aImage.Save( ms, System.Drawing.Imaging.ImageFormat.Png );
			return ms.ToArray( );
		}

		public Image byteArrayToImage( byte[ ] byteArrayIn )
		{
			MemoryStream ms = new MemoryStream( byteArrayIn );
			Image returnImage = Image.FromStream( ms );
			return returnImage;
		}

		public bool IsNumeric( string isNumber )
		{
			int retNum;

			return ( int.TryParse( isNumber, out retNum ) );
		}

		public bool IsEmailValid( string email )
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress( email );
				return true;
			}
			catch
			{
				return false;
			}
		}

		public DateTime ConvertStringToDateTime( string aDate )
		{
			try
			{
				var convertedDate = Convert.ToDateTime( aDate );

				return convertedDate;
			}
			catch ( FormatException )
			{
				Console.WriteLine( "'{0}' is not in the proper format.", aDate );
			}

			return new DateTime( );
		}

		#endregion

		#region Repository Methods

		public bool isEntityEmpty( )
		{
			if ( string.IsNullOrEmpty( mData.Entity.Name ) &&
				 string.IsNullOrEmpty( mData.Entity.EntityType.ToString( ) ) &&
				 string.IsNullOrEmpty( mData.Entity.Address ) &&
				 string.IsNullOrEmpty( mData.Entity.Nif.ToString( ) ) &&
				 string.IsNullOrEmpty( mData.Entity.PhoneNumber.ToString( ) ) &&
				 string.IsNullOrEmpty( mData.Entity.Email ) )
			{
				return false;
			}

			return true;
		}

		public bool IsBookingsEmpty( )
		{
			return mData.Bookings.Count == 0;
		}

		public bool IsClientsEmpty( )
		{
			return mData.Clients.Count == 0;
		}

		public bool IsRoomsEmpty( )
		{
			return mData.Rooms.Count == 0;
		}

		public bool IsActivitiesEmpty( )
		{
			return mData.Activities.Count == 0;
		}

		public bool IsTransportsEmpty( )
		{
			return mData.Transports.Count == 0;
		}

		public bool IsManagersEmpty( )
		{
			return mData.Managers.Count == 0;
		}

		public bool IsEmployeesEmpty( )
		{
			return mData.Employees.Count == 0;
		}

		// Count

		public int BookingsCount( )
		{
			return mData.Rooms.Count;
		}

		public int ClientsCount( )
		{
			return mData.Rooms.Count;
		}

		public int RoomsCount( )
		{
			return mData.Rooms.Count;
		}

		public int ActivitiesCount( )
		{
			return mData.Activities.Count;
		}

		public int TransportCount( )
		{
			return mData.Transports.Count;
		}

		public int ManagersCount( )
		{
			return mData.Managers.Count;
		}

		public int EmployeesCount( )
		{
			return mData.Employees.Count;
		}

		public int NextManagersId( )
		{
			if ( ManagersCount( ) == 0 )
				return 1;

			var temp = mData.Managers.Select( manager => manager.Id ).ToList( );

			return temp.Max( ) + 1;
		}

		#endregion




	}
}