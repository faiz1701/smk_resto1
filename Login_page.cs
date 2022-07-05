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

namespace smk_resto1
{
    public partial class Login_page : Form
    {

        public Login_page()
        {

            InitializeComponent();
        }

        public string User { get; private set; }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "" && tb_password.Text == "")
            {
                MessageBox.Show("Maaf data tidak valid");
            }
                if (tb_username.TextLength > 0 && tb_password.TextLength > 0)
            {
                string query = "SELECT * from MsEmployee where email ='" + tb_username.Text.Trim() + "'and password = '"+tb_password.Text.Trim()+"'";
                Env.con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Env.con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Env.con.Close();

                if (dataTable.Rows.Count == 1) 
                {

                    if (dataTable.Rows[0]["position"].ToString() == "admin")
                    {
                        this.Hide();
                        String User = tb_username.Text;
                        Admin_nav ad = new Admin_nav(User);
                        ad.Show();
                    }
                    if (dataTable.Rows[0]["position"].ToString() == "owner")
                    {
                        this.Hide();
                        Report rp = new Report();
                        rp.Show();
                    }
                    if (dataTable.Rows[0]["position"].ToString() == "cashier")
                    {
                        this.Hide();
                        String cashier = tb_username.Text;
                        Cashier_nav cs = new Cashier_nav(cashier);
                        cs.Show();
                    }
                }
            }
        }
    }
}
