using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            adminRB.Select();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTF.Text == "admin" && passwordTF.Text == "admin123" && adminRB.Checked)
            {
                GlobalData.isAdmin = true;
                this.Hide();
                new HomePage().Show();
            }
            else if (usernameTF.Text == "staff" && passwordTF.Text == "staff123" && staffRB.Checked)
            {
                GlobalData.isAdmin = false;
                this.Hide();
                new HomePage().Show();
            }
            else {
                MessageBox.Show("Please login with the valid credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
