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
    public partial class frm_timkiem_thietbi : Form
    {
        public frm_timkiem_thietbi()
        {
            InitializeComponent();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            KetNoiCSDL_TB.TaoKetNoi_CSDL();
            grdtimkiem.DataSource = null;
            string sql1 = "Select * from QLTTB where MA_PHONG like '" + txt_timkiem.Text + "' or MA_LOAITB like '" + txt_timkiem.Text + "' or TEN_TB like '%" + txt_timkiem.Text + "%' or SO_LUONG like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = KetNoiCSDL_TB.LoadDuLieu(sql1, "QLTTB");
        }
    }
}
