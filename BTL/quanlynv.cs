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
    public partial class quanlynv : Form
    {
        public quanlynv()
        {
            InitializeComponent();
        }

        private void bt_ttnv_Click(object sender, EventArgs e)
        {
            catnhatthongtinnv fcatnhatnv = new catnhatthongtinnv();
            fcatnhatnv.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-PDPQDVPT\SQLEXPRESS;Initial Catalog=QLkhachsan;Integrated Security=True");
        public void hienthi()
        {
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select LichTruc.ID, QLNV.TenNhanVien, LichTruc.CaTruc, LichTruc.NgayTruc, LichTruc.Note from LichTruc inner join QLNV on LichTruc.IDNhanVien=QLNV.IDNhanVien", conn);
            
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv_quanlynv.DataSource = ds.Tables[0];
        }
        private void quanlynv_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu();
            tc.Show();
            this.Hide();
        }
    }
}
