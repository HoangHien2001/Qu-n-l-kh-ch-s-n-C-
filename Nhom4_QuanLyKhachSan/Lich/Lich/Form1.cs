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

namespace Lich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        public void ketnoi()
        {
            conn = new SqlConnection(@"Data Source=desktop-7nnbdsh\nthoa;Initial Catalog=QLKS;Integrated Security=True");
            conn.Open();
        }
        public void hienthi()
        {
            string select = "select * from Lich";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            hienthi();
        }


        private void button_them_Click(object sender, EventArgs e)
        {
            string them = "insert into Lich values ('" + textBox_name.Text + "','" + textBox_ca.Text + "','" + dateTimePicker1.Text + "')";
            SqlCommand cmd = new SqlCommand(them, conn);
            cmd.ExecuteNonQuery();
            hienthi();

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string sua = "Update Lich Set TenNv = N'" + textBox_name.Text + "', Calamviec = N'" + textBox_ca.Text + "', Ngaylamviec = CONVERT(DATETIME, '" + dateTimePicker1.Text + "', 102) where TenNv = N'" + textBox_name.Text + "' ";
            SqlCommand cmd = new SqlCommand(sua, conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void button_xoa_Click_1(object sender, EventArgs e)
        {
            string xoa = "delete from Lich where TenNv = N'" + textBox_name.Text + "'";
            SqlCommand cmd = new SqlCommand(xoa, conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_ca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_xemlai_Click(object sender, EventArgs e)
        {
            string xemlai = "select * from Lich where Ngaylamviec = '" + dateTimePicker1.Text + "'";
            SqlCommand cmd = new SqlCommand(xemlai, conn);
            cmd.ExecuteNonQuery();
            hienthi();
        }
    }
}