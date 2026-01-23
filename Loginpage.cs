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
       /// <summary>
       /// Initializes a new instance of the LoginPage class.
       /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the login page form by centering the login panel and setting focus to the username
        /// text box.
        /// </summary>
        /// <param name="sender">The source of the event, typically the login page form.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void Loginpage_Load(object sender, EventArgs e)
        {
            LoginPnl.Location = new Point((this.Size.Width - LoginPnl.Width) / 2, (this.Size.Height - LoginPnl.Height) / 2);
            UserNameTxtBox.Focus();
        }


        /// <summary>
        /// Attempts to authenticate the user based on the entered credentials and navigates to the appropriate page
        /// upon successful login.
        /// </summary>
        /// <remarks>Displays an error message if the username, password, or user type is invalid.
        /// Navigates to the admin or employee page depending on the selected user type. This method is typically called
        /// in response to a login action, such as clicking a login button.</remarks>
        private void Performlogin()
        {
            if (isValid())
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

        /// <summary>
        /// Validates the user input fields for username, password, and user type selection in the login form.
        /// </summary>
        /// <remarks>If validation fails, an error message is displayed to the user and the relevant input
        /// field is focused for correction. This method is intended for use within the login form to ensure that all
        /// necessary information is provided before proceeding.</remarks>
        /// <returns>true if all required fields are filled and a user type is selected; otherwise, false.</returns>
        private bool isValid()
        {
            if (UserNameTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTxtBox.Focus();
                PasswordTxtBox.Text = PasswordTxtBox.Text.Trim();
                UserNameTxtBox.Clear();
                return false;
            }
            if (PasswordTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBox.Focus();
                UserNameTxtBox.Text = UserNameTxtBox.Text.Trim();
                PasswordTxtBox.Clear();
                return false;
            }
            if (!AdminRadioBtn.Checked && !EmployeeRadioBtn.Checked)
            {
                MessageBox.Show("Please select user type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTxtBox.Text = UserNameTxtBox.Text.Trim();
                PasswordTxtBox.Text = PasswordTxtBox.Text.Trim();
                UserNameTxtBox.Text=UserNameTxtBox.Text.Trim();
                PasswordTxtBox.Text = PasswordTxtBox.Text.Trim();

                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Handles key press events on the login page to provide keyboard shortcuts for common actions such as
        /// submitting the form, exiting the application, switching user roles, and navigating between input fields.
        /// </summary>
        /// <remarks>This handler enables keyboard navigation and shortcuts for the login page. Pressing
        /// Enter attempts to log in, Escape exits the application, F1 and F2 toggle between user roles, and the Up and
        /// Down arrow keys move focus between the username and password fields.</remarks>
        /// <param name="sender">The source of the event, typically the login page or one of its controls.</param>
        /// <param name="e">A KeyEventArgs that contains the event data, including information about the key pressed.</param>
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
