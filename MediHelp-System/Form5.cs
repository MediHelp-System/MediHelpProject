using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediHelp_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            COM com = new COM();
            com.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\C# Programming\MediHelp-System\MediHelpProject\MediHelp-System\MediHelpDatabase.mdf';Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Customers(Fname,Lname,Address,NIC,ContactNo) values ('" +textBox1.Text + "','" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Registration Successful");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Registration Error!");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
