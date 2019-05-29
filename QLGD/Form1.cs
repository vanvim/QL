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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void load(object sender, EventArgs e)
        {
            string sql = "SELECT * from TKB";
            grd_tkb.DataSource = null;
            grd_tkb.DataSource = ketnoiCSDL_TKB.laydl(sql, "TKB");

            string SQL = "Select * from LOP";
            grd_lop.DataSource = null;
            grd_lop.DataSource = KeyNoiCSDL_LOP.LoadDuLieu(SQL, "LOP");

            string SQL1 = "Select * from QLTTB";
            grd_TB.DataSource = null;
            grd_TB.DataSource = KetNoiCSDL_TB.LoadDuLieu(SQL1, "QLTTB");

            string SQL2 = "Select * from ROOM";
            grd_room.DataSource = null;
            grd_room.DataSource = KETNOICSDL_ROOM.laydulieu(SQL2, "ROOM");


        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load(null, null);
        }

        

        private void btn_tkb_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_TKB.ketnoi();
            grdtimkiem.DataSource = null;
            string sql1 = "Select * from TKB where MA_PHONG like '" + txt_timkiem.Text + "' or THU like '" + txt_timkiem.Text + "' or BUOI like '" + txt_timkiem.Text + "' or TINH_TRANG like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = ketnoiCSDL_TKB.laydl(sql1, "TKB");
        }

        private void btn_lop_Click(object sender, EventArgs e)
        {
            KeyNoiCSDL_LOP.KetNoi_CSDL();
            grdtimkiem.DataSource = null;
            string sql2 = "SELECT * FROM LOP WHERE MA_LOP like'" + txt_timkiem.Text + "' or TEN_LOP like '%" + txt_timkiem.Text + "%' or MA_GV like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = KeyNoiCSDL_LOP.LoadDuLieu(sql2, "LOP");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmdangkilop f1 = new frmdangkilop();
            f1.Show();
        }

        private void grd_tkb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_TB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdtimkiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            KETNOICSDL_ROOM.taoketnoi();
            grdtimkiem.DataSource = null;
            string sql_Statement = "select * from ROOM where MA_PHONG like '" + txt_timkiem.Text + "' or TEN_PHONG like '%" + txt_timkiem.Text + "%' or MA_LOAI like '" + txt_timkiem.Text + "' or SUC_CHUA like '" + txt_timkiem.Text + "' or GĐ like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = KETNOICSDL_ROOM.laydulieu(sql_Statement, "ROOM");
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            KetNoiCSDL_TB.TaoKetNoi_CSDL();
            grdtimkiem.DataSource = null;
            string sql1 = "Select * from QLTTB where MA_PHONG like '" + txt_timkiem.Text + "' or MA_LOAITB like '" + txt_timkiem.Text + "' or TEN_TB like '%" + txt_timkiem.Text + "%' or SO_LUONG like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = KetNoiCSDL_TB.LoadDuLieu(sql1, "QLTTB");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
