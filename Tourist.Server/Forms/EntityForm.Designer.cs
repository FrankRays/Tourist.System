namespace Tourist.Server.Forms
{
	partial class EntityForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityForm));
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.BasicInformation = new System.Windows.Forms.GroupBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.LogoLabel = new System.Windows.Forms.Label();
			this.TypeComboBox = new MetroFramework.Controls.MetroComboBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NifTextBox = new System.Windows.Forms.TextBox();
			this.TypeLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NifLabel = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.LogoLoad = new System.Windows.Forms.OpenFileDialog();
			this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.EditButton = new System.Windows.Forms.Button();
			this.LogoWrapper = new System.Windows.Forms.Panel();
			this.LogoPictureBox = new System.Windows.Forms.PictureBox();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.BodyPanel.SuspendLayout();
			this.BasicInformation.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
			this.LogoWrapper.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.BasicInformation);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 176);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 470);
			this.BodyPanel.TabIndex = 19;
			// 
			// BasicInformation
			// 
			this.BasicInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BasicInformation.Controls.Add(this.EditButton);
			this.BasicInformation.Controls.Add(this.LogoWrapper);
			this.BasicInformation.Controls.Add(this.SaveButton);
			this.BasicInformation.Controls.Add(this.AddressLabel);
			this.BasicInformation.Controls.Add(this.PhoneLabel);
			this.BasicInformation.Controls.Add(this.EmailLabel);
			this.BasicInformation.Controls.Add(this.EmailTextBox);
			this.BasicInformation.Controls.Add(this.AddressTextBox);
			this.BasicInformation.Controls.Add(this.PhoneTextBox);
			this.BasicInformation.Controls.Add(this.LogoLabel);
			this.BasicInformation.Controls.Add(this.TypeComboBox);
			this.BasicInformation.Controls.Add(this.NameLabel);
			this.BasicInformation.Controls.Add(this.NifTextBox);
			this.BasicInformation.Controls.Add(this.TypeLabel);
			this.BasicInformation.Controls.Add(this.NameTextBox);
			this.BasicInformation.Controls.Add(this.NifLabel);
			this.BasicInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BasicInformation.ForeColor = System.Drawing.Color.White;
			this.BasicInformation.Location = new System.Drawing.Point(164, 0);
			this.BasicInformation.Margin = new System.Windows.Forms.Padding(2);
			this.BasicInformation.Name = "BasicInformation";
			this.BasicInformation.Padding = new System.Windows.Forms.Padding(2);
			this.BasicInformation.Size = new System.Drawing.Size(907, 468);
			this.BasicInformation.TabIndex = 40;
			this.BasicInformation.TabStop = false;
			this.BasicInformation.Text = "Basic Information";
			// 
			// SaveButton
			// 
			this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.Color.White;
			this.SaveButton.Location = new System.Drawing.Point(643, 346);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(110, 105);
			this.SaveButton.TabIndex = 46;
			this.SaveButton.Text = "SAVE";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddressLabel.ForeColor = System.Drawing.Color.White;
			this.AddressLabel.Location = new System.Drawing.Point(65, 272);
			this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(107, 28);
			this.AddressLabel.TabIndex = 40;
			this.AddressLabel.Text = "Address (*)";
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneLabel.ForeColor = System.Drawing.Color.White;
			this.PhoneLabel.Location = new System.Drawing.Point(80, 349);
			this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(92, 28);
			this.PhoneLabel.TabIndex = 41;
			this.PhoneLabel.Text = "Phone (*)";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailLabel.ForeColor = System.Drawing.Color.White;
			this.EmailLabel.Location = new System.Drawing.Point(88, 416);
			this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(84, 28);
			this.EmailLabel.TabIndex = 42;
			this.EmailLabel.Text = "Email (*)";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.EmailTextBox.Location = new System.Drawing.Point(199, 416);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(405, 34);
			this.EmailTextBox.TabIndex = 45;
			this.EmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTextBox_Validating);
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.AddressTextBox.Location = new System.Drawing.Point(199, 269);
			this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(577, 34);
			this.AddressTextBox.TabIndex = 43;
			this.AddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressTextBox_Validating);
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.PhoneTextBox.Location = new System.Drawing.Point(199, 346);
			this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(405, 34);
			this.PhoneTextBox.TabIndex = 44;
			this.PhoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneTextBox_Validating);
			// 
			// LogoLabel
			// 
			this.LogoLabel.AutoSize = true;
			this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogoLabel.ForeColor = System.Drawing.Color.White;
			this.LogoLabel.Location = new System.Drawing.Point(62, 45);
			this.LogoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LogoLabel.Name = "LogoLabel";
			this.LogoLabel.Size = new System.Drawing.Size(57, 28);
			this.LogoLabel.TabIndex = 26;
			this.LogoLabel.Text = "Logo";
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.TypeComboBox.DisplayFocus = true;
			this.TypeComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.ItemHeight = 29;
			this.TypeComboBox.Items.AddRange(new object[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.TypeComboBox.Location = new System.Drawing.Point(351, 126);
			this.TypeComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(425, 35);
			this.TypeComboBox.TabIndex = 39;
			this.TypeComboBox.UseSelectable = true;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.ForeColor = System.Drawing.Color.White;
			this.NameLabel.Location = new System.Drawing.Point(246, 45);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(89, 28);
			this.NameLabel.TabIndex = 27;
			this.NameLabel.Text = "Name (*)";
			// 
			// NifTextBox
			// 
			this.NifTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.NifTextBox.ForeColor = System.Drawing.Color.Black;
			this.NifTextBox.Location = new System.Drawing.Point(351, 204);
			this.NifTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.NifTextBox.Name = "NifTextBox";
			this.NifTextBox.Size = new System.Drawing.Size(425, 34);
			this.NifTextBox.TabIndex = 37;
			this.NifTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NifTextBox_Validating);
			// 
			// TypeLabel
			// 
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TypeLabel.ForeColor = System.Drawing.Color.White;
			this.TypeLabel.Location = new System.Drawing.Point(256, 126);
			this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(79, 28);
			this.TypeLabel.TabIndex = 28;
			this.TypeLabel.Text = "Type (*)";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.NameTextBox.Location = new System.Drawing.Point(351, 45);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(425, 34);
			this.NameTextBox.TabIndex = 36;
			this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
			// 
			// NifLabel
			// 
			this.NifLabel.AutoSize = true;
			this.NifLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NifLabel.ForeColor = System.Drawing.Color.White;
			this.NifLabel.Location = new System.Drawing.Point(272, 204);
			this.NifLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NifLabel.Name = "NifLabel";
			this.NifLabel.Size = new System.Drawing.Size(63, 28);
			this.NifLabel.TabIndex = 29;
			this.NifLabel.Text = "Nif (*)";
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
			this.FooterPanel.TabIndex = 18;
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
			this.HeaderPanel.Location = new System.Drawing.Point(-1, 22);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1202, 150);
			this.HeaderPanel.TabIndex = 17;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(105, 86);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(242, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Basic Information Setup";
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
			this.TitleLabel.Size = new System.Drawing.Size(121, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Entity";
			// 
			// LogoLoad
			// 
			this.LogoLoad.Filter = "PNG|*.png|JPEG|*.jpg";
			// 
			// ErrorProvider
			// 
			this.ErrorProvider.ContainerControl = this;
			this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.EditButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditButton.ForeColor = System.Drawing.Color.White;
			this.EditButton.Location = new System.Drawing.Point(775, 346);
			this.EditButton.Margin = new System.Windows.Forms.Padding(2);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(110, 105);
			this.EditButton.TabIndex = 48;
			this.EditButton.Text = "EDIT ";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// LogoWrapper
			// 
			this.LogoWrapper.BackgroundImage = global::Tourist.Server.Properties.Resources.LogoFrame;
			this.LogoWrapper.Controls.Add(this.LogoPictureBox);
			this.LogoWrapper.Location = new System.Drawing.Point(68, 81);
			this.LogoWrapper.Name = "LogoWrapper";
			this.LogoWrapper.Size = new System.Drawing.Size(160, 160);
			this.LogoWrapper.TabIndex = 47;
			// 
			// LogoPictureBox
			// 
			this.LogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LogoPictureBox.Location = new System.Drawing.Point(5, 5);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new System.Drawing.Size(150, 150);
			this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.LogoPictureBox.TabIndex = 25;
			this.LogoPictureBox.TabStop = false;
			this.LogoPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoPictureBox_MouseClick);
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
			this.BackPanel.TabIndex = 12;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.Entity;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1056, 26);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(128, 102);
			this.ImagePanel.TabIndex = 13;
			// 
			// EntityForm
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
			this.Name = "EntityForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.EntitiesForm_Load);
			this.BodyPanel.ResumeLayout(false);
			this.BasicInformation.ResumeLayout(false);
			this.BasicInformation.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
			this.LogoWrapper.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel BackPanel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label NifLabel;
		private System.Windows.Forms.Label TypeLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label LogoLabel;
		private System.Windows.Forms.TextBox NifTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.GroupBox BasicInformation;
		private System.Windows.Forms.Label AddressLabel;
		private System.Windows.Forms.Label PhoneLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox AddressTextBox;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private MetroFramework.Controls.MetroComboBox TypeComboBox;
		private System.Windows.Forms.OpenFileDialog LogoLoad;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ErrorProvider ErrorProvider;
		private System.Windows.Forms.Panel LogoWrapper;
		private System.Windows.Forms.PictureBox LogoPictureBox;
		private System.Windows.Forms.Button EditButton;


	}
}