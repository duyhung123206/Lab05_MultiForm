using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmChiTietSinhVien : Form
    {
        private readonly SinhVien _sinhVien;

        // Constructor mặc định (dành cho trường hợp gọi không truyền dữ liệu từ Menu chính)
        public frmChiTietSinhVien()
        {
            InitializeComponent();
        }

        // Constructor nhận vào đối tượng SinhVien (dành cho Form1 truyền sang)[cite: 17]
        public frmChiTietSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();
            _sinhVien = sinhVien;
        }

        // Sự kiện Load form để hiển thị dữ liệu lên các Label[cite: 17]
        private void frmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            if (_sinhVien != null)
            {
                lblMa.Text = _sinhVien.MaSV;
                lblHoTen.Text = _sinhVien.HoTen;
                lblDiem.Text = _sinhVien.DiemTB.ToString("N2");
            }
        }
    }
}