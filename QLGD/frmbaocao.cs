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
    public partial class frmbaocao : Form
    {
        public frmbaocao()
        {
            InitializeComponent();
        }

        private void frmbaocao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
