namespace Tourist.Client.Forms
{
	partial class MainForm
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
			this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
			this.MainPanel = new MetroFramework.Controls.MetroPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DayOfWeekLabel = new System.Windows.Forms.Label();
			this.MonthNameLabel = new System.Windows.Forms.Label();
			this.YearLabel = new System.Windows.Forms.Label();
			this.DayNumberLabel = new System.Windows.Forms.Label();
			this.ClockTile = new System.Windows.Forms.Panel();
			this.ClockTitleLabel = new System.Windows.Forms.Label();
			this.AmPmLabel = new System.Windows.Forms.Label();
			this.ClockLabel = new System.Windows.Forms.Label();
			this.BrowseBookingsTile = new MetroFramework.Controls.MetroTile();
			this.HelpTile = new MetroFramework.Controls.MetroTile();
			this.ReportsTile = new MetroFramework.Controls.MetroTile();
			this.PaymentsTile = new MetroFramework.Controls.MetroTile();
			this.ToolsTile = new MetroFramework.Controls.MetroTile();
			this.ClientsTile = new MetroFramework.Controls.MetroTile();
			this.BookingsTile = new MetroFramework.Controls.MetroTile();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.TimerClock = new System.Windows.Forms.Timer(this.components);
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.SubTitleLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.SearchTile = new MetroFramework.Controls.MetroTile();
			this.LogoffTile = new MetroFramework.Controls.MetroTile();
			this.PrefrencesTile = new MetroFramework.Controls.MetroTile();
			this.MainPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.ClockTile.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.BodyPanel.SuspendLayout();
			this.SideBarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmlToolTip1
			// 
			this.htmlToolTip1.OwnerDraw = true;
			// 
			// MainPanel
			// 
			this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.MainPanel.Controls.Add(this.panel1);
			this.MainPanel.Controls.Add(this.ClockTile);
			this.MainPanel.Controls.Add(this.BrowseBookingsTile);
			this.MainPanel.Controls.Add(this.HelpTile);
			this.MainPanel.Controls.Add(this.ReportsTile);
			this.MainPanel.Controls.Add(this.PaymentsTile);
			this.MainPanel.Controls.Add(this.ToolsTile);
			this.MainPanel.Controls.Add(this.ClientsTile);
			this.MainPanel.Controls.Add(this.BookingsTile);
			this.MainPanel.HorizontalScrollbarBarColor = true;
			this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.MainPanel.HorizontalScrollbarSize = 8;
			this.MainPanel.Location = new System.Drawing.Point(178, 22);
			this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(859, 422);
			this.MainPanel.Style = MetroFramework.MetroColorStyle.Purple;
			this.MainPanel.TabIndex = 0;
			this.MainPanel.VerticalScrollbarBarColor = true;
			this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
			this.MainPanel.VerticalScrollbarSize = 8;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.panel1.Controls.Add(this.DayOfWeekLabel);
			this.panel1.Controls.Add(this.MonthNameLabel);
			this.panel1.Controls.Add(this.YearLabel);
			this.panel1.Controls.Add(this.DayNumberLabel);
			this.panel1.Location = new System.Drawing.Point(566, 284);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(278, 122);
			this.panel1.TabIndex = 13;
			// 
			// DayOfWeekLabel
			// 
			this.DayOfWeekLabel.AutoSize = true;
			this.DayOfWeekLabel.BackColor = System.Drawing.Color.Transparent;
			this.DayOfWeekLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DayOfWeekLabel.ForeColor = System.Drawing.Color.White;
			this.DayOfWeekLabel.Location = new System.Drawing.Point(109, -3);
			this.DayOfWeekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DayOfWeekLabel.Name = "DayOfWeekLabel";
			this.DayOfWeekLabel.Size = new System.Drawing.Size(174, 45);
			this.DayOfWeekLabel.TabIndex = 3;
			this.DayOfWeekLabel.Text = "DayofWeek";
			this.DayOfWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MonthNameLabel
			// 
			this.MonthNameLabel.AutoSize = true;
			this.MonthNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.MonthNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonthNameLabel.ForeColor = System.Drawing.Color.White;
			this.MonthNameLabel.Location = new System.Drawing.Point(109, 36);
			this.MonthNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MonthNameLabel.Name = "MonthNameLabel";
			this.MonthNameLabel.Size = new System.Drawing.Size(112, 45);
			this.MonthNameLabel.TabIndex = 3;
			this.MonthNameLabel.Text = "Month";
			this.MonthNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// YearLabel
			// 
			this.YearLabel.AutoSize = true;
			this.YearLabel.BackColor = System.Drawing.Color.Transparent;
			this.YearLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.YearLabel.ForeColor = System.Drawing.Color.White;
			this.YearLabel.Location = new System.Drawing.Point(111, 75);
			this.YearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(77, 45);
			this.YearLabel.TabIndex = 3;
			this.YearLabel.Text = "Year";
			this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DayNumberLabel
			// 
			this.DayNumberLabel.AutoSize = true;
			this.DayNumberLabel.BackColor = System.Drawing.Color.Transparent;
			this.DayNumberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 64.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DayNumberLabel.ForeColor = System.Drawing.Color.White;
			this.DayNumberLabel.Location = new System.Drawing.Point(-7, -9);
			this.DayNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DayNumberLabel.Name = "DayNumberLabel";
			this.DayNumberLabel.Size = new System.Drawing.Size(146, 116);
			this.DayNumberLabel.TabIndex = 3;
			this.DayNumberLabel.Text = "00";
			this.DayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClockTile
			// 
			this.ClockTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.ClockTile.Controls.Add(this.ClockTitleLabel);
			this.ClockTile.Controls.Add(this.AmPmLabel);
			this.ClockTile.Controls.Add(this.ClockLabel);
			this.ClockTile.Location = new System.Drawing.Point(566, 15);
			this.ClockTile.Margin = new System.Windows.Forms.Padding(2);
			this.ClockTile.Name = "ClockTile";
			this.ClockTile.Size = new System.Drawing.Size(278, 256);
			this.ClockTile.TabIndex = 12;
			// 
			// ClockTitleLabel
			// 
			this.ClockTitleLabel.AutoSize = true;
			this.ClockTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.ClockTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClockTitleLabel.ForeColor = System.Drawing.Color.White;
			this.ClockTitleLabel.Location = new System.Drawing.Point(11, 4);
			this.ClockTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ClockTitleLabel.Name = "ClockTitleLabel";
			this.ClockTitleLabel.Size = new System.Drawing.Size(251, 51);
			this.ClockTitleLabel.TabIndex = 2;
			this.ClockTitleLabel.Text = "Service Clock";
			this.ClockTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AmPmLabel
			// 
			this.AmPmLabel.AutoSize = true;
			this.AmPmLabel.BackColor = System.Drawing.Color.Transparent;
			this.AmPmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AmPmLabel.ForeColor = System.Drawing.Color.White;
			this.AmPmLabel.Location = new System.Drawing.Point(83, 170);
			this.AmPmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AmPmLabel.Name = "AmPmLabel";
			this.AmPmLabel.Size = new System.Drawing.Size(117, 86);
			this.AmPmLabel.TabIndex = 1;
			this.AmPmLabel.Text = "XX";
			this.AmPmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClockLabel
			// 
			this.ClockLabel.AutoSize = true;
			this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
			this.ClockLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClockLabel.ForeColor = System.Drawing.Color.White;
			this.ClockLabel.Location = new System.Drawing.Point(-2, 79);
			this.ClockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ClockLabel.Name = "ClockLabel";
			this.ClockLabel.Size = new System.Drawing.Size(292, 89);
			this.ClockLabel.TabIndex = 0;
			this.ClockLabel.Text = "00:00:00";
			this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BrowseBookingsTile
			// 
			this.BrowseBookingsTile.ActiveControl = null;
			this.BrowseBookingsTile.Location = new System.Drawing.Point(12, 149);
			this.BrowseBookingsTile.Margin = new System.Windows.Forms.Padding(2);
			this.BrowseBookingsTile.Name = "BrowseBookingsTile";
			this.BrowseBookingsTile.Size = new System.Drawing.Size(263, 122);
			this.BrowseBookingsTile.TabIndex = 9;
			this.BrowseBookingsTile.Text = "Browse Bookings";
			this.BrowseBookingsTile.TileImage = global::Tourist.Client.Properties.Resources.Disponibility;
			this.BrowseBookingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BrowseBookingsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.BrowseBookingsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.BrowseBookingsTile.UseSelectable = true;
			this.BrowseBookingsTile.UseTileImage = true;
			this.BrowseBookingsTile.Click += new System.EventHandler(this.DisponibilityTile_Click);
			// 
			// HelpTile
			// 
			this.HelpTile.ActiveControl = null;
			this.HelpTile.Location = new System.Drawing.Point(426, 284);
			this.HelpTile.Margin = new System.Windows.Forms.Padding(2);
			this.HelpTile.Name = "HelpTile";
			this.HelpTile.Size = new System.Drawing.Size(128, 122);
			this.HelpTile.TabIndex = 8;
			this.HelpTile.Text = "Help";
			this.HelpTile.TileImage = global::Tourist.Client.Properties.Resources.Help;
			this.HelpTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HelpTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.HelpTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.HelpTile.UseSelectable = true;
			this.HelpTile.UseTileImage = true;
			this.HelpTile.Click += new System.EventHandler(this.HelpTile_Click);
			// 
			// ReportsTile
			// 
			this.ReportsTile.ActiveControl = null;
			this.ReportsTile.Location = new System.Drawing.Point(286, 149);
			this.ReportsTile.Margin = new System.Windows.Forms.Padding(2);
			this.ReportsTile.Name = "ReportsTile";
			this.ReportsTile.Size = new System.Drawing.Size(268, 122);
			this.ReportsTile.TabIndex = 7;
			this.ReportsTile.Text = "New Feature";
			this.ReportsTile.TileImage = global::Tourist.Client.Properties.Resources.ComingSoon;
			this.ReportsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ReportsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ReportsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ReportsTile.UseSelectable = true;
			this.ReportsTile.UseTileImage = true;
			// 
			// PaymentsTile
			// 
			this.PaymentsTile.ActiveControl = null;
			this.PaymentsTile.Location = new System.Drawing.Point(286, 15);
			this.PaymentsTile.Margin = new System.Windows.Forms.Padding(2);
			this.PaymentsTile.Name = "PaymentsTile";
			this.PaymentsTile.Size = new System.Drawing.Size(267, 122);
			this.PaymentsTile.TabIndex = 6;
			this.PaymentsTile.Text = "Payments";
			this.PaymentsTile.TileImage = global::Tourist.Client.Properties.Resources.Payment;
			this.PaymentsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PaymentsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.PaymentsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PaymentsTile.UseSelectable = true;
			this.PaymentsTile.UseTileImage = true;
			this.PaymentsTile.Click += new System.EventHandler(this.PaymentsTile_Click);
			// 
			// ToolsTile
			// 
			this.ToolsTile.ActiveControl = null;
			this.ToolsTile.Location = new System.Drawing.Point(286, 284);
			this.ToolsTile.Margin = new System.Windows.Forms.Padding(2);
			this.ToolsTile.Name = "ToolsTile";
			this.ToolsTile.Size = new System.Drawing.Size(128, 122);
			this.ToolsTile.TabIndex = 5;
			this.ToolsTile.Text = "Tools";
			this.ToolsTile.TileImage = global::Tourist.Client.Properties.Resources.Tools;
			this.ToolsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ToolsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ToolsTile.UseSelectable = true;
			this.ToolsTile.UseTileImage = true;
			this.ToolsTile.Click += new System.EventHandler(this.ToolsTile_Click);
			// 
			// ClientsTile
			// 
			this.ClientsTile.ActiveControl = null;
			this.ClientsTile.Location = new System.Drawing.Point(12, 284);
			this.ClientsTile.Margin = new System.Windows.Forms.Padding(2);
			this.ClientsTile.Name = "ClientsTile";
			this.ClientsTile.Size = new System.Drawing.Size(263, 122);
			this.ClientsTile.TabIndex = 4;
			this.ClientsTile.Text = "Clients";
			this.ClientsTile.TileImage = global::Tourist.Client.Properties.Resources.clients;
			this.ClientsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClientsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ClientsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ClientsTile.UseSelectable = true;
			this.ClientsTile.UseTileImage = true;
			this.ClientsTile.Click += new System.EventHandler(this.ClientsTile_Click);
			// 
			// BookingsTile
			// 
			this.BookingsTile.ActiveControl = null;
			this.BookingsTile.Location = new System.Drawing.Point(12, 15);
			this.BookingsTile.Margin = new System.Windows.Forms.Padding(2);
			this.BookingsTile.Name = "BookingsTile";
			this.BookingsTile.Size = new System.Drawing.Size(263, 122);
			this.BookingsTile.TabIndex = 3;
			this.BookingsTile.Text = "Booking";
			this.BookingsTile.TileImage = global::Tourist.Client.Properties.Resources.Bookings;
			this.BookingsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BookingsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.BookingsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.BookingsTile.UseSelectable = true;
			this.BookingsTile.UseTileImage = true;
			this.BookingsTile.Click += new System.EventHandler(this.BookingsTile_Click);
			// 
			// TimerClock
			// 
			this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.SubTitleLabel);
			this.HeaderPanel.Controls.Add(this.TitleLabel);
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Location = new System.Drawing.Point(0, 23);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1201, 150);
			this.HeaderPanel.TabIndex = 11;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(28, 85);
			this.SubTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(266, 30);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Management Main Board ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(18, 31);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(109, 51);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Main";
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.AutoSize = true;
			this.ImagePanel.BackgroundImage = global::Tourist.Client.Properties.Resources.Home;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1085, 33);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(98, 91);
			this.ImagePanel.TabIndex = 14;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(0, 649);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1201, 150);
			this.FooterPanel.TabIndex = 12;
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.SideBarPanel);
			this.BodyPanel.Controls.Add(this.MainPanel);
			this.BodyPanel.Location = new System.Drawing.Point(0, 177);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1201, 468);
			this.BodyPanel.TabIndex = 13;
			this.BodyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BodyPanel_MouseMove);
			// 
			// SideBarPanel
			// 
			this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.SideBarPanel.Controls.Add(this.SearchTile);
			this.SideBarPanel.Controls.Add(this.LogoffTile);
			this.SideBarPanel.Controls.Add(this.PrefrencesTile);
			this.SideBarPanel.Location = new System.Drawing.Point(1196, 2);
			this.SideBarPanel.Margin = new System.Windows.Forms.Padding(2);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(112, 468);
			this.SideBarPanel.TabIndex = 14;
			this.SideBarPanel.Visible = false;
			// 
			// SearchTile
			// 
			this.SearchTile.ActiveControl = null;
			this.SearchTile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SearchTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.SearchTile.Location = new System.Drawing.Point(2, 188);
			this.SearchTile.Margin = new System.Windows.Forms.Padding(2);
			this.SearchTile.Name = "SearchTile";
			this.SearchTile.Size = new System.Drawing.Size(108, 85);
			this.SearchTile.TabIndex = 1;
			this.SearchTile.Text = "Search";
			this.SearchTile.TileImage = global::Tourist.Client.Properties.Resources.Magnifier;
			this.SearchTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SearchTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.SearchTile.UseCustomBackColor = true;
			this.SearchTile.UseSelectable = true;
			this.SearchTile.UseTileImage = true;
			// 
			// LogoffTile
			// 
			this.LogoffTile.ActiveControl = null;
			this.LogoffTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LogoffTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.LogoffTile.Location = new System.Drawing.Point(2, 20);
			this.LogoffTile.Margin = new System.Windows.Forms.Padding(2);
			this.LogoffTile.Name = "LogoffTile";
			this.LogoffTile.Size = new System.Drawing.Size(108, 85);
			this.LogoffTile.TabIndex = 0;
			this.LogoffTile.Text = "LogOff";
			this.LogoffTile.TileImage = global::Tourist.Client.Properties.Resources.PowerOff;
			this.LogoffTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LogoffTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.LogoffTile.UseCustomBackColor = true;
			this.LogoffTile.UseSelectable = true;
			this.LogoffTile.UseTileImage = true;
			this.LogoffTile.Click += new System.EventHandler(this.LogoffTile_Click);
			// 
			// PrefrencesTile
			// 
			this.PrefrencesTile.ActiveControl = null;
			this.PrefrencesTile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.PrefrencesTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.PrefrencesTile.Location = new System.Drawing.Point(2, 357);
			this.PrefrencesTile.Margin = new System.Windows.Forms.Padding(2);
			this.PrefrencesTile.Name = "PrefrencesTile";
			this.PrefrencesTile.Size = new System.Drawing.Size(108, 85);
			this.PrefrencesTile.TabIndex = 0;
			this.PrefrencesTile.Text = "Preferences";
			this.PrefrencesTile.TileImage = global::Tourist.Client.Properties.Resources.preferences;
			this.PrefrencesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PrefrencesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PrefrencesTile.UseCustomBackColor = true;
			this.PrefrencesTile.UseSelectable = true;
			this.PrefrencesTile.UseTileImage = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1024, 624);
			this.Movable = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 49);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ClockTile.ResumeLayout(false);
			this.ClockTile.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.BodyPanel.ResumeLayout(false);
			this.SideBarPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
		private MetroFramework.Controls.MetroPanel MainPanel;
		private MetroFramework.Controls.MetroTile BookingsTile;
		private MetroFramework.Controls.MetroTile ClientsTile;
		private MetroFramework.Controls.MetroTile BrowseBookingsTile;
		private MetroFramework.Controls.MetroTile HelpTile;
		private MetroFramework.Controls.MetroTile ReportsTile;
		private MetroFramework.Controls.MetroTile PaymentsTile;
		private MetroFramework.Controls.MetroTile ToolsTile;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel ClockTile;
		private System.Windows.Forms.Label ClockLabel;
		private System.Windows.Forms.Timer TimerClock;
		private System.Windows.Forms.Label AmPmLabel;
		private System.Windows.Forms.Label ClockTitleLabel;
		private System.Windows.Forms.Label YearLabel;
		private System.Windows.Forms.Label DayOfWeekLabel;
		private System.Windows.Forms.Label DayNumberLabel;
		private System.Windows.Forms.Label MonthNameLabel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Label SubTitleLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel SideBarPanel;
		private MetroFramework.Controls.MetroTile LogoffTile;
		private MetroFramework.Controls.MetroTile PrefrencesTile;
		private System.Windows.Forms.Panel ImagePanel;
		private MetroFramework.Controls.MetroTile SearchTile;
	}
}

