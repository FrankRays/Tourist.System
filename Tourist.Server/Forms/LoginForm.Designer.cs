namespace Tourist.Server.Forms
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.LoginFrame = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.LogoPicBox = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.BodyPanel.SuspendLayout();
			this.LoginFrame.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(0, 650);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1200, 150);
			this.FooterPanel.TabIndex = 14;
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.LoginFrame);
			this.BodyPanel.Location = new System.Drawing.Point(0, 178);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1200, 468);
			this.BodyPanel.TabIndex = 12;
			// 
			// LoginFrame
			// 
			this.LoginFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoginFrame.AutoSize = true;
			this.LoginFrame.BackgroundImage = global::Tourist.Server.Properties.Resources.LoginFrame;
			this.LoginFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LoginFrame.Controls.Add(this.ImagePanel);
			this.LoginFrame.Controls.Add(this.label1);
			this.LoginFrame.Controls.Add(this.ExitButton);
			this.LoginFrame.Controls.Add(this.OkButton);
			this.LoginFrame.Controls.Add(this.PasswordTextBox);
			this.LoginFrame.Controls.Add(this.UsernameTextBox);
			this.LoginFrame.Controls.Add(this.PasswordLabel);
			this.LoginFrame.Controls.Add(this.UsernameLabel);
			this.LoginFrame.Location = new System.Drawing.Point(254, 36);
			this.LoginFrame.Margin = new System.Windows.Forms.Padding(2);
			this.LoginFrame.Name = "LoginFrame";
			this.LoginFrame.Size = new System.Drawing.Size(702, 402);
			this.LoginFrame.TabIndex = 11;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.AutoSize = true;
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources.ClosedLock;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(578, 122);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(96, 95);
			this.ImagePanel.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(153, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 32);
			this.label1.TabIndex = 12;
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.ForeColor = System.Drawing.Color.White;
			this.ExitButton.Location = new System.Drawing.Point(350, 312);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(198, 40);
			this.ExitButton.TabIndex = 10;
			this.ExitButton.Text = "Cancel";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(130, 312);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(199, 40);
			this.OkButton.TabIndex = 9;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordTextBox.Location = new System.Drawing.Point(130, 216);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(418, 39);
			this.PasswordTextBox.TabIndex = 8;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameTextBox.Location = new System.Drawing.Point(130, 86);
			this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(418, 39);
			this.UsernameTextBox.TabIndex = 7;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLabel.ForeColor = System.Drawing.Color.White;
			this.PasswordLabel.Location = new System.Drawing.Point(124, 168);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(116, 32);
			this.PasswordLabel.TabIndex = 6;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsernameLabel.ForeColor = System.Drawing.Color.White;
			this.UsernameLabel.Location = new System.Drawing.Point(124, 35);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(125, 32);
			this.UsernameLabel.TabIndex = 5;
			this.UsernameLabel.Text = "Username";
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.LogoPicBox);
			this.HeaderPanel.Controls.Add(this.label2);
			this.HeaderPanel.Controls.Add(this.LoginLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(0, 24);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1200, 150);
			this.HeaderPanel.TabIndex = 13;
			// 
			// LogoPicBox
			// 
			this.LogoPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LogoPicBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.LogoPicBox.Location = new System.Drawing.Point(1033, 0);
			this.LogoPicBox.Name = "LogoPicBox";
			this.LogoPicBox.Size = new System.Drawing.Size(150, 150);
			this.LogoPicBox.TabIndex = 26;
			this.LogoPicBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(24, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(644, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "Welcome! Please enter your username and password to procede.";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
			this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginLabel.ForeColor = System.Drawing.Color.White;
			this.LoginLabel.Location = new System.Drawing.Point(17, 21);
			this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(322, 51);
			this.LoginLabel.TabIndex = 3;
			this.LoginLabel.Text = "Login Credentials";
			// 
			// ErrorProvider
			// 
			this.ErrorProvider.ContainerControl = this;
			this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
			// 
			// LoginForm
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Movable = false;
			this.Name = "LoginForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.BodyPanel.ResumeLayout(false);
			this.BodyPanel.PerformLayout();
			this.LoginFrame.ResumeLayout(false);
			this.LoginFrame.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Panel LoginFrame;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox LogoPicBox;
		private System.Windows.Forms.ErrorProvider ErrorProvider;

	}
}