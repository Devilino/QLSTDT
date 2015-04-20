using QuanLySieuThiDienThoai.GUI;
using QuanLySieuThiDienThoai.Rerport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLySieuThiDienThoai
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string TenDangNhap;
        public static string Quyen;
        private void frmMain_Load(object sender, EventArgs e)
        {
            Quyen = "admin";
            DangNhap();

        }
        private void barButtonItem_nguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            NguoiDung uc = new NguoiDung();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_nhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            NhanVien uc = new NhanVien();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_khachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            KhachHang uc = new KhachHang();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_mathang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            MatHang uc = new MatHang();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_nhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            NhapHang uc = new NhapHang();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            XuatHang uc = new XuatHang();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_baohanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            BaoHanh uc = new BaoHanh();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);
        }

        private void barButtonItem_hangton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_phieunhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem_phieuxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem_inphieubh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_doanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_banhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_indsnv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #region "Thiết lập quyền"
        void Guest()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = false;
            ribbonPageGroup_lapphieu.Enabled = false;
            ribbonPageGroup_thongke.Enabled = false;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_nguoidung.Enabled = false;
            barButtonItem_saoluu.Enabled = false;
            barButtonItem_hoiphuc.Enabled = false;
        }
        void admin()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_lapphieu.Enabled = true;
            ribbonPageGroup_thongke.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = true;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_nguoidung.Enabled = true;
            barButtonItem_saoluu.Enabled = true;
            barButtonItem_hoiphuc.Enabled = true;

            barButtonItem_baohanh.Enabled = true;
            barButtonItem_phieunhap.Enabled = true;
            barButtonItem_phieuxuat.Enabled = true;
            barButtonItem_inphieubh.Enabled = true;
        }
        void NVBanHang()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = false;
            ribbonPageGroup_lapphieu.Enabled = true;
            ribbonPageGroup_thongke.Enabled = false;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_nguoidung.Enabled = false;
            barButtonItem_saoluu.Enabled = false;
            barButtonItem_hoiphuc.Enabled = false;
        }
        void NVKeToan()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = false;
            ribbonPageGroup_lapphieu.Enabled = false;
            ribbonPageGroup_thongke.Enabled = true;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_nguoidung.Enabled = false;
            barButtonItem_saoluu.Enabled = false;
            barButtonItem_hoiphuc.Enabled = false;
        }
        void NVKho()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = false;
            ribbonPageGroup_lapphieu.Enabled = true;
            ribbonPageGroup_thongke.Enabled = false;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_baohanh.Enabled = false;
            barButtonItem_phieunhap.Enabled = false;
            barButtonItem_phieuxuat.Enabled = false;
            barButtonItem_inphieubh.Enabled = false;

            barButtonItem_nguoidung.Enabled = false;
            barButtonItem_saoluu.Enabled = false;
            barButtonItem_hoiphuc.Enabled = false;
        }
        void QuanLy()
        {
            ribbonPageGroup_hethong.Enabled = true;
            ribbonPageGroup_lapphieu.Enabled = true;
            ribbonPageGroup_thongke.Enabled = true;
            ribbonPageGroup_trangquanly.Enabled = true;
            ribbonPageGroup_trogiup.Enabled = true;

            barButtonItem_nguoidung.Enabled = false;
            barButtonItem_saoluu.Enabled = false;
            barButtonItem_hoiphuc.Enabled = false;
        }
        #endregion

        private void barButtonItem_dangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangNhap();
        }
        void DangNhap()
        {
            //Connect.DangNhap frm = new Connect.DangNhap();
            //frm.ShowDialog();
            if (Quyen == "Guest") Guest();
            if (Quyen == "admin") admin();
            if (Quyen == "NVBanHang") NVBanHang();
            if (Quyen == "NVKeToan") NVKeToan();
            if (Quyen == "NVKho") NVKho();
            if (Quyen == "QuanLy") QuanLy();
            lbl_hello.Text = "Xin chào " + TenDangNhap;
        }

        private void barButtonItem_saoluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_hoiphuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_thongtin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            Info uc = new Info();
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl.Controls.Add(uc);

        }

    }
}
