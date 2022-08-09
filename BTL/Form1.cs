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
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         private void dangnhap()
        {
            if (this.txtB_Dangnhap.Text.Length == 0 && this.txtb_matkhau.Text.Length == 0)
                MessageBox.Show("Chưa nhập Tên tài khoản và Mật khẩu");
            else
                 if (this.txtB_Dangnhap.Text.Length == 0)
                MessageBox.Show("Chưa nhập Tên tài khoản");
            else
                     if (this.txtb_matkhau.Text.Length == 0)
                MessageBox.Show("Chưa nhập mật khẩu");

            else if (this.txtB_Dangnhap.Text != "admin" && this.txtb_matkhau.Text != "admin")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            else
                return;
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu();
            if (this.txtB_Dangnhap.Text == "admin" && this.txtb_matkhau.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                tc.Show();
                this.Hide();// ẩn form2 sau khi đăng nhập thành công

            }
            dangnhap();
        }

       
        private void txtB_Dangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
