
namespace GUI_QLBH
{
    partial class frmLichsu
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
            this.dtw_lichsu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_lichsu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtw_lichsu
            // 
            this.dtw_lichsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtw_lichsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtw_lichsu.Location = new System.Drawing.Point(8, 131);
            this.dtw_lichsu.Name = "dtw_lichsu";
            this.dtw_lichsu.RowHeadersWidth = 51;
            this.dtw_lichsu.RowTemplate.Height = 29;
            this.dtw_lichsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtw_lichsu.Size = new System.Drawing.Size(823, 508);
            this.dtw_lichsu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG THÔNG TIN LỊCH SỬ";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_quaylai.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_quaylai.Location = new System.Drawing.Point(714, 69);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(94, 39);
            this.btn_quaylai.TabIndex = 2;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // frmLichsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 642);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtw_lichsu);
            this.Name = "frmLichsu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử";
            ((System.ComponentModel.ISupportInitialize)(this.dtw_lichsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtw_lichsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quaylai;
    }
}