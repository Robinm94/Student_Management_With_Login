using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserDB.SaveUsers(new List<User>
            {
                new User { Username = "ADMIN", Password = "Password" }
            });
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (UserDB.GetUsers().Where(u => u.Username == txtUserId.Text && u.Password == txtPassword.Text).Any())
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Form1().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
