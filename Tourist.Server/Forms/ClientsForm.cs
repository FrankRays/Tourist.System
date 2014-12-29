using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tourist.Data.Shared;

namespace Tourist.Server.Forms
{
	public partial class ClientsForm : MetroForm
	{

		#region Fields

		private readonly Repository Repository = Repository.Instance;
		private readonly MainForm mMainForm;
		private readonly BindingSource bindingSource;
		private bool mBackOrExit;

		#endregion

		#region Delegates Ui Update
		
		public delegate void UpdateDataGridView( ); // delegate type 
		public UpdateDataGridView UpdateDataGrid; // delegate object

		public void RefreshDataGrid( )
		{
			ClientsDataGrid.DataSource = null;
			ClientsDataGrid.DataSource = bindingSource;
		}

		#endregion

		#region Constructor
		
		public ClientsForm( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			bindingSource = new BindingSource( );
			mBackOrExit = default( bool );
			UpdateDataGrid = RefreshDataGrid;
		}

		#endregion

		#region Events

		private void ClientsForm_Load( object sender, EventArgs e )
		{
			SharedMethods.SetFormFullScreen( this );
			LoadDataToGrid( );
			Repository.MData.Clients.CollectionChanged += OnCollectionChange;
		}

		private void OnCollectionChange( object sender, NotifyCollectionChangedEventArgs e )
		{
			//different kind of changes that may have occurred in collection
			if ( e.Action == NotifyCollectionChangedAction.Add )
			{
				if (ClientsDataGrid.InvokeRequired)
				{
					ClientsDataGrid.Invoke(UpdateDataGrid);
				}
			}
			if ( e.Action == NotifyCollectionChangedAction.Replace )
			{
				if ( ClientsDataGrid.InvokeRequired )
				{
					ClientsDataGrid.Invoke( UpdateDataGrid );
				}
			}
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				if (ClientsDataGrid.InvokeRequired)
				{
					ClientsDataGrid.Invoke(UpdateDataGrid);
				}
			}
			if ( e.Action == NotifyCollectionChangedAction.Reset)
			{
				if (ClientsDataGrid.InvokeRequired)
				{
					ClientsDataGrid.Invoke(UpdateDataGrid);
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

		#endregion

		#region Private Methods

		private void LoadDataToGrid( )
		{
			ClientsDataGridProperties( );
			//bind column with object properties
			BindDataProperties( );
			//bind data do grid
			bindingSource.DataSource = Repository.MData.Clients;
			ClientsDataGrid.DataSource = bindingSource;
		}

		private void BindDataProperties( )
		{
			IdColumn.DataPropertyName = "Id";
			FirstNameColumn.DataPropertyName = "FirstName";
			LastNameColumn.DataPropertyName = "LastName";
			GenderColumn.DataPropertyName = "Gender";
			NationalityColumn.DataPropertyName = "Nationality";
			BirthDateColumn.DataPropertyName = "BirthDate";
			NifColumn.DataPropertyName = "Nif";
			AddressColumn.DataPropertyName = "Address";
			PhoneColumn.DataPropertyName = "Phone";
			EmailColumn.DataPropertyName = "Email";
		}

		private void ClientsDataGridProperties( )
		{
			//gridproperties
			ClientsDataGrid.ReadOnly = true;
			ClientsDataGrid.AutoGenerateColumns = false;
			ClientsDataGrid.AllowUserToAddRows = false;
			ClientsDataGrid.AllowUserToDeleteRows = false;
			ClientsDataGrid.AllowUserToOrderColumns = true;
			ClientsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			ClientsDataGrid.MultiSelect = false;
			ClientsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			ClientsDataGrid.AllowUserToResizeColumns = false;
			ClientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			ClientsDataGrid.AllowUserToResizeRows = false;
			ClientsDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		}

		#endregion

	}
}
