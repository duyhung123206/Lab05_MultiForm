using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện TextChanged theo thời gian thực
            this.txtMaSV.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.txtHoTen.TextChanged += new System.EventHandler(this.Input_TextChanged);
            this.txtDiemTB.TextChanged += new System.EventHandler(this.Input_TextChanged);
        }

        // Phương thức kiểm tra dữ liệu đầu vào sử dụng ErrorProvider
        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Nhập mã sinh viên");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Nhập họ tên");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                errorProvider1.SetError(txtDiemTB, "Nhập điểm trung bình");
                valid = false;
            }
            else
            {
                if (float.TryParse(txtDiemTB.Text, out float diem))
                {
                    if (diem < 0 || diem > 10)
                    {
                        errorProvider1.SetError(txtDiemTB, "Điểm trung bình phải từ 0 đến 10");
                        valid = false;
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDiemTB, "Điểm trung bình không hợp lệ");
                    valid = false;
                }
            }

            return valid;
        }

        // Giới hạn ký tự nhập vào ô txtDiemTB
        private void txtDiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtDiemTB.Text.Contains(".")) return;
            e.Handled = true;
        }

        // Cập nhật trạng thái và xem trước theo thời gian thực
        private void Input_TextChanged(object sender, EventArgs e)
        {
            double diem;
            bool hopLe = double.TryParse(txtDiemTB.Text, out diem)
                && diem >= 0 && diem <= 10;

            lblXemTruoc.Text = txtMaSV.Text + " - " + txtHoTen.Text;
            lblTrangThai.Text = hopLe ? "Dữ liệu điểm hợp lệ" : "Kiểm tra điểm";
        }

        // Sự kiện click nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            MessageBox.Show("Dữ liệu hợp lệ, tiến hành lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}