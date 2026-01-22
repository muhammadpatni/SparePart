using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparePart
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {
            LoginPnl.Location = new Point((this.Size.Width - LoginPnl.Width) / 2, (this.Size.Height - LoginPnl.Height) / 2);
            UserNameTxtBox.Focus();
        }


        private void Performlogin()
        {
           if(isValid())
            { 
                string userType = AdminRadioBtn.Checked ? "admin" : "employee";
                string query = $"SELECT * FROM Users WHERE UserName = '{UserNameTxtBox.Text.Trim()}' AND Password = '{PasswordTxtBox.Text.Trim()}' AND Designation = '{userType}'";
               
                DataTable dt = DatabaseManagement.retrieve(query);
                if (dt != null && dt.Rows.Count > 0)
                {

                    if (userType == "admin")
                    {
                        Adminpage adminPage = new Adminpage();
                        adminPage.Show();
                    }
                    else
                    {
                        Employeepage employeePage = new Employeepage();
                        employeePage.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isValid()
        {
            if (UserNameTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTxtBox.Focus();
                return false;
            }
             if (PasswordTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBox.Focus();
                return false;
            }
            if (!AdminRadioBtn.Checked && !EmployeeRadioBtn.Checked)
            {
                MessageBox.Show("Please select user type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Performlogin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Down && !PasswordTxtBox.Focused)
            {
                PasswordTxtBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F1 && !AdminRadioBtn.Checked)
            {
                AdminRadioBtn.Checked = true;
            }
            else if (e.KeyCode == Keys.F2 && !EmployeeRadioBtn.Checked)
            {
                EmployeeRadioBtn.Checked = true;
            }
            else if (e.KeyCode == Keys.Up && !UserNameTxtBox.Focused)
            {
                UserNameTxtBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Performlogin();
        }
    }
}
