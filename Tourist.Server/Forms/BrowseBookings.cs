using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;
using Tourist.Data.Shared;
using Tourist.Server.Properties;

namespace Tourist.Server.Forms
{
	public partial class BrowseBookings : MetroForm
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
			BookingsDataGrid.DataSource = null;
			BookingsDataGrid.DataSource = bindingSource;
		}

		#endregion

		#region Constructor
		
		public BrowseBookings( Form aForm )
		{
			InitializeComponent( );
			mMainForm = aForm as MainForm;
			bindingSource = new BindingSource( );
			mBackOrExit = default( bool );
			UpdateDataGrid = RefreshDataGrid;
		}

		#endregion

		#region Events

		private void DisponibilityForm_Load( object sender, EventArgs e )
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
				if ( BookingsDataGrid.InvokeRequired )
				{
					BookingsDataGrid.Invoke( UpdateDataGrid );
				}
			}
			if ( e.Action == NotifyCollectionChangedAction.Replace )
			{
				if ( BookingsDataGrid.InvokeRequired )
				{
					BookingsDataGrid.Invoke( UpdateDataGrid );
				}
			}
			if ( e.Action == NotifyCollectionChangedAction.Remove )
			{
				if ( BookingsDataGrid.InvokeRequired )
				{
					BookingsDataGrid.Invoke( UpdateDataGrid );
				}
			}
			if ( e.Action == NotifyCollectionChangedAction.Reset )
			{
				if ( BookingsDataGrid.InvokeRequired )
				{
					BookingsDataGrid.Invoke( UpdateDataGrid );
				}
			}
		}
		
		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			if ( mBackOrExit ) return;

			base.OnFormClosing( e );

			var dialogResult = MessageBox.Show( this, Resources.ExitMessage,
				Resources.ExitMessageTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk );

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
			BookingsDataGridProperties( );
			//bind column with object properties
			BindDataProperties( );
			//bind data do grid
			bindingSource.DataSource = Repository.MData.Bookings;
			BookingsDataGrid.DataSource = bindingSource;
		}

		private void BindDataProperties( )
		{
			BookingIdColumn.DataPropertyName = "Id";
			ClientNifColumn.DataPropertyName = "ClientNif";
			ClientNameColumn.DataPropertyName = "ClientName";
			TypeColumn.DataPropertyName = "BookableType";
			SubTypeColumn.DataPropertyName = "BookableSubType";
			//BookableIdColumn.DataPropertyName = "BookableId";
			BookableDescriptionColumn.DataPropertyName = "BookableDescription";
			BasePriceColumn.DataPropertyName = "BookableBasePrice";
			BookingDateColumn.DataPropertyName = "BookingDay";
			StartDateColumn.DataPropertyName = "BookingStartDate";
			EndDateColumn.DataPropertyName = "BookingEndDate";
			TotalPriceColumn.DataPropertyName = "BookingTotalPrice";
		}

		private void BookingsDataGridProperties( )
		{
			//gridproperties
			BookingsDataGrid.ReadOnly = true;
			BookingsDataGrid.AutoGenerateColumns = false;
			BookingsDataGrid.AllowUserToAddRows = false;
			BookingsDataGrid.AllowUserToDeleteRows = false;
			BookingsDataGrid.AllowUserToOrderColumns = true;
			BookingsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			BookingsDataGrid.MultiSelect = false;
			BookingsDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			BookingsDataGrid.AllowUserToResizeColumns = false;
			BookingsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			BookingsDataGrid.AllowUserToResizeRows = false;
			BookingsDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		}

		#endregion

	}
}
