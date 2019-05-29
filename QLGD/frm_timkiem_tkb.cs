using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGD
{
    public partial class frm_timkiem_tkb : Form
    {
        public frm_timkiem_tkb()
        {
            InitializeComponent();
        }

        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frm_TKB f2 = new frm_TKB();
            f2.Show();
            this.Hide();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_TKB.ketnoi();
            grdtimkiem.DataSource = null;
            string sql1 = "Select * from TKB where MA_PHONG like '" + txt_timkiem.Text + "' or THU like '" + txt_timkiem.Text + "' or BUOI like '" + txt_timkiem.Text + "' or TINH_TRANG like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = ketnoiCSDL_TKB.laydl(sql1, "TKB");
        }
    }
}
