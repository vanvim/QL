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
    public partial class frmThietBi : Form
    {
        private TextBox txtMLTB;
        private TextBox txtTTB;
        private TextBox txtSL;
        private Button btnTaoMoi;
        private Button btnChen;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private Button btn_timkiem;
        private Button btn_quaylai;
        private TextBox txt_maphong;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataTB;
        private Label label5;
        private Label label4;

        public frmThietBi()
        {
            InitializeComponent();
        }
        private void Load_DuLieu(object sender, EventArgs e)
        {
            string sql1 = "Select * from QLTTB";
            dataTB.DataSource = null;
            dataTB.DataSource = KetNoiCSDL_TB.LoadDuLieu(sql1, "QLTTB");
        }
        private void HienThi_DL()
        {
            txt_maphong.DataBindings.Clear();
            txt_maphong.DataBindings.Add("Text", dataTB.DataSource, "MA_PHONG");
            txtMLTB.DataBindings.Clear();
            txtMLTB.DataBindings.Add("Text", dataTB.DataSource, "MA_LOAITB");
            txtTTB.DataBindings.Clear();
            txtTTB.DataBindings.Add("Text", dataTB.DataSource, "TEN_TB");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dataTB.DataSource, "SO_LUONG");
        }


        

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtMLTB = new System.Windows.Forms.TextBox();
            this.txtTTB = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTB = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(307, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "THIẾT BỊ";
            // 
            // txtMLTB
            // 
            this.txtMLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLTB.Location = new System.Drawing.Point(228, 119);
            this.txtMLTB.Name = "txtMLTB";
            this.txtMLTB.Size = new System.Drawing.Size(121, 26);
            this.txtMLTB.TabIndex = 19;
            // 
            // txtTTB
            // 
            this.txtTTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTB.Location = new System.Drawing.Point(228, 172);
            this.txtTTB.Name = "txtTTB";
            this.txtTTB.Size = new System.Drawing.Size(121, 26);
            this.txtTTB.TabIndex = 20;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(228, 225);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(121, 26);
            this.txtSL.TabIndex = 21;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Location = new System.Drawing.Point(417, 59);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(114, 41);
            this.btnTaoMoi.TabIndex = 23;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click_1);
            // 
            // btnChen
            // 
            this.btnChen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChen.Location = new System.Drawing.Point(417, 122);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(114, 41);
            this.btnChen.TabIndex = 24;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = false;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(417, 193);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 41);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(583, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 41);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(583, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 41);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(583, 57);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(114, 39);
            this.btn_timkiem.TabIndex = 28;
            this.btn_timkiem.Text = "tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(505, 264);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(114, 39);
            this.btn_quaylai.TabIndex = 29;
            this.btn_quaylai.Text = "Quay lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // txt_maphong
            // 
            this.txt_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphong.Location = new System.Drawing.Point(228, 66);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(121, 26);
            this.txt_maphong.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "MÃ LOẠI THIẾT BỊ :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "TÊN THIẾT BỊ :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = " SỐ LƯỢNG :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataTB
            // 
            this.dataTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTB.Location = new System.Drawing.Point(29, 298);
            this.dataTB.Name = "dataTB";
            this.dataTB.Size = new System.Drawing.Size(405, 139);
            this.dataTB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "MÃ PHÒNG :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmThietBi
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 465);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.dataTB);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTTB);
            this.Controls.Add(this.txtMLTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmThietBi";
            this.Load += new System.EventHandler(this.frmThietBi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            
            frmmain f1 = new frmmain();
            f1.Show();
            this.Hide();
            
        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            txt_maphong.Text = "";
            txtMLTB.Text = "";
            txtTTB.Text = "";
            txtSL.Text = "";
        }

        private void frmThietBi_Load_1(object sender, EventArgs e)
        {
            Load_DuLieu(null, null);
            HienThi_DL();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string d = txt_maphong.Text;
                string a = txtMLTB.Text;
                string b = txtTTB.Text;
                string c = txtSL.Text;
                


                KetNoiCSDL_TB.Chen_DuLieu(d,a, b, c);
                Load_DuLieu(null, null);
                HienThi_DL();
            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            KetNoiCSDL_TB.Luu_Dulieu(txtMLTB.Text,txtTTB.Text, txtSL.Text,txt_maphong.Text );
            Load_DuLieu(null, null);
            HienThi_DL();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            KetNoiCSDL_TB.Xoa_Dulieu(txt_maphong.Text);
            Load_DuLieu(null, null);
            HienThi_DL();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            frm_timkiem_thietbi f6 = new frm_timkiem_thietbi();
            f6.Show();
        }
    }
}
