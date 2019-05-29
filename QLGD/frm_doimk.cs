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
    public partial class frm_doimk : Form
    {
        public frm_doimk()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ketnoicsdl_account.ketnoi();
            string sql = "select PWD from ACCOUNT where MATK = @ID  ";
            OleDbCommand cmd = new OleDbCommand(sql, ketnoicsdl_account.cnn);
            cmd.Parameters.AddWithValue("@ID", txt_name.Text);
            


            if (Convert.ToString(cmd.ExecuteScalar())==txt_pwd_cu.Text)
            {
                ketnoicsdl_account.LuuDL(txt_pwd_moi.Text,txt_name.Text);

                frm_dangnhp f2 = new frm_dangnhp();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("vui lòng xem lại tến đăng nhập hoặc mật khẩu");
                frm_doimk f3 = new frm_doimk();
                f3.Show();
                this.Hide();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pwd_cu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pwd_moi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
