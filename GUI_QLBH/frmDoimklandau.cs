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
    public partial class frmDoimklandau : Form
    {
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private IServiceMahoabus _iMahoabus;
        private string email = frmLogin.email2;
        public frmDoimklandau()
        {
            InitializeComponent();
            _iMahoabus = new ServiceMahoabus();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải từ 3 kí tự trở lên !", "Thông báo");
            }
            else if (txt_pass.Text == txt_nhaplai.Text)
            {
                var nv = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == email).FirstOrDefault();
                nv.Matkhau = _iMahoabus.GetHash(txt_pass.Text);
                MessageBox.Show(_iServiceNhanVienbus.Sua(nv), "Thông báo");
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập lại mật khẩu không chính xác !", "Thông báo");
            }
        }
    }
}
