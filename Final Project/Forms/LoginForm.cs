using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.BussinessLogic.Interfaces;

namespace Final_Project.Forms
{
    public partial class LoginForm : Form
    {
        private IAuthService _authService;
        private Admin admin;
        public LoginForm(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            if (_authService.ValidateUser(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
