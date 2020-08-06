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
    public partial class COM : Form
    {
        public COM()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
            
        }

        private void btnCustomerReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersDetails cd = new CustomersDetails();
            cd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails od = new OrderDetails();
            od.Show();
        }

        private void COM_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
