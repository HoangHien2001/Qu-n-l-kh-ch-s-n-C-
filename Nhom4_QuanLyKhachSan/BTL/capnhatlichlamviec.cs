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

    public partial class capnhatlichlamviec : Form
    {
        public capnhatlichlamviec()
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

        private void capnhatlichlamviec_Load(object sender, EventArgs e)
        {
            ketnoiSQL();
        }
        public void hienthi()
        {
            string sqlSELECT = "select QLNV.TenNhanVien, LichTruc.CaTruc, LichTruc.NgayTruc, LichTruc.Note from LichTruc inner join QLNV on LichTruc.IDNhanVien = QLNV.IDNhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_tennv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_catruc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_note.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            ketnoiSQL();
            /* string sqlINSERT = "insert into QLNV values (@tennv, @date_ngaysinh, @diachi)";
             SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
             cmd.Parameters.AddWithValue("TenNhanVien", tb_tennv.Text);
             cmd.Parameters.AddWithValue("NgaySinh", date_ngaysinh.Text);
             cmd.Parameters.AddWithValue("DiaChi", tb_diachi.Text);
             cmd.ExecuteNonQuery();
             hienthi();*/

            SqlCommand cmd = new SqlCommand("insert into LichTruc values (N'" + tb_tennv.Text + "','" + tb_catruc.Text + "','" + dateTimePicker1.Value.Date + "',N'" + tb_note.Text + "')", conn);
            cmd.ExecuteNonQuery();
            hienthi();

            /*SqlDataAdapter sda = new SqlDataAdapter("select*from QLNV", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];*/
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string sqlUPDATE = "Update LichTruc SET CaTruc=N'" + tb_catruc.Text + "', NgayTruc='" + dateTimePicker1.Value.Date + "',Note=N'"+tb_note.Text+"'";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            /* string sqlUPDATE = "Update QLNV set TenNhanVien=@tennv,NgaySinh=@ngaysinh,DiaChi=@diachi Where IDNhanvien = @idnv";
             SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
             cmd.Parameters.AddWithValue("IDNhanVien", tb_idnv.Text);
             cmd.Parameters.AddWithValue("TenNhanVien", tb_tennv.Text);
             cmd.Parameters.AddWithValue("NgaySinh", date_ngaysinh.Text);
             cmd.Parameters.AddWithValue("DiaChi", tb_diachi.Text);*/
            cmd.ExecuteNonQuery();

            hienthi();
        }


        private void button_quaylai_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu();
            tc.Show();
            this.Hide();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From LichTruc Where CaTruc = '" + tb_catruc.Text + "'", conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void button_xemlai_Click(object sender, EventArgs e)
        {
            ketnoiSQL(); // cần sửa
            string xem = "select QLNV.TenNhanVien, LichTruc.CaTruc, LichTruc.NgayTruc, LichTruc.Note from LichTruc inner join QLNV on LichTruc.IDNhanVien = QLNV.IDNhanVien where (NgayTruc = '"+dateTimePicker1.Text+"')";
            SqlCommand cmd = new SqlCommand(xem, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
