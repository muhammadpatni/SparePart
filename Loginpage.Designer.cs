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
            panel1 = new Panel();
            EmployeeRadioBtn = new RadioButton();
            AdminRadioBtn = new RadioButton();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            UserNameTxtBox = new TextBox();
            LoginPnl = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LoginPnl.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(175, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 2);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(175, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 2);
            panel1.TabIndex = 4;
            // 
            // EmployeeRadioBtn
            // 
            EmployeeRadioBtn.AutoSize = true;
            EmployeeRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeRadioBtn.ForeColor = Color.White;
            EmployeeRadioBtn.Location = new Point(314, 265);
            EmployeeRadioBtn.Name = "EmployeeRadioBtn";
            EmployeeRadioBtn.Size = new Size(100, 25);
            EmployeeRadioBtn.TabIndex = 3;
            EmployeeRadioBtn.Text = "Employee";
            EmployeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AdminRadioBtn
            // 
            AdminRadioBtn.AutoSize = true;
            AdminRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminRadioBtn.ForeColor = Color.White;
            AdminRadioBtn.Location = new Point(208, 265);
            AdminRadioBtn.Name = "AdminRadioBtn";
            AdminRadioBtn.Size = new Size(76, 25);
            AdminRadioBtn.TabIndex = 3;
            AdminRadioBtn.Text = "Admin";
            AdminRadioBtn.UseVisualStyleBackColor = true;
            AdminRadioBtn.CheckedChanged += AdminRadioBtn_CheckedChanged;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = Color.FromArgb(22, 31, 50);
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Font = new Font("Segoe UI", 9F);
            PasswordTxtBox.ForeColor = Color.White;
            PasswordTxtBox.Location = new Point(175, 213);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(276, 34);
            PasswordTxtBox.TabIndex = 3;
            PasswordTxtBox.TabStop = false;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            PasswordTxtBox.KeyDown += PasswordTxtBox_KeyDown;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.FromArgb(22, 31, 50);
            LoginBtn.Location = new Point(175, 317);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(276, 34);
            LoginBtn.TabIndex = 1;
            LoginBtn.TabStop = false;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(22, 31, 50);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 9F);
            UserNameTxtBox.ForeColor = Color.White;
            UserNameTxtBox.Location = new Point(175, 136);
            UserNameTxtBox.Multiline = true;
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(276, 34);
            UserNameTxtBox.TabIndex = 3;
            UserNameTxtBox.TabStop = false;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged;
            UserNameTxtBox.KeyDown += UserNameTxtBox_KeyDown;
            // 
            // LoginPnl
            // 
            LoginPnl.BackColor = Color.FromArgb(22, 31, 50);
            LoginPnl.BorderStyle = BorderStyle.FixedSingle;
            LoginPnl.Controls.Add(label3);
            LoginPnl.Controls.Add(label2);
            LoginPnl.Controls.Add(label1);
            LoginPnl.Controls.Add(panel2);
            LoginPnl.Controls.Add(PasswordTxtBox);
            LoginPnl.Controls.Add(panel1);
            LoginPnl.Controls.Add(LoginBtn);
            LoginPnl.Controls.Add(EmployeeRadioBtn);
            LoginPnl.Controls.Add(AdminRadioBtn);
            LoginPnl.Controls.Add(UserNameTxtBox);
            LoginPnl.Location = new Point(75, 25);
            LoginPnl.Name = "LoginPnl";
            LoginPnl.Size = new Size(630, 407);
            LoginPnl.TabIndex = 3;
            LoginPnl.Paint += LoginPnl_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(243, 14);
            label3.Name = "label3";
            label3.Size = new Size(121, 45);
            label3.TabIndex = 8;
            label3.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(175, 108);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 185);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Password";
            label1.Click += label1_Click;
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
        private Panel panel2;
        private Panel panel1;
        private RadioButton EmployeeRadioBtn;
        private RadioButton AdminRadioBtn;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private TextBox UserNameTxtBox;
        private Panel LoginPnl;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}