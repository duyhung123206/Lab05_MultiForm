using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hàm chống mở trùng lặp form con MDI
        private void OpenChildForm(Form child)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == child.GetType())
                {
                    f.Activate();
                    child.Dispose();
                    return;
                }
            }
            child.MdiParent = this;
            child.Show();
        }

        // 1. Sự kiện mở form Chi tiết Sinh viên
        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietSinhVien(null));
        }

        // 2. Hàm xử lý logic mở form Tìm kiếm
        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            formTimKiem frm = new formTimKiem();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string tuKhoa = frm.TuKhoa;
                MessageBox.Show($"Đã nhận từ khóa tìm kiếm: {tuKhoa}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Liên kết menu Tìm kiếm trên giao diện thiết kế
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuTimKiem_Click(sender, e);
        }

        // 3. Hàm xử lý logic mở form Chọn khoa
        private void mnuChonKhoa_Click(object sender, EventArgs e)
        {
            formChonKhoa frm = new formChonKhoa();

            List<string> danhSach = new List<string>()
            {
                "Công nghệ thông tin",
                "Quản trị kinh doanh",
                "Kế toán - Kiểm toán",
                "Điện - Điện tử"
            };

            frm.LoadDanhSachKhoa(danhSach);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string khoaChon = frm.KhoaDaChon;
                MessageBox.Show($"Bạn đã chọn khoa: {khoaChon}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Liên kết menu Chọn khoa trên giao diện thiết kế
        private void chọnKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuChonKhoa_Click(sender, e);
        }
    }
}