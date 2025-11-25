using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

       

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNV.Clear();
			txtHoVaTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            rdNhanVien.Checked = true;
            rdQuanLy.Checked = true;
		}
		private void LoadDanhSachNhanVien()
		{
			BUSNhanVien bUSNhanVien = new BUSNhanVien();
			dgrDanhSachNV.DataSource = null;
			dgrDanhSachNV.DataSource = bUSNhanVien.GetNhanVienList();

			dgrDanhSachNV.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
			dgrDanhSachNV.Columns["HoTen"].HeaderText = "Họ Tên";
			dgrDanhSachNV.Columns["Email"].HeaderText = "Email";
			dgrDanhSachNV.Columns["MatKhau"].HeaderText = "MatKhau";
			dgrDanhSachNV.Columns["VaiTro"].Visible = false;
			dgrDanhSachNV.Columns["TrangThai"].Visible = false;
			dgrDanhSachNV.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
			dgrDanhSachNV.Columns["VaiTroText"].HeaderText = "Vai Trò";

		}
	}
}
