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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.SearchDataGrid = new MetroFramework.Controls.MetroGrid();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.SearchParameter2Label = new System.Windows.Forms.Label();
			this.SearchParameter3 = new MetroFramework.Controls.MetroDateTime();
			this.SearchParameter2 = new MetroFramework.Controls.MetroDateTime();
			this.SearchParameter1Label = new System.Windows.Forms.Label();
			this.SearchParameter1 = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.SearchFilterComboBox = new MetroFramework.Controls.MetroComboBox();
			this.SearchByComboBox = new MetroFramework.Controls.MetroComboBox();
			this.SearchFilterLabel = new System.Windows.Forms.Label();
			this.SearchByLabel = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).BeginInit();
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
			this.BodyPanel.Controls.Add(this.SearchDataGrid);
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 469);
			this.BodyPanel.TabIndex = 16;
			// 
			// SearchDataGrid
			// 
			this.SearchDataGrid.AllowUserToAddRows = false;
			this.SearchDataGrid.AllowUserToDeleteRows = false;
			this.SearchDataGrid.AllowUserToOrderColumns = true;
			this.SearchDataGrid.AllowUserToResizeColumns = false;
			this.SearchDataGrid.AllowUserToResizeRows = false;
			this.SearchDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.SearchDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.SearchDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.SearchDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SearchDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.SearchDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.SearchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.SearchDataGrid.ColumnHeadersHeight = 60;
			this.SearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.SearchDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.SearchDataGrid.EnableHeadersVisualStyles = false;
			this.SearchDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.SearchDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.SearchDataGrid.Location = new System.Drawing.Point(284, 13);
			this.SearchDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.SearchDataGrid.Name = "SearchDataGrid";
			this.SearchDataGrid.ReadOnly = true;
			this.SearchDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.SearchDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.SearchDataGrid.RowHeadersWidth = 50;
			this.SearchDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.SearchDataGrid.RowTemplate.Height = 25;
			this.SearchDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.SearchDataGrid.Size = new System.Drawing.Size(900, 441);
			this.SearchDataGrid.TabIndex = 25;
			// 
			// GroupSearch
			// 
			this.GroupSearch.Controls.Add(this.SearchParameter2Label);
			this.GroupSearch.Controls.Add(this.SearchParameter3);
			this.GroupSearch.Controls.Add(this.SearchParameter2);
			this.GroupSearch.Controls.Add(this.SearchParameter1Label);
			this.GroupSearch.Controls.Add(this.SearchParameter1);
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Controls.Add(this.SearchFilterComboBox);
			this.GroupSearch.Controls.Add(this.SearchByComboBox);
			this.GroupSearch.Controls.Add(this.SearchFilterLabel);
			this.GroupSearch.Controls.Add(this.SearchByLabel);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(18, 1);
			this.GroupSearch.Margin = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Padding = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Size = new System.Drawing.Size(252, 453);
			this.GroupSearch.TabIndex = 24;
			this.GroupSearch.TabStop = false;
			// 
			// SearchParameter2Label
			// 
			this.SearchParameter2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchParameter2Label.AutoSize = true;
			this.SearchParameter2Label.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchParameter2Label.ForeColor = System.Drawing.Color.White;
			this.SearchParameter2Label.Location = new System.Drawing.Point(16, 284);
			this.SearchParameter2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SearchParameter2Label.Name = "SearchParameter2Label";
			this.SearchParameter2Label.Size = new System.Drawing.Size(202, 30);
			this.SearchParameter2Label.TabIndex = 29;
			this.SearchParameter2Label.Text = "Search Parameter 2";
			this.SearchParameter2Label.Visible = false;
			// 
			// SearchParameter3
			// 
			this.SearchParameter3.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.SearchParameter3.Location = new System.Drawing.Point(21, 317);
			this.SearchParameter3.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.SearchParameter3.MinimumSize = new System.Drawing.Size(0, 35);
			this.SearchParameter3.Name = "SearchParameter3";
			this.SearchParameter3.Size = new System.Drawing.Size(207, 35);
			this.SearchParameter3.TabIndex = 28;
			this.SearchParameter3.Visible = false;
			// 
			// SearchParameter2
			// 
			this.SearchParameter2.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.SearchParameter2.Location = new System.Drawing.Point(21, 229);
			this.SearchParameter2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.SearchParameter2.MinimumSize = new System.Drawing.Size(0, 35);
			this.SearchParameter2.Name = "SearchParameter2";
			this.SearchParameter2.Size = new System.Drawing.Size(207, 35);
			this.SearchParameter2.TabIndex = 28;
			this.SearchParameter2.Visible = false;
			// 
			// SearchParameter1Label
			// 
			this.SearchParameter1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchParameter1Label.AutoSize = true;
			this.SearchParameter1Label.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchParameter1Label.ForeColor = System.Drawing.Color.White;
			this.SearchParameter1Label.Location = new System.Drawing.Point(16, 196);
			this.SearchParameter1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SearchParameter1Label.Name = "SearchParameter1Label";
			this.SearchParameter1Label.Size = new System.Drawing.Size(202, 30);
			this.SearchParameter1Label.TabIndex = 27;
			this.SearchParameter1Label.Text = "Search Parameter 1";
			this.SearchParameter1Label.Visible = false;
			// 
			// SearchParameter1
			// 
			this.SearchParameter1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchParameter1.Location = new System.Drawing.Point(21, 229);
			this.SearchParameter1.Name = "SearchParameter1";
			this.SearchParameter1.Size = new System.Drawing.Size(207, 35);
			this.SearchParameter1.TabIndex = 26;
			this.SearchParameter1.Visible = false;
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(21, 380);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(211, 60);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "Search";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// SearchFilterComboBox
			// 
			this.SearchFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchFilterComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.SearchFilterComboBox.FormattingEnabled = true;
			this.SearchFilterComboBox.ItemHeight = 29;
			this.SearchFilterComboBox.Location = new System.Drawing.Point(21, 140);
			this.SearchFilterComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SearchFilterComboBox.Name = "SearchFilterComboBox";
			this.SearchFilterComboBox.Size = new System.Drawing.Size(211, 35);
			this.SearchFilterComboBox.TabIndex = 14;
			this.SearchFilterComboBox.UseSelectable = true;
			this.SearchFilterComboBox.SelectedValueChanged += new System.EventHandler(this.SeachFilterComboBox_SelectedValueChanged);
			// 
			// SearchByComboBox
			// 
			this.SearchByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchByComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.SearchByComboBox.FormattingEnabled = true;
			this.SearchByComboBox.ItemHeight = 29;
			this.SearchByComboBox.Location = new System.Drawing.Point(21, 59);
			this.SearchByComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SearchByComboBox.Name = "SearchByComboBox";
			this.SearchByComboBox.Size = new System.Drawing.Size(211, 35);
			this.SearchByComboBox.TabIndex = 24;
			this.SearchByComboBox.UseSelectable = true;
			this.SearchByComboBox.SelectedValueChanged += new System.EventHandler(this.SearchByComboBox_SelectedValueChanged);
			// 
			// SearchFilterLabel
			// 
			this.SearchFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchFilterLabel.AutoSize = true;
			this.SearchFilterLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchFilterLabel.ForeColor = System.Drawing.Color.White;
			this.SearchFilterLabel.Location = new System.Drawing.Point(16, 108);
			this.SearchFilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SearchFilterLabel.Name = "SearchFilterLabel";
			this.SearchFilterLabel.Size = new System.Drawing.Size(132, 30);
			this.SearchFilterLabel.TabIndex = 25;
			this.SearchFilterLabel.Text = "Search Filter";
			// 
			// SearchByLabel
			// 
			this.SearchByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchByLabel.AutoSize = true;
			this.SearchByLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.SearchByLabel.ForeColor = System.Drawing.Color.White;
			this.SearchByLabel.Location = new System.Drawing.Point(16, 27);
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
			((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).EndInit();
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
		private System.Windows.Forms.Label SearchFilterLabel;
		private MetroFramework.Controls.MetroComboBox SearchByComboBox;
		private System.Windows.Forms.Label SearchByLabel;
		private MetroFramework.Controls.MetroComboBox SearchFilterComboBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TextBox SearchParameter1;
		private System.Windows.Forms.Label SearchParameter1Label;
		private System.Windows.Forms.Label SearchParameter2Label;
		private MetroFramework.Controls.MetroDateTime SearchParameter3;
		private MetroFramework.Controls.MetroDateTime SearchParameter2;
		private MetroFramework.Controls.MetroGrid SearchDataGrid;

	}
}