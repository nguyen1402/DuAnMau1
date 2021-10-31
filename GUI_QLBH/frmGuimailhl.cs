using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH.Iservice;
using BUS_QLBH.Service;

namespace GUI_QLBH
{
    public partial class frmGuimailhl : Form
    {
        private IServiceNhanVienbus _iServiceNhanVienbus;
        private string emaills;
        private string noidung;
        private Attachment attachment = null;
        public frmGuimailhl()
        {
            InitializeComponent();
            _iServiceNhanVienbus = new ServiceNhanVienbus();
        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = open.FileName;
            }
        }

        void Guimail(string email, string noidung, Attachment file)
        {

            MailMessage mess = new MailMessage("nbui04953@gmail.com",email,"THÔNG BÁO TỪ PHẦN MỀM BÁN HÀNG",noidung);
            if (attachment != null)
            {
                mess.Attachments.Add(attachment);
            }

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("nbui04953@gmail.com", "16012002t");
            client.Send(mess);
        }
        private void btn_Gui_Click(object sender, EventArgs e)
        {
            noidung = rtb_nd.Text;
            attachment = null;
            try
            {
                FileInfo file = new FileInfo(txt_file.Text);
                attachment = new Attachment(txt_file.Text);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("File rỗng", "Thông báo");
            }
            string email;
            for (int i = 0; i < ls_email.Items.Count; i++)
            {
                email = (string)ls_email.Items[i];
                Guimail(email, noidung, attachment);
            }
            MessageBox.Show("Gửi thành công !", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _iServiceNhanVienbus.getlistNV().Count; i++)
            {
                emaills = (from x in _iServiceNhanVienbus.getlistNV()
                    select x.Email).ElementAt(i);
                ls_email.Items.Add(emaills);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn quay lại ?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmTrangchu frmTrangchu = new frmTrangchu();
                this.Hide();
                frmTrangchu.Show();
            }
        }

        private void btn_xoamail_Click(object sender, EventArgs e)
        {
            if (ls_email.SelectedIndex != -1)
            {
                ls_email.Items.RemoveAt(ls_email.SelectedIndex);
            }
        }

    }
}
