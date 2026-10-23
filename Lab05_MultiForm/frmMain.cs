using System;
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

        // Sự kiện click vào menu Sinh viên
        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTietSinhVien(null));
        }
    }
}