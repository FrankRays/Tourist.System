namespace Tourist.Client.Forms
{
	partial class ClientsForm
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
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.SearchTile = new MetroFramework.Controls.MetroTile();
			this.LogoffTile = new MetroFramework.Controls.MetroTile();
			this.PrefrencesTile = new MetroFramework.Controls.MetroTile();
			this.WrapperPanelGrid = new System.Windows.Forms.Panel();
			this.ClientsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GenderColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NifColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.SideBarPanel.SuspendLayout();
			this.WrapperPanelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
			this.GroupSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.panel2);
			this.HeaderPanel.Controls.Add(this.BackPanel);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 23);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 122);
			this.HeaderPanel.TabIndex = 14;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.clients;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1010, 15);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(174, 86);
			this.ImagePanel.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(422, 124);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(150, 26);
			this.panel2.TabIndex = 11;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Client.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 15);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 89);
			this.BackPanel.TabIndex = 12;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(107, 69);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(153, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Client Services";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(98, 12);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(138, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Clients";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.SideBarPanel);
			this.BodyPanel.Controls.Add(this.WrapperPanelGrid);
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 150);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 524);
			this.BodyPanel.TabIndex = 16;
			// 
			// SideBarPanel
			// 
			this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SideBarPanel.Controls.Add(this.SearchTile);
			this.SideBarPanel.Controls.Add(this.LogoffTile);
			this.SideBarPanel.Controls.Add(this.PrefrencesTile);
			this.SideBarPanel.Location = new System.Drawing.Point(1198, 2);
			this.SideBarPanel.Margin = new System.Windows.Forms.Padding(2);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(112, 525);
			this.SideBarPanel.TabIndex = 24;
			this.SideBarPanel.Visible = false;
			// 
			// SearchTile
			// 
			this.SearchTile.ActiveControl = null;
			this.SearchTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SearchTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.SearchTile.Location = new System.Drawing.Point(2, 20);
			this.SearchTile.Margin = new System.Windows.Forms.Padding(2);
			this.SearchTile.Name = "SearchTile";
			this.SearchTile.Size = new System.Drawing.Size(108, 85);
			this.SearchTile.TabIndex = 1;
			this.SearchTile.Text = "Search";
			this.SearchTile.TileImage = global::Tourist.Client.Properties.Resources.Magnifier;
			this.SearchTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SearchTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SearchTile.UseCustomBackColor = true;
			this.SearchTile.UseSelectable = true;
			this.SearchTile.UseTileImage = true;
			// 
			// LogoffTile
			// 
			this.LogoffTile.ActiveControl = null;
			this.LogoffTile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LogoffTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.LogoffTile.Location = new System.Drawing.Point(0, 421);
			this.LogoffTile.Margin = new System.Windows.Forms.Padding(2);
			this.LogoffTile.Name = "LogoffTile";
			this.LogoffTile.Size = new System.Drawing.Size(112, 85);
			this.LogoffTile.TabIndex = 0;
			this.LogoffTile.Text = "LogOff";
			this.LogoffTile.TileImage = global::Tourist.Client.Properties.Resources.PowerOff;
			this.LogoffTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LogoffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.LogoffTile.UseCustomBackColor = true;
			this.LogoffTile.UseSelectable = true;
			this.LogoffTile.UseTileImage = true;
			// 
			// PrefrencesTile
			// 
			this.PrefrencesTile.ActiveControl = null;
			this.PrefrencesTile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PrefrencesTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.PrefrencesTile.Location = new System.Drawing.Point(0, 218);
			this.PrefrencesTile.Margin = new System.Windows.Forms.Padding(2);
			this.PrefrencesTile.Name = "PrefrencesTile";
			this.PrefrencesTile.Size = new System.Drawing.Size(112, 85);
			this.PrefrencesTile.TabIndex = 0;
			this.PrefrencesTile.Text = "Preferences";
			this.PrefrencesTile.TileImage = global::Tourist.Client.Properties.Resources.preferences;
			this.PrefrencesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PrefrencesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PrefrencesTile.UseCustomBackColor = true;
			this.PrefrencesTile.UseSelectable = true;
			this.PrefrencesTile.UseTileImage = true;
			// 
			// WrapperPanelGrid
			// 
			this.WrapperPanelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WrapperPanelGrid.BackColor = System.Drawing.Color.White;
			this.WrapperPanelGrid.Controls.Add(this.ClientsDataGrid);
			this.WrapperPanelGrid.Location = new System.Drawing.Point(231, 24);
			this.WrapperPanelGrid.Name = "WrapperPanelGrid";
			this.WrapperPanelGrid.Size = new System.Drawing.Size(953, 482);
			this.WrapperPanelGrid.TabIndex = 23;
			// 
			// ClientsDataGrid
			// 
			this.ClientsDataGrid.AllowUserToOrderColumns = true;
			this.ClientsDataGrid.AllowUserToResizeColumns = false;
			this.ClientsDataGrid.AllowUserToResizeRows = false;
			this.ClientsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ClientsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ClientsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClientsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ClientsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ClientsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ClientsDataGrid.ColumnHeadersHeight = 60;
			this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ClientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.GenderColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.BirthDateColumn,
            this.NifColumn,
            this.AddressColumn,
            this.PhoneColumn,
            this.EmailColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClientsDataGrid.EnableHeadersVisualStyles = false;
			this.ClientsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ClientsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsDataGrid.Location = new System.Drawing.Point(2, 1);
			this.ClientsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.ClientsDataGrid.Name = "ClientsDataGrid";
			this.ClientsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.ClientsDataGrid.RowHeadersWidth = 50;
			this.ClientsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ClientsDataGrid.RowTemplate.Height = 25;
			this.ClientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientsDataGrid.Size = new System.Drawing.Size(949, 480);
			this.ClientsDataGrid.TabIndex = 19;
			// 
			// IdColumn
			// 
			this.IdColumn.HeaderText = "ID";
			this.IdColumn.MinimumWidth = 150;
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			// 
			// GenderColumn
			// 
			this.GenderColumn.HeaderText = "Gender";
			this.GenderColumn.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.GenderColumn.MinimumWidth = 150;
			this.GenderColumn.Name = "GenderColumn";
			this.GenderColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.GenderColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// FirstNameColumn
			// 
			this.FirstNameColumn.HeaderText = "First Name";
			this.FirstNameColumn.MinimumWidth = 150;
			this.FirstNameColumn.Name = "FirstNameColumn";
			this.FirstNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// LastNameColumn
			// 
			this.LastNameColumn.HeaderText = "Last Name";
			this.LastNameColumn.MinimumWidth = 150;
			this.LastNameColumn.Name = "LastNameColumn";
			// 
			// BirthDateColumn
			// 
			this.BirthDateColumn.HeaderText = "BirthDate";
			this.BirthDateColumn.MinimumWidth = 150;
			this.BirthDateColumn.Name = "BirthDateColumn";
			// 
			// NifColumn
			// 
			this.NifColumn.HeaderText = "NIF";
			this.NifColumn.MinimumWidth = 150;
			this.NifColumn.Name = "NifColumn";
			// 
			// AddressColumn
			// 
			this.AddressColumn.HeaderText = "Address";
			this.AddressColumn.MinimumWidth = 150;
			this.AddressColumn.Name = "AddressColumn";
			// 
			// PhoneColumn
			// 
			this.PhoneColumn.HeaderText = "Phone";
			this.PhoneColumn.MinimumWidth = 150;
			this.PhoneColumn.Name = "PhoneColumn";
			// 
			// EmailColumn
			// 
			this.EmailColumn.HeaderText = "Email";
			this.EmailColumn.MinimumWidth = 150;
			this.EmailColumn.Name = "EmailColumn";
			// 
			// GroupSearch
			// 
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Controls.Add(this.textBox1);
			this.GroupSearch.Controls.Add(this.metroComboBox1);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(18, 12);
			this.GroupSearch.Margin = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Padding = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Size = new System.Drawing.Size(197, 157);
			this.GroupSearch.TabIndex = 22;
			this.GroupSearch.TabStop = false;
			this.GroupSearch.Text = "Search ";
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(12, 106);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(176, 32);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(12, 64);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 32);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = " Search";
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(12, 29);
			this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
			this.metroComboBox1.TabIndex = 9;
			this.metroComboBox1.UseSelectable = true;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(-1, 679);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1202, 122);
			this.FooterPanel.TabIndex = 15;
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn27.HeaderText = "Number Reservations";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn26.HeaderText = "Last Reservation";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn25.HeaderText = "Contact Number";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn24.HeaderText = "Fiscal Number";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn23.HeaderText = "City";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn22.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn21.HeaderText = "Birth Date";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn20.HeaderText = "Client Name";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn19.HeaderText = "Client ID";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			// 
			// ClientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "ClientsForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.SideBarPanel.ResumeLayout(false);
			this.WrapperPanelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
			this.GroupSearch.ResumeLayout(false);
			this.GroupSearch.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.Panel WrapperPanelGrid;
		private System.Windows.Forms.GroupBox GroupSearch;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TextBox textBox1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.Panel SideBarPanel;
		private MetroFramework.Controls.MetroTile SearchTile;
		private MetroFramework.Controls.MetroTile LogoffTile;
		private MetroFramework.Controls.MetroTile PrefrencesTile;
		private MetroFramework.Controls.MetroGrid ClientsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn GenderColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;

	}
}