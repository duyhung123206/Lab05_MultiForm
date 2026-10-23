using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class formChonKhoa : Form
    {
        // Property lưu trữ khoa được chọn để trả về form gọi
        public string KhoaDaChon { get; private set; }

        public formChonKhoa()
        {
            InitializeComponent();
        }

        // Phương thức nhận danh sách khoa đưa vào ComboBox
        public void LoadDanhSachKhoa(List<string> dsKhoa)
        {
            cbKhoa.Items.Clear();
            foreach (var item in dsKhoa)
            {
                cbKhoa.Items.Add(item);
            }
            if (cbKhoa.Items.Count > 0)
            {
                cbKhoa.SelectedIndex = 0;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedItem != null || !string.IsNullOrEmpty(cbKhoa.Text))
            {
                KhoaDaChon = cbKhoa.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}