using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH.Iservice;
using BUS_QLBH.Service;

namespace GUI_QLBH
{
    public partial class frmLichsu : Form
    {
        private IServiceLichsubus _lichsubus;
        public frmLichsu()
        {
            InitializeComponent();
            _lichsubus = new SeviceLichsu();
            loaddata();
        }

        void loaddata()
        {
            dtw_lichsu.ColumnCount = 3;
            dtw_lichsu.Columns[0].Name = "Email";
            dtw_lichsu.Columns[1].Name = "Thời gian vào";
            dtw_lichsu.Columns[2].Name = "Thời gian ra";
            dtw_lichsu.Rows.Clear();
            foreach (var x in _lichsubus.getLichsus())
            {
                dtw_lichsu.Rows.Add(x.Email, x.Lucvao, x.Lucra);
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
