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
using DAL_QLBH.entities;

namespace GUI_QLBH
{
    public partial class frmTrangchu : Form
    {
        private IServiceDangnhapbus _iDangnhapbus;
        private IServiceLichsubus _lichsubus;
        private string email = frmLogin.email;
        private string pass = frmLogin.pass;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        public frmTrangchu()
        {
            InitializeComponent();
            _iDangnhapbus = new ServiceDangnhapbus();
            _lichsubus = new SeviceLichsu();
            if (!_iDangnhapbus.Chuquan(email,pass))
            {
                nhânViênToolStripMenuItem.Visible = false;
                lịchSửĐăngNhậpToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                gửiMailNhânViênToolStripMenuItem.Visible = false;
            }

            _iServiceNhanVienbus = new ServiceNhanVienbus();
            var ten = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == email).Select(c => c.TenNV)
                .FirstOrDefault();
            lb_chao.Text = "Xin chào : " + ten;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            this.Hide();
            frmNhanVien.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            this.Hide();
            frmSanPham.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang frmKhachhang = new frmKhachhang();
            this.Hide();
            frmKhachhang.Show();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn trở về form login không ?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var time = DateTime.Now;
                var email2 = _lichsubus.getLichsus().Where(c => c.id == _lichsubus.getLichsus().Max(c => c.id)).Select(c => c.Email).First();
                var idFirst = _lichsubus.getLichsus().Where(c => c.id == _lichsubus.getLichsus().Max(c => c.id)).Select(c => c.id).First();
                var ls = _lichsubus.getLichsus().Where(c => c.Email == email2 && c.id == idFirst).FirstOrDefault();
                ls.Lucra = time;
                _lichsubus.Update(ls);
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.Show();
            }
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau frmDoimatkhau = new frmDoimatkhau();
            this.Hide();
            frmDoimatkhau.Show();
        }

        private void lịchSửĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichsu frmLichsu = new frmLichsu();
            this.Hide();
            frmLichsu.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo",
                    MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var time = DateTime.Now;
                var email2 = _lichsubus.getLichsus().Where(c => c.id == _lichsubus.getLichsus().Max(c => c.id))
                    .Select(c => c.Email).First();
                var idFirst = _lichsubus.getLichsus().Where(c => c.id == _lichsubus.getLichsus().Max(c => c.id))
                    .Select(c => c.id).First();
                var ls = _lichsubus.getLichsus().Where(c => c.Email == email2 && c.id == idFirst).FirstOrDefault();
                ls.Lucra = time;
                _lichsubus.Update(ls);
                Application.Exit();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke frmThongke = new frmThongke();
            this.Hide();
            frmThongke.Show();
        }

        private void gửiMailNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuimailhl frmGuimailhl = new frmGuimailhl();
            this.Hide();
            frmGuimailhl.Show();
        }
    }
}
