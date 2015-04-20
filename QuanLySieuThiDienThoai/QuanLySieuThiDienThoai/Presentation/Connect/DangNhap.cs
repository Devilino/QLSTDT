using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiDienThoai.Connect
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLySieuThiDienThoai.frmMain.Quyen = "Guest";
            QuanLySieuThiDienThoai.frmMain.TenDangNhap = "Quest";
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {

                QuanLySieuThiDienThoai.frmMain.TenDangNhap = txt_tendangnhap.Text;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_dangnhap.PerformClick();
        }
    }
}
