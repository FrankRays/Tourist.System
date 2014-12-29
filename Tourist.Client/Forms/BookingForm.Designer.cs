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
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.RoomBookingsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNifColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookableTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BookableSubTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckInDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckOutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsDataGrid)).BeginInit();
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
			this.BodyPanel.Controls.Add(this.RoomBookingsDataGrid);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 468);
			this.BodyPanel.TabIndex = 16;
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
            this.IdColumn,
            this.ClientNifColumn,
            this.ClientNameColumn,
            this.BookableTypeColumn,
            this.BookableSubTypeColumn,
            this.BasePriceColumn,
            this.BookingDateColumn,
            this.CheckInDateColumn,
            this.CheckOutColumn,
            this.TotalPriceColumn});
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
			this.RoomBookingsDataGrid.Location = new System.Drawing.Point(18, 25);
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
			this.RoomBookingsDataGrid.Size = new System.Drawing.Size(1166, 429);
			this.RoomBookingsDataGrid.TabIndex = 20;
			// 
			// IdColumn
			// 
			this.IdColumn.HeaderText = "ID";
			this.IdColumn.MinimumWidth = 75;
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ClientNifColumn
			// 
			this.ClientNifColumn.HeaderText = "Client Nif (*)";
			this.ClientNifColumn.MinimumWidth = 150;
			this.ClientNifColumn.Name = "ClientNifColumn";
			this.ClientNifColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ClientNifColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ClientNameColumn
			// 
			this.ClientNameColumn.HeaderText = "Client Name";
			this.ClientNameColumn.MinimumWidth = 200;
			this.ClientNameColumn.Name = "ClientNameColumn";
			this.ClientNameColumn.ReadOnly = true;
			// 
			// BookableTypeColumn
			// 
			this.BookableTypeColumn.HeaderText = "Type (*)";
			this.BookableTypeColumn.Items.AddRange(new object[] {
            "Single",
            "DoubleSingle",
            "Double",
            "Suite",
            "FamilySuite",
            "Meeting"});
			this.BookableTypeColumn.MinimumWidth = 150;
			this.BookableTypeColumn.Name = "BookableTypeColumn";
			// 
			// BookableSubTypeColumn
			// 
			this.BookableSubTypeColumn.HeaderText = "Sub-Type (*)";
			this.BookableSubTypeColumn.MinimumWidth = 150;
			this.BookableSubTypeColumn.Name = "BookableSubTypeColumn";
			this.BookableSubTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.BookableSubTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// BasePriceColumn
			// 
			this.BasePriceColumn.HeaderText = "Base Price";
			this.BasePriceColumn.MinimumWidth = 110;
			this.BasePriceColumn.Name = "BasePriceColumn";
			this.BasePriceColumn.ReadOnly = true;
			// 
			// BookingDateColumn
			// 
			this.BookingDateColumn.HeaderText = "Booking Date";
			this.BookingDateColumn.MinimumWidth = 200;
			this.BookingDateColumn.Name = "BookingDateColumn";
			this.BookingDateColumn.ReadOnly = true;
			// 
			// CheckInDateColumn
			// 
			this.CheckInDateColumn.HeaderText = "Check-In-Date (*)";
			this.CheckInDateColumn.MinimumWidth = 200;
			this.CheckInDateColumn.Name = "CheckInDateColumn";
			this.CheckInDateColumn.ReadOnly = true;
			this.CheckInDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CheckInDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CheckOutColumn
			// 
			this.CheckOutColumn.HeaderText = "Check-Out-Date (*)";
			this.CheckOutColumn.MinimumWidth = 200;
			this.CheckOutColumn.Name = "CheckOutColumn";
			this.CheckOutColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CheckOutColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// TotalPriceColumn
			// 
			this.TotalPriceColumn.HeaderText = "Total Price";
			this.TotalPriceColumn.MinimumWidth = 100;
			this.TotalPriceColumn.Name = "TotalPriceColumn";
			this.TotalPriceColumn.ReadOnly = true;
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
			((System.ComponentModel.ISupportInitialize)(this.RoomBookingsDataGrid)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn BookableTypeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn BookableSubTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BasePriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookingDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;

	}
}