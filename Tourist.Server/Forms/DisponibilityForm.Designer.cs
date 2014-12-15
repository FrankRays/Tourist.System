namespace Tourist.Server.Forms
{
	partial class DisponibilityForm
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
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.ClientsTabsControl = new MetroFramework.Controls.MetroTabControl();
			this.RoomsTab = new MetroFramework.Controls.MetroTabPage();
			this.ActivitiesTab = new MetroFramework.Controls.MetroTabPage();
			this.TransportsTab = new MetroFramework.Controls.MetroTabPage();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
			this.label1 = new System.Windows.Forms.Label();
			this.SubTypeLabel = new System.Windows.Forms.Label();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.BookingTypeLabel = new System.Windows.Forms.Label();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
			this.OkButton = new System.Windows.Forms.Button();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.SearchTile = new MetroFramework.Controls.MetroTile();
			this.LogoffTile = new MetroFramework.Controls.MetroTile();
			this.PrefrencesTile = new MetroFramework.Controls.MetroTile();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.ClientsTabsControl.SuspendLayout();
			this.GroupSearch.SuspendLayout();
			this.SideBarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.BackPanel);
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.panel2);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 23);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 122);
			this.HeaderPanel.TabIndex = 14;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 16);
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
			this.ImagePanel.Location = new System.Drawing.Point(1084, 11);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(100, 95);
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
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(106, 72);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(216, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Disponibility Services";
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
			this.TitleLabel.Size = new System.Drawing.Size(239, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Disponibility";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.ClientsTabsControl);
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 150);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 524);
			this.BodyPanel.TabIndex = 16;
			// 
			// ClientsTabsControl
			// 
			this.ClientsTabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsTabsControl.Controls.Add(this.RoomsTab);
			this.ClientsTabsControl.Controls.Add(this.ActivitiesTab);
			this.ClientsTabsControl.Controls.Add(this.TransportsTab);
			this.ClientsTabsControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.ClientsTabsControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
			this.ClientsTabsControl.ItemSize = new System.Drawing.Size(150, 50);
			this.ClientsTabsControl.Location = new System.Drawing.Point(229, 12);
			this.ClientsTabsControl.Margin = new System.Windows.Forms.Padding(0);
			this.ClientsTabsControl.Name = "ClientsTabsControl";
			this.ClientsTabsControl.SelectedIndex = 0;
			this.ClientsTabsControl.Size = new System.Drawing.Size(955, 500);
			this.ClientsTabsControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.ClientsTabsControl.TabIndex = 21;
			this.ClientsTabsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClientsTabsControl.UseSelectable = true;
			// 
			// RoomsTab
			// 
			this.RoomsTab.HorizontalScrollbarBarColor = true;
			this.RoomsTab.HorizontalScrollbarHighlightOnWheel = false;
			this.RoomsTab.HorizontalScrollbarSize = 8;
			this.RoomsTab.Location = new System.Drawing.Point(4, 54);
			this.RoomsTab.Margin = new System.Windows.Forms.Padding(2);
			this.RoomsTab.Name = "RoomsTab";
			this.RoomsTab.Size = new System.Drawing.Size(947, 442);
			this.RoomsTab.TabIndex = 0;
			this.RoomsTab.Text = "ROOMS";
			this.RoomsTab.VerticalScrollbarBarColor = true;
			this.RoomsTab.VerticalScrollbarHighlightOnWheel = false;
			this.RoomsTab.VerticalScrollbarSize = 8;
			// 
			// ActivitiesTab
			// 
			this.ActivitiesTab.HorizontalScrollbarBarColor = true;
			this.ActivitiesTab.HorizontalScrollbarHighlightOnWheel = false;
			this.ActivitiesTab.HorizontalScrollbarSize = 8;
			this.ActivitiesTab.Location = new System.Drawing.Point(4, 54);
			this.ActivitiesTab.Margin = new System.Windows.Forms.Padding(2);
			this.ActivitiesTab.Name = "ActivitiesTab";
			this.ActivitiesTab.Size = new System.Drawing.Size(947, 442);
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
			this.TransportsTab.Size = new System.Drawing.Size(947, 442);
			this.TransportsTab.TabIndex = 2;
			this.TransportsTab.Text = "TRANSPORTS";
			this.TransportsTab.VerticalScrollbarBarColor = true;
			this.TransportsTab.VerticalScrollbarHighlightOnWheel = false;
			this.TransportsTab.VerticalScrollbarSize = 8;
			// 
			// GroupSearch
			// 
			this.GroupSearch.Controls.Add(this.label2);
			this.GroupSearch.Controls.Add(this.metroDateTime2);
			this.GroupSearch.Controls.Add(this.label1);
			this.GroupSearch.Controls.Add(this.SubTypeLabel);
			this.GroupSearch.Controls.Add(this.metroComboBox2);
			this.GroupSearch.Controls.Add(this.BookingTypeLabel);
			this.GroupSearch.Controls.Add(this.metroComboBox1);
			this.GroupSearch.Controls.Add(this.metroDateTime1);
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(20, 2);
			this.GroupSearch.Margin = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Padding = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Size = new System.Drawing.Size(197, 434);
			this.GroupSearch.TabIndex = 22;
			this.GroupSearch.TabStop = false;
			this.GroupSearch.Text = "Search ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 280);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 21);
			this.label2.TabIndex = 28;
			this.label2.Text = "End Date/Time";
			// 
			// metroDateTime2
			// 
			this.metroDateTime2.Location = new System.Drawing.Point(11, 304);
			this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
			this.metroDateTime2.Name = "metroDateTime2";
			this.metroDateTime2.Size = new System.Drawing.Size(176, 31);
			this.metroDateTime2.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 197);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 21);
			this.label1.TabIndex = 26;
			this.label1.Text = "Start Date/Time";
			// 
			// SubTypeLabel
			// 
			this.SubTypeLabel.AutoSize = true;
			this.SubTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTypeLabel.ForeColor = System.Drawing.Color.White;
			this.SubTypeLabel.Location = new System.Drawing.Point(8, 118);
			this.SubTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTypeLabel.Name = "SubTypeLabel";
			this.SubTypeLabel.Size = new System.Drawing.Size(131, 21);
			this.SubTypeLabel.TabIndex = 25;
			this.SubTypeLabel.Text = "Booking SubType";
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(11, 144);
			this.metroComboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(176, 29);
			this.metroComboBox2.TabIndex = 24;
			this.metroComboBox2.UseSelectable = true;
			// 
			// BookingTypeLabel
			// 
			this.BookingTypeLabel.AutoSize = true;
			this.BookingTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookingTypeLabel.ForeColor = System.Drawing.Color.White;
			this.BookingTypeLabel.Location = new System.Drawing.Point(8, 41);
			this.BookingTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BookingTypeLabel.Name = "BookingTypeLabel";
			this.BookingTypeLabel.Size = new System.Drawing.Size(104, 21);
			this.BookingTypeLabel.TabIndex = 23;
			this.BookingTypeLabel.Text = "Booking Type";
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(11, 67);
			this.metroComboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
			this.metroComboBox1.TabIndex = 14;
			this.metroComboBox1.UseSelectable = true;
			// 
			// metroDateTime1
			// 
			this.metroDateTime1.Location = new System.Drawing.Point(11, 221);
			this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new System.Drawing.Size(176, 31);
			this.metroDateTime1.TabIndex = 12;
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(11, 375);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(176, 32);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
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
			// SideBarPanel
			// 
			this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SideBarPanel.Controls.Add(this.SearchTile);
			this.SideBarPanel.Controls.Add(this.LogoffTile);
			this.SideBarPanel.Controls.Add(this.PrefrencesTile);
			this.SideBarPanel.Location = new System.Drawing.Point(1197, 149);
			this.SideBarPanel.Margin = new System.Windows.Forms.Padding(2);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(112, 525);
			this.SideBarPanel.TabIndex = 23;
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
			this.SearchTile.TileImage = global::Tourist.Server.Properties.Resources.Magnifier;
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
			this.LogoffTile.TileImage = global::Tourist.Server.Properties.Resources.PowerOff;
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
			this.PrefrencesTile.TileImage = global::Tourist.Server.Properties.Resources.preferences;
			this.PrefrencesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PrefrencesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PrefrencesTile.UseCustomBackColor = true;
			this.PrefrencesTile.UseSelectable = true;
			this.PrefrencesTile.UseTileImage = true;
			// 
			// DisponibilityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.SideBarPanel);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Movable = false;
			this.Name = "DisponibilityForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.ShowInTaskbar = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.DisponibilityForm_FormClosing );
			this.Load += new System.EventHandler(this.DisponibilityForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.ClientsTabsControl.ResumeLayout(false);
			this.GroupSearch.ResumeLayout(false);
			this.GroupSearch.PerformLayout();
			this.SideBarPanel.ResumeLayout(false);
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
		private MetroFramework.Controls.MetroTabControl ClientsTabsControl;
		private MetroFramework.Controls.MetroTabPage RoomsTab;
		private MetroFramework.Controls.MetroTabPage ActivitiesTab;
		private MetroFramework.Controls.MetroTabPage TransportsTab;
		private System.Windows.Forms.GroupBox GroupSearch;
		private System.Windows.Forms.Button OkButton;
		private MetroFramework.Controls.MetroDateTime metroDateTime1;
		private System.Windows.Forms.Label BookingTypeLabel;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.Label label2;
		private MetroFramework.Controls.MetroDateTime metroDateTime2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label SubTypeLabel;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private System.Windows.Forms.Panel SideBarPanel;
		private MetroFramework.Controls.MetroTile SearchTile;
		private MetroFramework.Controls.MetroTile LogoffTile;
		private MetroFramework.Controls.MetroTile PrefrencesTile;

	}
}