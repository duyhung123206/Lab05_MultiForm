namespace Lab05_MultiForm
{
    partial class frmChiTietSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(107, 55);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(44, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "label1";
            this.lblMa.Click += new System.EventHandler(this.frmChiTietSinhVien_Load);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(107, 101);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(44, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "label2";
            this.lblHoTen.Click += new System.EventHandler(this.frmChiTietSinhVien_Load);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(107, 153);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(44, 16);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "label3";
            this.lblDiem.Click += new System.EventHandler(this.frmChiTietSinhVien_Load);
            // 
            // frmChiTietSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMa);
            this.Name = "frmChiTietSinhVien";
            this.Text = "frmChiTietSinhVien";
            this.Load += new System.EventHandler(this.frmChiTietSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiem;
    }
}