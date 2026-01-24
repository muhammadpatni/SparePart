namespace SparePart
{
    partial class LoginPage
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
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            EmployeeRadioBtn = new RadioButton();
            AdminRadioBtn = new RadioButton();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            UserNameTxtBox = new TextBox();
            LoginPnl = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            LoginPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(94, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 2);
            panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(0, -90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(211, 34);
            textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(94, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 2);
            panel1.TabIndex = 4;
            // 
            // EmployeeRadioBtn
            // 
            EmployeeRadioBtn.AutoSize = true;
            EmployeeRadioBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EmployeeRadioBtn.Location = new Point(211, 164);
            EmployeeRadioBtn.Name = "EmployeeRadioBtn";
            EmployeeRadioBtn.Size = new Size(77, 19);
            EmployeeRadioBtn.TabIndex = 3;
            EmployeeRadioBtn.TabStop = true;
            EmployeeRadioBtn.Text = "Employee";
            EmployeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AdminRadioBtn
            // 
            AdminRadioBtn.AutoSize = true;
            AdminRadioBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AdminRadioBtn.Location = new Point(105, 164);
            AdminRadioBtn.Name = "AdminRadioBtn";
            AdminRadioBtn.Size = new Size(61, 19);
            AdminRadioBtn.TabIndex = 3;
            AdminRadioBtn.TabStop = true;
            AdminRadioBtn.Text = "Admin";
            AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = Color.FromArgb(239, 242, 247);
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Font = new Font("Segoe UI", 9F);
            PasswordTxtBox.ForeColor = Color.Black;
            PasswordTxtBox.Location = new Point(94, 100);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(211, 34);
            PasswordTxtBox.TabIndex = 3;
            PasswordTxtBox.KeyDown += PasswordTxtBox_KeyDown;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(94, 204);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(211, 40);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(239, 242, 247);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 9F);
            UserNameTxtBox.ForeColor = Color.Black;
            UserNameTxtBox.Location = new Point(94, 41);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(211, 34);
            UserNameTxtBox.TabIndex = 3;
            UserNameTxtBox.KeyDown += UserNameTxtBox_KeyDown;
            // 
            // LoginPnl
            // 
            LoginPnl.BackColor = Color.FromArgb(239, 242, 247);
            LoginPnl.BorderStyle = BorderStyle.FixedSingle;
            LoginPnl.Controls.Add(panel2);
            LoginPnl.Controls.Add(PasswordTxtBox);
            LoginPnl.Controls.Add(panel1);
            LoginPnl.Controls.Add(LoginBtn);
            LoginPnl.Controls.Add(EmployeeRadioBtn);
            LoginPnl.Controls.Add(AdminRadioBtn);
            LoginPnl.Controls.Add(UserNameTxtBox);
            LoginPnl.Location = new Point(181, 99);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(397, 310);
            LoginPnl.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_01_23_at_12_16_00_PM;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(759, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(759, 508);
            Controls.Add(LoginPnl);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            WindowState = FormWindowState.Maximized;
            Load += Loginpage_Load;
            KeyDown += LoginPage_KeyDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            LoginPnl.ResumeLayout(false);
            LoginPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private RadioButton EmployeeRadioBtn;
        private RadioButton AdminRadioBtn;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private TextBox UserNameTxtBox;
        private Panel LoginPnl;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}