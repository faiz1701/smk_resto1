using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smk_resto1
{
    public partial class Manage_member : Form
    {
        public Manage_member()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            string query_member = "SELECT * from MsMember";
            SqlCommand member = new SqlCommand(query_member, Env.con);
            Env.con.Open();
            SqlDataReader sqlDataReader = member.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            Env.con.Close();
            dg_member.DataSource = dataTable;

        }

        private void dg_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ins_member_Click(object sender, EventArgs e)
        {
            string ins_member = "INSERT INTO MsMember Values (@name, @email, @handphone, @joindate)";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(ins_member, Env.con);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@name", tx_name_member.Text);
            sqlCommand.Parameters.AddWithValue("@email", tx_email.Text);
            sqlCommand.Parameters.AddWithValue("@handphone", tx_handphone.Text);
            sqlCommand.Parameters.AddWithValue("@joindate", DateTime.Now.ToString());
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();

        }

        private void btn_del_member_Click(object sender, EventArgs e)
        {
            string del_member = "DELETE MsMember where id ='"+ memberid.Text +"'";
            SqlCommand sqlCommand = new SqlCommand(del_member, Env.con);
            Env.con.Open();
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();
        }

        private void RefreshForm()
        {
            GetData();
            memberid.Text = "";
            tx_name_member.Text = "";
            tx_email.Text = "";
            tx_handphone.Text = "";
        }

        private void dg_member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberid.Text = dg_member.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_name_member.Text = dg_member.Rows[e.RowIndex].Cells[1].Value.ToString();
            tx_email.Text = dg_member.Rows[e.RowIndex].Cells[2].Value.ToString();
            tx_handphone.Text = dg_member.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_upt_member_Click(object sender, EventArgs e)
        {
            string up_member = "UPDATE MsMember set name = @name, email = @email, handphone = @handphone where id='"+ memberid.Text +"'";
            SqlCommand sqlCommand = new SqlCommand(up_member, Env.con);
            Env.con.Open();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@name", tx_name_member.Text);
            sqlCommand.Parameters.AddWithValue("@email", tx_email.Text);
            sqlCommand.Parameters.AddWithValue("@handphone", tx_handphone.Text);
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();
            
        }

        private void src_member_Click(object sender, EventArgs e)
        {
            string src_member = "SELECT * from MsMember where name like '%" + tx_src_member.Text + "%' or email like '%"+ tx_src_member +"%' or handphone like '%"+ tx_src_member +"%'";
            SqlCommand sqlCommand = new SqlCommand(src_member, Env.con);
            Env.con.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dg_member.DataSource = dataTable;
            Env.con.Close();
        }

        private void Manage_member_Load(object sender, EventArgs e)
        {

        }
    }
}
