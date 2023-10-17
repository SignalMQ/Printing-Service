namespace Printing_Service.Forms
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            GridLayout = new TableLayoutPanel();
            Logo = new PictureBox();
            usersTable = new DataGridView();
            usersStrip = new ContextMenuStrip(components);
            createUserItem = new ToolStripMenuItem();
            editUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            updateTableToolStripMenuItem = new ToolStripMenuItem();
            btnExit = new Button();
            btnRequests = new Button();
            btnReports = new Button();
            requestsTable = new DataGridView();
            userBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GridLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            usersStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GridLayout
            // 
            GridLayout.ColumnCount = 5;
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            GridLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            GridLayout.Controls.Add(Logo, 0, 0);
            GridLayout.Controls.Add(usersTable, 1, 1);
            GridLayout.Controls.Add(btnExit, 1, 4);
            GridLayout.Controls.Add(btnRequests, 2, 4);
            GridLayout.Controls.Add(btnReports, 3, 4);
            GridLayout.Controls.Add(requestsTable, 1, 3);
            GridLayout.Dock = DockStyle.Fill;
            GridLayout.Location = new Point(0, 0);
            GridLayout.Name = "GridLayout";
            GridLayout.RowCount = 5;
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            GridLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            GridLayout.Size = new Size(784, 561);
            GridLayout.TabIndex = 0;
            // 
            // Logo
            // 
            GridLayout.SetColumnSpan(Logo, 5);
            Logo.Dock = DockStyle.Fill;
            Logo.Image = Properties.Resources.apu_logo;
            Logo.Location = new Point(3, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(778, 44);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // usersTable
            // 
            usersTable.AllowUserToAddRows = false;
            usersTable.AllowUserToDeleteRows = false;
            usersTable.AllowUserToResizeColumns = false;
            usersTable.AllowUserToResizeRows = false;
            usersTable.AutoGenerateColumns = false;
            usersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            GridLayout.SetColumnSpan(usersTable, 3);
            usersTable.ContextMenuStrip = usersStrip;
            usersTable.DataSource = userBindingSource;
            usersTable.Dock = DockStyle.Fill;
            usersTable.Location = new Point(23, 53);
            usersTable.Name = "usersTable";
            usersTable.ReadOnly = true;
            usersTable.RowTemplate.Height = 25;
            usersTable.Size = new Size(738, 214);
            usersTable.TabIndex = 1;
            usersTable.CellClick += usersTable_CellClick;
            // 
            // usersStrip
            // 
            usersStrip.Items.AddRange(new ToolStripItem[] { createUserItem, editUserToolStripMenuItem, deleteUserToolStripMenuItem, updateTableToolStripMenuItem });
            usersStrip.Name = "usersStrip";
            usersStrip.Size = new Size(147, 92);
            // 
            // createUserItem
            // 
            createUserItem.Name = "createUserItem";
            createUserItem.Size = new Size(146, 22);
            createUserItem.Text = "Add new user";
            createUserItem.Click += createUserItem_Click;
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(146, 22);
            editUserToolStripMenuItem.Text = "Edit user";
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(146, 22);
            deleteUserToolStripMenuItem.Text = "Delete user";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // updateTableToolStripMenuItem
            // 
            updateTableToolStripMenuItem.Name = "updateTableToolStripMenuItem";
            updateTableToolStripMenuItem.Size = new Size(146, 22);
            updateTableToolStripMenuItem.Text = "Update table";
            updateTableToolStripMenuItem.Click += updateTableToolStripMenuItem_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.Location = new Point(21, 515);
            btnExit.Margin = new Padding(1, 5, 1, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(246, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRequests
            // 
            btnRequests.Dock = DockStyle.Fill;
            btnRequests.Enabled = false;
            btnRequests.Location = new Point(269, 515);
            btnRequests.Margin = new Padding(1, 5, 1, 5);
            btnRequests.Name = "btnRequests";
            btnRequests.Size = new Size(246, 41);
            btnRequests.TabIndex = 3;
            btnRequests.Text = "Requests";
            btnRequests.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Fill;
            btnReports.Enabled = false;
            btnReports.Location = new Point(517, 515);
            btnReports.Margin = new Padding(1, 5, 1, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(246, 41);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // requestsTable
            // 
            requestsTable.AllowUserToAddRows = false;
            requestsTable.AllowUserToDeleteRows = false;
            requestsTable.AllowUserToResizeColumns = false;
            requestsTable.AllowUserToResizeRows = false;
            requestsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridLayout.SetColumnSpan(requestsTable, 3);
            requestsTable.Dock = DockStyle.Fill;
            requestsTable.Location = new Point(23, 293);
            requestsTable.Name = "requestsTable";
            requestsTable.RowTemplate.Height = 25;
            requestsTable.Size = new Size(738, 214);
            requestsTable.TabIndex = 5;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(BL.Objects.User);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(GridLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            GridLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            usersStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel GridLayout;
        private PictureBox Logo;
        private DataGridView usersTable;
        private Button btnExit;
        private Button btnRequests;
        private Button btnReports;
        private ContextMenuStrip usersStrip;
        private ToolStripMenuItem createUserItem;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem updateTableToolStripMenuItem;
        private DataGridView requestsTable;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}