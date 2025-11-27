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
using DTO_PolyCafe;

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
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoVaTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool vaiTro;
            if (rdNhanVien.Checked)
            {
                vaiTro = false;
            }
            else
            {
                vaiTro = true;
            }
            bool trangThai;
            if (rdActive.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui long dien day du thong tin");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUSNhanVien bus = new BUSNhanVien();
            string result = bus.InsertNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show(" Cap nhap thong tin thanh cong");
                ClearForm();
                LoadDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
			string maNV = txtMaNV.Text.Trim();
			string hoTen = txtHoVaTen.Text.Trim();
			string email = txtEmail.Text.Trim();
			string matKhau = txtMatKhau.Text.Trim();
			bool vaiTro;
			if (rdNhanVien.Checked)
			{
				vaiTro = false;
			}
			else
			{
				vaiTro = true;
			}
			bool trangThai;
			if (rdActive.Checked)
			{
				trangThai = true;
			}
			else
			{
				trangThai = false;
			}
			if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
			{
				MessageBox.Show("Vui long dien day du thong tin");
				return;
			}
			NhanVien nv = new NhanVien
			{
				MaNhanVien = maNV,
				HoTen = hoTen,
				Email = email,
				MatKhau = matKhau,
				VaiTro = vaiTro,
				TrangThai = trangThai
			};
			BUSNhanVien bus = new BUSNhanVien();
			string result = bus.UpdateNhanVien(nv);

			if (string.IsNullOrEmpty(result))
			{
				MessageBox.Show(" Cap nhap thong tin thanh cong");
				ClearForm();
				LoadDanhSachNhanVien();
			}
			else
			{
				MessageBox.Show(result);
			}
		}

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
			string maNhanVien = txtMaNV.Text.Trim();
			string name = txtHoVaTen.Text.Trim();
			if (string.IsNullOrEmpty(maNhanVien))
			{
				if (dgrDanhSachNV.SelectedRows.Count > 0)
				{
					DataGridViewRow selectedRow = dgrDanhSachNV.SelectedRows[0];
					maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
					name = selectedRow.Cells["HoTen"].Value.ToString();
				}
				else
				{
					MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (string.IsNullOrEmpty(maNhanVien))
			{
				MessageBox.Show("Xóa không thành công.");
				return;
			}

			DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				BUSNhanVien bus = new BUSNhanVien();
				string kq = bus.DeleteNhanVien(maNhanVien);

				if (string.IsNullOrEmpty(kq))
				{
					MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearForm();
					LoadDanhSachNhanVien();
				}
				else
				{
					MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			DataGridViewRow row = dgrDanhSachNV.Rows[e.RowIndex];
			// Đổ dữ liệu vào các ô nhập liệu trên form
			txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
			txtHoVaTen.Text = row.Cells["HoTen"].Value.ToString();
			txtEmail.Text = row.Cells["Email"].Value.ToString();
			txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
			txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

			bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
			if (vaiTro == false)
			{
				rdNhanVien.Checked = true;
			}
			else
			{
				rdQuanLy.Checked = true;
			}

			bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
			if (trangThai == false)
			{
				rdActive.Checked = true;
			}
			else
			{
				rdActive.Checked = true;
			}

			// Bật nút "Sửa"
			btnThem.Enabled = false;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			// Tắt chỉnh sửa mã nhân viên
			txtMaNV.Enabled = false;
		}
    }
}
