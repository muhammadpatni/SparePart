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
            Admindrawerpnl.BackColor = Color.Black;
            Admindrawerpnl.Controls.Add(panel2);
            Admindrawerpnl.Dock = DockStyle.Left;
            Admindrawerpnl.Location = new Point(0, 0);
            Admindrawerpnl.Name = "Admindrawerpnl";
            Admindrawerpnl.Size = new Size(220, 532);
            Admindrawerpnl.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlanchedAlmond;
            panel2.Controls.Add(MenuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 100);
            panel2.TabIndex = 0;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.SandyBrown;
            MenuButton.Location = new Point(9, 10);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(58, 42);
            MenuButton.TabIndex = 0;
            MenuButton.TabStop = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // Slidebartimer
            // 
            Slidebartimer.Interval = 10;
            Slidebartimer.Tick += Slidebartimer_Tick;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(908, 532);
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
    }
}