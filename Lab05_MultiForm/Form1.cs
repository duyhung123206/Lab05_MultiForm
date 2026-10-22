using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Phương thức kiểm tra dữ liệu đầu vào sử dụng ErrorProvider
        private bool ValidateInput()
        {
            errorProvider1.Clear();
            bool valid = true;

            // 1. Kiểm tra Mã sinh viên không được để trống
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Nhập mã sinh viên");
                valid = false;
            }

            // 2. Kiểm tra Họ tên không được để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Nhập họ tên");
                valid = false;
            }

            // 3. Kiểm tra Điểm trung bình (phải từ 0 đến 10)[cite: 16]
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

        // Sự kiện giới hạn ký tự nhập vào ô txtDiemTB (chỉ cho phép số và một dấu chấm)
        private void txtDiemTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && !txtDiemTB.Text.Contains(".")) return;
            e.Handled = true;
        }

        // Sự kiện click nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Nếu dữ liệu không hợp lệ thì dừng lại, không cho lưu
            if (!ValidateInput()) return;

            // Nếu dữ liệu hợp lệ, thực hiện lưu thành công
            MessageBox.Show("Dữ liệu hợp lệ, tiến hành lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}