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
    public partial class chitietphongphieu : Form
    {
        public chitietphongphieu()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        public void ketnoiSQL()
        {
            
            conn = new SqlConnection(@"Data Source=LAPTOP-PDPQDVPT\SQLEXPRESS;Initial Catalog=QLkhachsan;Integrated Security=True");
            conn.Open();
        }

        private void chitietphongphieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Close();
        }

        private void chitietphongphieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            ketnoiSQL();

            SqlCommand cmd2 = new SqlCommand("insert into QLKH values (N'" + tb_tenkhach.Text + "','" + tb_quoctich.Text + "','"+date_ngayvao.Text+"','"+date_ngaydi.Text+"')", conn);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into QLHD values (N'" + tb_tenkhach.Text + "','"+comb_sophong.Text+"','" + tb_sokhach.Text + "','" + tb_sodem.Text + "','" + tb_giaphong.Text + "')", conn);
            cmd3.ExecuteNonQuery();

            truyenthongtin.tenkhach = tb_tenkhach.Text;
            truyenthongtin.sokhach = tb_sokhach.Text;
            truyenthongtin.quoctich = tb_quoctich.Text;
            truyenthongtin.ngayden = date_ngayvao.Text;
            truyenthongtin.ngaydi = date_ngaydi.Text;
            trangchu tc1 = new trangchu();
            this.Hide();
            tc1.Show();
        }
        public class truyenthongtin
        {
            static public string tenkhach;
            static public string sokhach;
            static public string quoctich;
            static public string ngayden;
            static public string ngaydi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string tenphong = comb_sophong.SelectedItem.ToString();
            switch (tenphong)
            {
                case "Phòng số 1":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc1 = new trangchu();
                    this.Hide();
                    tc1.Show();
                    break;
                case "Phòng số 2":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc2 = new trangchu();
                    this.Hide();
                    tc2.Show();
                    break;
                case "Phòng số 3":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc3 = new trangchu();
                    this.Hide();
                    tc3.Show();
                    break;
                case "Phòng số 4":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc4 = new trangchu();
                    this.Hide();
                    tc4.Show();
                    break;
                case "Phòng số 5":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc5 = new trangchu();
                    this.Hide();
                    tc5.Show();
                    break;
                case "Phòng số 6":
                    truyenthongtin.tenkhach = tb_tenkhach.Text;
                    truyenthongtin.sokhach = tb_sokhach.Text;
                    truyenthongtin.quoctich = tb_quoctich.Text;
                    truyenthongtin.ngayden = date_ngayvao.Text;
                    truyenthongtin.ngaydi = date_ngaydi.Text;
                    trangchu tc6 = new trangchu();
                    this.Hide();
                    tc6.Show();
                    break;*/
               
            }
        private void tb_sodem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime ngay1 = Convert.ToDateTime(date_ngayvao.Text);
                DateTime ngay2 = Convert.ToDateTime(date_ngaydi.Text);
                TimeSpan Time = ngay2 - ngay1;
                //int TongSoNgay = Time.Days;
                tb_sodem.Text = Time.Days.ToString();
            }
            catch
            {
                tb_sodem.Text = "0";
            }
        }

        private void tb_giaphong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_thanhtien.Text = (int.Parse(tb_giaphong.Text) * int.Parse(tb_sodem.Text)).ToString();
            }
            catch
            {
                tb_thanhtien.Text = "0";
            }
        }

        
    }
}
