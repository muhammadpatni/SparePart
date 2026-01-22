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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 125);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 55);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 217);
            panel3.TabIndex = 0;
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
            // Employeepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employeepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employeepage";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox1;
    }
}