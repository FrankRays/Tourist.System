namespace Tourist.Server.Forms
{
	partial class EmployersForm
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
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.FowardPanel = new System.Windows.Forms.Panel();
			this.HomePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.LogoffTile = new MetroFramework.Controls.MetroTile();
			this.PrefrencesTile = new MetroFramework.Controls.MetroTile();
			this.SearchTile = new MetroFramework.Controls.MetroTile();
			this.FooterPanel.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.SideBarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Location = new System.Drawing.Point(-1, 183);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1368, 561);
			this.BodyPanel.TabIndex = 19;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Controls.Add(this.FowardPanel);
			this.FooterPanel.Controls.Add(this.HomePanel);
			this.FooterPanel.Controls.Add(this.BackPanel);
			this.FooterPanel.Location = new System.Drawing.Point(-1, 750);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1368, 150);
			this.FooterPanel.TabIndex = 18;
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
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 27);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1368, 150);
			this.HeaderPanel.TabIndex = 17;
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
			this.SubTitleLabel.Size = new System.Drawing.Size(261, 38);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Manage Employers ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(23, 3);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(418, 65);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Employers Details";
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
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.employers;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1140, 28);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(204, 92);
			this.ImagePanel.TabIndex = 14;
			// 
			// SideBarPanel
			// 
			this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SideBarPanel.Controls.Add(this.LogoffTile);
			this.SideBarPanel.Controls.Add(this.PrefrencesTile);
			this.SideBarPanel.Controls.Add(this.SearchTile);
			this.SideBarPanel.Location = new System.Drawing.Point(1217, 24);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(150, 876);
			this.SideBarPanel.TabIndex = 20;
			// 
			// LogoffTile
			// 
			this.LogoffTile.ActiveControl = null;
			this.LogoffTile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LogoffTile.Location = new System.Drawing.Point(0, 615);
			this.LogoffTile.Name = "LogoffTile";
			this.LogoffTile.Size = new System.Drawing.Size(144, 105);
			this.LogoffTile.TabIndex = 0;
			this.LogoffTile.Text = "LogOff";
			this.LogoffTile.TileImage = global::Tourist.Server.Properties.Resources.PowerOff;
			this.LogoffTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LogoffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.LogoffTile.UseSelectable = true;
			this.LogoffTile.UseTileImage = true;
			// 
			// PrefrencesTile
			// 
			this.PrefrencesTile.ActiveControl = null;
			this.PrefrencesTile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PrefrencesTile.Location = new System.Drawing.Point(3, 383);
			this.PrefrencesTile.Name = "PrefrencesTile";
			this.PrefrencesTile.Size = new System.Drawing.Size(141, 105);
			this.PrefrencesTile.TabIndex = 0;
			this.PrefrencesTile.Text = "Preferences";
			this.PrefrencesTile.TileImage = global::Tourist.Server.Properties.Resources.preferences;
			this.PrefrencesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PrefrencesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PrefrencesTile.UseSelectable = true;
			this.PrefrencesTile.UseTileImage = true;
			// 
			// SearchTile
			// 
			this.SearchTile.ActiveControl = null;
			this.SearchTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SearchTile.Location = new System.Drawing.Point(0, 156);
			this.SearchTile.Name = "SearchTile";
			this.SearchTile.Size = new System.Drawing.Size(144, 105);
			this.SearchTile.TabIndex = 0;
			this.SearchTile.Text = "Search";
			this.SearchTile.TileImage = global::Tourist.Server.Properties.Resources.Magnifier;
			this.SearchTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SearchTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SearchTile.UseSelectable = true;
			this.SearchTile.UseTileImage = true;
			// 
			// EmployersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 900);
			this.Controls.Add(this.SideBarPanel);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Name = "EmployersForm";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.FooterPanel.ResumeLayout(false);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.SideBarPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FowardPanel;
		private System.Windows.Forms.Panel HomePanel;
		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Panel SideBarPanel;
		private MetroFramework.Controls.MetroTile LogoffTile;
		private MetroFramework.Controls.MetroTile PrefrencesTile;
		private MetroFramework.Controls.MetroTile SearchTile;
	}
}