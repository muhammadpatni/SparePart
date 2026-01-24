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
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Slidebartimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            MenuButton = new PictureBox();
            Employeedrawerpnl = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
            Employeedrawerpnl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 218);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "EMPLOYEE";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(303, 122);
            button1.Name = "button1";
            button1.Size = new Size(178, 53);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Black_and_White_Bold_Automotive_Logo_removebg_preview;
            pictureBox1.Location = new Point(311, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Slidebartimer
            // 
            Slidebartimer.Interval = 10;
            Slidebartimer.Tick += Slidebartimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 125);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 55);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 31, 50);
            panel2.Controls.Add(MenuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 249);
            panel2.TabIndex = 0;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(22, 31, 50);
            MenuButton.Image = Properties.Resources.hamburger__1_;
            MenuButton.Location = new Point(9, 10);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(58, 42);
            MenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuButton.TabIndex = 0;
            MenuButton.TabStop = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // Employeedrawerpnl
            // 
            Employeedrawerpnl.BackColor = Color.Black;
            Employeedrawerpnl.Controls.Add(panel2);
            Employeedrawerpnl.Dock = DockStyle.Left;
            Employeedrawerpnl.Location = new Point(0, 0);
            Employeedrawerpnl.Name = "Employeedrawerpnl";
            Employeedrawerpnl.Size = new Size(220, 587);
            Employeedrawerpnl.TabIndex = 6;
            // 
            // Employeepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 587);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Employeedrawerpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employeepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employeepage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            Employeedrawerpnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer Slidebartimer;
        private Panel panel1;
        private Panel panel2;
        private PictureBox MenuButton;
        private FlowLayoutPanel Employeedrawerpnl;
    }
}