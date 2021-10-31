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

namespace GUI_QLBH
{
    public partial class frmNhanVien : Form
    {
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private IServiceMahoabus _iMahoabus;
        private int teamp;
        public frmNhanVien()
        {
            InitializeComponent();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            _iMahoabus = new ServiceMahoabus();
            ck_chuquan.Checked = true;
            rd_hd.Checked = true;
            Loaddata();
            VT.Items.Add("Chủ quán");
            VT.Items.Add("Nhân Viên");
            TT.Items.Add("Hoạt động");
            TT.Items.Add("Không hoạt động");

        }

        bool Checkmk(string txt)
        {
            var mk = _iServiceNhanVienbus.getlistNV().Where(c => c.Matkhau == txt_mk.Text).Select(c => c.Matkhau)
                .FirstOrDefault();
            if (mk == txt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Check()
        {
            var emailt = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == teamp).Select(c => c.Email).FirstOrDefault();
            string email = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                txt_email.BackColor = Color.IndianRed;
                MessageBox.Show(" Email đang trống !", "Thông báo");
                txt_email.BackColor = Color.White;
                txt_email.Focus();
                return false;
            }
            else if (txt_email.Text == emailt)
            {
                txt_email.BackColor = Color.IndianRed;
                MessageBox.Show(" Email trùng !", "Thông báo");
                txt_email.BackColor = Color.White;
                txt_email.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txt_email.Text, email))
            {
                txt_email.BackColor = Color.IndianRed;
                MessageBox.Show(" Email không hợp lệ !", "Thông báo");
                txt_email.BackColor = Color.White;
                txt_email.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_mk.Text))
            {
                txt_mk.BackColor = Color.IndianRed;
                MessageBox.Show("Mật khẩu không được trống", "Thông báo");
                txt_mk.BackColor = Color.White;
                txt_mk.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_tennv.Text))
            {
                txt_tennv.BackColor = Color.IndianRed;
                MessageBox.Show("Tên không được trống", "Thông báo");
                txt_tennv.BackColor = Color.White;
                txt_tennv.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_diaChi.Text))
            {
                txt_diaChi.BackColor = Color.IndianRed;
                MessageBox.Show("Địa chỉ không được trống", "Thông báo");
                txt_diaChi.BackColor = Color.White;
                txt_diaChi.Focus();
                return false;
            }
            return true;
        }
        bool Checks()
        {
            var emailt = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == txt_email.Text).Select(c => c.Email)
                .FirstOrDefault();
            if (txt_email.Text != emailt)
            {
                txt_email.BackColor = Color.IndianRed;
                MessageBox.Show(" Email không được phép sửa !", "Thông báo");
                txt_email.BackColor = Color.White;
                txt_email.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_mk.Text))
            {
                txt_mk.BackColor = Color.IndianRed;
                MessageBox.Show("Mật khẩu không được trống", "Thông báo");
                txt_mk.BackColor = Color.White;
                txt_mk.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_tennv.Text))
            {
                txt_tennv.BackColor = Color.IndianRed;
                MessageBox.Show("Tên không được trống", "Thông báo");
                txt_tennv.BackColor = Color.White;
                txt_tennv.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_diaChi.Text))
            {
                txt_diaChi.BackColor = Color.IndianRed;
                MessageBox.Show("Địa chỉ không được trống", "Thông báo");
                txt_diaChi.BackColor = Color.White;
                txt_diaChi.Focus();
                return false;
            }
            return true;
        }
        void Loaddata()
        {

            dtw_nhanvien.ColumnCount = 7;
            //dtw_nhanvien.Columns[0].Name = "Email";
            //dtw_nhanvien.Columns[1].Name = "Tên Nhân Viên";
            //dtw_nhanvien.Columns[2].Name = "Địa chỉ";
            //dtw_nhanvien.Columns[3].Name = "Vai trò";
            //dtw_nhanvien.Columns[4].Name = "Tình trạng";
            dtw_nhanvien.Columns[5].Name = "Mật Khẩu";
            //dtw_nhanvien.Columns[5].Visible = false;
            dtw_nhanvien.Columns[6].Name = "MaNV";
            dtw_nhanvien.Columns[6].Visible = false;
            dtw_nhanvien.Rows.Clear();
            foreach (var x in _iServiceNhanVienbus.getlistNV())
            {
                dtw_nhanvien.Rows.Add(x.Email, x.TenNV, x.DiaChi, x.vaitro == 0 ? "Chủ Quán" : "Nhân Viên"
                    , x.Tinhtrang == true ? "Hoạt động" : "Không hoạt động", x.Matkhau, x.MaNV);
            }
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dtw_nhanvien.Columns.Add(btn);
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Add";
            btn1.Text = "Add";
            btn1.UseColumnTextForButtonValue = true;
            dtw_nhanvien.Columns.Add(btn1);
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Update";
            btn2.Text = "Update";
            btn2.UseColumnTextForButtonValue = true;
            dtw_nhanvien.Columns.Add(btn2);
        }
        private void dtw_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[3].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[4].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value?.ToString()))
            {
                return;
            }
            if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[6].Value?.ToString()))
            {
                return;
            }
            if (e.RowIndex == _iServiceNhanVienbus.getlistNV().Count || e.RowIndex == -1) return;
            txt_email.Text = dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tennv.Text = dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_diaChi.Text = dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            ck_chuquan.Checked = dtw_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Chủ Quán";
            ck_nhanvien.Checked = dtw_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nhân Viên";
            rd_hd.Checked = dtw_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Hoạt động";
            rd_khd.Checked = dtw_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Không hoạt động";
            txt_mk.PasswordChar = '*';
            txt_mk.Text = dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            teamp = Convert.ToInt32(dtw_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString());

        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                var add = _iServiceNhanVienbus.NhanVien(txt_email.Text, txt_tennv.Text, txt_diaChi.Text,
                    ck_chuquan.Checked ? 0 : 1, rd_hd.Checked, _iMahoabus.GetHash(txt_mk.Text));
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iServiceNhanVienbus.Them(add), "Thông báo");
                    _iServiceNhanVienbus.getlistDB();
                }

                Loaddata();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (Checks())
            {
                var nv = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == teamp).FirstOrDefault();
                nv.Email = txt_email.Text;
                nv.TenNV = txt_tennv.Text;
                nv.DiaChi = txt_diaChi.Text;
                nv.vaitro = ck_chuquan.Checked ? 0 : 1;
                nv.Tinhtrang = rd_hd.Checked;
                if (Checkmk(txt_mk.Text))
                {
                    nv.Matkhau = nv.Matkhau;
                }
                else
                {
                    nv.Matkhau = _iMahoabus.GetHash(txt_mk.Text);
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iServiceNhanVienbus.Sua(nv), "Thông báo");
                    _iServiceNhanVienbus.getlistDB();
                }

                Loaddata();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                MessageBox.Show(_iServiceNhanVienbus.Xoa(teamp), "Thông báo");
                _iServiceNhanVienbus.getlistDB();
            }
            Loaddata();
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
            dtw_nhanvien.ColumnCount = 7;
            dtw_nhanvien.Columns[0].Name = "Email";
            dtw_nhanvien.Columns[1].Name = "Tên Nhân Viên";
            dtw_nhanvien.Columns[2].Name = "Địa chỉ";
            dtw_nhanvien.Columns[3].Name = "Vai trò";
            dtw_nhanvien.Columns[4].Name = "Tình trạng";
            dtw_nhanvien.Columns[5].Name = "Mật Khẩu";
            dtw_nhanvien.Columns[6].Name = "MaNV";
            dtw_nhanvien.Columns[6].Visible = false;
            dtw_nhanvien.Rows.Clear();
            foreach (var x in _iServiceNhanVienbus.TimKiem(acc))
            {
                dtw_nhanvien.Rows.Add(x.Email, x.TenNV, x.DiaChi, x.vaitro == 0 ? "Chủ Quán" : "Nhân Viên"
                    , x.Tinhtrang == true ? "Hoạt động" : "Không hoạt động", x.Matkhau, x.MaNV);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txt_timkiem.Text);
        }

        private void ck_nhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_nhanvien.Checked)
            {
                ck_chuquan.Checked = false;
            }
        }

        private void ck_chuquan_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_chuquan.Checked)
            {
                ck_nhanvien.Checked = false;
            }
        }

        private void dtw_nhanvien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridviewComboBoxCell value is not valid.")
            {
                object value = dtw_nhanvien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dtw_nhanvien.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dtw_nhanvien.Columns[e.ColumnIndex]).Items.Contains(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dtw_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool Checkmk2(string txt)
            {
                var mk = _iServiceNhanVienbus.getlistNV().Where(c => c.Matkhau == dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value?.ToString()).Select(c => c.Matkhau)
                    .FirstOrDefault();
                if (mk == txt)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            bool Check3()
            {
                string email = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value?.ToString()))
                {
                    MessageBox.Show(" Email đang trống !", "Thông báo");
                    return false;
                }
                var emailt = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == teamp).Select(c => c.Email).FirstOrDefault();
                if (dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value?.ToString() == emailt)
                {
                    MessageBox.Show(" Email trùng !", "Thông báo");
                    return false;
                }
                else if (!Regex.IsMatch(dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value?.ToString(), email))
                {
                    MessageBox.Show(" Email không hợp lệ !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value?.ToString()))
                {
                    MessageBox.Show("Mật khẩu không được trống", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value?.ToString()))
                {
                    MessageBox.Show("Tên không được trống", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    MessageBox.Show("Địa chỉ không được trống", "Thông báo");
                    return false;
                }
                return true;
            }
            bool Check4()
            {
                var emailt = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == teamp).Select(c => c.Email).FirstOrDefault();
                if (dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value?.ToString() != emailt)
                {
                    MessageBox.Show(" Không được sửa email !", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value?.ToString()))
                {
                    MessageBox.Show("Mật khẩu không được trống", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value?.ToString()))
                {
                    MessageBox.Show("Tên không được trống", "Thông báo");
                    return false;
                }
                else if (string.IsNullOrEmpty(dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    MessageBox.Show("Địa chỉ không được trống", "Thông báo");
                    return false;
                }
                return true;
            }
            if (dtw_nhanvien.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_iServiceNhanVienbus.Xoa(teamp), "Thông báo");
                    _iServiceNhanVienbus.getlistDB();
                    Loaddata();
                }
            }
            if (dtw_nhanvien.Columns[e.ColumnIndex].HeaderText == "Add")
            {

                if (Check3())
                {
                    var add = _iServiceNhanVienbus.NhanVien(dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString(), dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString(), dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        dtw_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Chủ quán" ? 0 : 1, dtw_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Hoạt động", _iMahoabus.GetHash(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iServiceNhanVienbus.Them(add), "Thông báo");
                        _iServiceNhanVienbus.getlistDB();
                    }
                    Loaddata();
                }
            }
            if (dtw_nhanvien.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                if (Check4())
                {
                    var nv = _iServiceNhanVienbus.getlistNV().Where(c => c.MaNV == teamp).FirstOrDefault();
                    nv.Email = dtw_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    nv.TenNV = dtw_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    nv.DiaChi = dtw_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    nv.vaitro = dtw_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Chủ quán" ? 0 : 1;
                    nv.Tinhtrang = dtw_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Hoạt động";
                    if (Checkmk2(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString()))
                    {
                        nv.Matkhau = nv.Matkhau;
                    }
                    else
                    {
                        nv.Matkhau = _iMahoabus.GetHash(dtw_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString());
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_iServiceNhanVienbus.Sua(nv), "Thông báo");
                        _iServiceNhanVienbus.getlistDB();
                        Loaddata();
                    }
                }
            }
        }
    }
}
