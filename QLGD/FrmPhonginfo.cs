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
    public partial class FrmPhonginfo : Form
    {
        private Label lbl_maphong;
        private Label lbl_tenphong;
        private Label lbl_maloai;
        private Label lbl_succhua;
        private Label lbl_gd;
        private TextBox txt_maphong;
        private TextBox txt_tenphong;
        private TextBox txt_maloai;
        private TextBox txt_succhua;
        private TextBox txt_gd;
        private DataGridView dtgrview_phonginfo;
        private Button btn_taomoi;
        private Button btn_chen;
        private Button btn_timkiem;
        private Button btn_xoa;
        private Button btn_thoat;
        private Button btn_luu;
        private Label lbl_header;

        public FrmPhonginfo()
        {
            InitializeComponent();
            KETNOICSDL_ROOM.taoketnoi();
        }

        private void HienThi_DL()
        {
            txt_maphong.DataBindings.Clear();
            txt_maphong.DataBindings.Add("Text", dtgrview_phonginfo.DataSource, "MA_PHONG");
            txt_tenphong.DataBindings.Clear();
            txt_tenphong.DataBindings.Add("Text", dtgrview_phonginfo.DataSource, "TEN_PHONG");
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dtgrview_phonginfo.DataSource, "MA_LOAI");
            txt_succhua.DataBindings.Clear();
            txt_succhua.DataBindings.Add("Text", dtgrview_phonginfo.DataSource, "SUC_CHUA");
            txt_gd.DataBindings.Clear();
            txt_gd.DataBindings.Add("Text", dtgrview_phonginfo.DataSource, "GĐ");
        }

        private void Load_DuLieu(object sender, EventArgs e)
        {
            dtgrview_phonginfo.DataSource = null;
            string SQL = "Select * from ROOM";
            dtgrview_phonginfo.DataSource = null;
            dtgrview_phonginfo.DataSource = KETNOICSDL_ROOM.loaddulieu(SQL, "ROOM");
            HienThi_DL();

        }

        

        
        

        
        

        

       

        private void InitializeComponent()
        {
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_maphong = new System.Windows.Forms.Label();
            this.lbl_tenphong = new System.Windows.Forms.Label();
            this.lbl_maloai = new System.Windows.Forms.Label();
            this.lbl_succhua = new System.Windows.Forms.Label();
            this.lbl_gd = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txt_succhua = new System.Windows.Forms.TextBox();
            this.txt_gd = new System.Windows.Forms.TextBox();
            this.dtgrview_phonginfo = new System.Windows.Forms.DataGridView();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.btn_chen = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview_phonginfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(276, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(215, 20);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "THÔNG TIN PHÒNG HỌC";
            // 
            // lbl_maphong
            // 
            this.lbl_maphong.AutoSize = true;
            this.lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphong.Location = new System.Drawing.Point(38, 42);
            this.lbl_maphong.Name = "lbl_maphong";
            this.lbl_maphong.Size = new System.Drawing.Size(99, 20);
            this.lbl_maphong.TabIndex = 5;
            this.lbl_maphong.Text = "Mã Phòng: ";
            // 
            // lbl_tenphong
            // 
            this.lbl_tenphong.AutoSize = true;
            this.lbl_tenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenphong.Location = new System.Drawing.Point(32, 93);
            this.lbl_tenphong.Name = "lbl_tenphong";
            this.lbl_tenphong.Size = new System.Drawing.Size(105, 20);
            this.lbl_tenphong.TabIndex = 13;
            this.lbl_tenphong.Text = "Tên Phòng: ";
            // 
            // lbl_maloai
            // 
            this.lbl_maloai.AutoSize = true;
            this.lbl_maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maloai.Location = new System.Drawing.Point(55, 137);
            this.lbl_maloai.Name = "lbl_maloai";
            this.lbl_maloai.Size = new System.Drawing.Size(82, 20);
            this.lbl_maloai.TabIndex = 14;
            this.lbl_maloai.Text = "Mã Loại: ";
            // 
            // lbl_succhua
            // 
            this.lbl_succhua.AutoSize = true;
            this.lbl_succhua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_succhua.Location = new System.Drawing.Point(354, 42);
            this.lbl_succhua.Name = "lbl_succhua";
            this.lbl_succhua.Size = new System.Drawing.Size(97, 20);
            this.lbl_succhua.TabIndex = 15;
            this.lbl_succhua.Text = "Sức Chứa: ";
            // 
            // lbl_gd
            // 
            this.lbl_gd.AutoSize = true;
            this.lbl_gd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gd.Location = new System.Drawing.Point(326, 93);
            this.lbl_gd.Name = "lbl_gd";
            this.lbl_gd.Size = new System.Drawing.Size(125, 20);
            this.lbl_gd.TabIndex = 16;
            this.lbl_gd.Text = "Giảng Đường: ";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(157, 39);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(123, 26);
            this.txt_maphong.TabIndex = 17;
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(157, 84);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(123, 26);
            this.txt_tenphong.TabIndex = 18;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(157, 134);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(123, 26);
            this.txt_maloai.TabIndex = 19;
            // 
            // txt_succhua
            // 
            this.txt_succhua.Location = new System.Drawing.Point(490, 42);
            this.txt_succhua.Name = "txt_succhua";
            this.txt_succhua.Size = new System.Drawing.Size(123, 26);
            this.txt_succhua.TabIndex = 20;
            // 
            // txt_gd
            // 
            this.txt_gd.Location = new System.Drawing.Point(490, 90);
            this.txt_gd.Name = "txt_gd";
            this.txt_gd.Size = new System.Drawing.Size(123, 26);
            this.txt_gd.TabIndex = 21;
            // 
            // dtgrview_phonginfo
            // 
            this.dtgrview_phonginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrview_phonginfo.Location = new System.Drawing.Point(37, 173);
            this.dtgrview_phonginfo.Name = "dtgrview_phonginfo";
            this.dtgrview_phonginfo.Size = new System.Drawing.Size(454, 191);
            this.dtgrview_phonginfo.TabIndex = 22;
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Location = new System.Drawing.Point(517, 173);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(75, 33);
            this.btn_taomoi.TabIndex = 23;
            this.btn_taomoi.Text = "Tạo Mới";
            this.btn_taomoi.UseVisualStyleBackColor = true;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // btn_chen
            // 
            this.btn_chen.Location = new System.Drawing.Point(517, 237);
            this.btn_chen.Name = "btn_chen";
            this.btn_chen.Size = new System.Drawing.Size(75, 32);
            this.btn_chen.TabIndex = 24;
            this.btn_chen.Text = "Chèn";
            this.btn_chen.UseVisualStyleBackColor = true;
            this.btn_chen.Click += new System.EventHandler(this.btn_chen_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(632, 173);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 33);
            this.btn_timkiem.TabIndex = 26;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(632, 237);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(632, 310);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 33);
            this.btn_thoat.TabIndex = 28;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(517, 310);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 33);
            this.btn_luu.TabIndex = 29;
            this.btn_luu.Text = "lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // FrmPhonginfo
            // 
            this.ClientSize = new System.Drawing.Size(729, 376);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_chen);
            this.Controls.Add(this.btn_taomoi);
            this.Controls.Add(this.dtgrview_phonginfo);
            this.Controls.Add(this.txt_gd);
            this.Controls.Add(this.txt_succhua);
            this.Controls.Add(this.txt_maloai);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.lbl_gd);
            this.Controls.Add(this.lbl_succhua);
            this.Controls.Add(this.lbl_maloai);
            this.Controls.Add(this.lbl_tenphong);
            this.Controls.Add(this.lbl_maphong);
            this.Controls.Add(this.lbl_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPhonginfo";
            this.Load += new System.EventHandler(this.FrmPhonginfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview_phonginfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {

            txt_maphong.Text = "";
            txt_tenphong.Text = "";
            txt_maloai.Text = "";
            txt_succhua.Text = "";
            txt_gd.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_chen_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txt_maphong.Text;
                string b = txt_tenphong.Text;
                string c = txt_maloai.Text;
                string a1 = txt_succhua.Text;
                string a2 = txt_gd.Text;

                KETNOICSDL_ROOM.chendulieu(a, b, c, a1, a2);
                Load_DuLieu(null, null);
            }
            catch (OleDbException Exception)
            {
                String a = Convert.ToString(Exception.ErrorCode);
                MessageBox.Show(a);

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            FrmPhongsearch search = new FrmPhongsearch();
            search.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           
            KETNOICSDL_ROOM.xoadulieu(txt_maphong.Text);
            Load_DuLieu(null, null);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            KETNOICSDL_ROOM.luudulieu(txt_maphong.Text, txt_tenphong.Text, txt_maloai.Text, txt_succhua.Text, txt_gd.Text);
            Load_DuLieu(null, null);
        }

        private void FrmPhonginfo_Load(object sender, EventArgs e)
        {
            Load_DuLieu(null, null);
            HienThi_DL();
        }
    }
}
