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
            LoginButton = new Button();
            panel1 = new Panel();
            EmployeeRadioButton = new RadioButton();
            AdminRadioButton = new RadioButton();
            PasswordTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DodgerBlue;
            LoginButton.Location = new Point(58, 198);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(153, 45);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(EmployeeRadioButton);
            panel1.Controls.Add(AdminRadioButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(UserNameTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 481);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // EmployeeRadioButton
            // 
            EmployeeRadioButton.AutoSize = true;
            EmployeeRadioButton.Location = new Point(150, 147);
            EmployeeRadioButton.Name = "EmployeeRadioButton";
            EmployeeRadioButton.Size = new Size(77, 19);
            EmployeeRadioButton.TabIndex = 3;
            EmployeeRadioButton.TabStop = true;
            EmployeeRadioButton.Text = "Employee";
            EmployeeRadioButton.UseVisualStyleBackColor = true;
            EmployeeRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // AdminRadioButton
            // 
            AdminRadioButton.AutoSize = true;
            AdminRadioButton.Location = new Point(47, 147);
            AdminRadioButton.Name = "AdminRadioButton";
            AdminRadioButton.Size = new Size(61, 19);
            AdminRadioButton.TabIndex = 3;
            AdminRadioButton.TabStop = true;
            AdminRadioButton.Text = "Admin";
            AdminRadioButton.UseVisualStyleBackColor = true;
            AdminRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(35, 94);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Size = new Size(211, 34);
            PasswordTextBox.TabIndex = 3;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(35, 35);
            UserNameTextBox.Multiline = true;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.PlaceholderText = "User Name";
            UserNameTextBox.Size = new Size(211, 34);
            UserNameTextBox.TabIndex = 3;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(648, 481);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += Loginpage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button LoginButton;
        private Panel panel1;
        private TextBox PasswordTextBox;
        private TextBox UserNameTextBox;
        private RadioButton AdminRadioButton;
        private RadioButton EmployeeRadioButton;
    }
}