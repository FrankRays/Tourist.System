using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Enums;
using Tourist.Data.Shared;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm : MetroForm
	{
		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private bool mBackOrExit = default( bool );

		public ClientsForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			
			IdColumn.DataPropertyName = "Id";
			FirstNameColumn.DataPropertyName = "FirstName";
			LastNameColumn.DataPropertyName = "LastName";
			GenderColumn.DataPropertyName = "Gender";
			NifColumn.DataPropertyName = "Nif";
			AddressColumn.DataPropertyName = "Address";
			PhoneColumn.DataPropertyName = "Phone";
			EmailColumn.DataPropertyName = "Email";

		}

		private void ClientsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen(this);
			LoadDataToGrid();
			
		}

		private void LoadDataToGrid( )
		{
			if ( Repository.IsEmpty( "Clients" ) )
				return;

			var clientsMatrix = Repository.ListToMatrix( "Clients" );

			for ( var i = 0 ; i < Repository.Count( "Clients" ) ; i++ )
			{
				ClientsDataGrid.Rows.Add( );

				for ( var j = 0 ; j < ClientsDataGrid.ColumnCount ; j++ )
				{
					ClientsDataGrid.Rows[ i ].Cells[ j ].Value = clientsMatrix[ i, j ];
				}
			}
		}

		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MetroMessageBox.Show( this, "\n Are you sure you want to exit the application?",
				"Close Button Pressed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

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
	}
}
