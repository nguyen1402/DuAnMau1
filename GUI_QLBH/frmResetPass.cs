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
using DAL_QLBH.DalIService;

namespace GUI_QLBH
{
    public partial class frmResetPass : Form
    {
        private string email = frmQuenmk.to;
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private IServiceMahoabus _iMahoabus;
        public frmResetPass()
        {
            InitializeComponent();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            _iMahoabus = new ServiceMahoabus();
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
                _iServiceNhanVienbus.Sua(nv);
                MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo");
                frmLogin frmLogin = new frmLogin();
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Nhập lại không đúng !", "Thông báo");
            }
        }
    }
}
