
namespace GUI_QLBH
{
    partial class frmThongke
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
            this.dtw_thongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tonkho = new System.Windows.Forms.Button();
            this.btn_sanphamnhapkho = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_thongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtw_thongke
            // 
            this.dtw_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtw_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtw_thongke.Location = new System.Drawing.Point(18, 32);
            this.dtw_thongke.Name = "dtw_thongke";
            this.dtw_thongke.RowHeadersWidth = 51;
            this.dtw_thongke.RowTemplate.Height = 29;
            this.dtw_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtw_thongke.Size = new System.Drawing.Size(712, 293);
            this.dtw_thongke.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_tonkho);
            this.groupBox1.Controls.Add(this.btn_sanphamnhapkho);
            this.groupBox1.Location = new System.Drawing.Point(202, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng thống kê";
            // 
            // btn_tonkho
            // 
            this.btn_tonkho.BackColor = System.Drawing.SystemColors.Control;
            this.btn_tonkho.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tonkho.Location = new System.Drawing.Point(43, 77);
            this.btn_tonkho.Name = "btn_tonkho";
            this.btn_tonkho.Size = new System.Drawing.Size(174, 45);
            this.btn_tonkho.TabIndex = 0;
            this.btn_tonkho.Text = "Tồn Kho";
            this.btn_tonkho.UseVisualStyleBackColor = false;
            this.btn_tonkho.Click += new System.EventHandler(this.btn_tonkho_Click);
            // 
            // btn_sanphamnhapkho
            // 
            this.btn_sanphamnhapkho.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sanphamnhapkho.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sanphamnhapkho.Location = new System.Drawing.Point(43, 26);
            this.btn_sanphamnhapkho.Name = "btn_sanphamnhapkho";
            this.btn_sanphamnhapkho.Size = new System.Drawing.Size(199, 45);
            this.btn_sanphamnhapkho.TabIndex = 0;
            this.btn_sanphamnhapkho.Text = "Sản Phẩm Nhập Kho";
            this.btn_sanphamnhapkho.UseVisualStyleBackColor = false;
            this.btn_sanphamnhapkho.Click += new System.EventHandler(this.btn_sanphamnhapkho_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtw_thongke);
            this.groupBox2.Location = new System.Drawing.Point(39, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thống kê";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(362, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dtw_thongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtw_thongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tonkho;
        private System.Windows.Forms.Button btn_sanphamnhapkho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}