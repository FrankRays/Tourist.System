using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Tourist.Data.Enums;
using Tourist.Data.Interfaces;
using Tourist.Data.Shared;


namespace Tourist.Client.Forms
{
	public partial class ClientsForm : MetroForm
	{

		#region Fields

		private readonly IRemote Remote;
		private readonly MainForm mMainForm;
		private readonly MetroDateTime mDateTimePicker;
		private bool mBackOrExit = default( bool );

		#endregion

		#region  Constructor

		public ClientsForm( Form aForm, IRemote aRemote )
		{
			InitializeComponent( );
			Remote = aRemote;
			mMainForm = aForm as MainForm;
			mDateTimePicker = new MetroDateTime( );
		}

		#endregion

		#region Events

		private void ClientsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
		}

		private void ClientsDataGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
		{

			var row = ClientsDataGrid.Rows[ e.RowIndex ];
			var clientIndex = e.RowIndex;
			int clientId;

			if ( clientIndex <= Remote.Count( "Clients" ) - 1 )
				clientId = Remote.GetId( clientIndex, "Clients" );
			else
				clientId = Remote.NextId( "Client" );

			ClientsDataGrid[ "IdColumn", e.RowIndex ].Value = clientId;
			var isRowValidated = SharedMethods.RowCellsValidated( row );

			if ( isRowValidated )
			{
				if ( !Remote.ExistingId( clientId, "Clients" ) )
				{
					var rowValues = SharedMethods.RowCellValues( row );
					AddToRepository( rowValues );
					MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.AddString,
					Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else
				{
					var aNewValue = e.FormattedValue.ToString( );

					switch ( e.ColumnIndex )
					{
						//FirstName
						case 1:
							Remote.Edit( "Client", clientId, "FirstName", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.FirstNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//LastName	
						case 2:
							Remote.Edit( "Client", clientId, "LastName", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.LastNameEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Gender	
						case 3:
							Remote.Edit( "Client", clientId, "Gender", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.GenderEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nationality
						case 4:
							Remote.Edit( "Client", clientId, "Nationality", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.NationalityEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//BirthDate
						case 5:
							Remote.Edit( "Client", clientId, "BirthDate", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.BirthDateEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Nif
						case 6:
							Remote.Edit( "Client", clientId, "Nif", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.NifEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Address
						case 7:
							Remote.Edit( "Client", clientId, "Address", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.AddressEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Phone
						case 8:
							Remote.Edit( "Client", clientId, "Phone", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.PhoneEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						//Email
						case 9:
							Remote.Edit( "Client", clientId, "Email", aNewValue );
							MessageBox.Show( this, Properties.Resources.ClientString + Properties.Resources.EmailEdited,
							Properties.Resources.OperationSucessfull, MessageBoxButtons.OK, MessageBoxIcon.Information );
							return;
						default:
							return;
					}
				}
			}
		}

		private void ClientsDataGrid_RowRemoved( object sender, DataGridViewRowsRemovedEventArgs e )
		{

			var dialog = MessageBox.Show( this, Properties.Resources.RemoveString,
			Properties.Resources.RemoveTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information );

			if (dialog == DialogResult.No)
			{
				ReLoadDataToGrid();
				return;
			}
				
			var removeIndex = e.RowIndex;

			Remote.Remove( removeIndex, "Clients" );

		}

		private void ClientsDataGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			if ( e.ColumnIndex >= 0 && e.RowIndex >= 0 )
			{
				var cell = ClientsDataGrid[ e.ColumnIndex, e.RowIndex ];
				ClientsDataGrid.CurrentCell = cell;
				ClientsDataGrid.BeginEdit( true );
			}
		}

		private void ClientsDataGrid_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			//BirthDateColumn
			if ( e.ColumnIndex == 5 )
			{
				ClientsDataGrid.Controls.Add( mDateTimePicker );
				mDateTimePicker.Format = DateTimePickerFormat.Short;
				var aRectangle = ClientsDataGrid.GetCellDisplayRectangle( e.ColumnIndex, e.RowIndex, true );
				mDateTimePicker.Size = new Size( aRectangle.Width, aRectangle.Height );
				mDateTimePicker.Location = new Point( aRectangle.X, aRectangle.Y );
				mDateTimePicker.CloseUp += oDateTimePicker_CloseUp;
				mDateTimePicker.TextChanged += dateTimePicker_OnTextChange;
				mDateTimePicker.Visible = true;
			}
		}

		private void dateTimePicker_OnTextChange( object sender, EventArgs e )
		{
			// Saving the 'Selected Date on Calendar' into DataGridView current cell  
			ClientsDataGrid.CurrentCell.Value = mDateTimePicker.Text;
		}

		private void oDateTimePicker_CloseUp( object sender, EventArgs e )
		{
			// Hiding the control after use   
			mDateTimePicker.Visible = false;
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, Properties.Resources.ExitMessage,
			Properties.Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

			if ( e.CloseReason == CloseReason.WindowsShutDown ) return;

			if ( dialogResult == DialogResult.No )
				e.Cancel = true;
			else
				Process.GetCurrentProcess( ).Kill( );
		}

		private void BackPanel_MouseClick( object sender, MouseEventArgs e )
		{
			mBackOrExit = true;
			Close( );
			mMainForm.Show( );
		}

		#endregion

		#region Private Methods

		private void LoadDataToGrid( )
		{
			if ( Remote.IsEmpty( "Clients" ) )
				return;

			var clientsMatrix = Remote.ListToMatrix( "Clients" );

			for ( var i = 0 ; i < Remote.Count( "Clients" ) ; i++ )
			{
				ClientsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ClientsDataGrid.ColumnCount ; j++ )
				{
					ClientsDataGrid.Rows[ i ].Cells[ j ].Value = clientsMatrix[ i, j ];
				}
			}
		}

		private void ReLoadDataToGrid(  )
		{
			SharedMethods.ClearDataGrid( ClientsDataGrid);
			LoadDataToGrid( );
		}

		private void AddToRepository( List<string> rowValues )
		{
			var client = Remote.Factory.CreateObject<Data.Classes.Client>( );

			client.Id = SharedMethods.ConvertStringToInt( rowValues[ 0 ] );
			client.FirstName = rowValues[ 1 ];
			client.LastName = rowValues[ 2 ];
			client.Gender = ( Gender ) SharedMethods.ConvertStringToEnum( rowValues[ 3 ], "Gender" );
			client.Nationality = rowValues[ 4 ];
			client.BirthDate = SharedMethods.ConvertStringToDateTime( rowValues[ 5 ] );
			client.Nif = SharedMethods.ConvertStringToInt( rowValues[ 6 ] );
			client.Address = rowValues[ 7 ];
			client.Phone = SharedMethods.ConvertStringToInt( rowValues[ 8 ] );
			client.Email = rowValues[ 9 ];

			Remote.Append( client, "Clients" );
		}

		#endregion

	}
}