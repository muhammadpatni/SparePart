namespace SparePart
{
    partial class Updateproductform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updateproductform));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Pagetitlelb = new Label();
            productnametxt = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            stocktxt = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pricetxt = new TextBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            lowstocktxt = new TextBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            Confirmbtn = new Button();
            Discardbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 31, 50);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Pagetitlelb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Pagetitlelb
            // 
            Pagetitlelb.AutoSize = true;
            Pagetitlelb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pagetitlelb.ForeColor = Color.White;
            Pagetitlelb.Location = new Point(294, 18);
            Pagetitlelb.Name = "Pagetitlelb";
            Pagetitlelb.Size = new Size(234, 30);
            Pagetitlelb.TabIndex = 1;
            Pagetitlelb.Text = "UPDATE SPARE PARTS";
            // 
            // productnametxt
            // 
            productnametxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            productnametxt.Location = new Point(82, 88);
            productnametxt.Multiline = true;
            productnametxt.Name = "productnametxt";
            productnametxt.Size = new Size(688, 43);
            productnametxt.TabIndex = 1;
            productnametxt.KeyDown += productnametxt_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 132, 140);
            label2.Location = new Point(82, 68);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // stocktxt
            // 
            stocktxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            stocktxt.ForeColor = Color.Black;
            stocktxt.Location = new Point(454, 160);
            stocktxt.Multiline = true;
            stocktxt.Name = "stocktxt";
            stocktxt.Size = new Size(316, 43);
            stocktxt.TabIndex = 1;
            stocktxt.TextChanged += stocktxt_TextChanged;
            stocktxt.KeyDown += stocktxt_KeyDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(410, 160);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 132, 140);
            label3.Location = new Point(454, 140);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 3;
            label3.Text = "Stock";
            // 
            // pricetxt
            // 
            pricetxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            pricetxt.Location = new Point(82, 160);
            pricetxt.Multiline = true;
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(316, 43);
            pricetxt.TabIndex = 1;
            pricetxt.TextChanged += pricetxt_TextChanged;
            pricetxt.KeyDown += pricetxt_KeyDown;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(38, 160);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 132, 140);
            label4.Location = new Point(82, 140);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // lowstocktxt
            // 
            lowstocktxt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lowstocktxt.Location = new Point(82, 237);
            lowstocktxt.Multiline = true;
            lowstocktxt.Name = "lowstocktxt";
            lowstocktxt.Size = new Size(688, 43);
            lowstocktxt.TabIndex = 1;
            lowstocktxt.KeyDown += lowstocktxt_KeyDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(38, 237);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 132, 140);
            label5.Location = new Point(82, 217);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 3;
            label5.Text = "Low Stock Alert (Min Qty)";
            // 
            // Confirmbtn
            // 
            Confirmbtn.BackColor = Color.FromArgb(22, 31, 50);
            Confirmbtn.FlatAppearance.BorderSize = 0;
            Confirmbtn.FlatStyle = FlatStyle.Flat;
            Confirmbtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirmbtn.ForeColor = Color.White;
            Confirmbtn.Location = new Point(596, 324);
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.Size = new Size(174, 45);
            Confirmbtn.TabIndex = 4;
            Confirmbtn.TabStop = false;
            Confirmbtn.Text = "Confirm Update";
            Confirmbtn.UseVisualStyleBackColor = false;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // Discardbtn
            // 
            Discardbtn.BackColor = Color.White;
            Discardbtn.FlatAppearance.BorderSize = 0;
            Discardbtn.FlatStyle = FlatStyle.Flat;
            Discardbtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Discardbtn.Location = new Point(444, 324);
            Discardbtn.Name = "Discardbtn";
            Discardbtn.Size = new Size(141, 45);
            Discardbtn.TabIndex = 4;
            Discardbtn.TabStop = false;
            Discardbtn.Text = "Discard";
            Discardbtn.UseVisualStyleBackColor = false;
            Discardbtn.Click += Discardbtn_Click;
            // 
            // Updateproductform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(Discardbtn);
            Controls.Add(Confirmbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pricetxt);
            Controls.Add(stocktxt);
            Controls.Add(lowstocktxt);
            Controls.Add(productnametxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Updateproductform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Updateproduct";
            Load += Updateproductform_Load;
            Shown += Updateproductform_Shown;
            KeyDown += Updateproductform_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Pagetitlelb;
        private PictureBox pictureBox1;
        private TextBox productnametxt;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox stocktxt;
        private PictureBox pictureBox3;
        private Label label3;
        private TextBox pricetxt;
        private PictureBox pictureBox4;
        private Label label4;
        private TextBox lowstocktxt;
        private PictureBox pictureBox5;
        private Label label5;
        private Button Confirmbtn;
        private Button Discardbtn;
    }
}