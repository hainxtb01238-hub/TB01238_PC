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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text.Trim();
            string tenLoai = txtTenLoaiSP.Text.Trim();
            string ghiChu = txtGhiChuSP.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            LoaiSanPham loai = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BUSLoaiSanPham bus = new BUSLoaiSanPham();
            string result = bus.InsertLoaiSanPham(loai);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text.Trim();
            string tenLoai = txtTenLoaiSP.Text.Trim();
            string ghiChu = txtGhiChuSP.Text.Trim();
            if (string.IsNullOrEmpty(maLoai))
            {
                if (dgrDanhSachLoaiSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachLoaiSP.SelectedRows[0];
                    maLoai = selectedRow.Cells["MaLoai"].Value.ToString();
                    tenLoai = selectedRow.Cells["TenLoai"].Value.ToString();
                    ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin loại sản phẩm cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {maLoai} - {tenLoai}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUSLoaiSanPham bus = new BUSLoaiSanPham();
                string kq = bus.DeleteLoaiSanPham(maLoai);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin loại sản phẩm {maLoai} - {tenLoai} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSP();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text.Trim();
            string tenLoai = txtTenLoaiSP.Text.Trim();
            string ghiChu = txtGhiChuSP.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin loại sản phẩm.");
                return;
            }
            LoaiSanPham loaiSanPham = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BUSLoaiSanPham bus = new BUSLoaiSanPham();
            string result = bus.UpdateLoaiSanPham(loaiSanPham);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnMoiLoaiSP_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void ClearForm()
        {
            btnThemLoaiSP.Enabled = true;
            btnSuaLoaiSP.Enabled = false;
            btnXoaLoaiSP.Enabled = true;
            txtMaLoaiSP.Clear();
            txtGhiChuSP.Clear();
            txtTenLoaiSP.Clear();
        }

        private void LoadDanhSachLoaiSP()
        {
            BUSLoaiSanPham busLoaiSp = new BUSLoaiSanPham();
            dgrDanhSachLoaiSP.DataSource = null;
            dgrDanhSachLoaiSP.DataSource = busLoaiSp.GetLoaiSanPhamList();
            dgrDanhSachLoaiSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgrDanhSachLoaiSP.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgrDanhSachLoaiSP.Columns["GhiChu"].HeaderText = "Ghi Chú";

            dgrDanhSachLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgrDanhSachLoaiSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrDanhSachLoaiSP.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaLoaiSP.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoaiSP.Text = row.Cells["TenLoai"].Value.ToString();
            txtGhiChuSP.Text = row.Cells["GhiChu"].Value.ToString();

            // Bật nút "Sửa"
            btnThemLoaiSP.Enabled = false;
            btnSuaLoaiSP.Enabled = true;
            btnXoaLoaiSP.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaLoaiSP.Enabled = false;
        }

        private void frmLoaiSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }
    }
}
