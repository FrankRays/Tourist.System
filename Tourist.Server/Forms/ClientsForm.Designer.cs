namespace Tourist.Server.Forms
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
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.ClientsTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.OverViewTab = new MetroFramework.Controls.MetroTabPage();
			this.BrowseTab = new MetroFramework.Controls.MetroTabPage();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.FowardPanel = new System.Windows.Forms.Panel();
			this.HomePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ClientsOverView = new MetroFramework.Controls.MetroGrid();
			this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientFN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientPhoneContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientLastReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientNumberOfReservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.ClientsTabsControl.SuspendLayout();
			this.OverViewTab.SuspendLayout();
			this.FooterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsOverView)).BeginInit();
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
			this.HeaderPanel.Size = new System.Drawing.Size(1368, 150);
			this.HeaderPanel.TabIndex = 14;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.clients;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1140, 28);
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
			this.SubTitleLabel.Size = new System.Drawing.Size(216, 38);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Manage Clients ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(23, 3);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(338, 65);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Clients Details";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.ClientsTabsControl);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 184);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1368, 561);
			this.BodyPanel.TabIndex = 16;
			// 
			// ClientsTabsControl
			// 
			this.ClientsTabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsTabsControl.Controls.Add(this.OverViewTab);
			this.ClientsTabsControl.Controls.Add(this.BrowseTab);
			this.ClientsTabsControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.ClientsTabsControl.ItemSize = new System.Drawing.Size(150, 50);
			this.ClientsTabsControl.Location = new System.Drawing.Point(24, 14);
			this.ClientsTabsControl.Name = "ClientsTabsControl";
			this.ClientsTabsControl.SelectedIndex = 0;
			this.ClientsTabsControl.Size = new System.Drawing.Size(1320, 531);
			this.ClientsTabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.ClientsTabsControl.TabIndex = 0;
			this.ClientsTabsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClientsTabsControl.UseSelectable = true;
			// 
			// OverViewTab
			// 
			this.OverViewTab.Controls.Add(this.ClientsOverView);
			this.OverViewTab.HorizontalScrollbarBarColor = true;
			this.OverViewTab.HorizontalScrollbarHighlightOnWheel = false;
			this.OverViewTab.HorizontalScrollbarSize = 10;
			this.OverViewTab.Location = new System.Drawing.Point(4, 54);
			this.OverViewTab.Name = "OverViewTab";
			this.OverViewTab.Size = new System.Drawing.Size(1312, 473);
			this.OverViewTab.TabIndex = 0;
			this.OverViewTab.Text = "Overview";
			this.OverViewTab.VerticalScrollbarBarColor = true;
			this.OverViewTab.VerticalScrollbarHighlightOnWheel = false;
			this.OverViewTab.VerticalScrollbarSize = 10;
			// 
			// BrowseTab
			// 
			this.BrowseTab.HorizontalScrollbarBarColor = true;
			this.BrowseTab.HorizontalScrollbarHighlightOnWheel = false;
			this.BrowseTab.HorizontalScrollbarSize = 10;
			this.BrowseTab.Location = new System.Drawing.Point(4, 54);
			this.BrowseTab.Name = "BrowseTab";
			this.BrowseTab.Size = new System.Drawing.Size(1330, 473);
			this.BrowseTab.TabIndex = 1;
			this.BrowseTab.Text = "Browse";
			this.BrowseTab.VerticalScrollbarBarColor = true;
			this.BrowseTab.VerticalScrollbarHighlightOnWheel = false;
			this.BrowseTab.VerticalScrollbarSize = 10;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Controls.Add(this.FowardPanel);
			this.FooterPanel.Controls.Add(this.HomePanel);
			this.FooterPanel.Controls.Add(this.BackPanel);
			this.FooterPanel.Location = new System.Drawing.Point(-1, 751);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1368, 150);
			this.FooterPanel.TabIndex = 15;
			// 
			// FowardPanel
			// 
			this.FowardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FowardPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.RightArrow;
			this.FowardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.FowardPanel.Location = new System.Drawing.Point(1261, 17);
			this.FowardPanel.Name = "FowardPanel";
			this.FowardPanel.Size = new System.Drawing.Size(83, 117);
			this.FowardPanel.TabIndex = 1;
			// 
			// HomePanel
			// 
			this.HomePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.HomePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.Home;
			this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.HomePanel.Location = new System.Drawing.Point(682, 17);
			this.HomePanel.Name = "HomePanel";
			this.HomePanel.Size = new System.Drawing.Size(130, 117);
			this.HomePanel.TabIndex = 2;
			// 
			// BackPanel
			// 
			this.BackPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(24, 17);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(85, 117);
			this.BackPanel.TabIndex = 3;
			// 
			// ClientsOverView
			// 
			this.ClientsOverView.AllowUserToResizeRows = false;
			this.ClientsOverView.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ClientsOverView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsOverView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClientsOverView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ClientsOverView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsOverView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ClientsOverView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ClientsOverView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.ClientName,
            this.ClientBirthDate,
            this.ClientGender,
            this.ClientCity,
            this.ClientFN,
            this.ClientPhoneContact,
            this.ClientLastReservationDate,
            this.ClientNumberOfReservations});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsOverView.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClientsOverView.EnableHeadersVisualStyles = false;
			this.ClientsOverView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ClientsOverView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsOverView.Location = new System.Drawing.Point(11, 42);
			this.ClientsOverView.Name = "ClientsOverView";
			this.ClientsOverView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsOverView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.ClientsOverView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.ClientsOverView.RowTemplate.Height = 24;
			this.ClientsOverView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientsOverView.Size = new System.Drawing.Size(1285, 428);
			this.ClientsOverView.TabIndex = 2;
			// 
			// ClientID
			// 
			this.ClientID.HeaderText = "Client ID";
			this.ClientID.Name = "ClientID";
			// 
			// ClientName
			// 
			this.ClientName.HeaderText = "Client Name";
			this.ClientName.Name = "ClientName";
			// 
			// ClientBirthDate
			// 
			this.ClientBirthDate.HeaderText = "Date of Birth";
			this.ClientBirthDate.Name = "ClientBirthDate";
			// 
			// ClientGender
			// 
			this.ClientGender.HeaderText = "Gender";
			this.ClientGender.Name = "ClientGender";
			// 
			// ClientCity
			// 
			this.ClientCity.HeaderText = "City";
			this.ClientCity.Name = "ClientCity";
			// 
			// ClientFN
			// 
			this.ClientFN.HeaderText = "Fiscal Number";
			this.ClientFN.Name = "ClientFN";
			// 
			// ClientPhoneContact
			// 
			this.ClientPhoneContact.HeaderText = "Conctact Number";
			this.ClientPhoneContact.Name = "ClientPhoneContact";
			// 
			// ClientLastReservationDate
			// 
			this.ClientLastReservationDate.HeaderText = "Last Reservation Date";
			this.ClientLastReservationDate.Name = "ClientLastReservationDate";
			// 
			// ClientNumberOfReservations
			// 
			this.ClientNumberOfReservations.HeaderText = "Number of Reservations";
			this.ClientNumberOfReservations.Name = "ClientNumberOfReservations";
			// 
			// ClientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 900);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Name = "ClientsForm";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.ClientsTabsControl.ResumeLayout(false);
			this.OverViewTab.ResumeLayout(false);
			this.FooterPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ClientsOverView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel BodyPanel;
		private MetroFramework.Controls.MetroTabControl ClientsTabsControl;
		private MetroFramework.Controls.MetroTabPage OverViewTab;
		private MetroFramework.Controls.MetroTabPage BrowseTab;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel FowardPanel;
		private System.Windows.Forms.Panel HomePanel;
		private System.Windows.Forms.Panel BackPanel;
		private MetroFramework.Controls.MetroGrid ClientsOverView;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientBirthDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientGender;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientFN;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhoneContact;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientLastReservationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumberOfReservations;

	}
}