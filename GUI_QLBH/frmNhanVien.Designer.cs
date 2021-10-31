
namespace GUI_QLBH
{
    partial class frmNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ck_chuquan = new System.Windows.Forms.CheckBox();
            this.ck_nhanvien = new System.Windows.Forms.CheckBox();
            this.rd_khd = new System.Windows.Forms.RadioButton();
            this.rd_hd = new System.Windows.Forms.RadioButton();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtw_nhanvien = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // ck_chuquan
            // 
            this.ck_chuquan.AutoSize = true;
            this.ck_chuquan.Location = new System.Drawing.Point(317, 144);
            this.ck_chuquan.Name = "ck_chuquan";
            this.ck_chuquan.Size = new System.Drawing.Size(97, 24);
            this.ck_chuquan.TabIndex = 85;
            this.ck_chuquan.Text = "Chủ Quán";
            this.ck_chuquan.UseVisualStyleBackColor = true;
            this.ck_chuquan.CheckedChanged += new System.EventHandler(this.ck_chuquan_CheckedChanged);
            // 
            // ck_nhanvien
            // 
            this.ck_nhanvien.AutoSize = true;
            this.ck_nhanvien.Location = new System.Drawing.Point(199, 144);
            this.ck_nhanvien.Name = "ck_nhanvien";
            this.ck_nhanvien.Size = new System.Drawing.Size(101, 24);
            this.ck_nhanvien.TabIndex = 84;
            this.ck_nhanvien.Text = "Nhân Viên";
            this.ck_nhanvien.UseVisualStyleBackColor = true;
            this.ck_nhanvien.CheckedChanged += new System.EventHandler(this.ck_nhanvien_CheckedChanged);
            // 
            // rd_khd
            // 
            this.rd_khd.AutoSize = true;
            this.rd_khd.Location = new System.Drawing.Point(723, 147);
            this.rd_khd.Name = "rd_khd";
            this.rd_khd.Size = new System.Drawing.Size(150, 24);
            this.rd_khd.TabIndex = 83;
            this.rd_khd.TabStop = true;
            this.rd_khd.Text = "Không Hoạt Động";
            this.rd_khd.UseVisualStyleBackColor = true;
            // 
            // rd_hd
            // 
            this.rd_hd.AutoSize = true;
            this.rd_hd.Location = new System.Drawing.Point(599, 146);
            this.rd_hd.Name = "rd_hd";
            this.rd_hd.Size = new System.Drawing.Size(105, 24);
            this.rd_hd.TabIndex = 82;
            this.rd_hd.TabStop = true;
            this.rd_hd.Text = "Hoạt Động";
            this.rd_hd.UseVisualStyleBackColor = true;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(601, 94);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(217, 28);
            this.txt_diaChi.TabIndex = 81;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(601, 43);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(217, 28);
            this.txt_tennv.TabIndex = 80;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(198, 94);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(183, 28);
            this.txt_mk.TabIndex = 78;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(198, 49);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 28);
            this.txt_email.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Vai Trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Tình Trạng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ck_chuquan);
            this.groupBox1.Controls.Add(this.ck_nhanvien);
            this.groupBox1.Controls.Add(this.rd_khd);
            this.groupBox1.Controls.Add(this.rd_hd);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 205);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_quaylai);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(21, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 102);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_quaylai.Location = new System.Drawing.Point(623, 27);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(116, 51);
            this.btn_quaylai.TabIndex = 0;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(484, 27);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 51);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(331, 27);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 51);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(186, 27);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 51);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtw_nhanvien);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(21, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 366);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu nhân viên";
            // 
            // dtw_nhanvien
            // 
            this.dtw_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtw_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtw_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.TNV,
            this.DC,
            this.VT,
            this.TT});
            this.dtw_nhanvien.Location = new System.Drawing.Point(0, 60);
            this.dtw_nhanvien.Name = "dtw_nhanvien";
            this.dtw_nhanvien.RowHeadersWidth = 51;
            this.dtw_nhanvien.RowTemplate.Height = 29;
            this.dtw_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtw_nhanvien.Size = new System.Drawing.Size(985, 286);
            this.dtw_nhanvien.TabIndex = 82;
            this.dtw_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtw_nhanvien_CellClick);
            this.dtw_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtw_nhanvien_CellContentClick);
            this.dtw_nhanvien.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtw_nhanvien_DataError);
            // 
            // Email
            // 
            this.Email.FillWeight = 78.61646F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // TNV
            // 
            this.TNV.FillWeight = 78.61646F;
            this.TNV.HeaderText = "Tên Nhân Viên";
            this.TNV.MinimumWidth = 6;
            this.TNV.Name = "TNV";
            // 
            // DC
            // 
            this.DC.FillWeight = 78.61646F;
            this.DC.HeaderText = "Địa Chỉ";
            this.DC.MinimumWidth = 6;
            this.DC.Name = "DC";
            // 
            // VT
            // 
            this.VT.FillWeight = 112.2995F;
            this.VT.HeaderText = "Vai Trò";
            this.VT.MinimumWidth = 6;
            this.VT.Name = "VT";
            this.VT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TT
            // 
            this.TT.FillWeight = 151.8512F;
            this.TT.HeaderText = "Tình Trạng";
            this.TT.MinimumWidth = 6;
            this.TT.Name = "TT";
            this.TT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(699, 26);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(217, 28);
            this.txt_timkiem.TabIndex = 81;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Tìm kiếm :";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 728);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ck_chuquan;
        private System.Windows.Forms.CheckBox ck_nhanvien;
        private System.Windows.Forms.RadioButton rd_khd;
        private System.Windows.Forms.RadioButton rd_hd;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtw_nhanvien;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewComboBoxColumn VT;
        private System.Windows.Forms.DataGridViewComboBoxColumn TT;
    }
}

