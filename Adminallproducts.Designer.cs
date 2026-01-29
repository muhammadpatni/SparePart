namespace SparePart
{
    partial class Adminallproducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            Outofstokelb1 = new Label();
            backbtn = new PictureBox();
            dataview = new DataGridView();
            panel3 = new Panel();
            panel7 = new Panel();
            searcchtxt = new TextBox();
            pictureBox2 = new PictureBox();
            panel10 = new Panel();
            lbstatus = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 31, 50);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(backbtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 56);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Outofstokelb1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(52, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 56);
            panel2.TabIndex = 20;
            // 
            // Outofstokelb1
            // 
            Outofstokelb1.AutoSize = true;
            Outofstokelb1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Outofstokelb1.ForeColor = Color.White;
            Outofstokelb1.Location = new Point(16, 12);
            Outofstokelb1.Name = "Outofstokelb1";
            Outofstokelb1.Size = new Size(213, 30);
            Outofstokelb1.TabIndex = 18;
            Outofstokelb1.Text = "PARTS INVENTORY";
            // 
            // backbtn
            // 
            backbtn.Dock = DockStyle.Left;
            backbtn.Image = Properties.Resources.chevron_left_1000dp_FFFFFF;
            backbtn.Location = new Point(0, 0);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(52, 56);
            backbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backbtn.TabIndex = 19;
            backbtn.TabStop = false;
            backbtn.Click += backbtn_Click;
            // 
            // dataview
            // 
            dataview.AllowUserToAddRows = false;
            dataview.AllowUserToDeleteRows = false;
            dataview.AllowUserToResizeColumns = false;
            dataview.AllowUserToResizeRows = false;
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataview.BackgroundColor = Color.FromArgb(248, 250, 252);
            dataview.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 105, 118);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataview.DefaultCellStyle = dataGridViewCellStyle2;
            dataview.Dock = DockStyle.Fill;
            dataview.EnableHeadersVisualStyles = false;
            dataview.GridColor = Color.FromArgb(30, 41, 59);
            dataview.Location = new Point(30, 30);
            dataview.Margin = new Padding(50);
            dataview.MultiSelect = false;
            dataview.Name = "dataview";
            dataview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataview.RowHeadersVisible = false;
            dataview.RowTemplate.DividerHeight = 2;
            dataview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataview.Size = new Size(979, 388);
            dataview.TabIndex = 21;
            dataview.TabStop = false;
            dataview.VirtualMode = true;
            dataview.CellContentClick += dataview_CellContentClick;
            dataview.KeyDown += dataview_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 41, 59);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(1039, 68);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(30, 41, 59);
            panel7.Controls.Add(searcchtxt);
            panel7.Controls.Add(pictureBox2);
            panel7.Location = new Point(372, 7);
            panel7.Name = "panel7";
            panel7.Size = new Size(540, 51);
            panel7.TabIndex = 19;
            // 
            // searcchtxt
            // 
            searcchtxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searcchtxt.Location = new Point(46, 8);
            searcchtxt.Multiline = true;
            searcchtxt.Name = "searcchtxt";
            searcchtxt.Size = new Size(482, 35);
            searcchtxt.TabIndex = 12;
            searcchtxt.TabStop = false;
            searcchtxt.TextChanged += searcchtxt_TextChanged;
            searcchtxt.KeyDown += searcchtxt_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(30, 41, 59);
            pictureBox2.Image = Properties.Resources.search_1000dp_FFFFFF;
            pictureBox2.Location = new Point(3, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(dataview);
            panel10.Controls.Add(lbstatus);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 124);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(30);
            panel10.Size = new Size(1039, 448);
            panel10.TabIndex = 23;
            // 
            // lbstatus
            // 
            lbstatus.AutoSize = true;
            lbstatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbstatus.ForeColor = Color.FromArgb(162, 162, 162);
            lbstatus.Location = new Point(626, 315);
            lbstatus.Name = "lbstatus";
            lbstatus.Size = new Size(81, 21);
            lbstatus.TabIndex = 19;
            lbstatus.Text = "Loading...";
            // 
            // Adminallproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1039, 572);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Adminallproducts";
            Text = "Adminllproducts";
            WindowState = FormWindowState.Maximized;
            Load += Adminallproducts_Load;
            KeyDown += Adminallproducts_KeyDown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox backbtn;
        private Label Outofstokelb1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel7;
        private TextBox searcchtxt;
        private PictureBox pictureBox2;
        private Panel panel10;
        private DataGridView dataview;
        private Label lbstatus;
    }
}