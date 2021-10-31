using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH.Iservice;
using BUS_QLBH.Service;

namespace GUI_QLBH
{
    public partial class frmThongke : Form
    {
        private IServiceSanPhambus _iServiceSanPhambus;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        public frmThongke()
        {
            InitializeComponent();
            _iServiceSanPhambus = new ServiceSanPhambus();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
        }
        private void btn_sanphamnhapkho_Click(object sender, EventArgs e)
        {
            var kq = (from a in _iServiceSanPhambus.GetlsHangs()
                join b in _iServiceNhanVienbus.getlistNV() on a.MaNV equals b.MaNV
                select new
                {
                    MaNV = a.MaNV,
                    TenNV = b.TenNV,
                    TenSP = a.TenHang,
                    SoLuong = a.SoLuong,
                }).ToList();
            //var lskq = kq.GroupBy(c => c.MaNV).Select(g => new
            //{
            //    g.Key,
            //    g.Where(c => c.MaNV = g.Key).Select(c => c.TenNV).FirstOrDefault(),
            //    g.Where(c => c.MaNV == g.Key).Select(c => c.TenSP).FirstOrDefault(),
            //    g.Sum(c => c.SoLuong)
            //}).ToList();
            dtw_thongke.ColumnCount = 4;
            dtw_thongke.Columns[0].Name = "Mã Nhân Viên";
            dtw_thongke.Columns[1].Name = "Tên Nhân Viên";
            dtw_thongke.Columns[2].Name = "Tên Sản Phẩm";
            dtw_thongke.Columns[3].Name = "Số Lượng";
            dtw_thongke.Rows.Clear();
            foreach (var x in kq)
            {
                dtw_thongke.Rows.Add(x.MaNV, x.TenNV, x.TenSP, x.SoLuong);
            }
        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            dtw_thongke.ColumnCount = 3;
            dtw_thongke.Columns[0].Name = "Mã Sản Phẩm";
            dtw_thongke.Columns[1].Name = "Tên Sản Phẩm";
            dtw_thongke.Columns[2].Name = "Tồn Kho";
            dtw_thongke.Rows.Clear();
            foreach (var x in _iServiceSanPhambus.GetlsHangs())
            {
                dtw_thongke.Rows.Add(x.MaHang, x.TenHang, x.SoLuong);
            }
            _iServiceSanPhambus.GetHangfromDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTrangchu frmTrangchu = new frmTrangchu();
            this.Hide();
            frmTrangchu.Show();
        }
    }
}
