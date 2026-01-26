namespace SparePart
{
    partial class Employeepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeepage));
            Slidebartimer = new System.Windows.Forms.Timer(components);
            Admindrawerpnl = new Panel();
            panel5 = new Panel();
            Dashboardselected = new Panel();
            Minquantitybtn = new Button();
            panel6 = new Panel();
            Outofstockbtn = new Button();
            panel4 = new Panel();
            Dashboardbtn = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            Logoutbutton = new Button();
            drawerinnerpanel = new Panel();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            Outofstokelb1 = new Label();
            MenubtnDrawer = new PictureBox();
            panel7 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            Admindrawerpnl.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            drawerinnerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenubtnDrawer).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Slidebartimer
            // 
            Slidebartimer.Interval = 10;
            // 
            // Admindrawerpnl
            // 
            Admindrawerpnl.BackColor = Color.White;
            Admindrawerpnl.Controls.Add(panel5);
            Admindrawerpnl.Controls.Add(panel6);
            Admindrawerpnl.Controls.Add(panel4);
            Admindrawerpnl.Controls.Add(panel3);
            Admindrawerpnl.Controls.Add(panel2);
            Admindrawerpnl.Controls.Add(drawerinnerpanel);
            Admindrawerpnl.Dock = DockStyle.Left;
            Admindrawerpnl.Location = new Point(0, 56);
            Admindrawerpnl.Name = "Admindrawerpnl";
            Admindrawerpnl.Size = new Size(220, 531);
            Admindrawerpnl.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(Dashboardselected);
            panel5.Controls.Add(Minquantitybtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 381);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 58);
            panel5.TabIndex = 14;
            // 
            // Dashboardselected
            // 
            Dashboardselected.BackColor = Color.FromArgb(30, 41, 59);
            Dashboardselected.Location = new Point(190, 16);
            Dashboardselected.Name = "Dashboardselected";
            Dashboardselected.Size = new Size(7, 25);
            Dashboardselected.TabIndex = 16;
            // 
            // Minquantitybtn
            // 
            Minquantitybtn.BackColor = Color.Transparent;
            Minquantitybtn.FlatAppearance.BorderSize = 0;
            Minquantitybtn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            Minquantitybtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Minquantitybtn.FlatStyle = FlatStyle.Flat;
            Minquantitybtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minquantitybtn.ForeColor = Color.FromArgb(74, 82, 97);
            Minquantitybtn.Image = (Image)resources.GetObject("Minquantitybtn.Image");
            Minquantitybtn.ImageAlign = ContentAlignment.MiddleLeft;
            Minquantitybtn.Location = new Point(5, 10);
            Minquantitybtn.Name = "Minquantitybtn";
            Minquantitybtn.Padding = new Padding(10, 0, 0, 0);
            Minquantitybtn.Size = new Size(194, 37);
            Minquantitybtn.TabIndex = 12;
            Minquantitybtn.Text = "Pending Bills";
            Minquantitybtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(Outofstockbtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 323);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 58);
            panel6.TabIndex = 15;
            // 
            // Outofstockbtn
            // 
            Outofstockbtn.BackColor = Color.Transparent;
            Outofstockbtn.FlatAppearance.BorderSize = 0;
            Outofstockbtn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            Outofstockbtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Outofstockbtn.FlatStyle = FlatStyle.Flat;
            Outofstockbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Outofstockbtn.ForeColor = Color.FromArgb(74, 82, 97);
            Outofstockbtn.Image = (Image)resources.GetObject("Outofstockbtn.Image");
            Outofstockbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Outofstockbtn.Location = new Point(5, 10);
            Outofstockbtn.Name = "Outofstockbtn";
            Outofstockbtn.Padding = new Padding(10, 0, 0, 0);
            Outofstockbtn.Size = new Size(194, 37);
            Outofstockbtn.TabIndex = 12;
            Outofstockbtn.Text = "Return";
            Outofstockbtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Dashboardbtn);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 58);
            panel4.TabIndex = 13;
            // 
            // Dashboardbtn
            // 
            Dashboardbtn.BackColor = Color.Transparent;
            Dashboardbtn.FlatAppearance.BorderSize = 0;
            Dashboardbtn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            Dashboardbtn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Dashboardbtn.FlatStyle = FlatStyle.Flat;
            Dashboardbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboardbtn.ForeColor = Color.FromArgb(74, 82, 97);
            Dashboardbtn.Image = (Image)resources.GetObject("Dashboardbtn.Image");
            Dashboardbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboardbtn.Location = new Point(5, 10);
            Dashboardbtn.Name = "Dashboardbtn";
            Dashboardbtn.Padding = new Padding(10, 0, 0, 0);
            Dashboardbtn.Size = new Size(194, 37);
            Dashboardbtn.TabIndex = 12;
            Dashboardbtn.Text = "Billing";
            Dashboardbtn.UseVisualStyleBackColor = false;
            Dashboardbtn.Click += Dashboardbtn_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 40);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(Logoutbutton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 63);
            panel2.TabIndex = 9;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = Color.FromArgb(254, 245, 245);
            Logoutbutton.FlatAppearance.BorderSize = 0;
            Logoutbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 235, 235);
            Logoutbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 235, 235);
            Logoutbutton.FlatStyle = FlatStyle.Flat;
            Logoutbutton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbutton.ForeColor = Color.FromArgb(255, 82, 82);
            Logoutbutton.Image = Properties.Resources.power_settings_new_24dp_FF5252;
            Logoutbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Logoutbutton.Location = new Point(10, 12);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Padding = new Padding(10, 0, 0, 0);
            Logoutbutton.Size = new Size(194, 37);
            Logoutbutton.TabIndex = 11;
            Logoutbutton.Text = "LOG OUT";
            Logoutbutton.UseVisualStyleBackColor = false;
            // 
            // drawerinnerpanel
            // 
            drawerinnerpanel.BackColor = Color.FromArgb(22, 31, 50);
            drawerinnerpanel.Controls.Add(panel8);
            drawerinnerpanel.Controls.Add(pictureBox1);
            drawerinnerpanel.Controls.Add(label3);
            drawerinnerpanel.Controls.Add(label1);
            drawerinnerpanel.Dock = DockStyle.Top;
            drawerinnerpanel.Location = new Point(0, 0);
            drawerinnerpanel.Margin = new Padding(0);
            drawerinnerpanel.Name = "drawerinnerpanel";
            drawerinnerpanel.Size = new Size(220, 225);
            drawerinnerpanel.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 2);
            panel8.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(49, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(161, 165, 172);
            label3.Location = new Point(29, 185);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 16;
            label3.Text = "SPARE PARTS MANAGEMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 155);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 15;
            label1.Text = "EMPLOYEES PORTAL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Outofstokelb1);
            panel1.Controls.Add(MenubtnDrawer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 56);
            panel1.TabIndex = 14;
            // 
            // Outofstokelb1
            // 
            Outofstokelb1.AutoSize = true;
            Outofstokelb1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Outofstokelb1.ForeColor = Color.Black;
            Outofstokelb1.Location = new Point(605, 15);
            Outofstokelb1.Name = "Outofstokelb1";
            Outofstokelb1.Size = new Size(159, 30);
            Outofstokelb1.TabIndex = 18;
            Outofstokelb1.Text = "BILLING PAGE";
            // 
            // MenubtnDrawer
            // 
            MenubtnDrawer.BackColor = Color.Transparent;
            MenubtnDrawer.Image = (Image)resources.GetObject("MenubtnDrawer.Image");
            MenubtnDrawer.Location = new Point(10, 11);
            MenubtnDrawer.Name = "MenubtnDrawer";
            MenubtnDrawer.Size = new Size(37, 32);
            MenubtnDrawer.SizeMode = PictureBoxSizeMode.StretchImage;
            MenubtnDrawer.TabIndex = 0;
            MenubtnDrawer.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(220, 56);
            panel7.Name = "panel7";
            panel7.Size = new Size(1014, 531);
            panel7.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 23);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 18;
            label2.Text = "Select Products";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 35);
            textBox1.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Employeepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 587);
            Controls.Add(panel7);
            Controls.Add(Admindrawerpnl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employeepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employeepage";
            WindowState = FormWindowState.Maximized;
            Admindrawerpnl.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            drawerinnerpanel.ResumeLayout(false);
            drawerinnerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenubtnDrawer).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Slidebartimer;
        private Panel Admindrawerpnl;
        private Panel panel5;
        private Panel Dashboardselected;
        private Button Minquantitybtn;
        private Panel panel6;
        private Button Outofstockbtn;
        private Panel panel4;
        private Button Dashboardbtn;
        private Panel panel3;
        private Panel panel2;
        private Button Logoutbutton;
        private Panel drawerinnerpanel;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label Outofstokelb1;
        private PictureBox MenubtnDrawer;
        private Panel panel7;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}