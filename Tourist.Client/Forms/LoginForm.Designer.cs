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
			this.BodyPanel = new System.Windows.Forms.Panel();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.FooterPanel = new System.Windows.Forms.Panel();
			this.ImagePanel = new System.Windows.Forms.Panel();
			this.LoginFrame = new System.Windows.Forms.Panel();
			this.EntityNameCombox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.BodyPanel.SuspendLayout();
			this.HeaderPanel.SuspendLayout();
			this.LoginFrame.SuspendLayout();
			this.SuspendLayout();
			// 
			// BodyPanel
			// 
			this.BodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.BodyPanel.Controls.Add(this.LoginFrame);
			this.BodyPanel.Location = new System.Drawing.Point(0, 151);
			this.BodyPanel.Margin = new System.Windows.Forms.Padding(2);
			this.BodyPanel.Name = "BodyPanel";
			this.BodyPanel.Size = new System.Drawing.Size(1200, 521);
			this.BodyPanel.TabIndex = 9;
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
			this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginLabel.ForeColor = System.Drawing.Color.White;
			this.LoginLabel.Location = new System.Drawing.Point(17, 3);
			this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(322, 51);
			this.LoginLabel.TabIndex = 3;
			this.LoginLabel.Text = "Login Credentials";
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.HeaderPanel.Controls.Add(this.ImagePanel);
			this.HeaderPanel.Controls.Add(this.panel1);
			this.HeaderPanel.Controls.Add(this.label2);
			this.HeaderPanel.Controls.Add(this.LoginLabel);
			this.HeaderPanel.Location = new System.Drawing.Point(0, 24);
			this.HeaderPanel.Margin = new System.Windows.Forms.Padding(2);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(1200, 122);
			this.HeaderPanel.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(422, 124);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 26);
			this.panel1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(24, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(644, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "Welcome! Please enter your username and password to procede.";
			// 
			// FooterPanel
			// 
			this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.FooterPanel.Location = new System.Drawing.Point(0, 678);
			this.FooterPanel.Margin = new System.Windows.Forms.Padding(2);
			this.FooterPanel.Name = "FooterPanel";
			this.FooterPanel.Size = new System.Drawing.Size(1200, 122);
			this.FooterPanel.TabIndex = 11;
			// 
			// ImagePanel
			// 
			this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImagePanel.AutoSize = true;
			this.ImagePanel.BackgroundImage = global::Tourist.Server.Properties.Resources._lock;
			this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ImagePanel.Location = new System.Drawing.Point(1080, 11);
			this.ImagePanel.Margin = new System.Windows.Forms.Padding(2);
			this.ImagePanel.Name = "ImagePanel";
			this.ImagePanel.Size = new System.Drawing.Size(103, 95);
			this.ImagePanel.TabIndex = 12;
			// 
			// LoginFrame
			// 
			this.LoginFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoginFrame.AutoSize = true;
			this.LoginFrame.BackgroundImage = global::Tourist.Server.Properties.Resources.LoginFrame;
			this.LoginFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LoginFrame.Controls.Add(this.EntityNameCombox);
			this.LoginFrame.Controls.Add(this.label3);
			this.LoginFrame.Controls.Add(this.label1);
			this.LoginFrame.Controls.Add(this.ExitButton);
			this.LoginFrame.Controls.Add(this.OkButton);
			this.LoginFrame.Controls.Add(this.textBox2);
			this.LoginFrame.Controls.Add(this.textBox1);
			this.LoginFrame.Controls.Add(this.PasswordLabel);
			this.LoginFrame.Controls.Add(this.UsernameLabel);
			this.LoginFrame.Location = new System.Drawing.Point(249, 59);
			this.LoginFrame.Margin = new System.Windows.Forms.Padding(2);
			this.LoginFrame.Name = "LoginFrame";
			this.LoginFrame.Size = new System.Drawing.Size(702, 402);
			this.LoginFrame.TabIndex = 12;
			// 
			// EntityNameCombox
			// 
			this.EntityNameCombox.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EntityNameCombox.FormattingEnabled = true;
			this.EntityNameCombox.Location = new System.Drawing.Point(149, 67);
			this.EntityNameCombox.Name = "EntityNameCombox";
			this.EntityNameCombox.Size = new System.Drawing.Size(418, 40);
			this.EntityNameCombox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(143, 21);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 32);
			this.label3.TabIndex = 13;
			this.label3.Text = "Entity Name";
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
			this.ExitButton.Location = new System.Drawing.Point(369, 331);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(198, 40);
			this.ExitButton.TabIndex = 10;
			this.ExitButton.Text = "Cancel";
			this.ExitButton.UseVisualStyleBackColor = false;
			// 
			// OkButton
			// 
			this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OkButton.ForeColor = System.Drawing.Color.White;
			this.OkButton.Location = new System.Drawing.Point(149, 331);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(199, 40);
			this.OkButton.TabIndex = 9;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(149, 265);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(418, 39);
			this.textBox2.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(149, 164);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(418, 39);
			this.textBox1.TabIndex = 7;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLabel.ForeColor = System.Drawing.Color.White;
			this.PasswordLabel.Location = new System.Drawing.Point(143, 219);
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
			this.UsernameLabel.Location = new System.Drawing.Point(143, 118);
			this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(125, 32);
			this.UsernameLabel.TabIndex = 5;
			this.UsernameLabel.Text = "Username";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1200, 800);
			this.Controls.Add(this.FooterPanel);
			this.Controls.Add(this.BodyPanel);
			this.Controls.Add(this.HeaderPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.Style = MetroFramework.MetroColorStyle.White;
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.BodyPanel.ResumeLayout(false);
			this.BodyPanel.PerformLayout();
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.LoginFrame.ResumeLayout(false);
			this.LoginFrame.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BodyPanel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel ImagePanel;
		private System.Windows.Forms.Panel FooterPanel;
		private System.Windows.Forms.Panel LoginFrame;
		private System.Windows.Forms.ComboBox EntityNameCombox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label UsernameLabel;
	}
}