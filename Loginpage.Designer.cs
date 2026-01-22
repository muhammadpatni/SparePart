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
            LoginBtn = new Button();
            LoginPnl = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            EmployeeRadioBtn = new RadioButton();
            AdminRadioBtn = new RadioButton();
            PasswordTxtBox = new TextBox();
            UserNameTxtBox = new TextBox();
            LoginPnl.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DodgerBlue;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(93, 211);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(211, 40);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginPnl
            // 
            LoginPnl.BackColor = SystemColors.ActiveCaption;
            LoginPnl.BorderStyle = BorderStyle.FixedSingle;
            LoginPnl.Controls.Add(panel2);
            LoginPnl.Controls.Add(panel1);
            LoginPnl.Controls.Add(EmployeeRadioBtn);
            LoginPnl.Controls.Add(AdminRadioBtn);
            LoginPnl.Controls.Add(PasswordTxtBox);
            LoginPnl.Controls.Add(LoginBtn);
            LoginPnl.Controls.Add(UserNameTxtBox);
            LoginPnl.Location = new Point(181, 99);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(397, 310);
            LoginPnl.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(93, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 3);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(93, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 3);
            panel1.TabIndex = 4;
            // 
            // EmployeeRadioBtn
            // 
            EmployeeRadioBtn.AutoSize = true;
            EmployeeRadioBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            EmployeeRadioBtn.Location = new Point(210, 171);
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
            AdminRadioBtn.Location = new Point(104, 171);
            AdminRadioBtn.Name = "AdminRadioBtn";
            AdminRadioBtn.Size = new Size(61, 19);
            AdminRadioBtn.TabIndex = 3;
            AdminRadioBtn.TabStop = true;
            AdminRadioBtn.Text = "Admin";
            AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = SystemColors.ActiveCaption;
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.ForeColor = Color.Black;
            PasswordTxtBox.Location = new Point(93, 107);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.Size = new Size(211, 34);
            PasswordTxtBox.TabIndex = 3;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = SystemColors.ActiveCaption;
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.ForeColor = Color.Black;
            UserNameTxtBox.Location = new Point(93, 48);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(211, 34);
            UserNameTxtBox.TabIndex = 3;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(759, 508);
            Controls.Add(LoginPnl);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            WindowState = FormWindowState.Maximized;
            Load += Loginpage_Load;
            KeyDown += LoginPage_KeyDown;
            LoginPnl.ResumeLayout(false);
            LoginPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button LoginBtn;
        private Panel LoginPnl;
        private TextBox PasswordTxtBox;
        private TextBox UserNameTxtBox;
        private RadioButton AdminRadioBtn;
        private RadioButton EmployeeRadioBtn;
        private Panel panel1;
        private Panel panel2;
    }
}