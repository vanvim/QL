using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLGD
{
    public partial class frm_TKB : Form
    {
        public frm_TKB()
        {
            InitializeComponent();
        }
        private void load(object sender, EventArgs e)
        {
            string sql = "SELECT * from TKB";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ketnoiCSDL_TKB.laydl(sql, "TKB");


        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frmmain f1 = new frmmain();
            f1.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            frm_timkiem_tkb f2 = new frm_timkiem_tkb();
            f2.Show();
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            txt_buoi.Text = "";
            txt_maphong.Text = "";
            txt_thu.Text = "";
            txt_tinhtrang.Text = "";
        }
        private void HienThi_DL()
        {
            id.DataBindings.Clear();
            id.DataBindings.Add("Text", dataGridView1.DataSource, "ID");
            txt_maphong.DataBindings.Clear();
            txt_maphong.DataBindings.Add("Text", dataGridView1.DataSource, "MA_PHONG");
            txt_thu.DataBindings.Clear();
            txt_thu.DataBindings.Add("Text", dataGridView1.DataSource, "THU");
            txt_buoi.DataBindings.Clear();
            txt_buoi.DataBindings.Add("Text", dataGridView1.DataSource, "BUOI");
            txt_tinhtrang.DataBindings.Clear();
            txt_tinhtrang.DataBindings.Add("Text", dataGridView1.DataSource, "TINH_TRANG");

        }

        private void frm_TKB_Load(object sender, EventArgs e)
        {
            load(null, null);
            HienThi_DL();
        }

        private void btn_chen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txt_maphong.Text;
                string b = txt_thu.Text;
                string c = txt_buoi.Text;
                string d = txt_tinhtrang.Text;


                ketnoiCSDL_TKB.chendl(a, b, c, d);
                load(null, null);
                HienThi_DL();
            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_TKB.LuuDL(txt_thu.Text, txt_buoi.Text, txt_tinhtrang.Text, txt_maphong.Text);
            load(null, null);
            HienThi_DL();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_TKB.XoaDL(txt_maphong.Text);
            load(null, null);
            HienThi_DL();
        }
    }
}
