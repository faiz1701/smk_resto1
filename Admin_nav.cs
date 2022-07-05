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
    public partial class Admin_nav : Form
    {
        public Admin_nav(String User)
        {
            InitializeComponent();
            labelUser.Text = User;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_menu mn = new Manage_menu();
            mn.Show();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_member mm = new Manage_member();
            mm.Show();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            this.Close();
            OrderHeader odr = new OrderHeader();
            odr.Show();
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_page ll = new Login_page();
            ll.Show();
        }

        private void ad_name_Click(object sender, EventArgs e)
        {
            
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void Admin_nav_Load(object sender, EventArgs e)
        {

        }
    }
}
