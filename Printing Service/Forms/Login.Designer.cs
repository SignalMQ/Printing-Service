namespace Printing_Service.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            GridLayout = new TableLayoutPanel();
            Menu = new Panel();
            Logo = new PictureBox();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            GridLayout.SuspendLayout();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // GridLayout
            // 
            GridLayout.ColumnCount = 3;
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            GridLayout.Controls.Add(Menu, 1, 1);
            GridLayout.Dock = DockStyle.Fill;
            GridLayout.Location = new Point(0, 0);
            GridLayout.Name = "GridLayout";
            GridLayout.RowCount = 3;
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            GridLayout.Size = new Size(784, 561);
            GridLayout.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.White;
            Menu.Controls.Add(Logo);
            Menu.Controls.Add(btnLogin);
            Menu.Controls.Add(lblPassword);
            Menu.Controls.Add(lblUsername);
            Menu.Controls.Add(txtPassword);
            Menu.Controls.Add(txtUsername);
            Menu.Dock = DockStyle.Fill;
            Menu.Location = new Point(261, 140);
            Menu.Margin = new Padding(0);
            Menu.Name = "Menu";
            Menu.Size = new Size(261, 280);
            Menu.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.APU_Logo_Final_Vertical_HR_V1;
            Logo.Location = new Point(15, 15);
            Logo.Margin = new Padding(15);
            Logo.Name = "Logo";
            Logo.Size = new Size(231, 99);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(15, 225);
            btnLogin.Margin = new Padding(10, 10, 10, 15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 185);
            lblPassword.Margin = new Padding(15, 0, 3, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(15, 142);
            lblUsername.Margin = new Padding(15, 0, 3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 182);
            txtPassword.Margin = new Padding(3, 10, 15, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(165, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(81, 139);
            txtUsername.Margin = new Padding(3, 10, 15, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(165, 23);
            txtUsername.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(784, 561);
            Controls.Add(GridLayout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            GridLayout.ResumeLayout(false);
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel GridLayout;
        private Panel Menu;
        private TextBox txtUsername;
        private PictureBox Logo;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
    }
}