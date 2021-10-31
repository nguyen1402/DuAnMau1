
namespace GUI_QLBH
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_nhomatkhau = new System.Windows.Forms.CheckBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lb_quenmk = new System.Windows.Forms.Label();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.ck_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐĂNG NHẬP CỬA HÀNG";
            // 
            // ckb_nhomatkhau
            // 
            this.ckb_nhomatkhau.AutoSize = true;
            this.ckb_nhomatkhau.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckb_nhomatkhau.Location = new System.Drawing.Point(88, 214);
            this.ckb_nhomatkhau.Name = "ckb_nhomatkhau";
            this.ckb_nhomatkhau.Size = new System.Drawing.Size(156, 28);
            this.ckb_nhomatkhau.TabIndex = 1;
            this.ckb_nhomatkhau.Text = "Nhớ mật khẩu ?";
            this.ckb_nhomatkhau.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(146, 99);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(228, 31);
            this.txt_email.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_matkhau.Location = new System.Drawing.Point(146, 145);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(228, 31);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // lb_quenmk
            // 
            this.lb_quenmk.AutoSize = true;
            this.lb_quenmk.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_quenmk.Location = new System.Drawing.Point(299, 218);
            this.lb_quenmk.Name = "lb_quenmk";
            this.lb_quenmk.Size = new System.Drawing.Size(145, 24);
            this.lb_quenmk.TabIndex = 0;
            this.lb_quenmk.Text = "Quên mật khẩu ?";
            this.lb_quenmk.Click += new System.EventHandler(this.lb_quenmk_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dangnhap.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dangnhap.Location = new System.Drawing.Point(98, 297);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(149, 48);
            this.btn_dangnhap.TabIndex = 3;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoat.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.Location = new System.Drawing.Point(278, 297);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(149, 48);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // ck_show
            // 
            this.ck_show.AutoSize = true;
            this.ck_show.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ck_show.Location = new System.Drawing.Point(393, 145);
            this.ck_show.Name = "ck_show";
            this.ck_show.Size = new System.Drawing.Size(115, 28);
            this.ck_show.TabIndex = 1;
            this.ck_show.Text = "Show Pass";
            this.ck_show.UseVisualStyleBackColor = true;
            this.ck_show.CheckedChanged += new System.EventHandler(this.ck_show_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 387);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.ck_show);
            this.Controls.Add(this.ckb_nhomatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_quenmk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckb_nhomatkhau;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lb_quenmk;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox ck_show;
    }
}