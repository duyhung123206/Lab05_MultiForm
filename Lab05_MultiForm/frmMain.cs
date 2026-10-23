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

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietSinhVien(null));
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            formTimKiem frm = new formTimKiem();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string tuKhoa = frm.TuKhoa;
                MessageBox.Show($"Đã nhận từ khóa tìm kiếm: {tuKhoa}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuTimKiem_Click(sender, e);
        }

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

        private void chọnKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuChonKhoa_Click(sender, e);
        }

        // Đồng hồ chạy thời gian thực trên StatusStrip (chỉ có duy nhất 1 hàm này)
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Xác nhận đóng ứng dụng an toàn
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy đóng ứng dụng nếu chọn No
            }
        }
    }
}