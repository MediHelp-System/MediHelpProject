﻿using System;
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
            pha_reg reg = new pha_reg();
            reg.Show();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formlog = new Login();
            formlog.Show();
        }
    }
}
