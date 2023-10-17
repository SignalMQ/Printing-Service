namespace Printing_Service.Forms
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            btnCancel = new Button();
            btnSave = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            Logo = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblRole = new Label();
            comboRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(14, 166);
            btnCancel.Margin = new Padding(10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(202, 47);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(270, 166);
            btnSave.Margin = new Padding(10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(202, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(14, 63);
            lblUsername.Margin = new Padding(5, 10, 5, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(17, 98);
            lblPassword.Margin = new Padding(5, 10, 5, 10);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // Logo
            // 
            Logo.Dock = DockStyle.Top;
            Logo.Image = Properties.Resources.apu_logo;
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(484, 50);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(82, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(390, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(390, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(44, 133);
            lblRole.Margin = new Padding(5, 10, 5, 10);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Customer", "Manager", "Worker" });
            comboRole.Location = new Point(82, 130);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(390, 23);
            comboRole.TabIndex = 7;
            comboRole.Text = "Admin";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 226);
            Controls.Add(comboRole);
            Controls.Add(lblRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Logo);
            Controls.Add(lblPassword);
            Controls.Add(btnSave);
            Controls.Add(lblUsername);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit user";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnSave;
        private Label lblPassword;
        private Label lblUsername;
        private PictureBox Logo;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox comboRole;
    }
}