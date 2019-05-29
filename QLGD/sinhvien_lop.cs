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
    public partial class sinhvien_lop : Form
    {
        public sinhvien_lop()
        {
            InitializeComponent();
        }
        private void Load_DuLieu(object sender, EventArgs e)
        {
            DataGvLop.DataSource = null;
            string SQL = "Select * from LOP";
            DataGvLop.DataSource = null;
            DataGvLop.DataSource = KetNoiCSDL_LOP.LoadDuLieu(SQL, "LOP");
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
        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
