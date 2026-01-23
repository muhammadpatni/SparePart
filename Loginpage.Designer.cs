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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            EmployeeRadioBtn = new RadioButton();
            AdminRadioBtn = new RadioButton();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            UserNameTxtBox = new TextBox();
            LoginPnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_01_23_at_12_16_00_PM;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 508);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(716, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 3);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(716, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 3);
            panel1.TabIndex = 4;
            // 
            // EmployeeRadioBtn
            // 
            EmployeeRadioBtn.AutoSize = true;
            EmployeeRadioBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EmployeeRadioBtn.Location = new Point(833, 222);
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
            AdminRadioBtn.Location = new Point(727, 222);
            AdminRadioBtn.Name = "AdminRadioBtn";
            AdminRadioBtn.Size = new Size(61, 19);
            AdminRadioBtn.TabIndex = 3;
            AdminRadioBtn.TabStop = true;
            AdminRadioBtn.Text = "Admin";
            AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = SystemColors.ActiveCaptionText;
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.ForeColor = Color.Black;
            PasswordTxtBox.Location = new Point(716, 158);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(211, 34);
            PasswordTxtBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(716, 262);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(211, 40);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = SystemColors.ActiveCaptionText;
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.ForeColor = Color.Black;
            UserNameTxtBox.Location = new Point(716, 99);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(211, 34);
            UserNameTxtBox.TabIndex = 3;
            // 
            // LoginPnl
            // 
            LoginPnl.BackColor = SystemColors.ActiveCaption;
            LoginPnl.BorderStyle = BorderStyle.FixedSingle;
            LoginPnl.Location = new Point(181, 99);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(397, 310);
            LoginPnl.TabIndex = 3;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 508);
            Controls.Add(panel2);
            Controls.Add(LoginPnl);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(EmployeeRadioBtn);
            Controls.Add(UserNameTxtBox);
            Controls.Add(AdminRadioBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            WindowState = FormWindowState.Maximized;
            Load += Loginpage_Load;
            KeyDown += LoginPage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private RadioButton EmployeeRadioBtn;
        private RadioButton AdminRadioBtn;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private TextBox UserNameTxtBox;
        private Panel LoginPnl;
    }
}