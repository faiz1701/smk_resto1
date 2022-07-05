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
    public partial class Manage_menu : Form
    {
        private object image1;

        public Manage_menu()
        {
            InitializeComponent();
            GetData();
            
        }

        private void GetData()
        {
            string query_menu = "Select * from MsMenu1";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(query_menu, Env.con);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dataReader);
            Env.con.Close();
            dg_menu.DataSource = data;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Manage_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_menu_Click(object sender, EventArgs e)
        {
            string ins_menu = "INSERT INTO MsMenu1 Values ( @name, @price, @photo, @carbo, @protein)";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(ins_menu, Env.con);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@name", tx_name_menu.Text);
            sqlCommand.Parameters.AddWithValue("@price", tx_price_menu.Text);
            sqlCommand.Parameters.AddWithValue("@photo", tx_photo_menu.Text);
            sqlCommand.Parameters.AddWithValue("@carbo", tx_carbon_menu.Text);
            sqlCommand.Parameters.AddWithValue("@protein", tx_protein_menu.Text);
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();
        }

        private void RefreshForm()
        {
            GetData();
            tx_menuId.Text = "";
            tx_name_menu.Text = "";
            tx_price_menu.Text = "";
            tx_photo_menu.Text = "";
            tx_carbon_menu.Text = "";
            tx_protein_menu.Text = "";
        }

        private void btn_delete_menu_Click(object sender, EventArgs e)
        {
            string del_member = "DELETE MsMenu1 where id ='" + tx_menuId.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(del_member, Env.con);
            Env.con.Open();
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();
        }

        private void dg_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_menuId.Text = dg_menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_name_menu.Text = dg_menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            tx_price_menu.Text = dg_menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            tx_photo_menu.Text = dg_menu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tx_carbon_menu.Text = dg_menu.Rows[e.RowIndex].Cells[4].Value.ToString();
            tx_protein_menu.Text = dg_menu.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_edit_menu_Click(object sender, EventArgs e)
        {
            string upt_menu = "UPDATE MsMenu1 set name = @name, price = @price, photo = @photo, carbo = @carbo, protein = @protein where id='"+ tx_menuId.Text + "'";
            Env.con.Open();
            SqlCommand sqlCommand = new SqlCommand(upt_menu, Env.con);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@name", tx_name_menu.Text);
            sqlCommand.Parameters.AddWithValue("@price", tx_price_menu.Text);
            sqlCommand.Parameters.AddWithValue("@photo", tx_photo_menu.Text);
            sqlCommand.Parameters.AddWithValue("@carbo", tx_carbon_menu.Text);
            sqlCommand.Parameters.AddWithValue("@protein", tx_protein_menu.Text);
            sqlCommand.ExecuteNonQuery();
            Env.con.Close();
            RefreshForm();
        }

        private void src_menu_Click(object sender, EventArgs e)
        {
        }

        private void dg_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            
        }
    }
}

