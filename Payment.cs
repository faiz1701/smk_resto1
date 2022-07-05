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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            string query_payment = "SELECT OrderHeader.id, OrderHeader.date OrderDetail.qty * MsMenu.price as total FROM OrderHeader, OrderDetail, MsMenu where OrderHeader.id = 202206030001  AND OrderDetail.orderId = 202206030001 AND MsMenu.id = OrderDetail.menuId";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(query_payment, Env.con);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dataReader);
            Env.con.Close();
            dg_payment.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_save_py_Click(object sender, EventArgs e)
        {
            string query_ins = " UPDATE OrderHeader SET paymentType = 'Credit Card', cardNumber = '987654321', bank = 'RAYA' WHERE id = 20221603001";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(query_ins, Env.con);
            sqlCommand.CommandType = CommandType.Text;
        }
    }
}
