
namespace GUI_QLBH
{
    partial class frmSanPham
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtw_sanpham = new System.Windows.Forms.DataGridView();
            this.MSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HA = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_hinhanh = new System.Windows.Forms.PictureBox();
            this.cbb_manv = new System.Windows.Forms.ComboBox();
            this.txt_dongiaban = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_dongianhap = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_sanpham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtw_sanpham);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(17, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1115, 524);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu sản phẩm";
            // 
            // dtw_sanpham
            // 
            this.dtw_sanpham.AllowUserToResizeColumns = false;
            this.dtw_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtw_sanpham.ColumnHeadersHeight = 29;
            this.dtw_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSP,
            this.TSP,
            this.SL,
            this.DGB,
            this.DGN,
            this.GC,
            this.HA,
            this.MaNV});
            this.dtw_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtw_sanpham.Location = new System.Drawing.Point(3, 24);
            this.dtw_sanpham.Name = "dtw_sanpham";
            this.dtw_sanpham.RowHeadersWidth = 51;
            this.dtw_sanpham.RowTemplate.Height = 150;
            this.dtw_sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtw_sanpham.Size = new System.Drawing.Size(1109, 497);
            this.dtw_sanpham.TabIndex = 82;
            this.dtw_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtw_sanpham_CellClick);
            this.dtw_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtw_sanpham_CellContentClick);
            this.dtw_sanpham.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtw_sanpham_DataError);
            // 
            // MSP
            // 
            this.MSP.FillWeight = 95.95111F;
            this.MSP.HeaderText = "Mã Sản Phẩm";
            this.MSP.MinimumWidth = 6;
            this.MSP.Name = "MSP";
            // 
            // TSP
            // 
            this.TSP.FillWeight = 95.95111F;
            this.TSP.HeaderText = "Tên Sản Phẩm";
            this.TSP.MinimumWidth = 6;
            this.TSP.Name = "TSP";
            // 
            // SL
            // 
            this.SL.FillWeight = 95.95111F;
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // DGB
            // 
            this.DGB.FillWeight = 95.95111F;
            this.DGB.HeaderText = "Đơn Giá Bán";
            this.DGB.MinimumWidth = 6;
            this.DGB.Name = "DGB";
            // 
            // DGN
            // 
            this.DGN.FillWeight = 95.95111F;
            this.DGN.HeaderText = "Đơn Giá Nhập";
            this.DGN.MinimumWidth = 6;
            this.DGN.Name = "DGN";
            // 
            // GC
            // 
            this.GC.FillWeight = 95.95111F;
            this.GC.HeaderText = "Ghi Chú";
            this.GC.MinimumWidth = 6;
            this.GC.Name = "GC";
            // 
            // HA
            // 
            this.HA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HA.FillWeight = 128.3423F;
            this.HA.HeaderText = "Hình Ảnh";
            this.HA.MinimumWidth = 6;
            this.HA.Name = "HA";
            this.HA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 95.95111F;
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(699, 26);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(217, 28);
            this.txt_timkiem.TabIndex = 81;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_quaylai);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(17, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 102);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_quaylai.Location = new System.Drawing.Point(565, 35);
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
            this.btn_xoa.Location = new System.Drawing.Point(426, 35);
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
            this.btn_sua.Location = new System.Drawing.Point(273, 35);
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
            this.btn_them.Location = new System.Drawing.Point(128, 35);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 51);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_hinhanh);
            this.groupBox1.Controls.Add(this.cbb_manv);
            this.groupBox1.Controls.Add(this.txt_dongiaban);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_dongianhap);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_masp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 205);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // pic_hinhanh
            // 
            this.pic_hinhanh.Location = new System.Drawing.Point(735, 47);
            this.pic_hinhanh.Name = "pic_hinhanh";
            this.pic_hinhanh.Size = new System.Drawing.Size(163, 125);
            this.pic_hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_hinhanh.TabIndex = 83;
            this.pic_hinhanh.TabStop = false;
            this.pic_hinhanh.Click += new System.EventHandler(this.pic_hinhanh_Click);
            // 
            // cbb_manv
            // 
            this.cbb_manv.FormattingEnabled = true;
            this.cbb_manv.Location = new System.Drawing.Point(486, 120);
            this.cbb_manv.Name = "cbb_manv";
            this.cbb_manv.Size = new System.Drawing.Size(158, 28);
            this.cbb_manv.TabIndex = 82;
            // 
            // txt_dongiaban
            // 
            this.txt_dongiaban.Location = new System.Drawing.Point(142, 171);
            this.txt_dongiaban.Name = "txt_dongiaban";
            this.txt_dongiaban.Size = new System.Drawing.Size(183, 28);
            this.txt_dongiaban.TabIndex = 81;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(486, 79);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(183, 28);
            this.txt_ghichu.TabIndex = 78;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(142, 120);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(183, 28);
            this.txt_soluong.TabIndex = 80;
            // 
            // txt_dongianhap
            // 
            this.txt_dongianhap.Location = new System.Drawing.Point(486, 34);
            this.txt_dongianhap.Name = "txt_dongianhap";
            this.txt_dongianhap.Size = new System.Drawing.Size(183, 28);
            this.txt_dongianhap.TabIndex = 79;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(142, 79);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(183, 28);
            this.txt_tensp.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "MaNV";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(142, 34);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(183, 28);
            this.txt_masp.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Đơn giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Hình ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Tên SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Đơn giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã SP:";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(266, 151);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_sanpham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtw_sanpham;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_dongiaban;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_dongianhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_hinhanh;
        private System.Windows.Forms.ComboBox cbb_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GC;
        private System.Windows.Forms.DataGridViewImageColumn HA;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
    }
}