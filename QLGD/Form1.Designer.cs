namespace QLGD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grd_tkb = new System.Windows.Forms.DataGridView();
            this.grd_lop = new System.Windows.Forms.DataGridView();
            this.grd_room = new System.Windows.Forms.DataGridView();
            this.grd_TB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdtimkiem = new System.Windows.Forms.DataGridView();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_tkb = new System.Windows.Forms.Button();
            this.btn_lop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_phong = new System.Windows.Forms.Button();
            this.btn_thietbi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_tkb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_tkb
            // 
            this.grd_tkb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_tkb.Location = new System.Drawing.Point(12, 52);
            this.grd_tkb.Name = "grd_tkb";
            this.grd_tkb.Size = new System.Drawing.Size(406, 131);
            this.grd_tkb.TabIndex = 0;
            this.grd_tkb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_tkb_CellContentClick);
            // 
            // grd_lop
            // 
            this.grd_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_lop.Location = new System.Drawing.Point(12, 224);
            this.grd_lop.Name = "grd_lop";
            this.grd_lop.Size = new System.Drawing.Size(406, 138);
            this.grd_lop.TabIndex = 1;
            this.grd_lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_lop_CellContentClick);
            // 
            // grd_room
            // 
            this.grd_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_room.Location = new System.Drawing.Point(12, 408);
            this.grd_room.Name = "grd_room";
            this.grd_room.Size = new System.Drawing.Size(406, 133);
            this.grd_room.TabIndex = 2;
            this.grd_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_room_CellContentClick);
            // 
            // grd_TB
            // 
            this.grd_TB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_TB.Location = new System.Drawing.Point(467, 52);
            this.grd_TB.Name = "grd_TB";
            this.grd_TB.Size = new System.Drawing.Size(406, 131);
            this.grd_TB.TabIndex = 3;
            this.grd_TB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_TB_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "LỚP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ROOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "THỜI KHÓA BIỂU";
            // 
            // grdtimkiem
            // 
            this.grdtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtimkiem.Location = new System.Drawing.Point(467, 224);
            this.grdtimkiem.Name = "grdtimkiem";
            this.grdtimkiem.Size = new System.Drawing.Size(406, 293);
            this.grdtimkiem.TabIndex = 11;
            this.grdtimkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtimkiem_CellContentClick);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(912, 157);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(167, 26);
            this.txt_timkiem.TabIndex = 12;
            // 
            // btn_tkb
            // 
            this.btn_tkb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_tkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tkb.Location = new System.Drawing.Point(912, 375);
            this.btn_tkb.Name = "btn_tkb";
            this.btn_tkb.Size = new System.Drawing.Size(172, 71);
            this.btn_tkb.TabIndex = 21;
            this.btn_tkb.Text = "TÌM KIẾM  THỜI KHÓA BIỂU";
            this.btn_tkb.UseVisualStyleBackColor = false;
            this.btn_tkb.Click += new System.EventHandler(this.btn_tkb_Click);
            // 
            // btn_lop
            // 
            this.btn_lop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lop.Location = new System.Drawing.Point(912, 205);
            this.btn_lop.Name = "btn_lop";
            this.btn_lop.Size = new System.Drawing.Size(172, 32);
            this.btn_lop.TabIndex = 22;
            this.btn_lop.Text = "TÌM KIẾM LỚP";
            this.btn_lop.UseVisualStyleBackColor = false;
            this.btn_lop.Click += new System.EventHandler(this.btn_lop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "TRANG THIẾT BỊ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(952, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "TÌM KIẾM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(912, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "ĐĂNG KÍ LỚP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_phong
            // 
            this.btn_phong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phong.Location = new System.Drawing.Point(912, 254);
            this.btn_phong.Name = "btn_phong";
            this.btn_phong.Size = new System.Drawing.Size(172, 32);
            this.btn_phong.TabIndex = 27;
            this.btn_phong.Text = "TÌM KIẾM PHÒNG";
            this.btn_phong.UseVisualStyleBackColor = false;
            this.btn_phong.Click += new System.EventHandler(this.btn_phong_Click);
            // 
            // btn_thietbi
            // 
            this.btn_thietbi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thietbi.Location = new System.Drawing.Point(912, 312);
            this.btn_thietbi.Name = "btn_thietbi";
            this.btn_thietbi.Size = new System.Drawing.Size(172, 32);
            this.btn_thietbi.TabIndex = 28;
            this.btn_thietbi.Text = "TÌM KIẾM THIẾT BỊ";
            this.btn_thietbi.UseVisualStyleBackColor = false;
            this.btn_thietbi.Click += new System.EventHandler(this.btn_thietbi_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(912, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 32);
            this.button2.TabIndex = 29;
            this.button2.Text = "ĐỔI MẬT KHẨU";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_thietbi);
            this.Controls.Add(this.btn_phong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_lop);
            this.Controls.Add(this.btn_tkb);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.grdtimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_TB);
            this.Controls.Add(this.grd_room);
            this.Controls.Add(this.grd_lop);
            this.Controls.Add(this.grd_tkb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_tkb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_tkb;
        private System.Windows.Forms.DataGridView grd_lop;
        private System.Windows.Forms.DataGridView grd_room;
        private System.Windows.Forms.DataGridView grd_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdtimkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_tkb;
        private System.Windows.Forms.Button btn_lop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_phong;
        private System.Windows.Forms.Button btn_thietbi;
        private System.Windows.Forms.Button button2;
    }
}