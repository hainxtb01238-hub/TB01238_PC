namespace GUI_PolyCafe
{
    partial class frmSanPham
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
            btnMoiSanPham = new Button();
            btnSuaSanPham = new Button();
            rdbDeActive = new RadioButton();
            rdbActive = new RadioButton();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtDonGia = new MaskedTextBox();
            pbHinhAnh = new PictureBox();
            cboLoaiSanPham = new ComboBox();
            btnXoaSanPham = new Button();
            btnUploadSanPham = new Button();
            btnThemSanPham = new Button();
            label5 = new Label();
            label4 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            txtMaSanPham = new TextBox();
            label2 = new Label();
            dgrDanhSachSP = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiemSP = new Button();
            txtTimKiemSP = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachSP).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMoiSanPham
            // 
            btnMoiSanPham.BackColor = SystemColors.Window;
            btnMoiSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiSanPham.Image = Properties.Resources.rotate;
            btnMoiSanPham.Location = new Point(261, 493);
            btnMoiSanPham.Name = "btnMoiSanPham";
            btnMoiSanPham.Size = new Size(84, 41);
            btnMoiSanPham.TabIndex = 3;
            btnMoiSanPham.Text = "Mới";
            btnMoiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiSanPham.UseVisualStyleBackColor = false;
            btnMoiSanPham.Click += btnMoiSanPham_Click;
            // 
            // btnSuaSanPham
            // 
            btnSuaSanPham.BackColor = SystemColors.Window;
            btnSuaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaSanPham.Image = Properties.Resources.edit;
            btnSuaSanPham.Location = new Point(94, 493);
            btnSuaSanPham.Name = "btnSuaSanPham";
            btnSuaSanPham.Size = new Size(75, 41);
            btnSuaSanPham.TabIndex = 3;
            btnSuaSanPham.Text = "Sửa";
            btnSuaSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaSanPham.UseVisualStyleBackColor = false;
            btnSuaSanPham.Click += btnSuaSanPham_Click;
            // 
            // rdbDeActive
            // 
            rdbDeActive.AutoSize = true;
            rdbDeActive.Font = new Font("Segoe UI", 10F);
            rdbDeActive.ForeColor = Color.Maroon;
            rdbDeActive.Location = new Point(255, 258);
            rdbDeActive.Name = "rdbDeActive";
            rdbDeActive.Size = new Size(96, 23);
            rdbDeActive.TabIndex = 8;
            rdbDeActive.Text = "Ngừng Bán";
            rdbDeActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.BackColor = Color.Transparent;
            rdbActive.Checked = true;
            rdbActive.Font = new Font("Segoe UI", 9F);
            rdbActive.ForeColor = Color.Maroon;
            rdbActive.Location = new Point(124, 259);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(83, 19);
            rdbActive.TabIndex = 7;
            rdbActive.TabStop = true;
            rdbActive.Text = "Hoạt Động";
            rdbActive.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(6, 262);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 6;
            label8.Text = "Trạng Thái";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(pbHinhAnh);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(rdbDeActive);
            groupBox1.Controls.Add(rdbActive);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnMoiSanPham);
            groupBox1.Controls.Add(btnXoaSanPham);
            groupBox1.Controls.Add(btnSuaSanPham);
            groupBox1.Controls.Add(btnUploadSanPham);
            groupBox1.Controls.Add(btnThemSanPham);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 542);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(124, 147);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(211, 29);
            txtDonGia.TabIndex = 6;
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            pbHinhAnh.ErrorImage = Properties.Resources.default_image;
            pbHinhAnh.Location = new Point(59, 296);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(230, 140);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 10;
            pbHinhAnh.TabStop = false;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Segoe UI", 11F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(124, 205);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(211, 28);
            cboLoaiSanPham.TabIndex = 9;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = SystemColors.Window;
            btnXoaSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaSanPham.Image = Properties.Resources.remove;
            btnXoaSanPham.Location = new Point(175, 493);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(80, 41);
            btnXoaSanPham.TabIndex = 3;
            btnXoaSanPham.Text = "Xóa";
            btnXoaSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaSanPham.UseVisualStyleBackColor = false;
            btnXoaSanPham.Click += btnXoaSanPham_Click;
            // 
            // btnUploadSanPham
            // 
            btnUploadSanPham.BackColor = SystemColors.Window;
            btnUploadSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUploadSanPham.Location = new Point(124, 442);
            btnUploadSanPham.Name = "btnUploadSanPham";
            btnUploadSanPham.Size = new Size(81, 26);
            btnUploadSanPham.TabIndex = 3;
            btnUploadSanPham.Text = "Chọn ảnh";
            btnUploadSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUploadSanPham.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.BackColor = SystemColors.Window;
            btnThemSanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemSanPham.Image = Properties.Resources.plus;
            btnThemSanPham.Location = new Point(7, 493);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(81, 41);
            btnThemSanPham.TabIndex = 3;
            btnThemSanPham.Text = "Thêm";
            btnThemSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(7, 208);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 0;
            label5.Text = "Loại Sản Phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "Đơn Gía";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Segoe UI", 12F);
            txtTenSanPham.Location = new Point(124, 96);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(211, 29);
            txtTenSanPham.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Tên Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Segoe UI", 12F);
            txtMaSanPham.Location = new Point(124, 47);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(211, 29);
            txtMaSanPham.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Sản Phẩm";
            // 
            // dgrDanhSachSP
            // 
            dgrDanhSachSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachSP.Location = new Point(6, 50);
            dgrDanhSachSP.Name = "dgrDanhSachSP";
            dgrDanhSachSP.ReadOnly = true;
            dgrDanhSachSP.RowHeadersWidth = 51;
            dgrDanhSachSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachSP.Size = new Size(781, 484);
            dgrDanhSachSP.TabIndex = 0;
            dgrDanhSachSP.CellDoubleClick += dgrDanhSachSP_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiemSP);
            groupBox2.Controls.Add(txtTimKiemSP);
            groupBox2.Controls.Add(dgrDanhSachSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(369, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 542);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản phẩm";
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemSP.Image = Properties.Resources.find;
            btnTimKiemSP.Location = new Point(720, 21);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(37, 24);
            btnTimKiemSP.TabIndex = 7;
            btnTimKiemSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemSP.Location = new Point(506, 21);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(213, 23);
            txtTimKiemSP.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(517, 21);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 3;
            label1.Text = "SẢN PHẨM";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1174, 642);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            Resize += frmSanPham_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachSP).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMoiSanPham;
        private Button btnSuaSanPham;
        private RadioButton rdbDeActive;
        private RadioButton rdbActive;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnXoaSanPham;
        private Button btnThemSanPham;
        private Label label5;
        private Label label4;
        private TextBox txtTenSanPham;
        private Label label3;
        private TextBox txtMaSanPham;
        private Label label2;
        private Button btnSearchNhanVien;
        private TextBox txttimKiemNhanVien;
        private DataGridView dgrDanhSachSP;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboLoaiSanPham;
        private PictureBox pbHinhAnh;
        private Button btnUploadSanPham;
        private Button btnTimKiemSP;
        private TextBox txtTimKiemSP;
        private MaskedTextBox txtDonGia;
    }
}