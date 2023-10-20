namespace Printing_Service.Forms
{
    partial class Customer
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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            requestsTable = new DataGridView();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            btnCancelLast = new Button();
            btnRequest = new Button();
            label3 = new Label();
            urgentCheckbox = new CheckBox();
            quantityUpDown = new NumericUpDown();
            label2 = new Label();
            serviceCombo = new ComboBox();
            label1 = new Label();
            requestBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestsTable).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.apu_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 511);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(requestsTable);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(23, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Previous requests";
            // 
            // requestsTable
            // 
            requestsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsTable.Dock = DockStyle.Fill;
            requestsTable.Location = new Point(3, 19);
            requestsTable.Name = "requestsTable";
            requestsTable.RowTemplate.Height = 25;
            requestsTable.Size = new Size(732, 301);
            requestsTable.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnCancelLast);
            groupBox2.Controls.Add(btnRequest);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(urgentCheckbox);
            groupBox2.Controls.Add(quantityUpDown);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(serviceCombo);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(23, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(738, 135);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create request";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 87);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(345, 63);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 8;
            label4.Text = "Total:";
            // 
            // btnCancelLast
            // 
            btnCancelLast.Enabled = false;
            btnCancelLast.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelLast.Location = new Point(445, 63);
            btnCancelLast.Margin = new Padding(10);
            btnCancelLast.Name = "btnCancelLast";
            btnCancelLast.Size = new Size(280, 50);
            btnCancelLast.TabIndex = 7;
            btnCancelLast.Text = "Cancel last";
            btnCancelLast.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            btnRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRequest.BackColor = Color.DodgerBlue;
            btnRequest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(13, 63);
            btnRequest.Margin = new Padding(10);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(280, 50);
            btnRequest.TabIndex = 6;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(582, 31);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 5;
            label3.Text = "(there will be charge 30%)";
            // 
            // urgentCheckbox
            // 
            urgentCheckbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            urgentCheckbox.AutoSize = true;
            urgentCheckbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            urgentCheckbox.Location = new Point(522, 30);
            urgentCheckbox.Margin = new Padding(10);
            urgentCheckbox.Name = "urgentCheckbox";
            urgentCheckbox.Size = new Size(62, 19);
            urgentCheckbox.TabIndex = 4;
            urgentCheckbox.Text = "Urgent";
            urgentCheckbox.UseVisualStyleBackColor = true;
            // 
            // quantityUpDown
            // 
            quantityUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityUpDown.Location = new Point(329, 27);
            quantityUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(180, 23);
            quantityUpDown.TabIndex = 3;
            quantityUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 31);
            label2.Margin = new Padding(3, 10, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity";
            // 
            // serviceCombo
            // 
            serviceCombo.FormattingEnabled = true;
            serviceCombo.Items.AddRange(new object[] { "Printing A4 – Black and White ", "Printing A4 – Color", "Binding – Comb Binding ", "Binding – Thick Cover ", "Poster printing (A1)", "Poster printing (A2)", "Poster printing (A3)", "Banner" });
            serviceCombo.Location = new Point(70, 27);
            serviceCombo.Name = "serviceCombo";
            serviceCombo.Size = new Size(180, 23);
            serviceCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 31);
            label1.Margin = new Padding(3, 10, 3, 10);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Service";
            // 
            // requestBindingSource
            // 
            requestBindingSource.DataSource = typeof(BL.Objects.Request);
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestsTable).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView requestsTable;
        private BindingSource requestBindingSource;
        private Label label1;
        private Label label3;
        private CheckBox urgentCheckbox;
        private NumericUpDown quantityUpDown;
        private Label label2;
        private ComboBox serviceCombo;
        private Button btnRequest;
        private Button btnCancelLast;
        private TextBox textBox1;
        private Label label4;
    }
}