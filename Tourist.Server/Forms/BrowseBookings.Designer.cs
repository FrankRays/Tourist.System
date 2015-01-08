namespace Tourist.Server.Forms
{
	partial class BrowseBookings
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
			this.BookingsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.BookingIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNifColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookableDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BookingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BookingsDataGrid)).BeginInit();
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
			this.BackPanel.Location = new System.Drawing.Point(18, 32);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 89);
			this.BackPanel.TabIndex = 9;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.AutoSize = true;
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.Disponibility;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1084, 27);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(100, 91);
			this.ImagePanel.TabIndex = 13;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(106, 88);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(264, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Browse Bookings Services";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(98, 28);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(317, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Browse Bookings";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.BookingsDataGrid);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 469);
			this.BodyPanel.TabIndex = 16;
			// 
			// BookingsDataGrid
			// 
			this.BookingsDataGrid.AllowUserToAddRows = false;
			this.BookingsDataGrid.AllowUserToOrderColumns = true;
			this.BookingsDataGrid.AllowUserToResizeColumns = false;
			this.BookingsDataGrid.AllowUserToResizeRows = false;
			this.BookingsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BookingsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.BookingsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.BookingsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BookingsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BookingsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.BookingsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.BookingsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.BookingsDataGrid.ColumnHeadersHeight = 60;
			this.BookingsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.BookingsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingIdColumn,
            this.ClientNifColumn,
            this.ClientNameColumn,
            this.TypeColumn,
            this.SubTypeColumn,
            this.BookableDescriptionColumn,
            this.BasePriceColumn,
            this.BookingDateColumn,
            this.StartDateColumn,
            this.EndDateColumn,
            this.TotalPriceColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.BookingsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.BookingsDataGrid.EnableHeadersVisualStyles = false;
			this.BookingsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.BookingsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BookingsDataGrid.Location = new System.Drawing.Point(18, 20);
			this.BookingsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.BookingsDataGrid.Name = "BookingsDataGrid";
			this.BookingsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.BookingsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.BookingsDataGrid.RowHeadersWidth = 50;
			this.BookingsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.BookingsDataGrid.RowTemplate.Height = 25;
			this.BookingsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.BookingsDataGrid.Size = new System.Drawing.Size(1166, 428);
			this.BookingsDataGrid.TabIndex = 23;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(-1, 650);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1202, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// BookingIdColumn
			// 
			this.BookingIdColumn.HeaderText = "Booking ID";
			this.BookingIdColumn.MinimumWidth = 125;
			this.BookingIdColumn.Name = "BookingIdColumn";
			this.BookingIdColumn.ReadOnly = true;
			this.BookingIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// ClientNifColumn
			// 
			this.ClientNifColumn.HeaderText = "Client Nif ";
			this.ClientNifColumn.MinimumWidth = 125;
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
			// TypeColumn
			// 
			this.TypeColumn.HeaderText = "Type ";
			this.TypeColumn.MinimumWidth = 150;
			this.TypeColumn.Name = "TypeColumn";
			this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// SubTypeColumn
			// 
			this.SubTypeColumn.HeaderText = "SubType";
			this.SubTypeColumn.MinimumWidth = 150;
			this.SubTypeColumn.Name = "SubTypeColumn";
			// 
			// BookableDescriptionColumn
			// 
			this.BookableDescriptionColumn.HeaderText = "Bookable Description";
			this.BookableDescriptionColumn.MinimumWidth = 250;
			this.BookableDescriptionColumn.Name = "BookableDescriptionColumn";
			this.BookableDescriptionColumn.ReadOnly = true;
			// 
			// BasePriceColumn
			// 
			this.BasePriceColumn.HeaderText = "Base Price";
			this.BasePriceColumn.MinimumWidth = 100;
			this.BasePriceColumn.Name = "BasePriceColumn";
			this.BasePriceColumn.ReadOnly = true;
			// 
			// BookingDateColumn
			// 
			this.BookingDateColumn.HeaderText = "Booking Date";
			this.BookingDateColumn.MinimumWidth = 125;
			this.BookingDateColumn.Name = "BookingDateColumn";
			this.BookingDateColumn.ReadOnly = true;
			// 
			// StartDateColumn
			// 
			this.StartDateColumn.HeaderText = "Start-Date ";
			this.StartDateColumn.MinimumWidth = 125;
			this.StartDateColumn.Name = "StartDateColumn";
			this.StartDateColumn.ReadOnly = true;
			this.StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.StartDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// EndDateColumn
			// 
			this.EndDateColumn.HeaderText = "End-Date";
			this.EndDateColumn.MinimumWidth = 125;
			this.EndDateColumn.Name = "EndDateColumn";
			this.EndDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.EndDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// TotalPriceColumn
			// 
			this.TotalPriceColumn.HeaderText = "Total Price";
			this.TotalPriceColumn.MinimumWidth = 125;
			this.TotalPriceColumn.Name = "TotalPriceColumn";
			this.TotalPriceColumn.ReadOnly = true;
			// 
			// BrowseBookings
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
			this.Name = "BrowseBookings";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.DisponibilityForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BookingsDataGrid)).EndInit();
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
		private MetroFramework.Controls.MetroGrid BookingsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookingIdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookableDescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BasePriceColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BookingDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;

	}
}