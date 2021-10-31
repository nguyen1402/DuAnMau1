using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH.Iservice;
using BUS_QLBH.Service;
using DAL_QLBH.entities;
using GUI_QLBH.Properties;

namespace GUI_QLBH
{
    public partial class frmLogin : Form
    {
        private IServiceDangnhapbus _iDangnhapbus;
        public static string email;
        public static string email2;
        public static string pass;
        private IServiceMahoabus _iMahoabus;
        private IServiceLichsubus _iLichsubus;
        public static DateTime giovao;
        public frmLogin()
        {
            InitializeComponent();
            _iDangnhapbus = new ServiceDangnhapbus();
            _iMahoabus = new ServiceMahoabus();
            _iLichsubus = new SeviceLichsu();
        }

        void AddLS()
        {
            var time = DateTime.Now;
            giovao = time;
            _iLichsubus.Add(new Lichsu()
            {
                Email = txt_email.Text,
                Lucvao = time,
                Tinhtrang = 1,
            });
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            if (_iLichsubus.getLichsus().Where(c=>c.Email == txt_email.Text).Select(c=>c.Tinhtrang).FirstOrDefault() != 1)
            {
                AddLS();
                email2 = txt_email.Text;
                frmDoimklandau frmDoimklandau = new frmDoimklandau();
                this.Hide();
                frmDoimklandau.Show();
            }
            else
            {
                AddLS();
                //email2 = txt_email.Text;
                if (_iDangnhapbus.Chuquan(txt_email.Text, _iMahoabus.GetHash(txt_matkhau.Text)))
                {
                    MessageBox.Show("Chào đại ca !", "Thông báo");
                    email = txt_email.Text;
                    pass = _iMahoabus.GetHash(txt_matkhau.Text);
                    frmTrangchu frmTrangchu = new frmTrangchu();
                    this.Hide();
                    frmTrangchu.Show();
                }
                else if (_iDangnhapbus.Nhanvien(txt_email.Text, _iMahoabus.GetHash(txt_matkhau.Text)))
                {
                    MessageBox.Show("Chào " + txt_email.Text, "Thông báo");
                    email = txt_email.Text;
                    pass = _iMahoabus.GetHash(txt_matkhau.Text);
                    frmTrangchu frmTrangchu = new frmTrangchu();
                    this.Hide();
                    frmTrangchu.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác !", "Thông báo");
                }
            }
            if (ckb_nhomatkhau.Checked == true)
            {
                Settings.Default.Pass = txt_matkhau.Text;
                Settings.Default.Save();
            }
            if (ckb_nhomatkhau.Checked == false)
            {
                Settings.Default.Pass = "";
                Settings.Default.Save();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_quenmk_Click(object sender, EventArgs e)
        {
            frmQuenmk frmQuenmk = new frmQuenmk();
            this.Hide();
            frmQuenmk.Show();
        }

        private void ck_show_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_show.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Pass != String.Empty)
            {
                txt_matkhau.Text = Properties.Settings.Default.Pass;
            }
        }
    }
}
