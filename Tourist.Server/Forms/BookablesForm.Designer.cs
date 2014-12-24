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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.BookablesTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.RoomsTab = new MetroFramework.Controls.MetroTabPage();
			this.RoomDataGrid = new MetroFramework.Controls.MetroGrid();
			this.ActivitiesTab = new MetroFramework.Controls.MetroTabPage();
			this.TransportsTab = new MetroFramework.Controls.MetroTabPage();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CapacityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StateColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.BookablesTabsControl.SuspendLayout();
			this.RoomsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).BeginInit();
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
            this.IdColumn,
            this.TypeColumn,
            this.DescriptionColumn,
            this.PriceColumn,
            this.CapacityColumn,
            this.StateColumn});
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
			this.RoomDataGrid.Size = new System.Drawing.Size(1166, 375);
			this.RoomDataGrid.TabIndex = 18;
			// 
			// ActivitiesTab
			// 
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
			// TransportsTab
			// 
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
			// IdColumn
			// 
			this.IdColumn.HeaderText = "ID";
			this.IdColumn.MinimumWidth = 150;
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			// 
			// TypeColumn
			// 
			this.TypeColumn.HeaderText = "Type";
			this.TypeColumn.Items.AddRange(new object[] {
            "Single",
            "DoubleSingle",
            "Double",
            "Suite",
            "FamilySuite",
            "Meeting"});
			this.TypeColumn.MinimumWidth = 150;
			this.TypeColumn.Name = "TypeColumn";
			// 
			// DescriptionColumn
			// 
			this.DescriptionColumn.HeaderText = "Description";
			this.DescriptionColumn.MinimumWidth = 150;
			this.DescriptionColumn.Name = "DescriptionColumn";
			// 
			// PriceColumn
			// 
			this.PriceColumn.HeaderText = "Price";
			this.PriceColumn.MinimumWidth = 150;
			this.PriceColumn.Name = "PriceColumn";
			// 
			// CapacityColumn
			// 
			this.CapacityColumn.HeaderText = "Capacity";
			this.CapacityColumn.MinimumWidth = 150;
			this.CapacityColumn.Name = "CapacityColumn";
			this.CapacityColumn.ReadOnly = true;
			this.CapacityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CapacityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// StateColumn
			// 
			this.StateColumn.HeaderText = "State";
			this.StateColumn.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.StateColumn.MinimumWidth = 150;
			this.StateColumn.Name = "StateColumn";
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
			this.BookablesTabsControl.ResumeLayout(false);
			this.RoomsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RoomDataGrid)).EndInit();
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
		private MetroFramework.Controls.MetroTabPage ActivitiesTab;
		private MetroFramework.Controls.MetroTabPage TransportsTab;
		private MetroFramework.Controls.MetroGrid RoomDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CapacityColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn StateColumn;

	}
}