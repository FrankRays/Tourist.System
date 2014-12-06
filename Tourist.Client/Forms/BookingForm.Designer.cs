namespace Tourist.Client.Forms
{
	partial class BookingForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.ClientsTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.Rooms = new MetroFramework.Controls.MetroTabPage();
			this.RoomBookingsGrid = new MetroFramework.Controls.MetroGrid();
			this.ClientsTile = new MetroFramework.Controls.MetroTile();
			this.BookingsTile = new MetroFramework.Controls.MetroTile();
			this.Actitivities = new MetroFramework.Controls.MetroTabPage();
			this.Transports = new MetroFramework.Controls.MetroTabPage();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.FowardPanel = new System.Windows.Forms.Panel();
			this.HomePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ClientIDHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirthHearder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GenderHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CityHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FiscalNumberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContactNumberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastReservationHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumberOfReservationsHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.ClientsTabsControl.SuspendLayout();
			this.Rooms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsGrid)).BeginInit();
			this.GroupSearch.SuspendLayout();
			this.FooterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.panel2);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 28);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1922, 150);
			this.HeaderPanel.TabIndex = 14;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.clients;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1694, 28);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(204, 92);
			this.ImagePanel.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(562, 153);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 32);
			this.panel2.TabIndex = 11;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(32, 82);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(226, 38);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Booking Services";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(23, 3);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(223, 65);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Booking ";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.dateTimePicker1);
			this.BodyPanel.Controls.Add(this.ClientsTabsControl);
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 184);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1922, 681);
			this.BodyPanel.TabIndex = 16;
			// 
			// ClientsTabsControl
			// 
			this.ClientsTabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsTabsControl.Controls.Add(this.Rooms);
			this.ClientsTabsControl.Controls.Add(this.Actitivities);
			this.ClientsTabsControl.Controls.Add(this.Transports);
			this.ClientsTabsControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.ClientsTabsControl.ItemSize = new System.Drawing.Size(150, 50);
			this.ClientsTabsControl.Location = new System.Drawing.Point(305, 17);
			this.ClientsTabsControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.ClientsTabsControl.Name = "ClientsTabsControl";
			this.ClientsTabsControl.SelectedIndex = 0;
			this.ClientsTabsControl.Size = new System.Drawing.Size(1593, 651);
			this.ClientsTabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.ClientsTabsControl.TabIndex = 0;
			this.ClientsTabsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClientsTabsControl.UseSelectable = true;
			// 
			// Rooms
			// 
			this.Rooms.Controls.Add(this.RoomBookingsGrid);
			this.Rooms.Controls.Add(this.ClientsTile);
			this.Rooms.Controls.Add(this.BookingsTile);
			this.Rooms.HorizontalScrollbarBarColor = true;
			this.Rooms.HorizontalScrollbarHighlightOnWheel = false;
			this.Rooms.HorizontalScrollbarSize = 10;
			this.Rooms.Location = new System.Drawing.Point(4, 54);
			this.Rooms.Name = "Rooms";
			this.Rooms.Size = new System.Drawing.Size(1585, 593);
			this.Rooms.TabIndex = 0;
			this.Rooms.Text = "Rooms";
			this.Rooms.VerticalScrollbarBarColor = true;
			this.Rooms.VerticalScrollbarHighlightOnWheel = false;
			this.Rooms.VerticalScrollbarSize = 10;
			// 
			// RoomBookingsGrid
			// 
			this.RoomBookingsGrid.AllowUserToResizeRows = false;
			this.RoomBookingsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomBookingsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RoomBookingsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.RoomBookingsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RoomBookingsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.RoomBookingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.RoomBookingsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIDHeader,
            this.ClientNameHeader,
            this.DateOfBirthHearder,
            this.GenderHeader,
            this.CityHeader,
            this.FiscalNumberHeader,
            this.ContactNumberHeader,
            this.LastReservationHeader,
            this.NumberOfReservationsHeader});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomBookingsGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.RoomBookingsGrid.EnableHeadersVisualStyles = false;
			this.RoomBookingsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.RoomBookingsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomBookingsGrid.Location = new System.Drawing.Point(3, 44);
			this.RoomBookingsGrid.Name = "RoomBookingsGrid";
			this.RoomBookingsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RoomBookingsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.RoomBookingsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.RoomBookingsGrid.RowTemplate.Height = 24;
			this.RoomBookingsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.RoomBookingsGrid.Size = new System.Drawing.Size(1579, 443);
			this.RoomBookingsGrid.TabIndex = 5;
			// 
			// ClientsTile
			// 
			this.ClientsTile.ActiveControl = null;
			this.ClientsTile.Location = new System.Drawing.Point(129, 3);
			this.ClientsTile.Name = "ClientsTile";
			this.ClientsTile.Size = new System.Drawing.Size(120, 25);
			this.ClientsTile.TabIndex = 4;
			this.ClientsTile.Text = "x Remove";
			this.ClientsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ClientsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ClientsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.ClientsTile.UseSelectable = true;
			this.ClientsTile.UseTileImage = true;
			// 
			// BookingsTile
			// 
			this.BookingsTile.ActiveControl = null;
			this.BookingsTile.Location = new System.Drawing.Point(3, 3);
			this.BookingsTile.Name = "BookingsTile";
			this.BookingsTile.Size = new System.Drawing.Size(120, 25);
			this.BookingsTile.TabIndex = 3;
			this.BookingsTile.Text = " + Add";
			this.BookingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BookingsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.BookingsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.BookingsTile.UseSelectable = true;
			// 
			// Actitivities
			// 
			this.Actitivities.HorizontalScrollbarBarColor = true;
			this.Actitivities.HorizontalScrollbarHighlightOnWheel = false;
			this.Actitivities.HorizontalScrollbarSize = 10;
			this.Actitivities.Location = new System.Drawing.Point(4, 54);
			this.Actitivities.Name = "Actitivities";
			this.Actitivities.Size = new System.Drawing.Size(1585, 593);
			this.Actitivities.TabIndex = 1;
			this.Actitivities.Text = "Activities";
			this.Actitivities.VerticalScrollbarBarColor = true;
			this.Actitivities.VerticalScrollbarHighlightOnWheel = false;
			this.Actitivities.VerticalScrollbarSize = 10;
			// 
			// Transports
			// 
			this.Transports.HorizontalScrollbarBarColor = true;
			this.Transports.HorizontalScrollbarHighlightOnWheel = false;
			this.Transports.HorizontalScrollbarSize = 10;
			this.Transports.Location = new System.Drawing.Point(4, 54);
			this.Transports.Name = "Transports";
			this.Transports.Size = new System.Drawing.Size(1585, 593);
			this.Transports.TabIndex = 2;
			this.Transports.Text = "Transports";
			this.Transports.VerticalScrollbarBarColor = true;
			this.Transports.VerticalScrollbarHighlightOnWheel = false;
			this.Transports.VerticalScrollbarSize = 10;
			// 
			// GroupSearch
			// 
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Controls.Add(this.textBox1);
			this.GroupSearch.Controls.Add(this.metroComboBox1);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(24, 17);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Size = new System.Drawing.Size(263, 193);
			this.GroupSearch.TabIndex = 12;
			this.GroupSearch.TabStop = false;
			this.GroupSearch.Text = "Search ";
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(16, 131);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(234, 39);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(16, 79);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 38);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = " Search";
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 24;
			this.metroComboBox1.Location = new System.Drawing.Point(16, 36);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(234, 30);
			this.metroComboBox1.TabIndex = 9;
			this.metroComboBox1.UseSelectable = true;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Controls.Add(this.FowardPanel);
			this.FooterPanel.Controls.Add(this.HomePanel);
			this.FooterPanel.Controls.Add(this.BackPanel);
			this.FooterPanel.Location = new System.Drawing.Point(-1, 871);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1922, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// FowardPanel
			// 
			this.FowardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FowardPanel.BackgroundImage = global::Tourist.Client.Properties.Resources.RightArrow;
			this.FowardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.FowardPanel.Location = new System.Drawing.Point(1815, 17);
			this.FowardPanel.Name = "FowardPanel";
			this.FowardPanel.Size = new System.Drawing.Size(83, 117);
			this.FowardPanel.TabIndex = 1;
			// 
			// HomePanel
			// 
			this.HomePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.HomePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.Home;
			this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.HomePanel.Location = new System.Drawing.Point(959, 17);
			this.HomePanel.Name = "HomePanel";
			this.HomePanel.Size = new System.Drawing.Size(130, 117);
			this.HomePanel.TabIndex = 2;
			// 
			// BackPanel
			// 
			this.BackPanel.BackgroundImage = global::Tourist.Client.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(24, 17);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(85, 117);
			this.BackPanel.TabIndex = 3;
			// 
			// ClientIDHeader
			// 
			this.ClientIDHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ClientIDHeader.HeaderText = "Client ID";
			this.ClientIDHeader.Name = "ClientIDHeader";
			this.ClientIDHeader.Width = 121;
			// 
			// ClientNameHeader
			// 
			this.ClientNameHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ClientNameHeader.HeaderText = "Client Name";
			this.ClientNameHeader.Name = "ClientNameHeader";
			this.ClientNameHeader.Width = 158;
			// 
			// DateOfBirthHearder
			// 
			this.DateOfBirthHearder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.DateOfBirthHearder.HeaderText = "Date Of Birth";
			this.DateOfBirthHearder.Name = "DateOfBirthHearder";
			this.DateOfBirthHearder.Width = 166;
			// 
			// GenderHeader
			// 
			this.GenderHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.GenderHeader.HeaderText = "Gender";
			this.GenderHeader.Name = "GenderHeader";
			this.GenderHeader.Width = 119;
			// 
			// CityHeader
			// 
			this.CityHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.CityHeader.HeaderText = "City";
			this.CityHeader.Name = "CityHeader";
			this.CityHeader.Width = 79;
			// 
			// FiscalNumberHeader
			// 
			this.FiscalNumberHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.FiscalNumberHeader.HeaderText = "Fiscal Number";
			this.FiscalNumberHeader.Name = "FiscalNumberHeader";
			this.FiscalNumberHeader.Width = 179;
			// 
			// ContactNumberHeader
			// 
			this.ContactNumberHeader.HeaderText = "Contact Number";
			this.ContactNumberHeader.Name = "ContactNumberHeader";
			this.ContactNumberHeader.Width = 120;
			// 
			// LastReservationHeader
			// 
			this.LastReservationHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.LastReservationHeader.HeaderText = "Last Reservation";
			this.LastReservationHeader.Name = "LastReservationHeader";
			this.LastReservationHeader.Width = 198;
			// 
			// NumberOfReservationsHeader
			// 
			this.NumberOfReservationsHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.NumberOfReservationsHeader.HeaderText = "Number Of Rervations";
			this.NumberOfReservationsHeader.Name = "NumberOfReservationsHeader";
			this.NumberOfReservationsHeader.Width = 260;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(46, 294);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// BookingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1920, 1020);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Name = "BookingForm";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.ClientsTabsControl.ResumeLayout(false);
			this.Rooms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsGrid)).EndInit();
			this.GroupSearch.ResumeLayout(false);
			this.GroupSearch.PerformLayout();
			this.FooterPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel BodyPanel;
		private MetroFramework.Controls.MetroTabControl ClientsTabsControl;
		private MetroFramework.Controls.MetroTabPage Rooms;
		private MetroFramework.Controls.MetroTabPage Actitivities;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel FowardPanel;
		private System.Windows.Forms.Panel HomePanel;
		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.TextBox textBox1;
		private MetroFramework.Controls.MetroTabPage Transports;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.GroupBox GroupSearch;
		private System.Windows.Forms.Button OkButton;
		private MetroFramework.Controls.MetroTile ClientsTile;
		private MetroFramework.Controls.MetroTile BookingsTile;
		private MetroFramework.Controls.MetroGrid RoomBookingsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientIDHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirthHearder;
		private System.Windows.Forms.DataGridViewTextBoxColumn GenderHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn CityHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn FiscalNumberHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumberHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastReservationHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfReservationsHeader;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;

	}
}