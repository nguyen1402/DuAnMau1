
namespace GUI_QLBH
{
    partial class frmGuimailhl
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
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_addfile = new System.Windows.Forms.Button();
            this.rtb_nd = new System.Windows.Forms.RichTextBox();
            this.btn_Gui = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.ls_email = new System.Windows.Forms.ListBox();
            this.btn_xoamail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(40, 35);
            this.txt_file.Name = "txt_file";
            this.txt_file.ReadOnly = true;
            this.txt_file.Size = new System.Drawing.Size(225, 27);
            this.txt_file.TabIndex = 0;
            // 
            // btn_addfile
            // 
            this.btn_addfile.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addfile.Location = new System.Drawing.Point(294, 29);
            this.btn_addfile.Name = "btn_addfile";
            this.btn_addfile.Size = new System.Drawing.Size(118, 38);
            this.btn_addfile.TabIndex = 1;
            this.btn_addfile.Text = "Thêm File";
            this.btn_addfile.UseVisualStyleBackColor = true;
            this.btn_addfile.Click += new System.EventHandler(this.btn_addfile_Click);
            // 
            // rtb_nd
            // 
            this.rtb_nd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_nd.Location = new System.Drawing.Point(25, 440);
            this.rtb_nd.Name = "rtb_nd";
            this.rtb_nd.Size = new System.Drawing.Size(484, 191);
            this.rtb_nd.TabIndex = 2;
            this.rtb_nd.Text = "";
            // 
            // btn_Gui
            // 
            this.btn_Gui.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gui.Location = new System.Drawing.Point(25, 647);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(118, 38);
            this.btn_Gui.TabIndex = 1;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(25, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Danh sách email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung email";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(426, 647);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(93, 37);
            this.btn_quaylai.TabIndex = 5;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // ls_email
            // 
            this.ls_email.FormattingEnabled = true;
            this.ls_email.ItemHeight = 20;
            this.ls_email.Location = new System.Drawing.Point(25, 195);
            this.ls_email.Name = "ls_email";
            this.ls_email.Size = new System.Drawing.Size(484, 204);
            this.ls_email.TabIndex = 6;
            // 
            // btn_xoamail
            // 
            this.btn_xoamail.Location = new System.Drawing.Point(395, 142);
            this.btn_xoamail.Name = "btn_xoamail";
            this.btn_xoamail.Size = new System.Drawing.Size(114, 47);
            this.btn_xoamail.TabIndex = 7;
            this.btn_xoamail.Text = "Xóa mail chọn";
            this.btn_xoamail.UseVisualStyleBackColor = true;
            this.btn_xoamail.Click += new System.EventHandler(this.btn_xoamail_Click);
            // 
            // frmGuimailhl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 697);
            this.Controls.Add(this.btn_xoamail);
            this.Controls.Add(this.ls_email);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_nd);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.btn_addfile);
            this.Controls.Add(this.txt_file);
            this.Name = "frmGuimailhl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi Mail Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button btn_addfile;
        private System.Windows.Forms.RichTextBox rtb_nd;
        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.ListBox ls_email;
        private System.Windows.Forms.Button btn_xoamail;
    }
}