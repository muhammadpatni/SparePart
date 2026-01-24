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
            Admindrawerpnl = new FlowLayoutPanel();
            panel2 = new Panel();
            MenuButton = new PictureBox();
            Slidebartimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            Admindrawerpnl.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
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
            // Admindrawerpnl
            // 
            Admindrawerpnl.BackColor = Color.White;
            Admindrawerpnl.Controls.Add(panel2);
            Admindrawerpnl.Dock = DockStyle.Left;
            Admindrawerpnl.Location = new Point(0, 0);
            Admindrawerpnl.Margin = new Padding(0);
            Admindrawerpnl.Name = "Admindrawerpnl";
            Admindrawerpnl.Size = new Size(220, 559);
            Admindrawerpnl.TabIndex = 7;
            Admindrawerpnl.Paint += Admindrawerpnl_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 41, 59);
            panel2.Controls.Add(MenuButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 202);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
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
            // Slidebartimer
            // 
            Slidebartimer.Interval = 10;
            Slidebartimer.Tick += Slidebartimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 45);
            panel1.TabIndex = 8;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(975, 559);
            Controls.Add(panel1);
            Controls.Add(Admindrawerpnl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adminpage";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Admindrawerpnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel Admindrawerpnl;
        private Panel panel2;
        private PictureBox MenuButton;
        private System.Windows.Forms.Timer Slidebartimer;
        private Panel panel1;
    }
}