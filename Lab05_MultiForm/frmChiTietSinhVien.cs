using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class frmChiTietSinhVien : Form
    {
        private readonly SinhVien _sinhVien;

        // Constructor nhận vào đối tượng SinhVien[cite: 17]
        public frmChiTietSinhVien(SinhVien sinhVien)
        {
            InitializeComponent();
            _sinhVien = sinhVien;
        }

        // Sự kiện Load form để hiển thị dữ liệu lên các Label tương ứng[cite: 17]
        private void frmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            lblMa.Text = _sinhVien.MaSV;
            lblHoTen.Text = _sinhVien.HoTen;
            lblDiem.Text = _sinhVien.DiemTB.ToString("N2");
        }
    }
}