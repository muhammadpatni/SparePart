namespace SparePart
{
    partial class Productcard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namelb = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Bigicon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bigicon).BeginInit();
            SuspendLayout();
            // 
            // namelb
            // 
            namelb.AutoSize = true;
            namelb.BackColor = Color.Transparent;
            namelb.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelb.ForeColor = Color.Black;
            namelb.Location = new Point(119, 6);
            namelb.Name = "namelb";
            namelb.Size = new Size(190, 30);
            namelb.TabIndex = 1;
            namelb.Text = "tyre 6 ply panther";
            namelb.Click += namelb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(762, 14);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Rs. 1850";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(244, 227, 227);
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 82, 82);
            label3.Location = new Point(119, 46);
            label3.Name = "label3";
            label3.Padding = new Padding(3, 2, 3, 2);
            label3.Size = new Size(45, 21);
            label3.TabIndex = 4;
            label3.Text = "0 pcs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 162, 162);
            label1.Location = new Point(178, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 5;
            label1.Text = "Min: 9";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(244, 227, 227);
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 82, 82);
            label4.Location = new Point(119, 75);
            label4.Name = "label4";
            label4.Padding = new Padding(3, 2, 3, 2);
            label4.Size = new Size(92, 21);
            label4.TabIndex = 6;
            label4.Text = "Out Of Stock";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.edit_note_24dp_90A4AE;
            pictureBox1.Location = new Point(837, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Bigicon
            // 
            Bigicon.BackColor = Color.FromArgb(201, 40, 40);
            Bigicon.Image = Properties.Resources.edit_note_1000dp_FFFFFF;
            Bigicon.Location = new Point(14, 12);
            Bigicon.Name = "Bigicon";
            Bigicon.Size = new Size(79, 82);
            Bigicon.SizeMode = PictureBoxSizeMode.StretchImage;
            Bigicon.TabIndex = 0;
            Bigicon.TabStop = false;
            Bigicon.Click += pictureBox1_Click;
            // 
            // Productcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(namelb);
            Controls.Add(Bigicon);
            Name = "Productcard";
            Size = new Size(898, 104);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bigicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label namelb;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox Bigicon;
    }
}
