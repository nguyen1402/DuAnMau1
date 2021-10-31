using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
    public partial class frmSanPham : Form
    {
        private IServiceSanPhambus _iServiceSanPhambus;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private string teamp;
        public frmSanPham()
        {
            InitializeComponent();
            _iServiceSanPhambus = new ServiceSanPhambus();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            loaddata();
            Loadmanv();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dtw_sanpham.Columns.Add(btn);
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Update";
            btn1.Text = "Update";
            btn1.UseColumnTextForButtonValue = true;
            dtw_sanpham.Columns.Add(btn1);
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Add";
            btn2.Text = "Add";
            btn2.UseColumnTextForButtonValue = true;
            dtw_sanpham.Columns.Add(btn2);
            dtw_sanpham.Columns[6].Width = 150;
            foreach (var x in _iServiceNhanVienbus.getlistNV())
            {
                MaNV.Items.Add(x.MaNV);
            }
            for (int i = 0; i < dtw_sanpham.Columns.Count; i++)
            {
                if (dtw_sanpham.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dtw_sanpham.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }
        bool Check()
        {
            var masp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == txt_masp.Text).Select(c => c.MaHang)
                .FirstOrDefault();
            string checkso = "^[0-9]+$";
            if (string.IsNullOrEmpty(txt_masp.Text))
            {
                txt_masp.BackColor = Color.IndianRed;
                MessageBox.Show("Mã sản phẩm không được trống!", "Thông báo");
                txt_masp.Focus();
                txt_masp.BackColor = Color.White;
                return false;
            }
            else if (txt_masp.Text == masp)
            {
                txt_masp.BackColor = Color.IndianRed;
                MessageBox.Show("Trùng mã Sản Phẩm !", "Thông báo");
                txt_masp.Focus();
                txt_masp.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_tensp.Text))
            {
                txt_tensp.BackColor = Color.IndianRed;
                MessageBox.Show("Tên sản phẩm không được trống!", "Thông báo");
                txt_tensp.Focus();
                txt_tensp.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_soluong.Text))
            {
                txt_soluong.BackColor = Color.IndianRed;
                MessageBox.Show("Số lượng không được để trống!", "Thông báo");
                txt_soluong.Focus();
                txt_soluong.BackColor = Color.White;
                return false;
            }
            else if (!Regex.IsMatch(txt_soluong.Text, checkso))
            {
                txt_soluong.BackColor = Color.IndianRed;
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                txt_soluong.Focus();
                txt_soluong.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_dongiaban.Text))
            {
                txt_dongiaban.BackColor = Color.IndianRed;
                MessageBox.Show("Đơn giá bán trống !", "Thông báo");
                txt_dongiaban.Focus();
                txt_dongiaban.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_dongianhap.Text))
            {
                txt_dongianhap.BackColor = Color.IndianRed;
                MessageBox.Show("Đơn giá nhập trống !", "Thông báo");
                txt_dongianhap.Focus();
                txt_dongianhap.BackColor = Color.White;
                return false;
            }
            return true;
        }
        bool Check2()
        {
            var masp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == txt_masp.Text).Select(c => c.MaHang)
                .FirstOrDefault();
            string checkso = "^[0-9]+$";
            if (txt_masp.Text != masp)
            {
                txt_masp.BackColor = Color.IndianRed;
                MessageBox.Show("Mã Sản Phẩm không được sửa !", "Thông báo");
                txt_masp.Focus();
                txt_masp.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_tensp.Text))
            {
                txt_tensp.BackColor = Color.IndianRed;
                MessageBox.Show("Tên sản phẩm không được trống!", "Thông báo");
                txt_tensp.Focus();
                txt_tensp.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_soluong.Text))
            {
                txt_soluong.BackColor = Color.IndianRed;
                MessageBox.Show("Số lượng không được để trống!", "Thông báo");
                txt_soluong.Focus();
                txt_soluong.BackColor = Color.White;
                return false;
            }
            else if (!Regex.IsMatch(txt_soluong.Text, checkso))
            {
                txt_soluong.BackColor = Color.IndianRed;
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                txt_soluong.Focus();
                txt_soluong.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_dongiaban.Text))
            {
                txt_dongiaban.BackColor = Color.IndianRed;
                MessageBox.Show("Đơn giá bán trống !", "Thông báo");
                txt_dongiaban.Focus();
                txt_dongiaban.BackColor = Color.White;
                return false;
            }
            else if (string.IsNullOrEmpty(txt_dongianhap.Text))
            {
                txt_dongianhap.BackColor = Color.IndianRed;
                MessageBox.Show("Đơn giá nhập trống !", "Thông báo");
                txt_dongianhap.Focus();
                txt_dongianhap.BackColor = Color.White;
                return false;
            }
            return true;
        }

        void Loadmanv()
        {
            foreach (var x in _iServiceNhanVienbus.getlistNV())
            {
                cbb_manv.Items.Add(x.MaNV);
                cbb_manv.SelectedIndex = 0;
            }
        }
        void loaddata()
        {
            //dtw_sanpham.ColumnCount = 8;
            //dtw_sanpham.Columns[0].Name = "Mã SP";
            //dtw_sanpham.Columns[1].Name = "Tên SP";
            //dtw_sanpham.Columns[2].Name = "Số lượng";
            //dtw_sanpham.Columns[3].Name = "Đơn giá bán";
            //dtw_sanpham.Columns[4].Name = "Đơn giá nhập";
            //dtw_sanpham.Columns[5].Name = "Ghi chú";
            //dtw_sanpham.Columns[6].Name = "Hình Ảnh";
            //dtw_sanpham.Columns[7].Name = "Mã NV";
            dtw_sanpham.Rows.Clear();
            foreach (var x in _iServiceSanPhambus.GetlsHangs())
            {
                dtw_sanpham.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.Dgiaban, x.Dgianhap, x.GhiChu, x.Hinhanh,
                    x.MaNV);
            }
            for (int i = 0; i < dtw_sanpham.Rows.Count; i++)
            {
                (dtw_sanpham.Rows[i].Cells[7] as DataGridViewComboBoxCell).DataSource = _iServiceNhanVienbus.getlistNV();
                (dtw_sanpham.Rows[i].Cells[7] as DataGridViewComboBoxCell).ValueMember = "MaNV";
            }
        }
        private void dtw_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[0].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[3].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[4].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[5].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[6].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[7].Value?.ToString()))
            {
                return;
            }

            if (e.RowIndex == _iServiceSanPhambus.GetlsHangs().Count || e.RowIndex == -1) return;
            txt_masp.Text = dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tensp.Text = dtw_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_soluong.Text = dtw_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_dongiaban.Text = dtw_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_dongianhap.Text = dtw_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ghichu.Text = dtw_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
            byte[] b = (byte[])dtw_sanpham.Rows[e.RowIndex].Cells[6].Value;
            pic_hinhanh.Image = BytesangImg(b);
            cbb_manv.Text = dtw_sanpham.Rows[e.RowIndex].Cells[7].Value.ToString();
            teamp = txt_masp.Text;

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    byte[] anh = ChuyenImagesangByte(pic_hinhanh.Image);
                    MessageBox.Show(_iServiceSanPhambus.Them(new Hang()
                    {
                        MaHang = txt_masp.Text,
                        TenHang = txt_tensp.Text,
                        SoLuong = Convert.ToInt32(txt_soluong.Text),
                        Dgiaban = float.Parse(txt_dongiaban.Text),
                        Dgianhap = float.Parse(txt_dongianhap.Text),
                        GhiChu = txt_ghichu.Text,
                        Hinhanh = anh,
                        MaNV = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == Convert.ToInt32(cbb_manv.Text))
                            .Select(c => c.MaNV).FirstOrDefault(),
                    }), "Thông báo");
                    _iServiceSanPhambus.GetHangfromDB();
                    loaddata();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                byte[] anh = ChuyenImagesangByte(pic_hinhanh.Image);
                var sp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == teamp).FirstOrDefault();
                sp.MaHang = txt_masp.Text;
                sp.TenHang = txt_tensp.Text;
                sp.SoLuong = Convert.ToInt32(txt_soluong.Text);
                sp.Dgiaban = float.Parse(txt_dongiaban.Text);
                sp.Dgianhap = float.Parse(txt_dongianhap.Text);
                sp.GhiChu = txt_ghichu.Text;
                sp.Hinhanh = anh;
                sp.MaNV = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == Convert.ToInt32(cbb_manv.Text))
                    .Select(c => c.MaNV).FirstOrDefault();
                MessageBox.Show(_iServiceSanPhambus.Sua(sp), "Thông báo");
                _iServiceSanPhambus.GetHangfromDB();
                loaddata();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                MessageBox.Show(_iServiceSanPhambus.Xoa(teamp), "Thông báo");
                _iServiceSanPhambus.GetHangfromDB();
                loaddata();
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn quay lại ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                frmTrangchu frmTrangchu = new frmTrangchu();
                this.Hide();
                frmTrangchu.Show();
            }
        }

        public byte[] ChuyenImagesangByte(Image img)
        {
            MemoryStream memory = new MemoryStream();
            img.Save(memory, ImageFormat.Png);
            return memory.ToArray();
        }
        public Image BytesangImg(byte[] b)
        {
            MemoryStream memory = new MemoryStream(b);
            return Image.FromStream(memory);
        }

        private void pic_hinhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_hinhanh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        void Timkiem(string acc)
        {
            dtw_sanpham.ColumnCount = 8;
            dtw_sanpham.Columns[0].Name = "Mã SP";
            dtw_sanpham.Columns[1].Name = "Tên SP";
            dtw_sanpham.Columns[2].Name = "Số lượng";
            dtw_sanpham.Columns[3].Name = "Đơn giá bán";
            dtw_sanpham.Columns[4].Name = "Đơn giá nhập";
            dtw_sanpham.Columns[5].Name = "Ghi chú";
            dtw_sanpham.Columns[6].Name = "Hình Ảnh";
            dtw_sanpham.Columns[7].Name = "Mã NV";
            dtw_sanpham.Rows.Clear();
            foreach (var x in _iServiceSanPhambus.TimKiem(acc))
            {
                dtw_sanpham.Rows.Add(x.MaHang, x.TenHang, x.SoLuong, x.Dgiaban, x.Dgianhap, x.GhiChu, x.Hinhanh,
                    x.MaNV);
            }

        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }

        private void dtw_sanpham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridviewComboBoxCell value is not valid.")
            {
                object value = dtw_sanpham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dtw_sanpham.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dtw_sanpham.Columns[e.ColumnIndex]).Items.Contains(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dtw_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool Check3()
            {
                string checkso = "^[0-9]+$";

                if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[0].Value?.ToString()))
                {
                    MessageBox.Show("Mã sản phẩm không được trống!", "Thông báo");
                    return false;
                }
                var masp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString()).Select(c => c.MaHang)
                    .FirstOrDefault();
                 if (dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString() == masp)
                {
                    MessageBox.Show("Trùng mã Sản Phẩm !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[1].Value?.ToString()))
                {
                    MessageBox.Show("Tên sản phẩm không được trống!", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString()))
                {
                    MessageBox.Show("Số lượng không được để trống!", "Thông báo");
                    return false;
                }
                else if (!Regex.IsMatch(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString(), checkso))
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Đơn giá bán trống !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString()))
                {
                    MessageBox.Show("Đơn giá nhập trống !", "Thông báo");
                    return false;
                }
                return true;
            }
            bool Check4()
            {
                string checkso = "^[0-9]+$";

                var masp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString()).Select(c => c.MaHang)
                    .FirstOrDefault();
                if (dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString() != masp)
                {
                    MessageBox.Show("Mã Sản Phẩm không được phép sửa !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[1].Value?.ToString()))
                {
                    MessageBox.Show("Tên sản phẩm không được trống!", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString()))
                {
                    MessageBox.Show("Số lượng không được để trống!", "Thông báo");
                    return false;
                }
                else if (!Regex.IsMatch(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value?.ToString(), checkso))
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Đơn giá bán trống !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString()))
                {
                    MessageBox.Show("Đơn giá nhập trống !", "Thông báo");
                    return false;
                }
                return true;
            }
            if (dtw_sanpham.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iServiceSanPhambus.Xoa(teamp), "Thông báo");
                    _iServiceSanPhambus.GetHangfromDB();
                    loaddata();
                }
            }
            if (dtw_sanpham.Columns[e.ColumnIndex].HeaderText == "Hình Ảnh")
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    HA.Image = Image.FromFile(open.FileName);
                    this.Text = open.FileName;
                }
            }
            if (dtw_sanpham.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                if(Check4())
                {
                    byte[] anh = ChuyenImagesangByte(HA.Image);
                    var sp = _iServiceSanPhambus.GetlsHangs().Where(c => c.MaHang == teamp).FirstOrDefault();
                    sp.MaHang = dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                    sp.TenHang = dtw_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
                    sp.SoLuong = Convert.ToInt32(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString());
                    sp.Dgiaban = float.Parse(dtw_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString());
                    sp.Dgianhap = float.Parse(dtw_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString());
                    sp.GhiChu = dtw_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
                    sp.Hinhanh = anh;
                    sp.MaNV = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == Convert.ToInt32(dtw_sanpham.Rows[e.RowIndex].Cells[7].Value.ToString()))
                    .Select(c => c.MaNV).FirstOrDefault();
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iServiceSanPhambus.Sua(sp), "Thông báo");
                    }
                }
                _iServiceSanPhambus.GetHangfromDB();
                loaddata();
            }
            if (dtw_sanpham.Columns[e.ColumnIndex].HeaderText == "Add")
            {
                if (Check3())
                {

                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        byte[] anh = ChuyenImagesangByte(HA.Image);
                        MessageBox.Show(_iServiceSanPhambus.Them(new Hang()
                        {
                            MaHang = dtw_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString(),
                            TenHang = dtw_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString(),
                            SoLuong = Convert.ToInt32(dtw_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString()),
                            Dgiaban = float.Parse(dtw_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString()),
                            Dgianhap = float.Parse(dtw_sanpham.Rows[e.RowIndex].Cells[4].Value.ToString()),
                            GhiChu = dtw_sanpham.Rows[e.RowIndex].Cells[5].Value.ToString(),
                            Hinhanh = anh,
                            MaNV = _iServiceNhanVienbus.getlistNV().Where(c =>
                                    c.MaNV == Convert.ToInt32(dtw_sanpham.Rows[e.RowIndex].Cells[7].Value))
                                .Select(c => c.MaNV).FirstOrDefault(),
                        }), "Thông báo");
                        _iServiceSanPhambus.GetHangfromDB();
                        loaddata();
                    }
                }
            }
        }
    }
}
