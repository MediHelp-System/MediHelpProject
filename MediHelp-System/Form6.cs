using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHelp_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyDetails pd = new PharmacyDetails();
            pd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 com = new Form7();
            com.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersDetails cd = new CustomersDetails();
            cd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails od = new OrderDetails();
            od.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendOrderDetails sod = new SendOrderDetails();
            sod.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
