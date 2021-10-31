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

namespace GUI_QLBH
{
    public partial class frmXacminh : Form
    {
        private string email = frmDoimatkhau.to;
        private string pass = frmDoimatkhau.mk;
        private string randam = frmDoimatkhau.code;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private IServiceMahoabus _iMahoabus;
        public frmXacminh()
        {
            InitializeComponent();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            _iMahoabus = new ServiceMahoabus();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
            frmDoimatkhau frmDoimatkhau = new frmDoimatkhau();
            this.Hide();
            frmDoimatkhau.Show();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (randam == txt_macode.Text)
            {
                var nv = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == email).FirstOrDefault();
                nv.Matkhau = _iMahoabus.GetHash(pass);
                _iServiceNhanVienbus.Sua(nv);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Mã xác minh không đúng !", "Thông báo");
            }
        }
    }
}
