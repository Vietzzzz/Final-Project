using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            home_usercontrol.Show();
            product_usercontrol.Hide();
            transaction_usercontrol.Hide();
            export_usercontrol.Hide();
        }
        private void product_button_Click(object sender, EventArgs e)
        {
            home_usercontrol.Hide();
            product_usercontrol.Show();
            transaction_usercontrol.Hide();
            export_usercontrol.Hide();
        }
        private void transaction_button_Click(object sender, EventArgs e)
        {
            home_usercontrol.Hide();
            product_usercontrol.Hide();
            transaction_usercontrol.Show();
            export_usercontrol.Hide();
        }
        private void export_button_click(object sender, EventArgs e)
        {
            home_usercontrol.Hide();
            product_usercontrol.Hide();
            transaction_usercontrol.Hide();
            export_usercontrol.Show();
        }
    }
}
