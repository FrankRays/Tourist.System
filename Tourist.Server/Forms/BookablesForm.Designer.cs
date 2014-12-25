namespace Tourist.Server.Forms
{
	partial class BookablesForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.TransportsTab = new MetroFramework.Controls.MetroTabPage();
			this.TransportsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.T_PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_StateColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.T_TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.T_IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ActivitiesTab = new MetroFramework.Controls.MetroTabPage();
			this.ActivitiesDataGrid = new MetroFramework.Controls.MetroGrid();
			this.A_PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.A_StateColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.A_TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.A_IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RoomsTab = new MetroFramework.Controls.MetroTabPage();
			this.RoomDataGrid = new MetroFramework.Controls.MetroGrid();
			this.R_PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.R_StateColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.R_TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.R_IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookablesTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.TransportsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TransportsDataGrid)).BeginInit();
			this.ActivitiesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ActivitiesDataGrid)).BeginInit();
			this.RoomsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).BeginInit();
			this.BookablesTabsControl.SuspendLayout();
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
			this.BackPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 34);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 88);
			this.BackPanel.TabIndex = 9;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.AutoSize = true;
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.services;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1050, 36);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(134, 81);
			this.ImagePanel.TabIndex = 13;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(105, 87);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(248, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Bookables Management";
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
			this.TitleLabel.Size = new System.Drawing.Size(200, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Bookables";
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
			this.BodyPanel.Size = new System.Drawing.Size(1202, 470);
			this.BodyPanel.TabIndex = 16;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(-1, 651);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1202, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// TransportsTab
			// 
			this.TransportsTab.Controls.Add(this.TransportsDataGrid);
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
			// TransportsDataGrid
			// 
			this.TransportsDataGrid.AllowUserToOrderColumns = true;
			this.TransportsDataGrid.AllowUserToResizeColumns = false;
			this.TransportsDataGrid.AllowUserToResizeRows = false;
			this.TransportsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TransportsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TransportsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.TransportsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TransportsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TransportsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.TransportsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.TransportsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.TransportsDataGrid.ColumnHeadersHeight = 60;
			this.TransportsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TransportsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.T_IdColumn,
            this.T_TypeColumn,
            this.T_StateColumn,
            this.T_DescriptionColumn,
            this.T_CapacityColumn,
            this.T_PriceColumn});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TransportsDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
			this.TransportsDataGrid.EnableHeadersVisualStyles = false;
			this.TransportsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TransportsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TransportsDataGrid.Location = new System.Drawing.Point(-4, 13);
			this.TransportsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.TransportsDataGrid.Name = "TransportsDataGrid";
			this.TransportsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.TransportsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.TransportsDataGrid.RowHeadersWidth = 50;
			this.TransportsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.TransportsDataGrid.RowTemplate.Height = 25;
			this.TransportsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.TransportsDataGrid.Size = new System.Drawing.Size(1166, 375);
			this.TransportsDataGrid.TabIndex = 19;
			this.TransportsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransportsDataGrid_CellDoubleClick);
			this.TransportsDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TransportsDataGrid_CellValidating);
			this.TransportsDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TransportsDataGrid_RowRemoved);
			// 
			// T_PriceColumn
			// 
			this.T_PriceColumn.HeaderText = "Price (€)";
			this.T_PriceColumn.MinimumWidth = 150;
			this.T_PriceColumn.Name = "T_PriceColumn";
			this.T_PriceColumn.ReadOnly = true;
			// 
			// T_CapacityColumn
			// 
			this.T_CapacityColumn.HeaderText = "Capacity";
			this.T_CapacityColumn.MinimumWidth = 150;
			this.T_CapacityColumn.Name = "T_CapacityColumn";
			this.T_CapacityColumn.ReadOnly = true;
			this.T_CapacityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.T_CapacityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// T_DescriptionColumn
			// 
			this.T_DescriptionColumn.HeaderText = "Description (*)";
			this.T_DescriptionColumn.MinimumWidth = 150;
			this.T_DescriptionColumn.Name = "T_DescriptionColumn";
			// 
			// T_StateColumn
			// 
			this.T_StateColumn.HeaderText = "State (*)";
			this.T_StateColumn.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.T_StateColumn.MinimumWidth = 150;
			this.T_StateColumn.Name = "T_StateColumn";
			// 
			// T_TypeColumn
			// 
			this.T_TypeColumn.HeaderText = "Type (*)";
			this.T_TypeColumn.Items.AddRange(new object[] {
            "TuckTuck",
            "CableCar",
            "Bicycle",
            "Car",
            "Bus",
            "Motorist"});
			this.T_TypeColumn.MinimumWidth = 150;
			this.T_TypeColumn.Name = "T_TypeColumn";
			// 
			// T_IdColumn
			// 
			this.T_IdColumn.HeaderText = "ID";
			this.T_IdColumn.MinimumWidth = 150;
			this.T_IdColumn.Name = "T_IdColumn";
			this.T_IdColumn.ReadOnly = true;
			// 
			// ActivitiesTab
			// 
			this.ActivitiesTab.Controls.Add(this.ActivitiesDataGrid);
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
			// ActivitiesDataGrid
			// 
			this.ActivitiesDataGrid.AllowUserToOrderColumns = true;
			this.ActivitiesDataGrid.AllowUserToResizeColumns = false;
			this.ActivitiesDataGrid.AllowUserToResizeRows = false;
			this.ActivitiesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ActivitiesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ActivitiesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ActivitiesDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ActivitiesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ActivitiesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ActivitiesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ActivitiesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.ActivitiesDataGrid.ColumnHeadersHeight = 60;
			this.ActivitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ActivitiesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_IdColumn,
            this.A_TypeColumn,
            this.A_StateColumn,
            this.A_DescriptionColumn,
            this.A_CapacityColumn,
            this.A_PriceColumn});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ActivitiesDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.ActivitiesDataGrid.EnableHeadersVisualStyles = false;
			this.ActivitiesDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ActivitiesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ActivitiesDataGrid.Location = new System.Drawing.Point(-4, 13);
			this.ActivitiesDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.ActivitiesDataGrid.Name = "ActivitiesDataGrid";
			this.ActivitiesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ActivitiesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.ActivitiesDataGrid.RowHeadersWidth = 50;
			this.ActivitiesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ActivitiesDataGrid.RowTemplate.Height = 25;
			this.ActivitiesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ActivitiesDataGrid.Size = new System.Drawing.Size(1166, 379);
			this.ActivitiesDataGrid.TabIndex = 19;
			this.ActivitiesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivitiesDataGrid_CellDoubleClick);
			this.ActivitiesDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ActivitiesDataGrid_CellValidating);
			this.ActivitiesDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ActivitiesDataGrid_RowRemoved);
			// 
			// A_PriceColumn
			// 
			this.A_PriceColumn.HeaderText = "Price (€)";
			this.A_PriceColumn.MinimumWidth = 150;
			this.A_PriceColumn.Name = "A_PriceColumn";
			this.A_PriceColumn.ReadOnly = true;
			// 
			// A_CapacityColumn
			// 
			this.A_CapacityColumn.HeaderText = "Capacity";
			this.A_CapacityColumn.MinimumWidth = 150;
			this.A_CapacityColumn.Name = "A_CapacityColumn";
			this.A_CapacityColumn.ReadOnly = true;
			this.A_CapacityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.A_CapacityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// A_DescriptionColumn
			// 
			this.A_DescriptionColumn.HeaderText = "Description (*)";
			this.A_DescriptionColumn.MinimumWidth = 150;
			this.A_DescriptionColumn.Name = "A_DescriptionColumn";
			// 
			// A_StateColumn
			// 
			this.A_StateColumn.HeaderText = "State (*)";
			this.A_StateColumn.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.A_StateColumn.MinimumWidth = 150;
			this.A_StateColumn.Name = "A_StateColumn";
			// 
			// A_TypeColumn
			// 
			this.A_TypeColumn.HeaderText = "Type (*)";
			this.A_TypeColumn.Items.AddRange(new object[] {
            "BoatRide",
            "Golf",
            "Camping",
            "Diving",
            "SightSeeing",
            "SkyDiving,"});
			this.A_TypeColumn.MinimumWidth = 150;
			this.A_TypeColumn.Name = "A_TypeColumn";
			// 
			// A_IdColumn
			// 
			this.A_IdColumn.HeaderText = "ID";
			this.A_IdColumn.MinimumWidth = 150;
			this.A_IdColumn.Name = "A_IdColumn";
			this.A_IdColumn.ReadOnly = true;
			// 
			// RoomsTab
			// 
			this.RoomsTab.Controls.Add(this.RoomDataGrid);
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
			// RoomDataGrid
			// 
			this.RoomDataGrid.AllowUserToOrderColumns = true;
			this.RoomDataGrid.AllowUserToResizeColumns = false;
			this.RoomDataGrid.AllowUserToResizeRows = false;
			this.RoomDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RoomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.RoomDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.RoomDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RoomDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.RoomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.RoomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.RoomDataGrid.ColumnHeadersHeight = 60;
			this.RoomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.RoomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_IdColumn,
            this.R_TypeColumn,
            this.R_StateColumn,
            this.R_DescriptionColumn,
            this.R_CapacityColumn,
            this.R_PriceColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.RoomDataGrid.EnableHeadersVisualStyles = false;
			this.RoomDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.RoomDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.RoomDataGrid.Location = new System.Drawing.Point(-4, 13);
			this.RoomDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.RoomDataGrid.Name = "RoomDataGrid";
			this.RoomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.RoomDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.RoomDataGrid.RowHeadersWidth = 50;
			this.RoomDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.RoomDataGrid.RowTemplate.Height = 25;
			this.RoomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.RoomDataGrid.Size = new System.Drawing.Size(1166, 379);
			this.RoomDataGrid.TabIndex = 18;
			this.RoomDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGrid_CellDoubleClick);
			this.RoomDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.RoomsDataGrid_CellValidating);
			this.RoomDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.RoomsDataGrid_RowRemoved);
			// 
			// R_PriceColumn
			// 
			this.R_PriceColumn.HeaderText = "Price (€)";
			this.R_PriceColumn.MinimumWidth = 150;
			this.R_PriceColumn.Name = "R_PriceColumn";
			this.R_PriceColumn.ReadOnly = true;
			// 
			// R_CapacityColumn
			// 
			this.R_CapacityColumn.HeaderText = "Capacity";
			this.R_CapacityColumn.MinimumWidth = 150;
			this.R_CapacityColumn.Name = "R_CapacityColumn";
			this.R_CapacityColumn.ReadOnly = true;
			this.R_CapacityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.R_CapacityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// R_DescriptionColumn
			// 
			this.R_DescriptionColumn.HeaderText = "Description (*)";
			this.R_DescriptionColumn.MinimumWidth = 150;
			this.R_DescriptionColumn.Name = "R_DescriptionColumn";
			// 
			// R_StateColumn
			// 
			this.R_StateColumn.HeaderText = "State (*)";
			this.R_StateColumn.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.R_StateColumn.MinimumWidth = 150;
			this.R_StateColumn.Name = "R_StateColumn";
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
			// 
			// R_IdColumn
			// 
			this.R_IdColumn.HeaderText = "ID";
			this.R_IdColumn.MinimumWidth = 150;
			this.R_IdColumn.Name = "R_IdColumn";
			this.R_IdColumn.ReadOnly = true;
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
			this.BookablesTabsControl.TabIndex = 21;
			this.BookablesTabsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BookablesTabsControl.UseSelectable = true;
			// 
			// BookablesForm
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
			this.Movable = false;
			this.Name = "BookablesForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ServicesForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.TransportsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TransportsDataGrid)).EndInit();
			this.ActivitiesTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ActivitiesDataGrid)).EndInit();
			this.RoomsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).EndInit();
			this.BookablesTabsControl.ResumeLayout(false);
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
		private MetroFramework.Controls.MetroTabControl BookablesTabsControl;
		private MetroFramework.Controls.MetroTabPage RoomsTab;
		private MetroFramework.Controls.MetroGrid RoomDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn R_TypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn R_StateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_CapacityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn R_PriceColumn;
		private MetroFramework.Controls.MetroTabPage ActivitiesTab;
		private MetroFramework.Controls.MetroGrid ActivitiesDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn A_TypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn A_StateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_CapacityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn A_PriceColumn;
		private MetroFramework.Controls.MetroTabPage TransportsTab;
		private MetroFramework.Controls.MetroGrid TransportsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn T_TypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn T_StateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_CapacityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_PriceColumn;

	}
}