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
            drawerinnerpanel = new Panel();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            MenuButton = new PictureBox();
            panel2 = new Panel();
            Logoutbutton = new Button();
            Slidebartimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel7 = new Panel();
            Productsbtn = new PictureBox();
            addnewproductbutton = new PictureBox();
            Dashboardtitlelb = new Label();
            Admindrawerpnl = new Panel();
            panel5 = new Panel();
            Minquantitybtn = new Button();
            panel6 = new Panel();
            Outofstockbtn = new Button();
            panel4 = new Panel();
            Dashboardselected = new Panel();
            Dashboardbtn = new Button();
            panel3 = new Panel();
            Mainpanel = new Panel();
            drawerinnerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Productsbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addnewproductbutton).BeginInit();
            Admindrawerpnl.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // drawerinnerpanel
            // 
            drawerinnerpanel.BackColor = Color.FromArgb(22, 31, 50);
            drawerinnerpanel.Controls.Add(panel8);
            drawerinnerpanel.Controls.Add(pictureBox1);
            drawerinnerpanel.Controls.Add(label3);
            drawerinnerpanel.Controls.Add(label2);
            drawerinnerpanel.Dock = DockStyle.Top;
            drawerinnerpanel.Location = new Point(0, 0);
            drawerinnerpanel.Margin = new Padding(0);
            drawerinnerpanel.Name = "drawerinnerpanel";
            drawerinnerpanel.Size = new Size(220, 225);
            drawerinnerpanel.TabIndex = 0;
            drawerinnerpanel.Paint += drawerinnerpanel_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(220, 2);
            panel8.TabIndex = 0;
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
            label3.Location = new Point(28, 185);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 16;
            label3.Text = "SPARE PARTS MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 153);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 15;
            label2.Text = "PARTEX ADMIN";
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.Transparent;
            MenuButton.Image = Properties.Resources.hamburger__1_;
            MenuButton.Location = new Point(10, 11);
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
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 63);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
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
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // Slidebartimer
            // 
            Slidebartimer.Interval = 5;
            Slidebartimer.Tick += Slidebartimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 31, 50);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(Dashboardtitlelb);
            panel1.Controls.Add(MenuButton);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 56);
            panel1.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(Productsbtn);
            panel7.Controls.Add(addnewproductbutton);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(881, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(94, 56);
            panel7.TabIndex = 14;
            // 
            // Productsbtn
            // 
            Productsbtn.BackColor = Color.Transparent;
            Productsbtn.Image = Properties.Resources.inventory_2_24dp_FFFFFF1;
            Productsbtn.Location = new Point(56, 16);
            Productsbtn.Name = "Productsbtn";
            Productsbtn.Size = new Size(24, 24);
            Productsbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            Productsbtn.TabIndex = 12;
            Productsbtn.TabStop = false;
            // 
            // addnewproductbutton
            // 
            addnewproductbutton.BackColor = Color.Transparent;
            addnewproductbutton.Image = Properties.Resources.add_box_24dp_FFFFFF;
            addnewproductbutton.Location = new Point(17, 16);
            addnewproductbutton.Name = "addnewproductbutton";
            addnewproductbutton.Size = new Size(24, 24);
            addnewproductbutton.SizeMode = PictureBoxSizeMode.StretchImage;
            addnewproductbutton.TabIndex = 13;
            addnewproductbutton.TabStop = false;
            // 
            // Dashboardtitlelb
            // 
            Dashboardtitlelb.AutoSize = true;
            Dashboardtitlelb.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboardtitlelb.ForeColor = Color.White;
            Dashboardtitlelb.Location = new Point(625, 15);
            Dashboardtitlelb.Name = "Dashboardtitlelb";
            Dashboardtitlelb.Size = new Size(135, 25);
            Dashboardtitlelb.TabIndex = 11;
            Dashboardtitlelb.Text = "DASHBOARD";
            Dashboardtitlelb.Click += partextitlelb_Click;
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
            Admindrawerpnl.Size = new Size(220, 503);
            Admindrawerpnl.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(Minquantitybtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 381);
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
            Minquantitybtn.Location = new Point(5, 10);
            Minquantitybtn.Name = "Minquantitybtn";
            Minquantitybtn.Padding = new Padding(10, 0, 0, 0);
            Minquantitybtn.Size = new Size(194, 37);
            Minquantitybtn.TabIndex = 12;
            Minquantitybtn.Text = " Min. Quantity";
            Minquantitybtn.UseVisualStyleBackColor = false;
            Minquantitybtn.Click += Minquantitybtn_Click;
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
            Outofstockbtn.Image = Properties.Resources.inventory_2_24dp_90A4AE;
            Outofstockbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Outofstockbtn.Location = new Point(5, 10);
            Outofstockbtn.Name = "Outofstockbtn";
            Outofstockbtn.Padding = new Padding(10, 0, 0, 0);
            Outofstockbtn.Size = new Size(194, 37);
            Outofstockbtn.TabIndex = 12;
            Outofstockbtn.Text = "Out Of Stock";
            Outofstockbtn.UseVisualStyleBackColor = false;
            Outofstockbtn.Click += Outofstockbtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(Dashboardselected);
            panel4.Controls.Add(Dashboardbtn);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 58);
            panel4.TabIndex = 13;
            // 
            // Dashboardselected
            // 
            Dashboardselected.BackColor = Color.FromArgb(30, 41, 59);
            Dashboardselected.Location = new Point(190, 16);
            Dashboardselected.Name = "Dashboardselected";
            Dashboardselected.Size = new Size(7, 25);
            Dashboardselected.TabIndex = 0;
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
            Dashboardbtn.Location = new Point(5, 10);
            Dashboardbtn.Name = "Dashboardbtn";
            Dashboardbtn.Padding = new Padding(10, 0, 0, 0);
            Dashboardbtn.Size = new Size(194, 37);
            Dashboardbtn.TabIndex = 12;
            Dashboardbtn.Text = "Dashboard";
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
            // Mainpanel
            // 
            Mainpanel.BackColor = Color.Gray;
            Mainpanel.Dock = DockStyle.Fill;
            Mainpanel.Location = new Point(220, 56);
            Mainpanel.Name = "Mainpanel";
            Mainpanel.Size = new Size(755, 503);
            Mainpanel.TabIndex = 11;
            Mainpanel.Paint += Mainpanel_Paint;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(975, 559);
            Controls.Add(Mainpanel);
            Controls.Add(Admindrawerpnl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Adminpage";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += Adminpage_Load;
            KeyDown += Adminpage_KeyDown;
            drawerinnerpanel.ResumeLayout(false);
            drawerinnerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Productsbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)addnewproductbutton).EndInit();
            Admindrawerpnl.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Label Dashboardtitlelb;
        private PictureBox addnewproductbutton;
        private PictureBox Productsbtn;
        private Panel panel7;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel Mainpanel;
        private Panel Dashboardselected;
        private Panel panel8;
    }
}