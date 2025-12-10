namespace GUI_PolyCafe
{
    partial class frmTheLuuDong
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
            btnMoiThe = new Button();
            btnSuaThe = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            chkAction = new CheckBox();
            btnXoaThe = new Button();
            btnThemThe = new Button();
            txtChuSoHuu = new TextBox();
            label3 = new Label();
            txtMaThe = new TextBox();
            label2 = new Label();
            dgrDanhSachThe = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiemThe = new Button();
            txtTimKiemThe = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThe).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMoiThe
            // 
            btnMoiThe.BackColor = SystemColors.Window;
            btnMoiThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiThe.Image = Properties.Resources.rotate;
            btnMoiThe.Location = new Point(261, 263);
            btnMoiThe.Name = "btnMoiThe";
            btnMoiThe.Size = new Size(84, 41);
            btnMoiThe.TabIndex = 7;
            btnMoiThe.Text = "Mới";
            btnMoiThe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiThe.UseVisualStyleBackColor = false;
            btnMoiThe.Click += btnMoiThe_Click;
            // 
            // btnSuaThe
            // 
            btnSuaThe.BackColor = SystemColors.Window;
            btnSuaThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaThe.Image = Properties.Resources.edit;
            btnSuaThe.Location = new Point(94, 263);
            btnSuaThe.Name = "btnSuaThe";
            btnSuaThe.Size = new Size(75, 41);
            btnSuaThe.TabIndex = 5;
            btnSuaThe.Text = "Sửa";
            btnSuaThe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaThe.UseVisualStyleBackColor = false;
            btnSuaThe.Click += btnSuaThe_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(6, 188);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 6;
            label8.Text = "Trạng Thái";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(chkAction);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnMoiThe);
            groupBox1.Controls.Add(btnXoaThe);
            groupBox1.Controls.Add(btnSuaThe);
            groupBox1.Controls.Add(btnThemThe);
            groupBox1.Controls.Add(txtChuSoHuu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaThe);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 533);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thẻ";
            // 
            // chkAction
            // 
            chkAction.AutoSize = true;
            chkAction.Checked = true;
            chkAction.CheckState = CheckState.Checked;
            chkAction.Location = new Point(124, 184);
            chkAction.Name = "chkAction";
            chkAction.Size = new Size(85, 19);
            chkAction.TabIndex = 3;
            chkAction.Text = "Hoạt động";
            chkAction.UseVisualStyleBackColor = true;
            // 
            // btnXoaThe
            // 
            btnXoaThe.BackColor = SystemColors.Window;
            btnXoaThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaThe.Image = Properties.Resources.remove;
            btnXoaThe.Location = new Point(175, 263);
            btnXoaThe.Name = "btnXoaThe";
            btnXoaThe.Size = new Size(80, 41);
            btnXoaThe.TabIndex = 6;
            btnXoaThe.Text = "Xóa";
            btnXoaThe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaThe.UseVisualStyleBackColor = false;
            btnXoaThe.Click += btnXoaThe_Click;
            // 
            // btnThemThe
            // 
            btnThemThe.BackColor = SystemColors.Window;
            btnThemThe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemThe.Image = Properties.Resources.plus;
            btnThemThe.Location = new Point(7, 263);
            btnThemThe.Name = "btnThemThe";
            btnThemThe.Size = new Size(81, 41);
            btnThemThe.TabIndex = 4;
            btnThemThe.Text = "Thêm";
            btnThemThe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemThe.UseVisualStyleBackColor = false;
            btnThemThe.Click += btnThemThe_Click;
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Font = new Font("Segoe UI", 12F);
            txtChuSoHuu.Location = new Point(124, 126);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(211, 29);
            txtChuSoHuu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Chủ Sở Hữu";
            // 
            // txtMaThe
            // 
            txtMaThe.Font = new Font("Segoe UI", 12F);
            txtMaThe.Location = new Point(124, 77);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.ReadOnly = true;
            txtMaThe.Size = new Size(211, 29);
            txtMaThe.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Thẻ";
            // 
            // dgrDanhSachThe
            // 
            dgrDanhSachThe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachThe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachThe.Location = new Point(6, 50);
            dgrDanhSachThe.Name = "dgrDanhSachThe";
            dgrDanhSachThe.ReadOnly = true;
            dgrDanhSachThe.RowHeadersWidth = 51;
            dgrDanhSachThe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachThe.Size = new Size(781, 477);
            dgrDanhSachThe.TabIndex = 0;
            dgrDanhSachThe.CellDoubleClick += dgrDanhSachThe_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiemThe);
            groupBox2.Controls.Add(txtTimKiemThe);
            groupBox2.Controls.Add(dgrDanhSachThe);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(369, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 533);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Thẻ Lưu Động";
            // 
            // btnTimKiemThe
            // 
            btnTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiemThe.FlatStyle = FlatStyle.Flat;
            btnTimKiemThe.Image = Properties.Resources.find;
            btnTimKiemThe.Location = new Point(727, 21);
            btnTimKiemThe.Name = "btnTimKiemThe";
            btnTimKiemThe.Size = new Size(37, 20);
            btnTimKiemThe.TabIndex = 4;
            btnTimKiemThe.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemThe
            // 
            txtTimKiemThe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiemThe.Location = new Point(513, 21);
            txtTimKiemThe.Name = "txtTimKiemThe";
            txtTimKiemThe.Size = new Size(213, 23);
            txtTimKiemThe.TabIndex = 3;
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
            label1.Size = new Size(217, 37);
            label1.TabIndex = 3;
            label1.Text = "THẺ LƯU ĐỘNG";
            // 
            // frmTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1174, 642);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "frmTheLuuDong";
            Text = "PPolyCafe - Thẻ Lưu Động";
            Load += frmTheLuuDong_Load;
            Resize += frmTheLuuDong_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachThe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMoiThe;
        private Button btnSuaThe;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnXoaThe;
        private Button btnThemThe;
        private TextBox txtChuSoHuu;
        private Label label3;
        private TextBox txtMaThe;
        private Label label2;
        private Button btnSearchNhanVien;
        private TextBox txttimKiemNhanVien;
        private DataGridView dgrDanhSachThe;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnTimKiemThe;
        private TextBox txtTimKiemThe;
        private CheckBox chkAction;
    }
}