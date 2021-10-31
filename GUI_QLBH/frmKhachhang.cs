using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH.Iservice;
using BUS_QLBH.Service;
using DAL_QLBH.entities;

namespace GUI_QLBH
{
    public partial class frmKhachhang : Form
    {
        private IServiceKhachhangbus _iServiceKhachhangbus;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private Guid teamp;
        public frmKhachhang()
        {
            InitializeComponent();
            _iServiceKhachhangbus = new ServiceKhachhangbus();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            loadmanv();
            loaddata();
        }

        void loadmanv()
        {
            foreach (var x in _iServiceNhanVienbus.getlistNV())
            {
                cbb_manv.Items.Add(x.MaNV);
                cbb_manv.SelectedIndex = 0;
            }
        }

        bool Check()
        {
            var sdt = _iServiceKhachhangbus.getlistKH().Where(c => c.MaKH == teamp).Select(c => c.SDtKH)
                .FirstOrDefault();
            string checkso = "^[0-9]+$";
            if (string.IsNullOrEmpty(txt_ten.Text))
            {
                txt_ten.BackColor = Color.IndianRed;
                MessageBox.Show("Tên không được trống!", "Thông báo");
                txt_ten.Focus();
                txt_ten.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                txt_diachi.BackColor = Color.IndianRed;
                MessageBox.Show("Địa chỉ không được trống!", "Thông báo");
                txt_diachi.Focus();
                txt_diachi.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                txt_sdt.BackColor = Color.IndianRed;
                MessageBox.Show("Số điện thoại không được trống!", "Thông báo");
                txt_sdt.Focus();
                txt_sdt.BackColor = Color.White;
                return false;
            }
            else if (!Regex.IsMatch(txt_sdt.Text,checkso))
            {
                txt_sdt.BackColor = Color.IndianRed;
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                txt_sdt.Focus();
                txt_sdt.BackColor = Color.White;
                return false;
            }
            else if (txt_sdt.Text == sdt)
            {
                txt_sdt.BackColor = Color.IndianRed;
                MessageBox.Show("Trùng số điện thoại!", "Thông báo");
                txt_sdt.Focus();
                txt_sdt.BackColor = Color.White;
                return false;
            }
            return true;
        }
        void loaddata()
        {
            dtw_khachhang.ColumnCount = 6;
            dtw_khachhang.Columns[0].Name = "Tên Khách Hàng";
            dtw_khachhang.Columns[1].Name = "Địa chỉ";
            dtw_khachhang.Columns[2].Name = "Giới tính";
            dtw_khachhang.Columns[3].Name = "Số điện thoại";
            dtw_khachhang.Columns[4].Name = "Mã NV";
            dtw_khachhang.Columns[5].Name = "MaKH";
            dtw_khachhang.Columns[5].Visible = false;
            dtw_khachhang.Rows.Clear();
            foreach (var x in _iServiceKhachhangbus.getlistKH())
            {
                dtw_khachhang.Rows.Add(x.TenKhach, x.Diachi, x.Phai == 1 ? "Nam" : "Nữ",x.SDtKH, x.MaNV,x.MaKH);
            }
        }
        private void dtw_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == _iServiceKhachhangbus.getlistKH().Count) return;
            txt_ten.Text = dtw_khachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_diachi.Text = dtw_khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
            rd_nam.Checked = dtw_khachhang.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam";
            rd_nu.Checked = dtw_khachhang.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nữ";
            txt_sdt.Text = dtw_khachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbb_manv.Text = dtw_khachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
            teamp = Guid.Parse(dtw_khachhang.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (true)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iServiceKhachhangbus.Them(new KhachHang()
                        {
                            TenKhach = txt_ten.Text,
                            Diachi = txt_diachi.Text,
                            Phai = rd_nam.Checked ? 1 : 0,
                            SDtKH = txt_sdt.Text,
                            MaNV = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == Convert.ToInt32(cbb_manv.Text))
                                .Select(c => c.MaNV).FirstOrDefault(),
                        }), "Thông báo");
                        _iServiceKhachhangbus.getlsfromDB();
                    }
                }
                loaddata();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var kh = _iServiceKhachhangbus.getlistKH().Where(c => c.MaKH == teamp).FirstOrDefault();
                kh.TenKhach = txt_ten.Text;
                kh.Diachi = txt_diachi.Text;
                kh.Phai = rd_nam.Checked ? 1 : 0;
                kh.SDtKH = txt_sdt.Text;
                kh.MaNV = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == Convert.ToInt32(cbb_manv.Text))
                    .Select(c => c.MaNV).FirstOrDefault();
                MessageBox.Show(_iServiceKhachhangbus.Sua(kh), "Thông báo");
                _iServiceKhachhangbus.getlsfromDB();
                loaddata();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                MessageBox.Show(_iServiceKhachhangbus.Xoa(teamp), "Thông báo");
                _iServiceKhachhangbus.getlsfromDB();
                loaddata();
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn quay lại không ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                frmTrangchu frmTrangchu = new frmTrangchu();
                this.Hide();
                frmTrangchu.Show();
            }
        }
        void Timkiem(string acc)
        {
            dtw_khachhang.ColumnCount = 6;
            dtw_khachhang.Columns[0].Name = "Tên Khách Hàng";
            dtw_khachhang.Columns[1].Name = "Địa chỉ";
            dtw_khachhang.Columns[2].Name = "Giới tính";
            dtw_khachhang.Columns[3].Name = "Số điện thoại";
            dtw_khachhang.Columns[4].Name = "Mã NV";
            dtw_khachhang.Columns[5].Name = "MaKH";
            dtw_khachhang.Columns[5].Visible = false;
            dtw_khachhang.Rows.Clear();
            foreach (var x in _iServiceKhachhangbus.Timkiem(acc))
            {
                dtw_khachhang.Rows.Add(x.TenKhach, x.Diachi, x.Phai == 1 ? "Nam" : "Nữ", x.SDtKH, x.MaNV, x.MaKH);
            }
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }
    }
}
