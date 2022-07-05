using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smk_resto1
{
    public partial class Cashier_nav : Form
    {
        public Cashier_nav(String cashier)
        {
            InitializeComponent();
            labelCashier.Text = cashier;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_nav_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_page log = new Login_page();
            log.Show();
        }
    }
}
