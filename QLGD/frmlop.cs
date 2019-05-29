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
    public partial class frmlop : Form
    {
        public frmlop()
        {
            InitializeComponent();
        }

        private void Load_DuLieu(object sender, EventArgs e)
        {
            DataGvLop.DataSource = null;
            string SQL = "Select * from LOP";
            DataGvLop.DataSource = null;
            DataGvLop.DataSource = KeyNoiCSDL_LOP.LoadDuLieu(SQL, "LOP");
            HienThi_DL();

        }
        private void HienThi_DL()
        {


            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", DataGvLop.DataSource, "MA_LOP");

            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", DataGvLop.DataSource, "TEN_LOP");

            txtmagv.DataBindings.Clear();
            txtmagv.DataBindings.Add("Text", DataGvLop.DataSource, "MA_GV");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmlop_Load(object sender, EventArgs e)
        {
            Load_DuLieu(null, null);
            HienThi_DL();
        }
        private void btntaomoi_Click(object sender, EventArgs e)
        {
            
            txtmalop.Text = "";
            txttenlop.Text = "";
            txtmagv.Text = "";
        }

       

        private void btnchendl_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                string c = txtmalop.Text;
                string d = txttenlop.Text;
                string b = txtmagv.Text;


                KeyNoiCSDL_LOP.chendl(c, d,b);
                Load_DuLieu(null, null);
                HienThi_DL();


            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }

        }
        private void btnluudl_Click(object sender, EventArgs e)
        {
            KeyNoiCSDL_LOP.luudl(txttenlop.Text, txtmagv.Text, txtmalop.Text);
            Load_DuLieu(null, null);
            HienThi_DL();

        }

        private void btnxoadl_Click(object sender, EventArgs e)
        {
            KeyNoiCSDL_LOP.xoadl(txtmalop.Text);
            Load_DuLieu(null, null);
            HienThi_DL();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            frmtimkiem_lop f3 = new frmtimkiem_lop();
            f3.Show();
            KeyNoiCSDL_LOP.KetNoi_CSDL();
            DataGvLop.DataSource = null;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quay_Click(object sender, EventArgs e)
        {
            frmmain f4 = new frmmain();
            f4.Show();
            this.Hide();
        }
    }
}
