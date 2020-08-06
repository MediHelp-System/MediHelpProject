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
using System.Runtime.InteropServices;

namespace MediHelp_System
{
    public partial class pha_reg : Form
    {
        public pha_reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUP_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3Ad = new Form3();
            form3Ad.Show();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            name_textBox.Text = "";
            address_textBox.Text = "";
            contact_textBox.Text = "";
            //PhamaID_textBox.Text = "";
            textBox4.Text = "";
        }

        private void SignUP_button_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\C# Programming\MediHelp-System\MediHelpProject\MediHelp-System\MediHelpDatabase.mdf';Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into PharmacyRegistration(PharmacyName,PharmacyAddress,ContactNo,RegistrationNo) values ('" + name_textBox.Text + "','" + address_textBox.Text + "','" + contact_textBox.Text + "','" + textBox4.Text + "')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {
                MessageBox.Show("Registration Successful");
                name_textBox.Text = "";
                address_textBox.Text = "";
                contact_textBox.Text = "";
                //PhamaID_textBox.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Registration Error!");
            }
        }

        private void pha_reg_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
