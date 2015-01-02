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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsForm));
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.BackPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.BookingInfo = new System.Windows.Forms.GroupBox();
			this.BookingData = new System.Windows.Forms.GroupBox();
			this.BookingDateTextBox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.TotalPriceLabel = new System.Windows.Forms.TextBox();
			this.EditButton = new System.Windows.Forms.Button();
			this.BookingIDLabel = new System.Windows.Forms.Label();
			this.BookingIdTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EndDatePicker = new MetroFramework.Controls.MetroDateTime();
			this.StartDatePicker = new MetroFramework.Controls.MetroDateTime();
			this.EndDateLabel = new System.Windows.Forms.Label();
			this.StartDateLabel = new System.Windows.Forms.Label();
			this.BookingDateLabel = new System.Windows.Forms.Label();
			this.BookableData = new System.Windows.Forms.GroupBox();
			this.BasePriceTextBox = new System.Windows.Forms.TextBox();
			this.BasePriceLabel = new System.Windows.Forms.Label();
			this.BookableIdComboBox = new MetroFramework.Controls.MetroComboBox();
			this.SubTypeComboBox = new MetroFramework.Controls.MetroComboBox();
			this.SubTypeLabel = new System.Windows.Forms.Label();
			this.TypeCombox = new MetroFramework.Controls.MetroComboBox();
			this.BookableIdLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionLabel = new System.Windows.Forms.Label();
			this.TypeLabel = new System.Windows.Forms.Label();
			this.ClientData = new System.Windows.Forms.GroupBox();
			this.NewClientButton = new System.Windows.Forms.Button();
			this.ClientIdLabel = new System.Windows.Forms.Label();
			this.NifComboBox = new MetroFramework.Controls.MetroComboBox();
			this.ClientIdTextBox = new System.Windows.Forms.TextBox();
			this.NifLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.BookingInfo.SuspendLayout();
			this.BookingData.SuspendLayout();
			this.BookableData.SuspendLayout();
			this.ClientData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
			this.BodyPanel.Controls.Add(this.BookingInfo);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 468);
			this.BodyPanel.TabIndex = 16;
			// 
			// BookingInfo
			// 
			this.BookingInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BookingInfo.Controls.Add(this.BookingData);
			this.BookingInfo.Controls.Add(this.BookableData);
			this.BookingInfo.Controls.Add(this.ClientData);
			this.BookingInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookingInfo.ForeColor = System.Drawing.Color.White;
			this.BookingInfo.Location = new System.Drawing.Point(80, -5);
			this.BookingInfo.Margin = new System.Windows.Forms.Padding(2);
			this.BookingInfo.Name = "BookingInfo";
			this.BookingInfo.Padding = new System.Windows.Forms.Padding(2);
			this.BookingInfo.Size = new System.Drawing.Size(1036, 468);
			this.BookingInfo.TabIndex = 41;
			this.BookingInfo.TabStop = false;
			// 
			// BookingData
			// 
			this.BookingData.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BookingData.Controls.Add(this.BookingDateTextBox);
			this.BookingData.Controls.Add(this.SaveButton);
			this.BookingData.Controls.Add(this.TotalPriceLabel);
			this.BookingData.Controls.Add(this.EditButton);
			this.BookingData.Controls.Add(this.BookingIDLabel);
			this.BookingData.Controls.Add(this.BookingIdTextBox);
			this.BookingData.Controls.Add(this.label3);
			this.BookingData.Controls.Add(this.EndDatePicker);
			this.BookingData.Controls.Add(this.StartDatePicker);
			this.BookingData.Controls.Add(this.EndDateLabel);
			this.BookingData.Controls.Add(this.StartDateLabel);
			this.BookingData.Controls.Add(this.BookingDateLabel);
			this.BookingData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookingData.ForeColor = System.Drawing.Color.White;
			this.BookingData.Location = new System.Drawing.Point(482, 18);
			this.BookingData.Margin = new System.Windows.Forms.Padding(2);
			this.BookingData.Name = "BookingData";
			this.BookingData.Padding = new System.Windows.Forms.Padding(2);
			this.BookingData.Size = new System.Drawing.Size(539, 434);
			this.BookingData.TabIndex = 51;
			this.BookingData.TabStop = false;
			this.BookingData.Text = "Booking";
			// 
			// BookingDateTextBox
			// 
			this.BookingDateTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.BookingDateTextBox.Location = new System.Drawing.Point(341, 43);
			this.BookingDateTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BookingDateTextBox.Name = "BookingDateTextBox";
			this.BookingDateTextBox.Size = new System.Drawing.Size(138, 34);
			this.BookingDateTextBox.TabIndex = 57;
			this.BookingDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SaveButton
			// 
			this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveButton.ForeColor = System.Drawing.Color.White;
			this.SaveButton.Location = new System.Drawing.Point(20, 359);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(240, 63);
			this.SaveButton.TabIndex = 46;
			this.SaveButton.Text = "SAVE";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// TotalPriceLabel
			// 
			this.TotalPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.TotalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalPriceLabel.ForeColor = System.Drawing.Color.White;
			this.TotalPriceLabel.Location = new System.Drawing.Point(5, 255);
			this.TotalPriceLabel.Margin = new System.Windows.Forms.Padding(2);
			this.TotalPriceLabel.Name = "TotalPriceLabel";
			this.TotalPriceLabel.Size = new System.Drawing.Size(531, 90);
			this.TotalPriceLabel.TabIndex = 56;
			this.TotalPriceLabel.Text = "0000.00€";
			this.TotalPriceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.EditButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditButton.ForeColor = System.Drawing.Color.White;
			this.EditButton.Location = new System.Drawing.Point(278, 359);
			this.EditButton.Margin = new System.Windows.Forms.Padding(2);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(240, 63);
			this.EditButton.TabIndex = 48;
			this.EditButton.Text = "EDIT ";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// BookingIDLabel
			// 
			this.BookingIDLabel.AutoSize = true;
			this.BookingIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookingIDLabel.ForeColor = System.Drawing.Color.White;
			this.BookingIDLabel.Location = new System.Drawing.Point(66, 43);
			this.BookingIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BookingIDLabel.Name = "BookingIDLabel";
			this.BookingIDLabel.Size = new System.Drawing.Size(31, 28);
			this.BookingIDLabel.TabIndex = 55;
			this.BookingIDLabel.Text = "ID";
			// 
			// BookingIdTextBox
			// 
			this.BookingIdTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.BookingIdTextBox.ForeColor = System.Drawing.Color.Black;
			this.BookingIdTextBox.Location = new System.Drawing.Point(108, 43);
			this.BookingIdTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BookingIdTextBox.Name = "BookingIdTextBox";
			this.BookingIdTextBox.Size = new System.Drawing.Size(75, 34);
			this.BookingIdTextBox.TabIndex = 54;
			this.BookingIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.BookingIdTextBox.TextChanged += new System.EventHandler(this.BookingIdTextBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(186, 209);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(195, 50);
			this.label3.TabIndex = 50;
			this.label3.Text = "Total Price";
			// 
			// EndDatePicker
			// 
			this.EndDatePicker.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.EndDatePicker.Location = new System.Drawing.Point(213, 154);
			this.EndDatePicker.MinimumSize = new System.Drawing.Size(0, 35);
			this.EndDatePicker.Name = "EndDatePicker";
			this.EndDatePicker.Size = new System.Drawing.Size(266, 35);
			this.EndDatePicker.TabIndex = 49;
			this.EndDatePicker.Value = new System.DateTime(2015, 1, 1, 19, 44, 29, 0);
			this.EndDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.EndDatePicker_Validating);
			// 
			// StartDatePicker
			// 
			this.StartDatePicker.FontSize = MetroFramework.MetroDateTimeSize.Tall;
			this.StartDatePicker.Location = new System.Drawing.Point(213, 95);
			this.StartDatePicker.MinimumSize = new System.Drawing.Size(0, 35);
			this.StartDatePicker.Name = "StartDatePicker";
			this.StartDatePicker.Size = new System.Drawing.Size(266, 35);
			this.StartDatePicker.TabIndex = 49;
			this.StartDatePicker.Value = new System.DateTime(2015, 1, 1, 19, 44, 34, 0);
			this.StartDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.StartDatePicker_Validating);
			// 
			// EndDateLabel
			// 
			this.EndDateLabel.AutoSize = true;
			this.EndDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EndDateLabel.ForeColor = System.Drawing.Color.White;
			this.EndDateLabel.Location = new System.Drawing.Point(75, 161);
			this.EndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EndDateLabel.Name = "EndDateLabel";
			this.EndDateLabel.Size = new System.Drawing.Size(119, 28);
			this.EndDateLabel.TabIndex = 27;
			this.EndDateLabel.Text = "End-Date (*)";
			// 
			// StartDateLabel
			// 
			this.StartDateLabel.AutoSize = true;
			this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartDateLabel.ForeColor = System.Drawing.Color.White;
			this.StartDateLabel.Location = new System.Drawing.Point(66, 100);
			this.StartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.StartDateLabel.Name = "StartDateLabel";
			this.StartDateLabel.Size = new System.Drawing.Size(128, 28);
			this.StartDateLabel.TabIndex = 27;
			this.StartDateLabel.Text = "Start-Date (*)";
			// 
			// BookingDateLabel
			// 
			this.BookingDateLabel.AutoSize = true;
			this.BookingDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookingDateLabel.ForeColor = System.Drawing.Color.White;
			this.BookingDateLabel.Location = new System.Drawing.Point(197, 43);
			this.BookingDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BookingDateLabel.Name = "BookingDateLabel";
			this.BookingDateLabel.Size = new System.Drawing.Size(131, 28);
			this.BookingDateLabel.TabIndex = 27;
			this.BookingDateLabel.Text = "Booking Date";
			// 
			// BookableData
			// 
			this.BookableData.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BookableData.Controls.Add(this.BasePriceTextBox);
			this.BookableData.Controls.Add(this.BasePriceLabel);
			this.BookableData.Controls.Add(this.BookableIdComboBox);
			this.BookableData.Controls.Add(this.SubTypeComboBox);
			this.BookableData.Controls.Add(this.SubTypeLabel);
			this.BookableData.Controls.Add(this.TypeCombox);
			this.BookableData.Controls.Add(this.BookableIdLabel);
			this.BookableData.Controls.Add(this.label4);
			this.BookableData.Controls.Add(this.textBox4);
			this.BookableData.Controls.Add(this.DescriptionTextBox);
			this.BookableData.Controls.Add(this.DescriptionLabel);
			this.BookableData.Controls.Add(this.TypeLabel);
			this.BookableData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookableData.ForeColor = System.Drawing.Color.White;
			this.BookableData.Location = new System.Drawing.Point(13, 196);
			this.BookableData.Margin = new System.Windows.Forms.Padding(2);
			this.BookableData.Name = "BookableData";
			this.BookableData.Padding = new System.Windows.Forms.Padding(2);
			this.BookableData.Size = new System.Drawing.Size(450, 256);
			this.BookableData.TabIndex = 50;
			this.BookableData.TabStop = false;
			this.BookableData.Text = "Bookable";
			// 
			// BasePriceTextBox
			// 
			this.BasePriceTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.BasePriceTextBox.Location = new System.Drawing.Point(331, 149);
			this.BasePriceTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.BasePriceTextBox.Name = "BasePriceTextBox";
			this.BasePriceTextBox.Size = new System.Drawing.Size(100, 34);
			this.BasePriceTextBox.TabIndex = 53;
			this.BasePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BasePriceLabel
			// 
			this.BasePriceLabel.AutoSize = true;
			this.BasePriceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BasePriceLabel.ForeColor = System.Drawing.Color.White;
			this.BasePriceLabel.Location = new System.Drawing.Point(229, 151);
			this.BasePriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BasePriceLabel.Name = "BasePriceLabel";
			this.BasePriceLabel.Size = new System.Drawing.Size(98, 28);
			this.BasePriceLabel.TabIndex = 52;
			this.BasePriceLabel.Text = "Base Price";
			// 
			// BookableIdComboBox
			// 
			this.BookableIdComboBox.DisplayFocus = true;
			this.BookableIdComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.BookableIdComboBox.FormattingEnabled = true;
			this.BookableIdComboBox.ItemHeight = 29;
			this.BookableIdComboBox.Items.AddRange(new object[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.BookableIdComboBox.Location = new System.Drawing.Point(142, 148);
			this.BookableIdComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.BookableIdComboBox.Name = "BookableIdComboBox";
			this.BookableIdComboBox.Size = new System.Drawing.Size(83, 35);
			this.BookableIdComboBox.TabIndex = 51;
			this.BookableIdComboBox.UseSelectable = true;
			this.BookableIdComboBox.SelectedValueChanged += new System.EventHandler(this.BookableIdComboBox_SelectedValueChanged);
			// 
			// SubTypeComboBox
			// 
			this.SubTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.SubTypeComboBox.DisplayFocus = true;
			this.SubTypeComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.SubTypeComboBox.FormattingEnabled = true;
			this.SubTypeComboBox.ItemHeight = 29;
			this.SubTypeComboBox.Items.AddRange(new object[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.SubTypeComboBox.Location = new System.Drawing.Point(142, 89);
			this.SubTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.SubTypeComboBox.Name = "SubTypeComboBox";
			this.SubTypeComboBox.Size = new System.Drawing.Size(289, 35);
			this.SubTypeComboBox.TabIndex = 50;
			this.SubTypeComboBox.UseSelectable = true;
			this.SubTypeComboBox.SelectedValueChanged += new System.EventHandler(this.SubTypeComboBox_SelectedValueChanged);
			// 
			// SubTypeLabel
			// 
			this.SubTypeLabel.AutoSize = true;
			this.SubTypeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTypeLabel.ForeColor = System.Drawing.Color.White;
			this.SubTypeLabel.Location = new System.Drawing.Point(14, 93);
			this.SubTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTypeLabel.Name = "SubTypeLabel";
			this.SubTypeLabel.Size = new System.Drawing.Size(113, 28);
			this.SubTypeLabel.TabIndex = 49;
			this.SubTypeLabel.Text = "SubType (*)";
			// 
			// TypeCombox
			// 
			this.TypeCombox.AutoCompleteCustomSource.AddRange(new string[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.TypeCombox.DisplayFocus = true;
			this.TypeCombox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.TypeCombox.FormattingEnabled = true;
			this.TypeCombox.ItemHeight = 29;
			this.TypeCombox.Items.AddRange(new object[] {
            "Room",
            "Activity",
            "Transport"});
			this.TypeCombox.Location = new System.Drawing.Point(142, 31);
			this.TypeCombox.Margin = new System.Windows.Forms.Padding(2);
			this.TypeCombox.Name = "TypeCombox";
			this.TypeCombox.Size = new System.Drawing.Size(289, 35);
			this.TypeCombox.TabIndex = 48;
			this.TypeCombox.UseSelectable = true;
			this.TypeCombox.SelectedValueChanged += new System.EventHandler(this.TypeCombox_SelectedValueChanged);
			// 
			// BookableIdLabel
			// 
			this.BookableIdLabel.AutoSize = true;
			this.BookableIdLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookableIdLabel.ForeColor = System.Drawing.Color.White;
			this.BookableIdLabel.Location = new System.Drawing.Point(92, 151);
			this.BookableIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BookableIdLabel.Name = "BookableIdLabel";
			this.BookableIdLabel.Size = new System.Drawing.Size(31, 28);
			this.BookableIdLabel.TabIndex = 46;
			this.BookableIdLabel.Text = "ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(88, 416);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 42;
			this.label4.Text = "Email (*)";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.textBox4.Location = new System.Drawing.Point(199, 416);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(234, 34);
			this.textBox4.TabIndex = 45;
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.DescriptionTextBox.Location = new System.Drawing.Point(142, 207);
			this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(289, 34);
			this.DescriptionTextBox.TabIndex = 36;
			// 
			// DescriptionLabel
			// 
			this.DescriptionLabel.AutoSize = true;
			this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
			this.DescriptionLabel.Location = new System.Drawing.Point(15, 207);
			this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DescriptionLabel.Name = "DescriptionLabel";
			this.DescriptionLabel.Size = new System.Drawing.Size(112, 28);
			this.DescriptionLabel.TabIndex = 27;
			this.DescriptionLabel.Text = "Description";
			// 
			// TypeLabel
			// 
			this.TypeLabel.AutoSize = true;
			this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TypeLabel.ForeColor = System.Drawing.Color.White;
			this.TypeLabel.Location = new System.Drawing.Point(47, 35);
			this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TypeLabel.Name = "TypeLabel";
			this.TypeLabel.Size = new System.Drawing.Size(79, 28);
			this.TypeLabel.TabIndex = 28;
			this.TypeLabel.Text = "Type (*)";
			// 
			// ClientData
			// 
			this.ClientData.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ClientData.Controls.Add(this.NewClientButton);
			this.ClientData.Controls.Add(this.ClientIdLabel);
			this.ClientData.Controls.Add(this.NifComboBox);
			this.ClientData.Controls.Add(this.ClientIdTextBox);
			this.ClientData.Controls.Add(this.NifLabel);
			this.ClientData.Controls.Add(this.NameTextBox);
			this.ClientData.Controls.Add(this.NameLabel);
			this.ClientData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClientData.ForeColor = System.Drawing.Color.White;
			this.ClientData.Location = new System.Drawing.Point(13, 18);
			this.ClientData.Margin = new System.Windows.Forms.Padding(2);
			this.ClientData.Name = "ClientData";
			this.ClientData.Padding = new System.Windows.Forms.Padding(2);
			this.ClientData.Size = new System.Drawing.Size(450, 173);
			this.ClientData.TabIndex = 49;
			this.ClientData.TabStop = false;
			this.ClientData.Text = "Client";
			// 
			// NewClientButton
			// 
			this.NewClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.NewClientButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewClientButton.ForeColor = System.Drawing.Color.White;
			this.NewClientButton.Location = new System.Drawing.Point(141, 129);
			this.NewClientButton.Margin = new System.Windows.Forms.Padding(2);
			this.NewClientButton.Name = "NewClientButton";
			this.NewClientButton.Size = new System.Drawing.Size(162, 40);
			this.NewClientButton.TabIndex = 54;
			this.NewClientButton.Text = "New Client";
			this.NewClientButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.NewClientButton.UseVisualStyleBackColor = false;
			this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
			// 
			// ClientIdLabel
			// 
			this.ClientIdLabel.AutoSize = true;
			this.ClientIdLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClientIdLabel.ForeColor = System.Drawing.Color.White;
			this.ClientIdLabel.Location = new System.Drawing.Point(311, 34);
			this.ClientIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ClientIdLabel.Name = "ClientIdLabel";
			this.ClientIdLabel.Size = new System.Drawing.Size(31, 28);
			this.ClientIdLabel.TabIndex = 53;
			this.ClientIdLabel.Text = "ID";
			// 
			// NifComboBox
			// 
			this.NifComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.NifComboBox.DisplayFocus = true;
			this.NifComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
			this.NifComboBox.FormattingEnabled = true;
			this.NifComboBox.ItemHeight = 29;
			this.NifComboBox.Items.AddRange(new object[] {
            "Hotel",
            "ActivityAgency",
            "TransportAgency",
            "HotelierGroup"});
			this.NifComboBox.Location = new System.Drawing.Point(141, 31);
			this.NifComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.NifComboBox.Name = "NifComboBox";
			this.NifComboBox.Size = new System.Drawing.Size(162, 35);
			this.NifComboBox.TabIndex = 52;
			this.NifComboBox.UseSelectable = true;
			this.NifComboBox.SelectedValueChanged += new System.EventHandler(this.NifComboBox_SelectedValueChanged);
			// 
			// ClientIdTextBox
			// 
			this.ClientIdTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.ClientIdTextBox.ForeColor = System.Drawing.Color.Black;
			this.ClientIdTextBox.Location = new System.Drawing.Point(349, 31);
			this.ClientIdTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ClientIdTextBox.Name = "ClientIdTextBox";
			this.ClientIdTextBox.Size = new System.Drawing.Size(81, 34);
			this.ClientIdTextBox.TabIndex = 37;
			this.ClientIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NifLabel
			// 
			this.NifLabel.AutoSize = true;
			this.NifLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NifLabel.ForeColor = System.Drawing.Color.White;
			this.NifLabel.Location = new System.Drawing.Point(57, 34);
			this.NifLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NifLabel.Name = "NifLabel";
			this.NifLabel.Size = new System.Drawing.Size(63, 28);
			this.NifLabel.TabIndex = 29;
			this.NifLabel.Text = "Nif (*)";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
			this.NameTextBox.Location = new System.Drawing.Point(141, 81);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(291, 34);
			this.NameTextBox.TabIndex = 36;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.ForeColor = System.Drawing.Color.White;
			this.NameLabel.Location = new System.Drawing.Point(56, 83);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(69, 28);
			this.NameLabel.TabIndex = 27;
			this.NameLabel.Text = "Name ";
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
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
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
			this.BookingInfo.ResumeLayout(false);
			this.BookingData.ResumeLayout(false);
			this.BookingData.PerformLayout();
			this.BookableData.ResumeLayout(false);
			this.BookableData.PerformLayout();
			this.ClientData.ResumeLayout(false);
			this.ClientData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
		private System.Windows.Forms.GroupBox BookingInfo;
		private System.Windows.Forms.GroupBox BookingData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button SaveButton;
		private MetroFramework.Controls.MetroDateTime EndDatePicker;
		private MetroFramework.Controls.MetroDateTime StartDatePicker;
		private System.Windows.Forms.Label EndDateLabel;
		private System.Windows.Forms.Label StartDateLabel;
		private System.Windows.Forms.Label BookingDateLabel;
		private System.Windows.Forms.GroupBox BookableData;
		private System.Windows.Forms.Label BasePriceLabel;
		private MetroFramework.Controls.MetroComboBox BookableIdComboBox;
		private MetroFramework.Controls.MetroComboBox SubTypeComboBox;
		private System.Windows.Forms.Label SubTypeLabel;
		private MetroFramework.Controls.MetroComboBox TypeCombox;
		private System.Windows.Forms.Label BookableIdLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Label TypeLabel;
		private System.Windows.Forms.GroupBox ClientData;
		private System.Windows.Forms.TextBox ClientIdTextBox;
		private System.Windows.Forms.Label NifLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox BasePriceTextBox;
		private System.Windows.Forms.Label ClientIdLabel;
		private MetroFramework.Controls.MetroComboBox NifComboBox;
		private System.Windows.Forms.TextBox TotalPriceLabel;
		private System.Windows.Forms.Label BookingIDLabel;
		private System.Windows.Forms.TextBox BookingIdTextBox;
		private System.Windows.Forms.TextBox BookingDateTextBox;
		private System.Windows.Forms.Button NewClientButton;
		private System.Windows.Forms.ErrorProvider errorProvider;

	}
}