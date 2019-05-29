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
    public partial class FrmPhongsearch : Form
    {
        private Label lbl_maphong;
        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private Button btn_quaylai;
        private Button btn_thoat;
        private DataGridView dtgrview_phongtimkiem;
        private Label lbl_header;

        public FrmPhongsearch()
        {
            InitializeComponent();
            KETNOICSDL_ROOM.taoketnoi();
        }

        

        

        private void InitializeComponent()
        {
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_maphong = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtgrview_phongtimkiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview_phongtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(232, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(198, 20);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "TÌM KIẾM PHÒNG HỌC";
            // 
            // lbl_maphong
            // 
            this.lbl_maphong.AutoSize = true;
            this.lbl_maphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphong.Location = new System.Drawing.Point(55, 48);
            this.lbl_maphong.Name = "lbl_maphong";
            this.lbl_maphong.Size = new System.Drawing.Size(472, 20);
            this.lbl_maphong.TabIndex = 5;
            this.lbl_maphong.Text = "Mã Phòng/ Tên Phòng/ Mã Loại/ Sức Chứa/ Giảng Đường :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(168, 93);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(282, 26);
            this.txt_timkiem.TabIndex = 6;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_timkiem.Location = new System.Drawing.Point(59, 143);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(87, 31);
            this.btn_timkiem.TabIndex = 7;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click_1);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_quaylai.Location = new System.Drawing.Point(273, 143);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(90, 31);
            this.btn_quaylai.TabIndex = 8;
            this.btn_quaylai.Text = "Quay Lại";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(467, 143);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(90, 31);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtgrview_phongtimkiem
            // 
            this.dtgrview_phongtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrview_phongtimkiem.Location = new System.Drawing.Point(59, 197);
            this.dtgrview_phongtimkiem.Name = "dtgrview_phongtimkiem";
            this.dtgrview_phongtimkiem.Size = new System.Drawing.Size(508, 233);
            this.dtgrview_phongtimkiem.TabIndex = 10;
            // 
            // FrmPhongsearch
            // 
            this.ClientSize = new System.Drawing.Size(636, 471);
            this.Controls.Add(this.dtgrview_phongtimkiem);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.lbl_maphong);
            this.Controls.Add(this.lbl_header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPhongsearch";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview_phongtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_timkiem_Click_1(object sender, EventArgs e)
        {
            KETNOICSDL_ROOM.taoketnoi();
            dtgrview_phongtimkiem.DataSource = null;
            string sql_Statement = "select * from ROOM where MA_PHONG like '" + txt_timkiem.Text + "' or TEN_PHONG like '" + txt_timkiem.Text + "' or MA_LOAI like '" + txt_timkiem.Text + "' or SUC_CHUA like '" + txt_timkiem.Text + "' or GĐ like '" + txt_timkiem.Text + "'";
            dtgrview_phongtimkiem.DataSource = KETNOICSDL_ROOM.laydulieu(sql_Statement, "ROOM");
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPhonginfo form_info = new FrmPhonginfo();
            form_info.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
