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
    public partial class frmdangkilop : Form
    {
        public frmdangkilop()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void load(object sender, EventArgs e)
        {
            string sql = "SELECT * from DANG_KI";
            grd_dangki.DataSource = null;
            grd_dangki.DataSource = ketnoiCSDL_dangki.laydl(sql, "DANG_KI");


        }
        private void HienThi_DL()
        {
            
            txt_maphong.DataBindings.Clear();
            txt_maphong.DataBindings.Add("Text", grd_dangki.DataSource, "MA_PHONG");
            txt_magvsv.DataBindings.Clear();
            txt_magvsv.DataBindings.Add("Text", grd_dangki.DataSource, "MA_ACCOUNT");
            txt_thu.DataBindings.Clear();
            txt_thu.DataBindings.Add("Text", grd_dangki.DataSource, "THU");
            txt_buoi.DataBindings.Clear();
            txt_buoi.DataBindings.Add("Text", grd_dangki.DataSource, "BUOI");
            

        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoiCSDL_TKB.ketnoi();
                string sql = "select TINH_TRANG from TKB where MA_PHONG = @MA_PHONG and THU = @THU and BUOI=@BUOI ";
                OleDbCommand cmd = new OleDbCommand(sql, ketnoiCSDL_TKB.cnn);
                cmd.Parameters.AddWithValue("@MA_PHONG", txt_maphong.Text);
                cmd.Parameters.AddWithValue("@THU", txt_thu.Text);
                cmd.Parameters.AddWithValue("@BUOI", txt_buoi.Text);
               

                if(Convert.ToString(cmd.ExecuteScalar())=="null")
                {
                    string a = txt_maphong.Text;
                    string b = txt_magvsv.Text;
                    string c = txt_thu.Text;
                    string d = txt_buoi.Text;


                    ketnoiCSDL_dangki.chendl(a, b, c, d);
                    ketnoiCSDL_TKB.LuuDL(txt_thu.Text, txt_buoi.Text, "use", txt_maphong.Text);
                    load(null, null);
                   HienThi_DL();

                }
                else
                {
                    MessageBox.Show("lớp đã được sử dụng");
                }



            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            txt_magvsv.Text = "";
            txt_buoi.Text = "";
            txt_maphong.Text = "";
            txt_thu.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_dangki.XoaDL(txt_maphong.Text,txt_magvsv.Text,txt_thu.Text,txt_buoi.Text);
            ketnoiCSDL_TKB.LuuDL(txt_thu.Text, txt_buoi.Text, "null", txt_maphong.Text);
            load(null, null);
            HienThi_DL();
        }

        private void frmdangkilop_Load(object sender, EventArgs e)
        {
            load(null, null);
            HienThi_DL();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ketnoiCSDL_dangki.LuuDL(txt_maphong.Text,txt_thu.Text, txt_buoi.Text, txt_magvsv.Text);
            load(null, null);
            HienThi_DL();
        }

        private void btn_quay_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();

        }
    }
}
