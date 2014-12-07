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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.WrapperPanelGrid = new System.Windows.Forms.Panel();
			this.ClientsGrid = new MetroFramework.Controls.MetroGrid();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroTile6 = new MetroFramework.Controls.MetroTile();
			this.GroupSearch = new System.Windows.Forms.GroupBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.FowardPanel = new System.Windows.Forms.Panel();
			this.HomePanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.EmployerIDHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployerNameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployerBirthDateHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployerGenderHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployerFiscalNumberHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployerConctactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UsernameEmployerHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PasswordEmployerHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BodyPanel.SuspendLayout();
			this.WrapperPanelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
			this.GroupSearch.SuspendLayout();
			this.FooterPanel.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.WrapperPanelGrid);
			this.BodyPanel.Controls.Add(this.GroupSearch);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 149);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 525);
			this.BodyPanel.TabIndex = 19;
			// 
			// WrapperPanelGrid
			// 
			this.WrapperPanelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WrapperPanelGrid.BackColor = System.Drawing.Color.White;
			this.WrapperPanelGrid.Controls.Add(this.ClientsGrid);
			this.WrapperPanelGrid.Controls.Add(this.metroTile5);
			this.WrapperPanelGrid.Controls.Add(this.metroTile6);
			this.WrapperPanelGrid.Location = new System.Drawing.Point(231, 27);
			this.WrapperPanelGrid.Name = "WrapperPanelGrid";
			this.WrapperPanelGrid.Size = new System.Drawing.Size(953, 482);
			this.WrapperPanelGrid.TabIndex = 25;
			// 
			// ClientsGrid
			// 
			this.ClientsGrid.AllowUserToOrderColumns = true;
			this.ClientsGrid.AllowUserToResizeRows = false;
			this.ClientsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ClientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ClientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ClientsGrid.ColumnHeadersHeight = 60;
			this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployerIDHeader,
            this.EmployerNameHeader,
            this.EmployerBirthDateHeader,
            this.EmployerGenderHeader,
            this.EmployerFiscalNumberHeader,
            this.EmployerConctactNumber,
            this.UsernameEmployerHeader,
            this.PasswordEmployerHeader});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClientsGrid.EnableHeadersVisualStyles = false;
			this.ClientsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ClientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsGrid.Location = new System.Drawing.Point(2, 33);
			this.ClientsGrid.Margin = new System.Windows.Forms.Padding(2);
			this.ClientsGrid.Name = "ClientsGrid";
			this.ClientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ClientsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.ClientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ClientsGrid.RowTemplate.Height = 24;
			this.ClientsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientsGrid.Size = new System.Drawing.Size(949, 449);
			this.ClientsGrid.TabIndex = 17;
			// 
			// metroTile5
			// 
			this.metroTile5.ActiveControl = null;
			this.metroTile5.AutoSize = true;
			this.metroTile5.Location = new System.Drawing.Point(114, 3);
			this.metroTile5.Margin = new System.Windows.Forms.Padding(2);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(108, 26);
			this.metroTile5.TabIndex = 16;
			this.metroTile5.Text = "x Remove";
			this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile5.UseSelectable = true;
			this.metroTile5.UseTileImage = true;
			// 
			// metroTile6
			// 
			this.metroTile6.ActiveControl = null;
			this.metroTile6.AutoSize = true;
			this.metroTile6.Location = new System.Drawing.Point(2, 3);
			this.metroTile6.Margin = new System.Windows.Forms.Padding(2);
			this.metroTile6.Name = "metroTile6";
			this.metroTile6.Size = new System.Drawing.Size(108, 26);
			this.metroTile6.TabIndex = 15;
			this.metroTile6.Text = " + Add";
			this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile6.UseSelectable = true;
			// 
			// GroupSearch
			// 
			this.GroupSearch.Controls.Add(this.OkButton);
			this.GroupSearch.Controls.Add(this.textBox1);
			this.GroupSearch.Controls.Add(this.metroComboBox1);
			this.GroupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupSearch.ForeColor = System.Drawing.Color.White;
			this.GroupSearch.Location = new System.Drawing.Point(18, 15);
			this.GroupSearch.Margin = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Name = "GroupSearch";
			this.GroupSearch.Padding = new System.Windows.Forms.Padding(2);
			this.GroupSearch.Size = new System.Drawing.Size(197, 157);
			this.GroupSearch.TabIndex = 24;
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
			this.FooterPanel.Controls.Add(this.FowardPanel);
			this.FooterPanel.Controls.Add(this.HomePanel);
			this.FooterPanel.Controls.Add(this.BackPanel);
			this.FooterPanel.Location = new System.Drawing.Point(-1, 678);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1202, 122);
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
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 22);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 122);
			this.HeaderPanel.TabIndex = 17;
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
			this.SubTitleLabel.Location = new System.Drawing.Point(24, 70);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(205, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Manage Employers ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(17, 5);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(328, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Employers Details";
			// 
			// FowardPanel
			// 
			this.FowardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FowardPanel.AutoSize = true;
			this.FowardPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.RightArrow;
			this.FowardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.FowardPanel.Location = new System.Drawing.Point(1122, 14);
			this.FowardPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FowardPanel.Name = "FowardPanel";
			this.FowardPanel.Size = new System.Drawing.Size(62, 95);
			this.FowardPanel.TabIndex = 13;
			// 
			// HomePanel
			// 
			this.HomePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.HomePanel.AutoSize = true;
			this.HomePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.Home;
			this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.HomePanel.Location = new System.Drawing.Point(551, 14);
			this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
			this.HomePanel.Name = "HomePanel";
			this.HomePanel.Size = new System.Drawing.Size(111, 95);
			this.HomePanel.TabIndex = 14;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Server.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(19, 14);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 95);
			this.BackPanel.TabIndex = 15;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.employers;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1010, 15);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(174, 86);
			this.ImagePanel.TabIndex = 14;
			// 
			// EmployerIDHeader
			// 
			this.EmployerIDHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerIDHeader.HeaderText = "Employer ID";
			this.EmployerIDHeader.Name = "EmployerIDHeader";
			this.EmployerIDHeader.Width = 139;
			// 
			// EmployerNameHeader
			// 
			this.EmployerNameHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerNameHeader.HeaderText = "Employer Name";
			this.EmployerNameHeader.Name = "EmployerNameHeader";
			this.EmployerNameHeader.Width = 172;
			// 
			// EmployerBirthDateHeader
			// 
			this.EmployerBirthDateHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerBirthDateHeader.HeaderText = "Birth Date";
			this.EmployerBirthDateHeader.Name = "EmployerBirthDateHeader";
			this.EmployerBirthDateHeader.Width = 121;
			// 
			// EmployerGenderHeader
			// 
			this.EmployerGenderHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerGenderHeader.HeaderText = "Gender";
			this.EmployerGenderHeader.Name = "EmployerGenderHeader";
			this.EmployerGenderHeader.Width = 99;
			// 
			// EmployerFiscalNumberHeader
			// 
			this.EmployerFiscalNumberHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerFiscalNumberHeader.HeaderText = "Fiscal Number";
			this.EmployerFiscalNumberHeader.Name = "EmployerFiscalNumberHeader";
			this.EmployerFiscalNumberHeader.Width = 157;
			// 
			// EmployerConctactNumber
			// 
			this.EmployerConctactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.EmployerConctactNumber.HeaderText = "Contact Number";
			this.EmployerConctactNumber.Name = "EmployerConctactNumber";
			this.EmployerConctactNumber.Width = 177;
			// 
			// UsernameEmployerHeader
			// 
			this.UsernameEmployerHeader.HeaderText = "Username";
			this.UsernameEmployerHeader.Name = "UsernameEmployerHeader";
			// 
			// PasswordEmployerHeader
			// 
			this.PasswordEmployerHeader.HeaderText = "Password";
			this.PasswordEmployerHeader.Name = "PasswordEmployerHeader";
			// 
			// EmployersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EmployersForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.BodyPanel.ResumeLayout(false);
			this.WrapperPanelGrid.ResumeLayout(false);
			this.WrapperPanelGrid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
			this.GroupSearch.ResumeLayout(false);
			this.GroupSearch.PerformLayout();
			this.FooterPanel.ResumeLayout(false);
			this.FooterPanel.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel WrapperPanelGrid;
		private MetroFramework.Controls.MetroGrid ClientsGrid;
		private MetroFramework.Controls.MetroTile metroTile5;
		private MetroFramework.Controls.MetroTile metroTile6;
		private System.Windows.Forms.GroupBox GroupSearch;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TextBox textBox1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private System.Windows.Forms.Panel FowardPanel;
		private System.Windows.Forms.Panel HomePanel;
		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerIDHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerNameHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerBirthDateHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerGenderHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerFiscalNumberHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployerConctactNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn UsernameEmployerHeader;
		private System.Windows.Forms.DataGridViewTextBoxColumn PasswordEmployerHeader;
	}
}