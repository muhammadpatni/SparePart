namespace SparePart
{
    partial class Adminpage
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
            label1 = new Label();
            drawerinnerpanel = new Panel();
            MenuButton = new PictureBox();
            panel2 = new Panel();
            Logoutbutton = new Button();
            Slidebartimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            Admindrawerpnl = new Panel();
            Dashboardbtn = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            Minquantitybtn = new Button();
            panel6 = new Panel();
            Outofstockbtn = new Button();
            drawerinnerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
            panel2.SuspendLayout();
            Admindrawerpnl.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 127);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "ADMIN";
            // 
            // drawerinnerpanel
            // 
            drawerinnerpanel.BackColor = Color.FromArgb(30, 41, 59);
            drawerinnerpanel.Controls.Add(MenuButton);
            drawerinnerpanel.Dock = DockStyle.Top;
            drawerinnerpanel.Location = new Point(0, 0);
            drawerinnerpanel.Margin = new Padding(0);
            drawerinnerpanel.Name = "drawerinnerpanel";
            drawerinnerpanel.Size = new Size(220, 202);
            drawerinnerpanel.TabIndex = 0;
            drawerinnerpanel.Paint += panel2_Paint;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.Transparent;
            MenuButton.Image = Properties.Resources.hamburger__1_;
            MenuButton.Location = new Point(8, 10);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(37, 32);
            MenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuButton.TabIndex = 0;
            MenuButton.TabStop = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Logoutbutton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 496);
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
            Logoutbutton.Click += button1_Click;
            // 
            // Slidebartimer
            // 
            Slidebartimer.Interval = 5;
            Slidebartimer.Tick += Slidebartimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 56);
            panel1.TabIndex = 8;
            // 
            // Admindrawerpnl
            // 
            Admindrawerpnl.Controls.Add(panel5);
            Admindrawerpnl.Controls.Add(panel6);
            Admindrawerpnl.Controls.Add(panel4);
            Admindrawerpnl.Controls.Add(panel3);
            Admindrawerpnl.Controls.Add(panel2);
            Admindrawerpnl.Controls.Add(drawerinnerpanel);
            Admindrawerpnl.Dock = DockStyle.Left;
            Admindrawerpnl.Location = new Point(0, 0);
            Admindrawerpnl.Name = "Admindrawerpnl";
            Admindrawerpnl.Size = new Size(220, 559);
            Admindrawerpnl.TabIndex = 10;
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
            Dashboardbtn.Image = Properties.Resources.dashboard_24dp_90A4AE;
            Dashboardbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboardbtn.Location = new Point(10, 10);
            Dashboardbtn.Name = "Dashboardbtn";
            Dashboardbtn.Padding = new Padding(10, 0, 0, 0);
            Dashboardbtn.Size = new Size(194, 37);
            Dashboardbtn.TabIndex = 12;
            Dashboardbtn.Text = "Dashboard";
            Dashboardbtn.UseVisualStyleBackColor = false;
            Dashboardbtn.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 21);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(Dashboardbtn);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 223);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 58);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(Minquantitybtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 339);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 58);
            panel5.TabIndex = 14;
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
            Minquantitybtn.Image = Properties.Resources.warning_amber_24dp_90A4AE;
            Minquantitybtn.ImageAlign = ContentAlignment.MiddleLeft;
            Minquantitybtn.Location = new Point(10, 10);
            Minquantitybtn.Name = "Minquantitybtn";
            Minquantitybtn.Padding = new Padding(10, 0, 0, 0);
            Minquantitybtn.Size = new Size(194, 37);
            Minquantitybtn.TabIndex = 12;
            Minquantitybtn.Text = "Min. Quantity";
            Minquantitybtn.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(Outofstockbtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 281);
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
            Outofstockbtn.Image = Properties.Resources.inventory_2_24dp_90A4AE;
            Outofstockbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Outofstockbtn.Location = new Point(10, 10);
            Outofstockbtn.Name = "Outofstockbtn";
            Outofstockbtn.Padding = new Padding(10, 0, 0, 0);
            Outofstockbtn.Size = new Size(194, 37);
            Outofstockbtn.TabIndex = 12;
            Outofstockbtn.Text = "Out Of Stock";
            Outofstockbtn.UseVisualStyleBackColor = false;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(975, 559);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Admindrawerpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminpage";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Adminpage_Load;
            drawerinnerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            panel2.ResumeLayout(false);
            Admindrawerpnl.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel drawerinnerpanel;
        private PictureBox MenuButton;
        private System.Windows.Forms.Timer Slidebartimer;
        private Panel panel1;
        private Panel panel2;
        private Panel Admindrawerpnl;
        private Button Logoutbutton;
        private Panel panel3;
        private Button Dashboardbtn;
        private Panel panel4;
        private Panel panel5;
        private Button Minquantitybtn;
        private Panel panel6;
        private Button Outofstockbtn;
    }
}