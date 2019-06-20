using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMArchiveApp
{
    public partial class LoginForm : Form
    {
        private string login;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
            login = "admin";
            password = "123";

            passwordTextBox.Text = "";
            passwordTextBox.PasswordChar = '*';

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (loginTextBox.Text == login && passwordTextBox.Text == password)
            {
                new InfoForm().Show();
                Hide();
                return;
            }
            MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
