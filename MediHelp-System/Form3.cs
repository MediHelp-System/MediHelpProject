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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pha_reg pha = new pha_reg();
            pha.Show();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formlog = new Login();
            formlog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            COM com = new COM();
            com.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersDetails cd = new CustomersDetails();
            cd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployesDetails ed = new EmployesDetails();
            ed.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyDetails pd = new PharmacyDetails();
            pd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendOrderDetails sod = new SendOrderDetails();
            sod.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
