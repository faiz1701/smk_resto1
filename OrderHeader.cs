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
    public partial class OrderHeader : Form
    {
        public OrderHeader()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            string query_order = "SELECT MsMenu1.name, MsMenu1.price, MsMenu1.carbo, MsMenu1.protein FROM MsMenu1";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(query_order, Env.con);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dataReader);
            Env.con.Close();
            dg_orderAtas.DataSource = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderHeader_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
        }

        private void bt_order_Click(object sender, EventArgs e)
        {

        }

        private void dg_orderAtas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_MenuName.Text = dg_orderAtas.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_qtyOrder.Text = dg_orderAtas.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
