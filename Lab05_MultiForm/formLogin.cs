using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class formLogin : Form
    {
        private int failedAttempts = 0; // Biến đếm số lần nhập sai

        public formLogin()
        {
            InitializeComponent();

            // Cấu hình Timer đếm ngược 30 giây (nếu chưa thiết lập trong Properties)
            if (timer1 == null)
            {
                timer1 = new Timer();
            }
            timer1.Interval = 30000; // 30 giây (30000 ms)
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Tài khoản mẫu: admin / 123456
            if (txtUser.Text == "admin" && txtPass.Text == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form chính (frmMain)
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                failedAttempts++;
                int remainingAttempts = 3 - failedAttempts;

                if (failedAttempts >= 3)
                {
                    // Khóa nút đăng nhập và kích hoạt Timer đếm 30 giây
                    btnLogin.Enabled = false;
                    timer1.Start();

                    MessageBox.Show("Bạn đã nhập sai 3 lần! Nút đăng nhập đã bị khóa trong 30 giây.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Sai tài khoản hoặc mật khẩu! Bạn còn {remainingAttempts} lần thử.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện xảy ra khi hết 30 giây khóa
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();           // Dừng timer lại
            btnLogin.Enabled = true; // Mở khóa nút đăng nhập
            failedAttempts = 0;      // Reset lại số lần đếm sai

            MessageBox.Show("Đã hết thời gian khóa. Bạn có thể thử đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hàm xử lý sự kiện TextChanged của txtUser (tránh lỗi phát sinh từ Designer)
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống hoặc xử lý giao diện tùy ý
        }
    }
}