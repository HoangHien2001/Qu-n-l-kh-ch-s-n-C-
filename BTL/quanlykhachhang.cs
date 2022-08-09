using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTL
{
    public partial class quanlykhachhang : Form
    {
        public quanlykhachhang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        public void hienthi()
        {
            string sqlselect = "SELECT*From QLKH";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
           dgv_qlkhachhang.DataSource = dt;
        }
        private void quanlykhachhang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-PDPQDVPT\SQLEXPRESS;Initial Catalog=QLkhachsan;Integrated Security=True");
            conn.Open();
            hienthi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenKhachHang", "*" + textBox1.Text + "*");
           (dgv_qlkhachhang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
           trangchu tc = new trangchu();
            tc.Show();
            this.Hide();
        }

        private void quanlykhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void bt_loc_Click(object sender, EventArgs e)
        {
            string sqlLOC= "Select * From QLKH Where (Ngayden  BETWEEN '" + dateTimePicker_tungay.Text+ "' AND  '" + dateTimePicker_denngay.Text + "') " +
                "AND (Ngaydi  BETWEEN '" + dateTimePicker_tungay.Text + "' AND  '" + dateTimePicker_denngay.Text + "')";

            SqlCommand cmd = new SqlCommand(sqlLOC, conn);
            cmd.ExecuteNonQuery();
            
        }
    }
}
