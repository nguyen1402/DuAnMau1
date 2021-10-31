
namespace GUI_QLBH
{
    partial class frmResetPass
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
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nhaplai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(134, 55);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(218, 28);
            this.txt_pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu mới";
            // 
            // btn_gui
            // 
            this.btn_gui.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gui.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_gui.Location = new System.Drawing.Point(134, 175);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(180, 51);
            this.btn_gui.TabIndex = 3;
            this.btn_gui.Text = "Đổi Mật Khẩu";
            this.btn_gui.UseVisualStyleBackColor = false;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập lại ";
            // 
            // txt_nhaplai
            // 
            this.txt_nhaplai.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nhaplai.Location = new System.Drawing.Point(134, 106);
            this.txt_nhaplai.Name = "txt_nhaplai";
            this.txt_nhaplai.Size = new System.Drawing.Size(218, 28);
            this.txt_nhaplai.TabIndex = 5;
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.txt_nhaplai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gui);
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhaplai;
    }
}