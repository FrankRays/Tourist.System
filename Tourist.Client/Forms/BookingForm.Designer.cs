namespace Tourist.Client.Forms
{
	partial class BookingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.BookablesTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.RoomsTab = new MetroFramework.Controls.MetroTabPage();
			this.RoomBookingsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.ActivitiesTab = new MetroFramework.Controls.MetroTabPage();
			this.ActivitiesBookingDataGrid = new MetroFramework.Controls.MetroGrid();
			this.A_BookingIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_ClientNifColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.A_ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.A_ActivityIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.A_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_BasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransportsTab = new MetroFramework.Controls.MetroTabPage();
			this.TransportBookingsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.T_BookingIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_ClientNifColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.T_ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.T_BookableIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.T_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_BasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_BookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.R_IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_ClientNifColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.R_ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.R_RoomIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.R_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_BasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_CheckInDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_CheckOutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.BookablesTabsControl.SuspendLayout();
			this.RoomsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsDataGrid)).BeginInit();
			this.ActivitiesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ActivitiesBookingDataGrid)).BeginInit();
			this.TransportsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TransportBookingsDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.BackPanel);
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 23);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 150);
			this.HeaderPanel.TabIndex = 14;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Client.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 34);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 89);
			this.BackPanel.TabIndex = 15;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.Bookings;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1049, 37);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(135, 86);
			this.ImagePanel.TabIndex = 13;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(106, 86);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(178, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Booking Services";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(98, 30);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(176, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Booking ";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.BookablesTabsControl);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 468);
			this.BodyPanel.TabIndex = 16;
			// 
			// BookablesTabsControl
			// 
			this.BookablesTabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BookablesTabsControl.Controls.Add(this.RoomsTab);
			this.BookablesTabsControl.Controls.Add(this.ActivitiesTab);
			this.BookablesTabsControl.Controls.Add(this.TransportsTab);
			this.BookablesTabsControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.BookablesTabsControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
			this.BookablesTabsControl.ItemSize = new System.Drawing.Size(150, 50);
			this.BookablesTabsControl.Location = new System.Drawing.Point(18, 12);
			this.BookablesTabsControl.Margin = new System.Windows.Forms.Padding(0);
			this.BookablesTabsControl.Name = "BookablesTabsControl";
			this.BookablesTabsControl.SelectedIndex = 0;
			this.BookablesTabsControl.Size = new System.Drawing.Size(1166, 446);
			this.BookablesTabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.BookablesTabsControl.TabIndex = 22;
			this.BookablesTabsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BookablesTabsControl.UseSelectable = true;
			// 
			// RoomsTab
			// 
			this.RoomsTab.Controls.Add(this.RoomBookingsDataGrid);
			this.RoomsTab.HorizontalScrollbarBarColor = true;
			this.RoomsTab.HorizontalScrollbarHighlightOnWheel = false;
			this.RoomsTab.HorizontalScrollbarSize = 8;
			this.RoomsTab.Location = new System.Drawing.Point(4, 54);
			this.RoomsTab.Margin = new System.Windows.Forms.Padding(2);
			this.RoomsTab.Name = "RoomsTab";
			this.RoomsTab.Size = new System.Drawing.Size(1158, 388);
			this.RoomsTab.TabIndex = 0;
			this.RoomsTab.Text = "ROOMS";
			this.RoomsTab.VerticalScrollbarBarColor = true;
			this.RoomsTab.VerticalScrollbarHighlightOnWheel = false;
			this.RoomsTab.VerticalScrollbarSize = 8;
			// 
			// RoomBookingsDataGrid
			// 
			this.RoomBookingsDataGrid.AllowUserToOrderColumns = true;
			this.RoomBookingsDataGrid.AllowUserToResizeColumns = false;
			this.RoomBookingsDataGrid.AllowUserToResizeRows = false;
			this.RoomBookingsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RoomBookingsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.RoomBookingsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.RoomBookingsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomBookingsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RoomBookingsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.RoomBookingsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.RoomBookingsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.RoomBookingsDataGrid.ColumnHeadersHeight = 60;
			this.RoomBookingsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.RoomBookingsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_IdColumn,
            this.R_ClientNifColumn,
            this.R_ClientNameColumn,
            this.R_TypeColumn,
            this.R_RoomIdColumn,
            this.R_DescriptionColumn,
            this.R_BasePriceColumn,
            this.R_BookingDateColumn,
            this.R_CheckInDateColumn,
            this.R_CheckOutColumn,
            this.R_TotalPriceColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomBookingsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.RoomBookingsDataGrid.EnableHeadersVisualStyles = false;
			this.RoomBookingsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.RoomBookingsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomBookingsDataGrid.Location = new System.Drawing.Point(2, 13);
			this.RoomBookingsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.RoomBookingsDataGrid.Name = "RoomBookingsDataGrid";
			this.RoomBookingsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomBookingsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.RoomBookingsDataGrid.RowHeadersWidth = 50;
			this.RoomBookingsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.RoomBookingsDataGrid.RowTemplate.Height = 25;
			this.RoomBookingsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.RoomBookingsDataGrid.Size = new System.Drawing.Size(1154, 379);
			this.RoomBookingsDataGrid.TabIndex = 21;
			// 
			// ActivitiesTab
			// 
			this.ActivitiesTab.Controls.Add(this.ActivitiesBookingDataGrid);
			this.ActivitiesTab.HorizontalScrollbarBarColor = true;
			this.ActivitiesTab.HorizontalScrollbarHighlightOnWheel = false;
			this.ActivitiesTab.HorizontalScrollbarSize = 8;
			this.ActivitiesTab.Location = new System.Drawing.Point(4, 54);
			this.ActivitiesTab.Margin = new System.Windows.Forms.Padding(2);
			this.ActivitiesTab.Name = "ActivitiesTab";
			this.ActivitiesTab.Size = new System.Drawing.Size(1158, 388);
			this.ActivitiesTab.TabIndex = 1;
			this.ActivitiesTab.Text = "ACTIVITIES";
			this.ActivitiesTab.VerticalScrollbarBarColor = true;
			this.ActivitiesTab.VerticalScrollbarHighlightOnWheel = false;
			this.ActivitiesTab.VerticalScrollbarSize = 8;
			// 
			// ActivitiesBookingDataGrid
			// 
			this.ActivitiesBookingDataGrid.AllowUserToOrderColumns = true;
			this.ActivitiesBookingDataGrid.AllowUserToResizeColumns = false;
			this.ActivitiesBookingDataGrid.AllowUserToResizeRows = false;
			this.ActivitiesBookingDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActivitiesBookingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ActivitiesBookingDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ActivitiesBookingDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ActivitiesBookingDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ActivitiesBookingDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ActivitiesBookingDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ActivitiesBookingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.ActivitiesBookingDataGrid.ColumnHeadersHeight = 60;
			this.ActivitiesBookingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ActivitiesBookingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_BookingIdColumn,
            this.A_ClientNifColumn,
            this.A_ClientNameColumn,
            this.A_TypeColumn,
            this.A_ActivityIdColumn,
            this.A_Description,
            this.A_BasePriceColumn,
            this.A_BookingDateColumn,
            this.A_StartDateColumn,
            this.A_EndDateColumn,
            this.A_TotalPrice});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ActivitiesBookingDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.ActivitiesBookingDataGrid.EnableHeadersVisualStyles = false;
			this.ActivitiesBookingDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ActivitiesBookingDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ActivitiesBookingDataGrid.Location = new System.Drawing.Point(2, 12);
			this.ActivitiesBookingDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.ActivitiesBookingDataGrid.Name = "ActivitiesBookingDataGrid";
			this.ActivitiesBookingDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ActivitiesBookingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.ActivitiesBookingDataGrid.RowHeadersWidth = 50;
			this.ActivitiesBookingDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ActivitiesBookingDataGrid.RowTemplate.Height = 25;
			this.ActivitiesBookingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ActivitiesBookingDataGrid.Size = new System.Drawing.Size(1154, 379);
			this.ActivitiesBookingDataGrid.TabIndex = 22;
			// 
			// A_BookingIdColumn
			// 
			this.A_BookingIdColumn.HeaderText = "Booking ID";
			this.A_BookingIdColumn.MinimumWidth = 150;
			this.A_BookingIdColumn.Name = "A_BookingIdColumn";
			this.A_BookingIdColumn.ReadOnly = true;
			this.A_BookingIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// A_ClientNifColumn
			// 
			this.A_ClientNifColumn.HeaderText = "Client Nif (*)";
			this.A_ClientNifColumn.MinimumWidth = 150;
			this.A_ClientNifColumn.Name = "A_ClientNifColumn";
			this.A_ClientNifColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// A_ClientNameColumn
			// 
			this.A_ClientNameColumn.HeaderText = "Client Name";
			this.A_ClientNameColumn.MinimumWidth = 200;
			this.A_ClientNameColumn.Name = "A_ClientNameColumn";
			this.A_ClientNameColumn.ReadOnly = true;
			// 
			// A_TypeColumn
			// 
			this.A_TypeColumn.HeaderText = "Type (*)";
			this.A_TypeColumn.MinimumWidth = 150;
			this.A_TypeColumn.Name = "A_TypeColumn";
			this.A_TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.A_TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// A_ActivityIdColumn
			// 
			this.A_ActivityIdColumn.HeaderText = "Activity ID";
			this.A_ActivityIdColumn.MinimumWidth = 150;
			this.A_ActivityIdColumn.Name = "A_ActivityIdColumn";
			this.A_ActivityIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.A_ActivityIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// A_Description
			// 
			this.A_Description.HeaderText = "Activity Description";
			this.A_Description.MinimumWidth = 200;
			this.A_Description.Name = "A_Description";
			// 
			// A_BasePriceColumn
			// 
			this.A_BasePriceColumn.HeaderText = "Base Price";
			this.A_BasePriceColumn.MinimumWidth = 110;
			this.A_BasePriceColumn.Name = "A_BasePriceColumn";
			this.A_BasePriceColumn.ReadOnly = true;
			// 
			// A_BookingDateColumn
			// 
			this.A_BookingDateColumn.HeaderText = "Booking Date";
			this.A_BookingDateColumn.MinimumWidth = 200;
			this.A_BookingDateColumn.Name = "A_BookingDateColumn";
			this.A_BookingDateColumn.ReadOnly = true;
			// 
			// A_StartDateColumn
			// 
			this.A_StartDateColumn.HeaderText = "Start - Date (*)";
			this.A_StartDateColumn.MinimumWidth = 200;
			this.A_StartDateColumn.Name = "A_StartDateColumn";
			this.A_StartDateColumn.ReadOnly = true;
			this.A_StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.A_StartDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// A_EndDateColumn
			// 
			this.A_EndDateColumn.HeaderText = "End - Date (*)";
			this.A_EndDateColumn.MinimumWidth = 200;
			this.A_EndDateColumn.Name = "A_EndDateColumn";
			this.A_EndDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.A_EndDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// A_TotalPrice
			// 
			this.A_TotalPrice.HeaderText = "Total Price";
			this.A_TotalPrice.MinimumWidth = 100;
			this.A_TotalPrice.Name = "A_TotalPrice";
			this.A_TotalPrice.ReadOnly = true;
			// 
			// TransportsTab
			// 
			this.TransportsTab.Controls.Add(this.TransportBookingsDataGrid);
			this.TransportsTab.HorizontalScrollbarBarColor = true;
			this.TransportsTab.HorizontalScrollbarHighlightOnWheel = false;
			this.TransportsTab.HorizontalScrollbarSize = 8;
			this.TransportsTab.Location = new System.Drawing.Point(4, 54);
			this.TransportsTab.Margin = new System.Windows.Forms.Padding(2);
			this.TransportsTab.Name = "TransportsTab";
			this.TransportsTab.Size = new System.Drawing.Size(1158, 388);
			this.TransportsTab.TabIndex = 2;
			this.TransportsTab.Text = "TRANSPORTS";
			this.TransportsTab.VerticalScrollbarBarColor = true;
			this.TransportsTab.VerticalScrollbarHighlightOnWheel = false;
			this.TransportsTab.VerticalScrollbarSize = 8;
			// 
			// TransportBookingsDataGrid
			// 
			this.TransportBookingsDataGrid.AllowUserToOrderColumns = true;
			this.TransportBookingsDataGrid.AllowUserToResizeColumns = false;
			this.TransportBookingsDataGrid.AllowUserToResizeRows = false;
			this.TransportBookingsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TransportBookingsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TransportBookingsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.TransportBookingsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TransportBookingsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TransportBookingsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.TransportBookingsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.TransportBookingsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.TransportBookingsDataGrid.ColumnHeadersHeight = 60;
			this.TransportBookingsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TransportBookingsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_BookingIdColumn,
            this.T_ClientNifColumn,
            this.T_ClientNameColumn,
            this.dataGridViewComboBoxColumn4,
            this.T_BookableIdColumn,
            this.T_Description,
            this.T_BasePriceColumn,
            this.T_BookingDate,
            this.T_StartDateColumn,
            this.T_EndDateColumn,
            this.T_TotalPriceColumn});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TransportBookingsDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
			this.TransportBookingsDataGrid.EnableHeadersVisualStyles = false;
			this.TransportBookingsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TransportBookingsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TransportBookingsDataGrid.Location = new System.Drawing.Point(2, 13);
			this.TransportBookingsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.TransportBookingsDataGrid.Name = "TransportBookingsDataGrid";
			this.TransportBookingsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TransportBookingsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.TransportBookingsDataGrid.RowHeadersWidth = 50;
			this.TransportBookingsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.TransportBookingsDataGrid.RowTemplate.Height = 25;
			this.TransportBookingsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TransportBookingsDataGrid.Size = new System.Drawing.Size(1154, 379);
			this.TransportBookingsDataGrid.TabIndex = 22;
			// 
			// T_BookingIdColumn
			// 
			this.T_BookingIdColumn.HeaderText = "Booking ID";
			this.T_BookingIdColumn.MinimumWidth = 150;
			this.T_BookingIdColumn.Name = "T_BookingIdColumn";
			this.T_BookingIdColumn.ReadOnly = true;
			this.T_BookingIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// T_ClientNifColumn
			// 
			this.T_ClientNifColumn.HeaderText = "Client Nif (*)";
			this.T_ClientNifColumn.MinimumWidth = 150;
			this.T_ClientNifColumn.Name = "T_ClientNifColumn";
			this.T_ClientNifColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// T_ClientNameColumn
			// 
			this.T_ClientNameColumn.HeaderText = "Client Name";
			this.T_ClientNameColumn.MinimumWidth = 200;
			this.T_ClientNameColumn.Name = "T_ClientNameColumn";
			this.T_ClientNameColumn.ReadOnly = true;
			// 
			// dataGridViewComboBoxColumn4
			// 
			this.dataGridViewComboBoxColumn4.HeaderText = "Type (*)";
			this.dataGridViewComboBoxColumn4.MinimumWidth = 150;
			this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
			this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// T_BookableIdColumn
			// 
			this.T_BookableIdColumn.HeaderText = "Transport ID";
			this.T_BookableIdColumn.MinimumWidth = 150;
			this.T_BookableIdColumn.Name = "T_BookableIdColumn";
			this.T_BookableIdColumn.ReadOnly = true;
			this.T_BookableIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.T_BookableIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// T_Description
			// 
			this.T_Description.HeaderText = "Transport Description";
			this.T_Description.MinimumWidth = 200;
			this.T_Description.Name = "T_Description";
			// 
			// T_BasePriceColumn
			// 
			this.T_BasePriceColumn.HeaderText = "Base Price";
			this.T_BasePriceColumn.MinimumWidth = 110;
			this.T_BasePriceColumn.Name = "T_BasePriceColumn";
			this.T_BasePriceColumn.ReadOnly = true;
			// 
			// T_BookingDate
			// 
			this.T_BookingDate.HeaderText = "Booking Date";
			this.T_BookingDate.MinimumWidth = 200;
			this.T_BookingDate.Name = "T_BookingDate";
			this.T_BookingDate.ReadOnly = true;
			// 
			// T_StartDateColumn
			// 
			this.T_StartDateColumn.HeaderText = "Start - Date (*)";
			this.T_StartDateColumn.MinimumWidth = 200;
			this.T_StartDateColumn.Name = "T_StartDateColumn";
			this.T_StartDateColumn.ReadOnly = true;
			this.T_StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.T_StartDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// T_EndDateColumn
			// 
			this.T_EndDateColumn.HeaderText = "End - Date (*)";
			this.T_EndDateColumn.MinimumWidth = 200;
			this.T_EndDateColumn.Name = "T_EndDateColumn";
			this.T_EndDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.T_EndDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// T_TotalPriceColumn
			// 
			this.T_TotalPriceColumn.HeaderText = "Total Price";
			this.T_TotalPriceColumn.MinimumWidth = 100;
			this.T_TotalPriceColumn.Name = "T_TotalPriceColumn";
			this.T_TotalPriceColumn.ReadOnly = true;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(-1, 649);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1202, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// R_IdColumn
			// 
			this.R_IdColumn.HeaderText = "Booking ID";
			this.R_IdColumn.MinimumWidth = 150;
			this.R_IdColumn.Name = "R_IdColumn";
			this.R_IdColumn.ReadOnly = true;
			this.R_IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// R_ClientNifColumn
			// 
			this.R_ClientNifColumn.HeaderText = "Client Nif (*)";
			this.R_ClientNifColumn.MinimumWidth = 150;
			this.R_ClientNifColumn.Name = "R_ClientNifColumn";
			this.R_ClientNifColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// R_ClientNameColumn
			// 
			this.R_ClientNameColumn.HeaderText = "Client Name";
			this.R_ClientNameColumn.MinimumWidth = 200;
			this.R_ClientNameColumn.Name = "R_ClientNameColumn";
			this.R_ClientNameColumn.ReadOnly = true;
			// 
			// R_TypeColumn
			// 
			this.R_TypeColumn.HeaderText = "Type (*)";
			this.R_TypeColumn.Items.AddRange(new object[] {
            "Single",
            "DoubleSingle",
            "Double",
            "Suite",
            "FamilySuite",
            "Meeting"});
			this.R_TypeColumn.MinimumWidth = 150;
			this.R_TypeColumn.Name = "R_TypeColumn";
			this.R_TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.R_TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// R_RoomIdColumn
			// 
			this.R_RoomIdColumn.HeaderText = "Room ID (*)";
			this.R_RoomIdColumn.MinimumWidth = 150;
			this.R_RoomIdColumn.Name = "R_RoomIdColumn";
			this.R_RoomIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.R_RoomIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// R_DescriptionColumn
			// 
			this.R_DescriptionColumn.HeaderText = "Room Description";
			this.R_DescriptionColumn.MinimumWidth = 200;
			this.R_DescriptionColumn.Name = "R_DescriptionColumn";
			this.R_DescriptionColumn.ReadOnly = true;
			// 
			// R_BasePriceColumn
			// 
			this.R_BasePriceColumn.HeaderText = "Base Price";
			this.R_BasePriceColumn.MinimumWidth = 110;
			this.R_BasePriceColumn.Name = "R_BasePriceColumn";
			this.R_BasePriceColumn.ReadOnly = true;
			// 
			// R_BookingDateColumn
			// 
			this.R_BookingDateColumn.HeaderText = "Booking Date";
			this.R_BookingDateColumn.MinimumWidth = 200;
			this.R_BookingDateColumn.Name = "R_BookingDateColumn";
			this.R_BookingDateColumn.ReadOnly = true;
			// 
			// R_CheckInDateColumn
			// 
			this.R_CheckInDateColumn.HeaderText = "Check-In-Date (*)";
			this.R_CheckInDateColumn.MinimumWidth = 175;
			this.R_CheckInDateColumn.Name = "R_CheckInDateColumn";
			this.R_CheckInDateColumn.ReadOnly = true;
			this.R_CheckInDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.R_CheckInDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// R_CheckOutColumn
			// 
			this.R_CheckOutColumn.HeaderText = "Check-Out-Date (*)";
			this.R_CheckOutColumn.MinimumWidth = 175;
			this.R_CheckOutColumn.Name = "R_CheckOutColumn";
			this.R_CheckOutColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.R_CheckOutColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// R_TotalPriceColumn
			// 
			this.R_TotalPriceColumn.HeaderText = "Total Price";
			this.R_TotalPriceColumn.MinimumWidth = 100;
			this.R_TotalPriceColumn.Name = "R_TotalPriceColumn";
			this.R_TotalPriceColumn.ReadOnly = true;
			// 
			// BookingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1200, 800);
			this.Name = "BookingsForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.BookingsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.BookablesTabsControl.ResumeLayout(false);
			this.RoomsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsDataGrid)).EndInit();
			this.ActivitiesTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ActivitiesBookingDataGrid)).EndInit();
			this.TransportsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TransportBookingsDataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel BackPanel;
		private MetroFramework.Controls.MetroGrid RoomBookingsDataGrid;
		private MetroFramework.Controls.MetroTabControl BookablesTabsControl;
		private MetroFramework.Controls.MetroTabPage RoomsTab;
		private MetroFramework.Controls.MetroTabPage ActivitiesTab;
		private MetroFramework.Controls.MetroGrid ActivitiesBookingDataGrid;
		private MetroFramework.Controls.MetroTabPage TransportsTab;
		private MetroFramework.Controls.MetroGrid TransportBookingsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_BookingIdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn A_ClientNifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_ClientNameColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn A_TypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn A_ActivityIdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_BasePriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_BookingDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_StartDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_EndDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_TotalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_BookingIdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn T_ClientNifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_ClientNameColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
		private System.Windows.Forms.DataGridViewComboBoxColumn T_BookableIdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_BasePriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_BookingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_StartDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_EndDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_TotalPriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn R_ClientNifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_ClientNameColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn R_TypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn R_RoomIdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_BasePriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_BookingDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_CheckInDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_CheckOutColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_TotalPriceColumn;

	}
}