namespace SparePart
{
    partial class Cartandreturn
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
            Productnamelb = new Label();
            Instocklb = new Label();
            quantitycount = new NumericUpDown();
            pictureBox1 = new PictureBox();
            Cancelbtn = new Button();
            ConfirmAddbtn = new Button();
            totallb = new Label();
            Pricetxt = new Label();
            ((System.ComponentModel.ISupportInitialize)quantitycount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Productnamelb
            // 
            Productnamelb.AutoSize = true;
            Productnamelb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Productnamelb.ForeColor = Color.FromArgb(30, 41, 59);
            Productnamelb.Location = new Point(167, 129);
            Productnamelb.Name = "Productnamelb";
            Productnamelb.Size = new Size(137, 30);
            Productnamelb.TabIndex = 0;
            Productnamelb.Text = "poductname";
            // 
            // Instocklb
            // 
            Instocklb.AutoSize = true;
            Instocklb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Instocklb.ForeColor = Color.DimGray;
            Instocklb.Location = new Point(181, 162);
            Instocklb.Name = "Instocklb";
            Instocklb.Size = new Size(101, 19);
            Instocklb.TabIndex = 1;
            Instocklb.Text = "In Stock : 1200";
            // 
            // quantitycount
            // 
            quantitycount.BorderStyle = BorderStyle.FixedSingle;
            quantitycount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantitycount.ForeColor = Color.FromArgb(30, 41, 59);
            quantitycount.Location = new Point(169, 193);
            quantitycount.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
            quantitycount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantitycount.Name = "quantitycount";
            quantitycount.Size = new Size(120, 33);
            quantitycount.TabIndex = 2;
            quantitycount.TabStop = false;
            quantitycount.TextAlign = HorizontalAlignment.Center;
            quantitycount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantitycount.ValueChanged += quantitycount_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_shopping_cart_1000dp_1E293B;
            pictureBox1.Location = new Point(185, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.FromArgb(238, 238, 238);
            Cancelbtn.FlatAppearance.BorderSize = 0;
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancelbtn.ForeColor = Color.FromArgb(158, 158, 158);
            Cancelbtn.Location = new Point(44, 295);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(175, 57);
            Cancelbtn.TabIndex = 5;
            Cancelbtn.TabStop = false;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // ConfirmAddbtn
            // 
            ConfirmAddbtn.BackColor = Color.FromArgb(30, 41, 59);
            ConfirmAddbtn.FlatAppearance.BorderSize = 0;
            ConfirmAddbtn.FlatStyle = FlatStyle.Flat;
            ConfirmAddbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ConfirmAddbtn.ForeColor = Color.White;
            ConfirmAddbtn.Location = new Point(242, 295);
            ConfirmAddbtn.Name = "ConfirmAddbtn";
            ConfirmAddbtn.Size = new Size(175, 57);
            ConfirmAddbtn.TabIndex = 6;
            ConfirmAddbtn.TabStop = false;
            ConfirmAddbtn.Text = "Confirm Add";
            ConfirmAddbtn.UseVisualStyleBackColor = false;
            ConfirmAddbtn.Click += ConfirmAddbtn_Click;
            // 
            // totallb
            // 
            totallb.AutoSize = true;
            totallb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totallb.ForeColor = Color.DimGray;
            totallb.Location = new Point(250, 251);
            totallb.Name = "totallb";
            totallb.Size = new Size(83, 19);
            totallb.TabIndex = 7;
            totallb.Text = "Total : 5000";
            // 
            // Pricetxt
            // 
            Pricetxt.AutoSize = true;
            Pricetxt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pricetxt.ForeColor = Color.DimGray;
            Pricetxt.Location = new Point(106, 251);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(75, 19);
            Pricetxt.TabIndex = 8;
            Pricetxt.Text = "Price : 300";
            // 
            // Cartandreturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(470, 376);
            Controls.Add(Pricetxt);
            Controls.Add(totallb);
            Controls.Add(ConfirmAddbtn);
            Controls.Add(Cancelbtn);
            Controls.Add(pictureBox1);
            Controls.Add(quantitycount);
            Controls.Add(Instocklb);
            Controls.Add(Productnamelb);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Cartandreturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cartandreturn";
            Load += Cartandreturn_Load;
            KeyDown += Cartandreturn_KeyDown;
            ((System.ComponentModel.ISupportInitialize)quantitycount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Productnamelb;
        private Label Instocklb;
        private NumericUpDown quantitycount;
        private PictureBox pictureBox1;
        private Button Cancelbtn;
        private Button ConfirmAddbtn;
        private Label totallb;
        private Label Pricetxt;
    }
}