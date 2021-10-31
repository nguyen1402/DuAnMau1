
namespace GUI_QLBH
{
    partial class frmQuenmk
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
            this.btn_gui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_macode = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gui
            // 
            this.btn_gui.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_gui.Location = new System.Drawing.Point(162, 113);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(108, 51);
            this.btn_gui.TabIndex = 0;
            this.btn_gui.Text = "Gửi";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(134, 69);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(184, 28);
            this.txt_email.TabIndex = 2;
            // 
            // txt_macode
            // 
            this.txt_macode.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_macode.Location = new System.Drawing.Point(134, 200);
            this.txt_macode.Name = "txt_macode";
            this.txt_macode.Size = new System.Drawing.Size(184, 28);
            this.txt_macode.TabIndex = 2;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xacnhan.Location = new System.Drawing.Point(172, 249);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(108, 51);
            this.btn_xacnhan.TabIndex = 0;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_quaylai.Location = new System.Drawing.Point(310, 326);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(108, 51);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Code";
            // 
            // frmQuenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 414);
            this.Controls.Add(this.txt_macode);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.btn_gui);
            this.Name = "frmQuenmk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_macode;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Label label2;
    }
}