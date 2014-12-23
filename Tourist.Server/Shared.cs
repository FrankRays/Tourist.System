using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Tourist.Data.Interfaces;

namespace Tourist.Server
{
	public static class Shared
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
				var addr = new MailAddress( aEmail );
				
				return true;
			}
			catch ( FormatException )
			{
				Console.WriteLine( "'{0}' is not a valid email address.", aEmail );
				return false;
			}
		}

		public static int ConvertStringToInt(string aInt)
		{
			try
			{
				var convertedInt = Convert.ToInt32( aInt );

				return convertedInt;
			}
			catch ( FormatException )
			{
				Console.WriteLine( "'{0}' is not a integer.", aInt );
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
				Console.WriteLine( "'{0}' is not in the proper format.", aDate );
			}

			return new DateTime( );
		}

		public static Enum ConvertStringToEnum(string aEnum, string aEnumType)
		{
			switch (aEnumType)
			{
				case "EntityType":
						try
						{
							return ( EnumEntityType ) Enum.Parse( typeof( EnumEntityType ), aEnum );
						}
						catch ( Exception )
						{
							Console.WriteLine( "'{0}' is not a Enum.", aEnumType );
							return null;
						}
				case "Gender":
						try
						{
							return ( Gender ) Enum.Parse( typeof( Gender ), aEnum );
						}
						catch ( Exception )
						{
							Console.WriteLine( "'{0}' is not a Enum.", aEnumType );
							return null;
						}
				case "BookableState":
						try
						{
							return ( BookableState ) Enum.Parse( typeof( BookableState ), aEnum );
						}
						catch ( Exception )
						{
							Console.WriteLine( "'{0}' is not a Enum.", aEnumType );
							return null;
						}
				default :
					return null;
			}
		}


		public static void CellErrorRemove( DataGridViewCell aCell )
		{
			aCell.ErrorText = string.Empty;
		}

		public static List<string> RowCellValues( DataGridViewRow rows )
		{
			var rowCellValues = new List<string>();

			for ( int i = 0 ; i < rows.Cells.Count ; i++ )
			{
				rowCellValues.Add(rows.Cells[ i ].EditedFormattedValue.ToString( ));
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
				if ( aRow.Cells[ i ].EditedFormattedValue.ToString( ).Length == 0 )
				{
					aRow.Cells[ i ].ErrorText = "This Cell can´t be empty!";

					cellHasError[ i - 1 ] = true;
				}
				else
				{
					CellErrorRemove( aRow.Cells[ i ] );
				}
			}

			if ( aRow.Cells[ "NifColumn" ].Value != null )
			{
				if ( !IsNumeric( aRow.Cells[ "NifColumn" ].EditedFormattedValue.ToString( ) ) )
				{
					aRow.Cells[ "NifColumn" ].ErrorText = "The Nif has only numbers!";
					return false;
				}

				CellErrorRemove( aRow.Cells[ "NifColumn" ] );
			}

			if ( aRow.Cells[ "PhoneColumn" ].Value != null )
			{
				if ( !IsNumeric( aRow.Cells[ "PhoneColumn" ].EditedFormattedValue.ToString( ) ) )
				{
					aRow.Cells[ "PhoneColumn" ].ErrorText = "The Phone has only numbers !";
					return false;
				}

				CellErrorRemove( aRow.Cells[ "PhoneColumn" ] );
			}


			return !cellHasError.Any( bolean => bolean );
		}

		#endregion

	}
}
