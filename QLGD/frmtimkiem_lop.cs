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
    public partial class frmtimkiem_lop : Form
    {
        private Label label2;
        private TextBox txt_timkiem;
        private Button btn_timkiemlop;
        private Button btn_thoat;
        private Button btn_quaylai;
        private DataGridView grdtimkiem;
        private Label label1;

        public frmtimkiem_lop()
        {
            InitializeComponent();
        }

        

        

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiemlop = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.grdtimkiem = new System.Windows.Forms.DataGridView();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHẬP MÃ LỚP,TÊN LỚP HOẶC MÃ GIÁO VIÊN ĐỂ TÌM LỚP :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(495, 60);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(176, 26);
            this.txt_timkiem.TabIndex = 2;
            // 
            // btn_timkiemlop
            // 
            this.btn_timkiemlop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_timkiemlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemlop.Location = new System.Drawing.Point(67, 104);
            this.btn_timkiemlop.Name = "btn_timkiemlop";
            this.btn_timkiemlop.Size = new System.Drawing.Size(120, 30);
            this.btn_timkiemlop.TabIndex = 3;
            this.btn_timkiemlop.Text = "TÌM KIẾM";
            this.btn_timkiemlop.UseVisualStyleBackColor = false;
            this.btn_timkiemlop.Click += new System.EventHandler(this.btn_timkiemlop_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(267, 104);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(120, 30);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // grdtimkiem
            // 
            this.grdtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtimkiem.Location = new System.Drawing.Point(29, 153);
            this.grdtimkiem.Name = "grdtimkiem";
            this.grdtimkiem.Size = new System.Drawing.Size(642, 188);
            this.grdtimkiem.TabIndex = 6;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(462, 104);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(120, 30);
            this.btn_quaylai.TabIndex = 5;
            this.btn_quaylai.Text = "QUAY LẠI";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // frmtimkiem_lop
            // 
            this.ClientSize = new System.Drawing.Size(716, 353);
            this.Controls.Add(this.grdtimkiem);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_timkiemlop);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtimkiem_lop";
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
           
            frmlop f1 = new frmlop();
            f1.Show();
            this.Hide();
        }

        private void btn_timkiemlop_Click(object sender, EventArgs e)
        {
            KeyNoiCSDL_LOP.KetNoi_CSDL();
            grdtimkiem.DataSource = null;
            string sql2 = "SELECT * FROM LOP WHERE MA_LOP like'" + txt_timkiem.Text + "' or TEN_LOP like '%" + txt_timkiem.Text + "%' or MA_GV like '" + txt_timkiem.Text + "'";
            grdtimkiem.DataSource = KeyNoiCSDL_LOP.LoadDuLieu(sql2, "LOP");
        }
    }
    }

