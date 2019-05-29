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
    public partial class frm_dangnhp : Form
    {
        public frm_dangnhp()
        {
            InitializeComponent();
            ketnoicsdl_account.ketnoi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ketnoicsdl_account.ketnoi();
            string sql = "select COUNT(*) from ACCOUNT where MATK = @ID and PWD = @PWD ";
            OleDbCommand cmd = new OleDbCommand(sql, ketnoicsdl_account.cnn);
            cmd.Parameters.AddWithValue("@ID", txt_name.Text);
            cmd.Parameters.AddWithValue("@PWD", txt_pwd.Text);

            
            if (Convert.ToBoolean(cmd.ExecuteScalar()))
            {
                if(txt_name.Text =="admin")
                {
                    MessageBox.Show("bạn đã đăng nhập thành công");
                    frmmain f1 = new frmmain();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("bạn đã đăng nhập thành công");
                    Form1 f2 = new Form1();
                    f2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("vui lòng xem lại tến đăng nhập hoặc mật khẩu");
                frm_dangnhp f3 = new frm_dangnhp();
                f3.Show();
            }
            ketnoicsdl_account.cnn.Close();
        }
    }
}
