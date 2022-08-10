using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlynv fqlnv = new quanlynv();
            fqlnv.Show();
            this.Hide();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlykhachhang fqlkh = new quanlykhachhang();
            fqlkh.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LienHe flh = new LienHe();
            flh.Show();
            this.Hide();
        }

        private void bt_chitiet1_Click(object sender, EventArgs e)
        {
            chitietphieuphong chitiethoadon = new chitietphieuphong();
            chitiethoadon.Show();
           
        }

        private void bt_checkout1_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach1.Text = "..............................";
            lbl_ndsokhach1.Text = "..............................";
            lbl_ndquoctich1.Text = "..............................";
            lbl_ndngayden1.Text = "..............................";
            lbl_ndngaydi1.Text = "..............................";
            panel_loaphong1.BackColor = Color.Gray;
        }

        private void bt_checkout2_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach2.Text = "..............................";
            lbl_ndsokhach2.Text = "..............................";
            lbl_ndquoctich2.Text = "..............................";
            lbl_ndngayden2.Text = "..............................";
            lbl_ndngaydi2.Text = "..............................";
            panel_loaphong2.BackColor = Color.Gray;
        }

        private void bt_checkout3_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach3.Text = "..............................";
            lbl_ndsokhach3.Text = "..............................";
            lbl_ndquoctich3.Text = "..............................";
            lbl_ndngayden3.Text = "..............................";
            lbl_ndngaydi3.Text = "..............................";
            panel_loaphong3.BackColor = Color.Gray;
        }

        private void bt_checkout4_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach4.Text = "..............................";
            lbl_ndsokhach4.Text = "..............................";
            lbl_ndquoctich4.Text = "..............................";
            lbl_ndngayden4.Text = "..............................";
            lbl_ndngaydi4.Text = "..............................";
            panel_loaphong4.BackColor = Color.Gray;
        }

        private void bt_checkout5_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach5.Text = "..............................";
            lbl_ndsokhach5.Text = "..............................";
            lbl_ndquoctich5.Text = "..............................";
            lbl_ndngayden5.Text = "..............................";
            lbl_ndngaydi5.Text = "..............................";
            panel_loaphong5.BackColor = Color.Gray;
        }

        private void bt_checkout6_Click(object sender, EventArgs e)
        {
            lbl_ndtenkhach6.Text = "..............................";
            lbl_ndsokhach6.Text = "..............................";
            lbl_ndquoctich6.Text = "..............................";
            lbl_ndngayden6.Text = "..............................";
            lbl_ndngaydi6.Text = "..............................";
            panel_loaphong6.BackColor = Color.Gray;
        }

        private void combb_trangthai1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong1.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong1.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong1.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong1.BackColor = Color.Gray;
                    break;
            }
        }

        private void combb_trangthai2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai2.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong2.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong2.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong2.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong2.BackColor = Color.Gray;
                    break;
            }
        }

        private void combb_trangthai3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai3.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong3.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong3.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong3.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong3.BackColor = Color.Gray;
                    break;
            }
        }

        private void combb_trangthai4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai4.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong4.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong4.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong4.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong4.BackColor = Color.Gray;
                    break;
            }
        }

        private void combb_trangthai5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai5.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong5.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong5.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong5.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong5.BackColor = Color.Gray;
                    break;
            }
        }

        private void combb_trangthai6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = combb_trangthai1.SelectedItem.ToString();
            switch (trangThai)
            {
                case "Phòng Ở":
                    panel_loaphong6.BackColor = Color.Green;
                    break;
                case "Phòng Trả":
                    panel_loaphong6.BackColor = Color.Yellow;
                    break;
                case "Phòng Trống":
                    panel_loaphong6.BackColor = Color.Salmon;
                    break;
                case "Phòng Đang Dọn":
                    panel_loaphong6.BackColor = Color.Gray;
                    break;
            }
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            lbl_ndtenkhach1.Text = chitietphieuphong.truyenthongtin.tenkhach;
            lbl_ndsokhach1.Text = chitietphieuphong.truyenthongtin.sokhach;
            lbl_ndquoctich1.Text = chitietphieuphong.truyenthongtin.quoctich;
            lbl_ndngayden1.Text = chitietphieuphong.truyenthongtin.ngayden;
            lbl_ndngaydi1.Text = chitietphieuphong.truyenthongtin.ngaydi;

        }
    
    }
}
