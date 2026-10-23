using System;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class formTimKiem : Form
    {
        // Khai báo Property để trả kết quả về form gọi
        public string TuKhoa { get; private set; }

        public formTimKiem()
        {
            InitializeComponent(); // Hàm này sẽ hết lỗi khi có từ khóa partial
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            TuKhoa = txtTuKhoa.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}