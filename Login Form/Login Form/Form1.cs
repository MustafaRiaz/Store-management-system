using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if((loginName.Text=="Mustafa" ) && (loginPassword.Text == "maxie"))
            {
                notifications.Text = "Login Successful";
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
            }
            else
            {
                notifications.Text = "Login Failed";

            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                loginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                loginPassword.UseSystemPasswordChar = true;
            }
        }

        private void loginPassword_TextChanged_1(object sender, EventArgs e)
        {
            loginPassword.UseSystemPasswordChar = true;
        }
    }
}
