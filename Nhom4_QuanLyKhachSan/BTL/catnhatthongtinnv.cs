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
    public partial class catnhatthongtinnv : Form
    {
        public catnhatthongtinnv()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        public void ketnoiSQL()
        {
            conn = new SqlConnection(@"Data Source=desktop-7nnbdsh\nthoa;Initial Catalog=QLkhachsan;Integrated Security=True");
            conn.Open();
            hienthi();
        }
        private void catnhatthongtinnv_Load(object sender, EventArgs e)
        {
            ketnoiSQL();
        }
        public void hienthi()
        {
            string sqlSELECT = "Select *from QLNV";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            ketnoiSQL();
            /* string sqlINSERT = "insert into QLNV values (@tennv, @date_ngaysinh, @diachi)";
             SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
             cmd.Parameters.AddWithValue("TenNhanVien", tb_tennv.Text);
             cmd.Parameters.AddWithValue("NgaySinh", date_ngaysinh.Text);
             cmd.Parameters.AddWithValue("DiaChi", tb_diachi.Text);
             cmd.ExecuteNonQuery();
             hienthi();*/
            SqlCommand cmd = new SqlCommand("insert into QLNV values (N'"+tb_tennv.Text+"','"+date_ngaysinh.Text+ "',N'"+tb_diachi.Text+"')", conn);
            cmd.ExecuteNonQuery();
            hienthi();
            /*SqlDataAdapter sda = new SqlDataAdapter("select*from QLNV", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idnv.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_tennv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            date_ngaysinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_diachi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {          
            SqlCommand cmd = new SqlCommand("Delete From QLNV Where IDNhanVien = '"+tb_idnv.Text+"'", conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void bt_sửa_Click(object sender, EventArgs e) // sửa toàn bộ bảng ghi sai
        {
            SqlCommand cmd = new SqlCommand("Update QLNV SET " +
                "TenNhanVien = N'" + tb_tennv.Text + "',NgaySinh='" + date_ngaysinh.Value.Date + "',DiaChi=N'" + tb_diachi.Text + "'" +
                " Where (IDNhanVien = '" + tb_idnv.Text + "')", conn);
           /* string sqlUPDATE = "Update QLNV set TenNhanVien=@tennv,NgaySinh=@ngaysinh,DiaChi=@diachi Where IDNhanvien = @idnv";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            cmd.Parameters.AddWithValue("IDNhanVien", tb_idnv.Text);
            cmd.Parameters.AddWithValue("TenNhanVien", tb_tennv.Text);
            cmd.Parameters.AddWithValue("NgaySinh", date_ngaysinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", tb_diachi.Text);*/
            cmd.ExecuteNonQuery();
          
            hienthi();
         }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            tb_idnv.Text = "";
            tb_tennv.Text = "";
            date_ngaysinh.Text = "1/1/1999";
            tb_diachi.Text = "";
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {

            //SqlCommand cmd = new SqlCommand("Select * from QLNV Where TenNhanVien like '%"+tb_timkiem.Text+"%'", conn);
            //cmd.ExecuteNonQuery();

            /*SqlDataAdapter sda = new SqlDataAdapter("Select * from QLNV Where TenNhanVien like '%" + tb_timkiem.Text + "%'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];*/

           /* string SQLtim = "Select *from QLNV ";
            SqlCommand cmd = new SqlCommand(SQLtim, conn);
            cmd.Parameters.AddWithValue("TenNhanVien", tb_timkiem.Text);
            cmd.Parameters.AddWithValue("NgaySinh", date_ngaysinh.Text);
            cmd.Parameters.AddWithValue("DiaChi", tb_diachi.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;*/
        }


        private void catnhatthongtinnv_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenNhanVien", "*" + tb_timkiem.Text + "*");
             (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        private void catnhatthongtinnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu();
            tc.Show();
            this.Hide();
        }
    }
}
