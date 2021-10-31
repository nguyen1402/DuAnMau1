using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmDoimatkhau : Form
    {
        private string randomCode;
        public static string code;
        public static string to;
        public static string mk;
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(99999)).ToString();
            MailMessage message = new MailMessage();
            to = (txt_email.Text).ToString();
            from = "nbui04953@gmail.com";
            pass = "16012002t";
            messageBody = "Mã làm mới mật khẩu là : " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Mã gửi lại mật khẩu ";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                if (txt_pass.Text.Length < 3)
                {
                    MessageBox.Show("Mật khẩu phải từ 3 kí tự trở lên !", "Thông báo");
                }
                else if (txt_pass.Text == txt_nhaplai.Text)
                {
                    smtp.Send(message);
                    MessageBox.Show("Nhập mã xác minh bước 2 để đổi mật khẩu !", "Thông báo");
                    mk = txt_pass.Text;
                    code = randomCode;
                    frmXacminh frmXacminh = new frmXacminh();
                    this.Hide();
                    frmXacminh.Show();
                }
                else
                {
                    MessageBox.Show("Nhập lại không khớp mật khẩu !", "Thông báo");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frmTrangchu frmTrangchu = new frmTrangchu();
            this.Hide();
            frmTrangchu.Show();
        }
    }
}
