using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBH
{
    public partial class frmQuenmk : Form
    {
        private string randomCode;
        public static string to;
        public frmQuenmk()
        {
            InitializeComponent();
        }
        bool Check()
        {
            string email = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(txt_email.Text, email))
            {
                MessageBox.Show("Email nhập không hợp lệ !", "Thông báo");
                txt_email.Focus();
                return false;
            }

            return true;
        }
        private void btn_gui_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(99999)).ToString();
                MailMessage message = new MailMessage();
                to = txt_email.Text;
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
                    smtp.Send(message);
                    MessageBox.Show("Mã xác minh gửi thành công", "Thông báo");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (randomCode == txt_macode.Text)
            {
                to = txt_email.Text;
                frmResetPass frmResetPass = new frmResetPass();
                this.Hide();
                frmResetPass.Show();
            }
            else
            {
                MessageBox.Show("Mã xác minh sai !");
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
