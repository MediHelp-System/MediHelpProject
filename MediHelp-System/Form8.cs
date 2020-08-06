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
using System.IO;

namespace MediHelp_System
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            COM com = new COM();
            com.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBT = null;
            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBT = br.ReadBytes((int)fstream.Length);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='F:\C# Programming\MediHelp-System\MediHelpProject\MediHelp-System\MediHelpDatabase.mdf';Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into OrderDetails(CustomerID,CustomerAge,CustomerAddress,CustomerContactNo,IMG) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Input Order Details Successful");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                //textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Error!");
            }


            File.Copy(textBox5.Text, Path.Combine(@"F:\C# Programming\MediHelp-System\MediHelpProject\MediHelp-System\Images\", Path.GetFileName(textBox5.Text)), true);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
