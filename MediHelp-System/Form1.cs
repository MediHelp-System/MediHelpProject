using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHelp_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "Admin" && txtPassword.Text == "admin12345")
                {
                    //MessageBox.Show("Admin Interface");
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else if(txtUsername.Text == "COM" && txtPassword.Text == "com12345")
                {
                    //MessageBox.Show("COM Interface");
                    this.Hide();
                    COM com = new COM();
                    com.Show();
                }
                else if(txtUsername.Text == "OM" && txtPassword.Text == "om12345")
                {
                    //MessageBox.Show("OM Interface");
                    this.Hide();
                    Form6 form6 = new Form6();
                    form6.Show();
                }
                else
                {
                    MessageBox.Show("Login Error!");
                }
            }
            catch
            {
                MessageBox.Show("Syntex Error!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
