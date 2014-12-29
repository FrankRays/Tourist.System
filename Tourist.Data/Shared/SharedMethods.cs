using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tourist.Data.Enums;

namespace Tourist.Data.Shared
{
	public static class SharedMethods
	{

		#region Shared Methods

		public static void SetFormFullScreen( Form aForm )
		{
			var x = Screen.PrimaryScreen.Bounds.Width;
			var y = Screen.PrimaryScreen.Bounds.Height;

			aForm.Location = new Point( 0, 0 );
			aForm.Size = new Size( x, y );
			aForm.FormBorderStyle = FormBorderStyle.None;
			aForm.Focus( );
		}

		public static byte[ ] ImageToByteArray( Image aImage )
		{
			var ms = new MemoryStream( );
			aImage.Save( ms, ImageFormat.Png );
			return ms.ToArray( );
		}

		public static Image ByteArrayToImage( byte[ ] byteArrayIn )
		{
			var ms = new MemoryStream( byteArrayIn );
			var returnImage = Image.FromStream( ms );
			return returnImage;
		}

		public static bool IsNumeric( string isNumber )
		{
			int retNum;

			return ( int.TryParse( isNumber, out retNum ) );
		}

		public static bool IsEmailValid( string aEmail )
		{
			try
			{
				var emailParts = aEmail.Split( '@' );

				if ( !string.IsNullOrEmpty( emailParts[ 0 ] ) )
				{
					var domainParts = emailParts[ 1 ].Split( '.' );

					if ( !string.IsNullOrEmpty( domainParts[ 0 ] ) && !string.IsNullOrEmpty( domainParts[ 1 ] ) )
					{
						return true;
					}
				}
			}
			catch (Exception)
			{
				// ignored
			}

			return false;
		}

		public static int ConvertStringToInt( string aInt )
		{
			try
			{
				var convertedInt = Convert.ToInt32( aInt );

				return convertedInt;
			}
			catch ( FormatException )
			{
				Console.WriteLine( Strings.IsNotInteger );
			}

			return 0;
		}

		public static double ConvertStringToDouble( string aDouble )
		{
			try
			{
				var convertedInt = Convert.ToDouble( aDouble, CultureInfo.InvariantCulture );

				return convertedInt;
			}
			catch ( FormatException )
			{
				Console.WriteLine( Strings.IsNotDouble );
			}

			return 0;
		}

		public static DateTime ConvertStringToDateTime( string aDate )
		{
			try
			{
				var convertedDate = Convert.ToDateTime( aDate );

				return convertedDate;
			}
			catch ( FormatException )
			{
				Console.WriteLine( Strings.IsNotDateFormat );
			}

			return new DateTime( );
		}

		public static Enum ConvertStringToEnum( string aEnum, string aEnumType )
		{
			switch ( aEnumType )
			{
				case "EntityType":
					try
					{
						return ( EntityType ) Enum.Parse( typeof( EntityType ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum );
						return null;
					}
				case "Gender":
					try
					{
						return ( Gender ) Enum.Parse( typeof( Gender ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum );
						return null;
					}
				case "BookableState":
					try
					{
						return ( BookableState ) Enum.Parse( typeof( BookableState ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum, aEnumType );
						return null;
					}
				case "RoomType":
					try
					{
						return ( RoomType ) Enum.Parse( typeof( RoomType ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum, aEnumType );
						return null;
					}
				case "ActivityType":
					try
					{
						return ( ActivityType ) Enum.Parse( typeof( ActivityType ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum, aEnumType );
						return null;
					}
				case "TransportType":
					try
					{
						return ( TransportType ) Enum.Parse( typeof( TransportType ), aEnum );
					}
					catch ( Exception )
					{
						Console.WriteLine( Strings.IsNotEnum, aEnumType );
						return null;
					}
				default:
					return null;
			}
		}


		public static void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
		}

		public static List<string> RowCellValues( DataGridViewRow rows )
		{
			var rowCellValues = new List<string>( );

			for ( int i = 0 ; i < rows.Cells.Count ; i++ )
			{
				rowCellValues.Add( rows.Cells[ i ].EditedFormattedValue.ToString( ) );
			}

			return rowCellValues;
		}

		public static bool RowCellsValidated( DataGridViewRow aRow )
		{

			var cellHasError = new bool[ aRow.Cells.Count ];

			for ( var i = 0 ; i < aRow.Cells.Count ; i++ )  //for ( var i = 0 ; i < aRow.Cells.Count - 1 ; i++ )
			{
				cellHasError[ i ] = false;
			}

			for ( var i = 0 ; i < aRow.Cells.Count ; i++ ) //for ( var i = 1 ; i < aRow.Cells.Count ; i++ )
			{
				if ( string.IsNullOrEmpty( aRow.Cells[ i ].EditedFormattedValue.ToString( ) ) )
				{
					aRow.Cells[ i ].ErrorText = Strings.ErrorCellEmpty;

					cellHasError[ i - 1 ] = true;
				}
				else
				{
					CellErrorRemove( aRow.Cells[ i ] );
				}
			}
			try
			{
				if ( aRow.Cells[ "NifColumn" ].Value != null )
				{
					if ( !IsNumeric( aRow.Cells[ "NifColumn" ].EditedFormattedValue.ToString( ) ) )
					{
						aRow.Cells[ "NifColumn" ].ErrorText = Strings.ErrorNifOnlyDigits;
						return false;
					}

					if ( ( aRow.Cells[ "NifColumn" ].EditedFormattedValue.ToString( ).Length < 9 ) || ( aRow.Cells[ "NifColumn" ].EditedFormattedValue.ToString( ).Length > 9 ) )
					{
						aRow.Cells[ "NifColumn" ].ErrorText = Strings.ErrorNifNineDigits;
						return false;
					}

					CellErrorRemove( aRow.Cells[ "NifColumn" ] );
				}
			}
			catch (Exception)
			{
				// ignored
			}

			try
			{
				if ( aRow.Cells[ "PhoneColumn" ].Value != null )
				{
					if ( !IsNumeric( aRow.Cells[ "PhoneColumn" ].EditedFormattedValue.ToString( ) ) )
					{
						aRow.Cells[ "PhoneColumn" ].ErrorText = Strings.ErrorPhoneOnlyDigits;
						return false;
					}
					// other phone verifications
					CellErrorRemove( aRow.Cells[ "PhoneColumn" ] );
				}
			}
			catch (Exception)
			{
				// ignored
			}

			try
			{
				if ( aRow.Cells[ "EmailColumn" ].Value != null )
				{
					if ( !IsEmailValid( aRow.Cells[ "EmailColumn" ].EditedFormattedValue.ToString( ) ) )
					{
						aRow.Cells[ "EmailColumn" ].ErrorText = Strings.ErrorEmailNotValid;
						return false;
					}

					CellErrorRemove( aRow.Cells[ "EmailColumn" ] );
				}
			}
			catch (Exception)
			{
				// ignored
			}


			return !cellHasError.Any( bolean => bolean );
		}

		public static void TimerClockAnimation( Label aClock, Label aAmPm, Label aDayNumber,
										Label aDayOfWeek, Label aMonth, Label aYear )
		{
			aClock.Text = DateTime.Now.ToString( "HH:mm:ss" );

			if ( DateTime.Now.Hour >= 12 && DateTime.Now.Minute >= 0 )
				aAmPm.Text = "PM";
			else
				aAmPm.Text = "AM";

			if ( DateTime.Today.Day < 10 )
				aDayNumber.Text = "0" + DateTime.Today.Day;
			else
				aDayNumber.Text = DateTime.Today.Day.ToString( );

			aDayOfWeek.Text = DateTime.Today.DayOfWeek.ToString( );
			aMonth.Text = MonthsName( DateTime.Today.Month );
			aYear.Text = DateTime.Today.Year.ToString( );
		}

		public static string MonthsName( int aMonth )
		{
			switch ( aMonth )
			{
				case 1: return "January";
				case 2: return "February";
				case 3: return "March";
				case 4: return "April";
				case 5: return "May";
				case 6: return "June";
				case 7: return "July";
				case 8: return "August";
				case 9: return "September";
				case 10: return "October";
				case 11: return "November";
				case 12: return "December";
				default: return "Error";
			}
		}

		#endregion
	
	}
}
