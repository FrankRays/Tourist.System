namespace Tourist.Server.Forms
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
			this.EmployersTile = new MetroFramework.Controls.MetroTile();
			this.DisponibilityTile = new MetroFramework.Controls.MetroTile();
			this.BackupTile = new MetroFramework.Controls.MetroTile();
			this.ReportsTile = new MetroFramework.Controls.MetroTile();
			this.NotifyTile = new MetroFramework.Controls.MetroTile();
			this.AdminToolsTile = new MetroFramework.Controls.MetroTile();
			this.ServicesTile = new MetroFramework.Controls.MetroTile();
			this.ClientsTile = new MetroFramework.Controls.MetroTile();
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
			this.MainPanel.Controls.Add(this.EmployersTile);
			this.MainPanel.Controls.Add(this.DisponibilityTile);
			this.MainPanel.Controls.Add(this.BackupTile);
			this.MainPanel.Controls.Add(this.ReportsTile);
			this.MainPanel.Controls.Add(this.NotifyTile);
			this.MainPanel.Controls.Add(this.AdminToolsTile);
			this.MainPanel.Controls.Add(this.ServicesTile);
			this.MainPanel.Controls.Add(this.ClientsTile);
			this.MainPanel.HorizontalScrollbarBarColor = true;
			this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.MainPanel.HorizontalScrollbarSize = 10;
			this.MainPanel.Location = new System.Drawing.Point(121, 20);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(1121, 519);
			this.MainPanel.Style = MetroFramework.MetroColorStyle.Purple;
			this.MainPanel.TabIndex = 0;
			this.MainPanel.VerticalScrollbarBarColor = true;
			this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
			this.MainPanel.VerticalScrollbarSize = 10;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.panel1.Controls.Add(this.DayOfWeekLabel);
			this.panel1.Controls.Add(this.MonthNameLabel);
			this.panel1.Controls.Add(this.YearLabel);
			this.panel1.Controls.Add(this.DayNumberLabel);
			this.panel1.Location = new System.Drawing.Point(755, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 150);
			this.panel1.TabIndex = 13;
			// 
			// DayOfWeekLabel
			// 
			this.DayOfWeekLabel.AutoSize = true;
			this.DayOfWeekLabel.BackColor = System.Drawing.Color.Transparent;
			this.DayOfWeekLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DayOfWeekLabel.ForeColor = System.Drawing.Color.White;
			this.DayOfWeekLabel.Location = new System.Drawing.Point(145, -4);
			this.DayOfWeekLabel.Name = "DayOfWeekLabel";
			this.DayOfWeekLabel.Size = new System.Drawing.Size(221, 54);
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
			this.MonthNameLabel.Location = new System.Drawing.Point(145, 44);
			this.MonthNameLabel.Name = "MonthNameLabel";
			this.MonthNameLabel.Size = new System.Drawing.Size(138, 54);
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
			this.YearLabel.Location = new System.Drawing.Point(148, 92);
			this.YearLabel.Name = "YearLabel";
			this.YearLabel.Size = new System.Drawing.Size(96, 54);
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
			this.DayNumberLabel.Location = new System.Drawing.Point(-9, -11);
			this.DayNumberLabel.Name = "DayNumberLabel";
			this.DayNumberLabel.Size = new System.Drawing.Size(184, 146);
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
			this.ClockTile.Location = new System.Drawing.Point(755, 18);
			this.ClockTile.Name = "ClockTile";
			this.ClockTile.Size = new System.Drawing.Size(350, 315);
			this.ClockTile.TabIndex = 12;
			// 
			// ClockTitleLabel
			// 
			this.ClockTitleLabel.AutoSize = true;
			this.ClockTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.ClockTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClockTitleLabel.ForeColor = System.Drawing.Color.White;
			this.ClockTitleLabel.Location = new System.Drawing.Point(15, 5);
			this.ClockTitleLabel.Name = "ClockTitleLabel";
			this.ClockTitleLabel.Size = new System.Drawing.Size(319, 65);
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
			this.AmPmLabel.Location = new System.Drawing.Point(93, 209);
			this.AmPmLabel.Name = "AmPmLabel";
			this.AmPmLabel.Size = new System.Drawing.Size(145, 106);
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
			this.ClockLabel.Location = new System.Drawing.Point(-2, 97);
			this.ClockLabel.Name = "ClockLabel";
			this.ClockLabel.Size = new System.Drawing.Size(363, 110);
			this.ClockLabel.TabIndex = 0;
			this.ClockLabel.Text = "00:00:00";
			this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EmployersTile
			// 
			this.EmployersTile.ActiveControl = null;
			this.EmployersTile.BackColor = System.Drawing.Color.Transparent;
			this.EmployersTile.Location = new System.Drawing.Point(16, 350);
			this.EmployersTile.Name = "EmployersTile";
			this.EmployersTile.Size = new System.Drawing.Size(350, 150);
			this.EmployersTile.TabIndex = 2;
			this.EmployersTile.Text = "Employers";
			this.EmployersTile.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.EmployersTile.TileImage = global::Tourist.Server.Properties.Resources.employers;
			this.EmployersTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.EmployersTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.EmployersTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.EmployersTile.UseSelectable = true;
			this.EmployersTile.UseTileImage = true;
			// 
			// DisponibilityTile
			// 
			this.DisponibilityTile.ActiveControl = null;
			this.DisponibilityTile.Location = new System.Drawing.Point(382, 18);
			this.DisponibilityTile.Name = "DisponibilityTile";
			this.DisponibilityTile.Size = new System.Drawing.Size(170, 150);
			this.DisponibilityTile.TabIndex = 9;
			this.DisponibilityTile.Text = "Disponibility";
			this.DisponibilityTile.TileImage = global::Tourist.Server.Properties.Resources.Disponibility;
			this.DisponibilityTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DisponibilityTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.DisponibilityTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.DisponibilityTile.UseSelectable = true;
			this.DisponibilityTile.UseTileImage = true;
			// 
			// BackupTile
			// 
			this.BackupTile.ActiveControl = null;
			this.BackupTile.Location = new System.Drawing.Point(382, 350);
			this.BackupTile.Name = "BackupTile";
			this.BackupTile.Size = new System.Drawing.Size(170, 150);
			this.BackupTile.TabIndex = 8;
			this.BackupTile.Text = "Backup";
			this.BackupTile.TileImage = global::Tourist.Server.Properties.Resources.backup;
			this.BackupTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BackupTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.BackupTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.BackupTile.UseSelectable = true;
			this.BackupTile.UseTileImage = true;
			// 
			// ReportsTile
			// 
			this.ReportsTile.ActiveControl = null;
			this.ReportsTile.Location = new System.Drawing.Point(382, 183);
			this.ReportsTile.Name = "ReportsTile";
			this.ReportsTile.Size = new System.Drawing.Size(357, 150);
			this.ReportsTile.TabIndex = 7;
			this.ReportsTile.Text = "Reports ";
			this.ReportsTile.TileImage = global::Tourist.Server.Properties.Resources.BarGraph;
			this.ReportsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ReportsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ReportsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ReportsTile.UseSelectable = true;
			this.ReportsTile.UseTileImage = true;
			// 
			// NotifyTile
			// 
			this.NotifyTile.ActiveControl = null;
			this.NotifyTile.Location = new System.Drawing.Point(568, 18);
			this.NotifyTile.Name = "NotifyTile";
			this.NotifyTile.Size = new System.Drawing.Size(170, 150);
			this.NotifyTile.TabIndex = 6;
			this.NotifyTile.Text = "Notify";
			this.NotifyTile.TileImage = global::Tourist.Server.Properties.Resources.Message;
			this.NotifyTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NotifyTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.NotifyTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.NotifyTile.UseSelectable = true;
			this.NotifyTile.UseTileImage = true;
			// 
			// AdminToolsTile
			// 
			this.AdminToolsTile.ActiveControl = null;
			this.AdminToolsTile.Location = new System.Drawing.Point(568, 350);
			this.AdminToolsTile.Name = "AdminToolsTile";
			this.AdminToolsTile.Size = new System.Drawing.Size(170, 150);
			this.AdminToolsTile.TabIndex = 5;
			this.AdminToolsTile.Text = "Tools";
			this.AdminToolsTile.TileImage = global::Tourist.Server.Properties.Resources.Tools;
			this.AdminToolsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AdminToolsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.AdminToolsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.AdminToolsTile.UseSelectable = true;
			this.AdminToolsTile.UseTileImage = true;
			// 
			// ServicesTile
			// 
			this.ServicesTile.ActiveControl = null;
			this.ServicesTile.Location = new System.Drawing.Point(16, 183);
			this.ServicesTile.Name = "ServicesTile";
			this.ServicesTile.Size = new System.Drawing.Size(351, 150);
			this.ServicesTile.TabIndex = 4;
			this.ServicesTile.Text = "Services";
			this.ServicesTile.TileImage = global::Tourist.Server.Properties.Resources.services;
			this.ServicesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ServicesTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ServicesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ServicesTile.UseSelectable = true;
			this.ServicesTile.UseTileImage = true;
			// 
			// ClientsTile
			// 
			this.ClientsTile.ActiveControl = null;
			this.ClientsTile.Location = new System.Drawing.Point(16, 18);
			this.ClientsTile.Name = "ClientsTile";
			this.ClientsTile.Size = new System.Drawing.Size(351, 150);
			this.ClientsTile.TabIndex = 3;
			this.ClientsTile.Text = "Clients";
			this.ClientsTile.TileImage = global::Tourist.Server.Properties.Resources.clients;
			this.ClientsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ClientsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.ClientsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.ClientsTile.UseSelectable = true;
			this.ClientsTile.UseTileImage = true;
			this.ClientsTile.Click += new System.EventHandler(this.ClientsTile_Click);
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
			this.HeaderPanel.Location = new System.Drawing.Point(0, 28);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1369, 150);
			this.HeaderPanel.TabIndex = 11;
			// 
			// SubTitleLabel
			// 
			this.SubTitleLabel.AutoSize = true;
			this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLabel.ForeColor = System.Drawing.Color.White;
			this.SubTitleLabel.Location = new System.Drawing.Point(32, 82);
			this.SubTitleLabel.Name = "SubTitleLabel";
			this.SubTitleLabel.Size = new System.Drawing.Size(339, 38);
			this.SubTitleLabel.TabIndex = 4;
			this.SubTitleLabel.Text = "Management Main Board ";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(23, 3);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(138, 65);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Main";
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.Home;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1211, 23);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(134, 103);
			this.ImagePanel.TabIndex = 14;
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(0, 751);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1369, 150);
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
			this.BodyPanel.Location = new System.Drawing.Point(0, 184);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1369, 561);
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
			this.SideBarPanel.Location = new System.Drawing.Point(1363, 0);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(150, 561);
			this.SideBarPanel.TabIndex = 14;
			this.SideBarPanel.Visible = false;
			// 
			// SearchTile
			// 
			this.SearchTile.ActiveControl = null;
			this.SearchTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SearchTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
			this.SearchTile.Location = new System.Drawing.Point(3, 24);
			this.SearchTile.Name = "SearchTile";
			this.SearchTile.Size = new System.Drawing.Size(144, 105);
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
			this.LogoffTile.Location = new System.Drawing.Point(0, 433);
			this.LogoffTile.Name = "LogoffTile";
			this.LogoffTile.Size = new System.Drawing.Size(150, 105);
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
			this.PrefrencesTile.Location = new System.Drawing.Point(0, 227);
			this.PrefrencesTile.Name = "PrefrencesTile";
			this.PrefrencesTile.Size = new System.Drawing.Size(150, 105);
			this.PrefrencesTile.TabIndex = 0;
			this.PrefrencesTile.Text = "Preferences";
			this.PrefrencesTile.TileImage = global::Tourist.Server.Properties.Resources.preferences;
			this.PrefrencesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PrefrencesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.PrefrencesTile.UseCustomBackColor = true;
			this.PrefrencesTile.UseSelectable = true;
			this.PrefrencesTile.UseTileImage = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1368, 900);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.HeaderPanel);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1366, 768);
			this.Movable = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 60);
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
		private MetroFramework.Controls.MetroTile ClientsTile;
		private MetroFramework.Controls.MetroTile EmployersTile;
		private MetroFramework.Controls.MetroTile ServicesTile;
		private MetroFramework.Controls.MetroTile DisponibilityTile;
		private MetroFramework.Controls.MetroTile BackupTile;
		private MetroFramework.Controls.MetroTile ReportsTile;
		private MetroFramework.Controls.MetroTile NotifyTile;
		private MetroFramework.Controls.MetroTile AdminToolsTile;
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

