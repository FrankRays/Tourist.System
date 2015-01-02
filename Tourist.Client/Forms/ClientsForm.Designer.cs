namespace Tourist.Client.Forms
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
			this.BackPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.WrapperPanelGrid = new System.Windows.Forms.Panel();
			this.ClientsDataGrid = new MetroFramework.Controls.MetroGrid();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GenderColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.NationalityColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NifColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.WrapperPanelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
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
			this.ImagePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.clients;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1010, 35);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(174, 89);
			this.ImagePanel.TabIndex = 13;
			// 
			// BackPanel
			// 
			this.BackPanel.AutoSize = true;
			this.BackPanel.BackgroundImage = global::Tourist.Client.Properties.Resources.LeftArrow;
			this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BackPanel.Location = new System.Drawing.Point(18, 35);
			this.BackPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BackPanel.Name = "BackPanel";
			this.BackPanel.Size = new System.Drawing.Size(64, 89);
			this.BackPanel.TabIndex = 12;
			this.BackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackPanel_MouseClick);
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(107, 89);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(153, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Client Services";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(98, 32);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(138, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Clients";
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.WrapperPanelGrid);
			this.BodyPanel.Location = new System.Drawing.Point(-1, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1202, 468);
			this.BodyPanel.TabIndex = 16;
			// 
			// WrapperPanelGrid
			// 
			this.WrapperPanelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WrapperPanelGrid.BackColor = System.Drawing.Color.White;
			this.WrapperPanelGrid.Controls.Add(this.ClientsDataGrid);
			this.WrapperPanelGrid.Location = new System.Drawing.Point(19, 24);
			this.WrapperPanelGrid.Name = "WrapperPanelGrid";
			this.WrapperPanelGrid.Size = new System.Drawing.Size(1165, 426);
			this.WrapperPanelGrid.TabIndex = 23;
			// 
			// ClientsDataGrid
			// 
			this.ClientsDataGrid.AllowUserToOrderColumns = true;
			this.ClientsDataGrid.AllowUserToResizeColumns = false;
			this.ClientsDataGrid.AllowUserToResizeRows = false;
			this.ClientsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ClientsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.ClientsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClientsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.ClientsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ClientsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ClientsDataGrid.ColumnHeadersHeight = 60;
			this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ClientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.GenderColumn,
            this.NationalityColumn,
            this.BirthDateColumn,
            this.NifColumn,
            this.AddressColumn,
            this.PhoneColumn,
            this.EmailColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.ClientsDataGrid.EnableHeadersVisualStyles = false;
			this.ClientsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ClientsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientsDataGrid.Location = new System.Drawing.Point(2, 0);
			this.ClientsDataGrid.Margin = new System.Windows.Forms.Padding(2);
			this.ClientsDataGrid.Name = "ClientsDataGrid";
			this.ClientsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ClientsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.ClientsDataGrid.RowHeadersWidth = 50;
			this.ClientsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ClientsDataGrid.RowTemplate.Height = 25;
			this.ClientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ClientsDataGrid.Size = new System.Drawing.Size(1161, 427);
			this.ClientsDataGrid.TabIndex = 21;
			this.ClientsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGrid_CellClick);
			this.ClientsDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGrid_CellDoubleClick);
			this.ClientsDataGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ClientsDataGrid_CellValidating);
			this.ClientsDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ClientsDataGrid_RowRemoved);
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
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn27.HeaderText = "Number Reservations";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn26.HeaderText = "Last Reservation";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn25.HeaderText = "Contact Number";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn24.HeaderText = "Fiscal Number";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn23.HeaderText = "City";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn22.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn21.HeaderText = "Birth Date";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn20.HeaderText = "Client Name";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn19.HeaderText = "Client ID";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			// 
			// IdColumn
			// 
			this.IdColumn.HeaderText = "ID";
			this.IdColumn.MinimumWidth = 150;
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			// 
			// FirstNameColumn
			// 
			this.FirstNameColumn.HeaderText = "First Name (*)";
			this.FirstNameColumn.MinimumWidth = 150;
			this.FirstNameColumn.Name = "FirstNameColumn";
			this.FirstNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// LastNameColumn
			// 
			this.LastNameColumn.HeaderText = "Last Name (*)";
			this.LastNameColumn.MinimumWidth = 150;
			this.LastNameColumn.Name = "LastNameColumn";
			// 
			// GenderColumn
			// 
			this.GenderColumn.HeaderText = "Gender (*)";
			this.GenderColumn.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.GenderColumn.MinimumWidth = 150;
			this.GenderColumn.Name = "GenderColumn";
			this.GenderColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.GenderColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// NationalityColumn
			// 
			this.NationalityColumn.HeaderText = "Nationality (*)";
			this.NationalityColumn.Items.AddRange(new object[] {
            "AD  Andorra",
            "AE  United Arab Emirates",
            "AF  Afghanistan",
            "AG  Antigua and Barbuda",
            "AL  Albania",
            "AM  Armenia",
            "AO  Angola",
            "AR  Argentina",
            "AT  Austria",
            "AU  Australia",
            "AZ  Azerbaijan",
            "BA  Bosnia and Herzegovina",
            "BB  Barbados",
            "BD  Bangladesh",
            "BE  Belgium",
            "BF  Burkina Faso",
            "BG  Bulgaria",
            "BH  Bahrain",
            "BI  Burundi",
            "BJ  Benin",
            "BN  Brunei Darussalam",
            "BO  Bolivia (Plurinational State of)",
            "BR  Brazil",
            "BS  Bahamas",
            "BT  Bhutan",
            "BW  Botswana",
            "BY  Belarus",
            "BZ  Belize",
            "CA  Canada",
            "CD  Democratic Republic of the Congo",
            "CF  Central African Republic",
            "CG  Congo",
            "CH  Switzerland",
            "CI  Côte d\'Ivoire",
            "CL  Chile",
            "CM  Cameroon",
            "CN  China",
            "CO  Colombia",
            "CR  Costa Rica",
            "CU  Cuba",
            "CV  Cape Verde",
            "CY  Cyprus",
            "CZ  Czech Republic",
            "DE  Germany",
            "DJ  Djibouti",
            "DK  Denmark",
            "DM  Dominica",
            "DO  Dominican Republic",
            "DZ  Algeria",
            "EC  Ecuador",
            "EE  Estonia",
            "EG  Egypt",
            "ER  Eritrea",
            "ES  Spain",
            "ET  Ethiopia",
            "FI  Finland",
            "FJ  Fiji",
            "FM  Micronesia (Federated States of)",
            "FR  France",
            "GA  Gabon",
            "GB  United Kingdom of Great Britain and Northern Ireland",
            "GD  Grenada",
            "GE  Georgia",
            "GH  Ghana",
            "GM  Gambia",
            "GN  Guinea",
            "GQ  Equatorial Guinea",
            "GR  Greece",
            "GT  Guatemala",
            "GW  Guinea-Bissau",
            "GY  Guyana",
            "HN  Honduras",
            "HR  Croatia",
            "HT  Haiti",
            "HU  Hungary",
            "ID  Indonesia",
            "IE  Ireland",
            "IL  Israel",
            "IN  India",
            "IQ  Iraq",
            "IR  Iran (Islamic Republic of)",
            "IS  Iceland",
            "IT  Italy",
            "JM  Jamaica",
            "JO  Jordan",
            "JP  Japan",
            "KE  Kenya",
            "KG  Kyrgyzstan",
            "KH  Cambodia",
            "KI  Kiribati",
            "KM  Comoros",
            "KN  Saint Kitts and Nevis",
            "KP  Democratic People\'s Republic of Korea",
            "KR  Republic of Korea",
            "KW  Kuwait",
            "KZ  Kazakhstan",
            "LA  Lao People\'s Democratic Republic",
            "LB  Lebanon",
            "LC  Saint Lucia",
            "LI  Liechtenstein",
            "LK  Sri Lanka",
            "LR  Liberia",
            "LS  Lesotho",
            "LT  Lithuania",
            "LU  Luxembourg",
            "LV  Latvia",
            "LY  Libyan Arab Jamahiriya",
            "MA  Morocco",
            "MC  Monaco",
            "MD  Republic of Moldova",
            "ME  Montenegro",
            "MG  Madagascar",
            "MH  Marshall Islands",
            "MK  The former Yugoslav Republic of Macedonia",
            "ML  Mali",
            "MM  Myanmar",
            "MN  Mongolia",
            "MR  Mauritania",
            "MT  Malta",
            "MU  Mauritius",
            "MV  Maldives",
            "MW  Malawi",
            "MX  Mexico",
            "MY  Malaysia",
            "MZ  Mozambique",
            "NA  Namibia",
            "NE  Niger",
            "NG  Nigeria",
            "NI  Nicaragua",
            "NL  Netherlands",
            "NO  Norway",
            "NP  Nepal",
            "NR  Nauru",
            "NZ  New Zealand",
            "OM  Oman",
            "PA  Panama",
            "PE  Peru",
            "PG  Papua New Guinea",
            "PH  Philippines",
            "PK  Pakistan",
            "PL  Poland",
            "PT  Portugal",
            "PW  Palau",
            "PY  Paraguay",
            "QA  Qatar",
            "RO  Romania",
            "RS  Serbia",
            "RU  Russian Federation",
            "RW  Rwanda",
            "SA  Saudi Arabia",
            "SB  Solomon Islands",
            "SC  Seychelles",
            "SD  Sudan",
            "SE  Sweden",
            "SG  Singapore",
            "SI  Slovenia",
            "SK  Slovakia",
            "SL  Sierra Leone",
            "SM  San Marino",
            "SN  Senegal",
            "SO  Somalia",
            "SR  Suriname",
            "SS  South Sudan",
            "ST  Sao Tome and Principe",
            "SV  El Salvador",
            "SY  Syrian Arab Republic",
            "SZ  Swaziland",
            "TD  Chad",
            "TG  Togo",
            "TH  Thailand",
            "TJ  Tajikistan",
            "TL  Timor-Leste",
            "TM  Turkmenistan",
            "TN  Tunisia",
            "TO  Tonga",
            "TR  Turkey",
            "TT  Trinidad and Tobago",
            "TV  Tuvalu",
            "TZ  United Republic of Tanzania",
            "UA  Ukraine",
            "UG  Uganda",
            "US  United States of America",
            "UY  Uruguay",
            "UZ  Uzbekistan",
            "VC  Saint Vincent and the Grenadines",
            "VE  Venezuela (Bolivarian Republic of)",
            "VN  Viet Nam",
            "VU  Vanuatu",
            "WS  Samoa",
            "YE  Yemen",
            "ZA  South Africa",
            "ZM  Zambia",
            "ZW  Zimbabwe"});
			this.NationalityColumn.MinimumWidth = 150;
			this.NationalityColumn.Name = "NationalityColumn";
			this.NationalityColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.NationalityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// BirthDateColumn
			// 
			this.BirthDateColumn.HeaderText = "Birth Date (*)";
			this.BirthDateColumn.MinimumWidth = 150;
			this.BirthDateColumn.Name = "BirthDateColumn";
			// 
			// NifColumn
			// 
			this.NifColumn.HeaderText = "NIF (*)";
			this.NifColumn.MinimumWidth = 150;
			this.NifColumn.Name = "NifColumn";
			// 
			// AddressColumn
			// 
			this.AddressColumn.HeaderText = "Address (*)";
			this.AddressColumn.MinimumWidth = 150;
			this.AddressColumn.Name = "AddressColumn";
			// 
			// PhoneColumn
			// 
			this.PhoneColumn.HeaderText = "Phone (*)";
			this.PhoneColumn.MinimumWidth = 150;
			this.PhoneColumn.Name = "PhoneColumn";
			// 
			// EmailColumn
			// 
			this.EmailColumn.HeaderText = "Email (*)";
			this.EmailColumn.MinimumWidth = 150;
			this.EmailColumn.Name = "EmailColumn";
			// 
			// ClientsForm
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
			this.Name = "ClientsForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.WrapperPanelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.Panel WrapperPanelGrid;
		private MetroFramework.Controls.MetroGrid ClientsDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn GenderColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn NationalityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NifColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;

	}
}