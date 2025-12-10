namespace GUI_PolyCafe
{
    partial class frmLoaiSanPham
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
            label1 = new Label();
            btnTimKiemThe = new Button();
            groupBox2 = new GroupBox();
            btnTimKiemLoaiSP = new Button();
            txtTimKiemLoaiSP = new TextBox();
            dgrDanhSachLoaiSP = new DataGridView();
            btnMoiLoaiSP = new Button();
            btnXoaLoaiSP = new Button();
            btnThemLoaiSP = new Button();
            txtTenLoaiSP = new TextBox();
            txtMaLoaiSP = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSuaLoaiSP = new Button();
            txtGhiChuSP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(517, 21);
            label1.Name = "label1";
            label1.Size = new Size(230, 37);
            label1.TabIndex = 6;
            label1.Text = "LOẠI SẢN PHẨM";
            // 
            // btnTimKiemThe
            // 
            btnTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemThe.FlatStyle = FlatStyle.Flat;
            btnTimKiemThe.Image = Properties.Resources.find;
            btnTimKiemThe.Location = new Point(1320, 21);
            btnTimKiemThe.Name = "btnTimKiemThe";
            btnTimKiemThe.Size = new Size(37, 24);
            btnTimKiemThe.TabIndex = 4;
            btnTimKiemThe.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiemLoaiSP);
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemLoaiSP);
            groupBox2.Controls.Add(dgrDanhSachLoaiSP);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(369, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 533);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // btnTimKiemLoaiSP
            // 
            btnTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemLoaiSP.FlatStyle = FlatStyle.Flat;
            btnTimKiemLoaiSP.Image = Properties.Resources.find;
            btnTimKiemLoaiSP.Location = new Point(727, 21);
            btnTimKiemLoaiSP.Name = "btnTimKiemLoaiSP";
            btnTimKiemLoaiSP.Size = new Size(37, 23);
            btnTimKiemLoaiSP.TabIndex = 5;
            btnTimKiemLoaiSP.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemLoaiSP
            // 
            txtTimKiemLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTimKiemLoaiSP.Location = new Point(513, 21);
            txtTimKiemLoaiSP.Name = "txtTimKiemLoaiSP";
            txtTimKiemLoaiSP.Size = new Size(213, 23);
            txtTimKiemLoaiSP.TabIndex = 3;
            // 
            // dgrDanhSachLoaiSP
            // 
            dgrDanhSachLoaiSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachLoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachLoaiSP.Location = new Point(6, 50);
            dgrDanhSachLoaiSP.Name = "dgrDanhSachLoaiSP";
            dgrDanhSachLoaiSP.ReadOnly = true;
            dgrDanhSachLoaiSP.RowHeadersWidth = 51;
            dgrDanhSachLoaiSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachLoaiSP.Size = new Size(781, 477);
            dgrDanhSachLoaiSP.TabIndex = 0;
            dgrDanhSachLoaiSP.CellDoubleClick += dgrDanhSachLoaiSP_CellDoubleClick;
            // 
            // btnMoiLoaiSP
            // 
            btnMoiLoaiSP.BackColor = SystemColors.Window;
            btnMoiLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiLoaiSP.Image = Properties.Resources.rotate;
            btnMoiLoaiSP.Location = new Point(259, 376);
            btnMoiLoaiSP.Name = "btnMoiLoaiSP";
            btnMoiLoaiSP.Size = new Size(84, 41);
            btnMoiLoaiSP.TabIndex = 7;
            btnMoiLoaiSP.Text = "Mới";
            btnMoiLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiLoaiSP.UseVisualStyleBackColor = false;
            btnMoiLoaiSP.Click += btnMoiLoaiSP_Click;
            // 
            // btnXoaLoaiSP
            // 
            btnXoaLoaiSP.BackColor = SystemColors.Window;
            btnXoaLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLoaiSP.Image = Properties.Resources.remove;
            btnXoaLoaiSP.Location = new Point(173, 376);
            btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            btnXoaLoaiSP.Size = new Size(80, 41);
            btnXoaLoaiSP.TabIndex = 6;
            btnXoaLoaiSP.Text = "Xóa";
            btnXoaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaLoaiSP.UseVisualStyleBackColor = false;
            btnXoaLoaiSP.Click += btnXoaLoaiSP_Click;
            // 
            // btnThemLoaiSP
            // 
            btnThemLoaiSP.BackColor = SystemColors.Window;
            btnThemLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemLoaiSP.Image = Properties.Resources.plus;
            btnThemLoaiSP.Location = new Point(5, 376);
            btnThemLoaiSP.Name = "btnThemLoaiSP";
            btnThemLoaiSP.Size = new Size(81, 41);
            btnThemLoaiSP.TabIndex = 4;
            btnThemLoaiSP.Text = "Thêm";
            btnThemLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemLoaiSP.UseVisualStyleBackColor = false;
            btnThemLoaiSP.Click += btnThemLoaiSP_Click;
            // 
            // txtTenLoaiSP
            // 
            txtTenLoaiSP.Font = new Font("Segoe UI", 12F);
            txtTenLoaiSP.Location = new Point(124, 126);
            txtTenLoaiSP.Name = "txtTenLoaiSP";
            txtTenLoaiSP.Size = new Size(211, 29);
            txtTenLoaiSP.TabIndex = 2;
            // 
            // txtMaLoaiSP
            // 
            txtMaLoaiSP.Font = new Font("Segoe UI", 12F);
            txtMaLoaiSP.Location = new Point(124, 77);
            txtMaLoaiSP.Name = "txtMaLoaiSP";
            txtMaLoaiSP.ReadOnly = true;
            txtMaLoaiSP.Size = new Size(211, 29);
            txtMaLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnMoiLoaiSP);
            groupBox1.Controls.Add(btnXoaLoaiSP);
            groupBox1.Controls.Add(btnSuaLoaiSP);
            groupBox1.Controls.Add(btnThemLoaiSP);
            groupBox1.Controls.Add(txtGhiChuSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenLoaiSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLoaiSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 533);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại ";
            // 
            // btnSuaLoaiSP
            // 
            btnSuaLoaiSP.BackColor = SystemColors.Window;
            btnSuaLoaiSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaLoaiSP.Image = Properties.Resources.edit;
            btnSuaLoaiSP.Location = new Point(92, 376);
            btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            btnSuaLoaiSP.Size = new Size(75, 41);
            btnSuaLoaiSP.TabIndex = 5;
            btnSuaLoaiSP.Text = "Sửa";
            btnSuaLoaiSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaLoaiSP.UseVisualStyleBackColor = false;
            btnSuaLoaiSP.Click += btnSuaLoaiSP_Click;
            // 
            // txtGhiChuSP
            // 
            txtGhiChuSP.Font = new Font("Segoe UI", 12F);
            txtGhiChuSP.Location = new Point(124, 179);
            txtGhiChuSP.Multiline = true;
            txtGhiChuSP.Name = "txtGhiChuSP";
            txtGhiChuSP.Size = new Size(211, 140);
            txtGhiChuSP.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(6, 187);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Tên Loại";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1174, 642);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiSanPham";
            Text = "frmLoaiSanPham";
            Load += frmLoaiSanPham_Load;
            Resize += frmLoaiSanPham_Resize;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachLoaiSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTimKiemThe;
        private GroupBox groupBox2;
        private TextBox txtTimKiemLoaiSP;
        private Button btnSearchNhanVien;
        private TextBox txttimKiemNhanVien;
        private DataGridView dgrDanhSachLoaiSP;
        private Button btnMoiLoaiSP;
        private Button btnXoaLoaiSP;
        private Button btnThemLoaiSP;
        private TextBox txtTenLoaiSP;
        private TextBox txtMaLoaiSP;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnSuaLoaiSP;
        private TextBox txtGhiChuSP;
        private Label label4;
        private Label label3;
        private Button btnTimKiemLoaiSP;
    }
}