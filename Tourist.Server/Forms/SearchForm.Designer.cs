namespace Tourist.Server.Forms
{
	partial class SearchForm
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
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.EndDateLabel = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.SeachFilterComboBox = new MetroFramework.Controls.MetroComboBox();
			this.SearchByComboBox = new MetroFramework.Controls.MetroComboBox();
			this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
			this.StartDateLabel = new System.Windows.Forms.Label();
			this.SearchFilterLabel = new System.Windows.Forms.Label();
			this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
			this.SearchByLabel = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.GroupSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.BackPanel);
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 23);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 150);
			this.HeaderPanel.TabIndex = 14;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.MagnifierBig;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1091, 30);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(93, 92);
			this.ImagePanel.TabIndex = 13;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 34);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 85);
			this.BackPanel.TabIndex = 15;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(107, 86);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(163, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Search Services";
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
			this.TitleLabel.Size = new System.Drawing.Size(137, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Search";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 469);
			this.BodyPanel.TabIndex = 16;
			// 
			// GroupSearch
			// 
			this.GroupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.GroupSearch.Controls.Add(this.EndDateLabel);
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Controls.Add(this.SeachFilterComboBox);
			this.GroupSearch.Controls.Add(this.SearchByComboBox);
			this.GroupSearch.Controls.Add(this.metroDateTime1);
			this.GroupSearch.Controls.Add(this.StartDateLabel);
			this.GroupSearch.Controls.Add(this.SearchFilterLabel);
			this.GroupSearch.Controls.Add(this.metroDateTime2);
			this.GroupSearch.Controls.Add(this.SearchByLabel);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(18, 0);
			this.GroupSearch.Margin = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Padding = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Size = new System.Drawing.Size(252, 459);
			this.GroupSearch.TabIndex = 24;
			this.GroupSearch.TabStop = false;
			// 
			// EndDateLabel
			// 
			this.EndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.EndDateLabel.AutoSize = true;
			this.EndDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.EndDateLabel.ForeColor = System.Drawing.Color.White;
			this.EndDateLabel.Location = new System.Drawing.Point(21, 286);
			this.EndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EndDateLabel.Name = "EndDateLabel";
			this.EndDateLabel.Size = new System.Drawing.Size(103, 30);
			this.EndDateLabel.TabIndex = 28;
			this.EndDateLabel.Text = "End-Date";
			// 
			// OkButton
			// 
			this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(21, 374);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(211, 71);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "Search";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// SeachFilterComboBox
			// 
			this.SeachFilterComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SeachFilterComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.SeachFilterComboBox.FormattingEnabled = true;
			this.SeachFilterComboBox.ItemHeight = 29;
			this.SeachFilterComboBox.Location = new System.Drawing.Point(21, 142);
			this.SeachFilterComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SeachFilterComboBox.Name = "SeachFilterComboBox";
			this.SeachFilterComboBox.Size = new System.Drawing.Size(211, 35);
			this.SeachFilterComboBox.TabIndex = 14;
			this.SeachFilterComboBox.UseSelectable = true;
			// 
			// SearchByComboBox
			// 
			this.SearchByComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SearchByComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.SearchByComboBox.FormattingEnabled = true;
			this.SearchByComboBox.ItemHeight = 29;
			this.SearchByComboBox.Items.AddRange(new object[] {
            "Bookings",
            "Bookables",
            "Clients",
            "Employees",
            "Managers"});
			this.SearchByComboBox.Location = new System.Drawing.Point(21, 53);
			this.SearchByComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SearchByComboBox.Name = "SearchByComboBox";
			this.SearchByComboBox.Size = new System.Drawing.Size(211, 35);
			this.SearchByComboBox.TabIndex = 24;
			this.SearchByComboBox.UseSelectable = true;
			this.SearchByComboBox.SelectedValueChanged += new System.EventHandler(this.SearchByComboBox_SelectedValueChanged);
			// 
			// metroDateTime1
			// 
			this.metroDateTime1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.metroDateTime1.Location = new System.Drawing.Point(21, 319);
			this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 35);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new System.Drawing.Size(211, 35);
			this.metroDateTime1.TabIndex = 12;
			// 
			// StartDateLabel
			// 
			this.StartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.StartDateLabel.AutoSize = true;
			this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.StartDateLabel.ForeColor = System.Drawing.Color.White;
			this.StartDateLabel.Location = new System.Drawing.Point(21, 194);
			this.StartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.StartDateLabel.Name = "StartDateLabel";
			this.StartDateLabel.Size = new System.Drawing.Size(112, 30);
			this.StartDateLabel.TabIndex = 26;
			this.StartDateLabel.Text = "Start-Date";
			// 
			// SearchFilterLabel
			// 
			this.SearchFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SearchFilterLabel.AutoSize = true;
			this.SearchFilterLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchFilterLabel.ForeColor = System.Drawing.Color.White;
			this.SearchFilterLabel.Location = new System.Drawing.Point(21, 110);
			this.SearchFilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SearchFilterLabel.Name = "SearchFilterLabel";
			this.SearchFilterLabel.Size = new System.Drawing.Size(132, 30);
			this.SearchFilterLabel.TabIndex = 25;
			this.SearchFilterLabel.Text = "Search Filter";
			// 
			// metroDateTime2
			// 
			this.metroDateTime2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.metroDateTime2.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.metroDateTime2.Location = new System.Drawing.Point(21, 230);
			this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 35);
			this.metroDateTime2.Name = "metroDateTime2";
			this.metroDateTime2.Size = new System.Drawing.Size(211, 35);
			this.metroDateTime2.TabIndex = 27;
			// 
			// SearchByLabel
			// 
			this.SearchByLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SearchByLabel.AutoSize = true;
			this.SearchByLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchByLabel.ForeColor = System.Drawing.Color.White;
			this.SearchByLabel.Location = new System.Drawing.Point(16, 21);
			this.SearchByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SearchByLabel.Name = "SearchByLabel";
			this.SearchByLabel.Size = new System.Drawing.Size(108, 30);
			this.SearchByLabel.TabIndex = 23;
			this.SearchByLabel.Text = "Search By";
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
			// SearchForm
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
			this.Movable = false;
			this.Name = "SearchForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ToolsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.GroupSearch.ResumeLayout(false);
			this.GroupSearch.PerformLayout();
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
		private System.Windows.Forms.GroupBox GroupSearch;
		private System.Windows.Forms.Label EndDateLabel;
		private MetroFramework.Controls.MetroDateTime metroDateTime2;
		private System.Windows.Forms.Label StartDateLabel;
		private System.Windows.Forms.Label SearchFilterLabel;
		private MetroFramework.Controls.MetroComboBox SearchByComboBox;
		private System.Windows.Forms.Label SearchByLabel;
		private MetroFramework.Controls.MetroComboBox SeachFilterComboBox;
		private MetroFramework.Controls.MetroDateTime metroDateTime1;
		private System.Windows.Forms.Button OkButton;

	}
}