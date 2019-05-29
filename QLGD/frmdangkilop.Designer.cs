namespace QLGD
{
    partial class frmdangkilop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_magvsv = new System.Windows.Forms.TextBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_thu = new System.Windows.Forms.TextBox();
            this.txt_buoi = new System.Windows.Forms.TextBox();
            this.grd_dangki = new System.Windows.Forms.DataGridView();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_taomoi = new System.Windows.Forms.Button();
            this.btn_quay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dangki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÍ LỚP HOẶC PHÒNG HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "mã sinh viên,hoặc mã giáo viên :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "buổi :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "thứ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "mã phòng:";
            // 
            // txt_magvsv
            // 
            this.txt_magvsv.Location = new System.Drawing.Point(320, 61);
            this.txt_magvsv.Name = "txt_magvsv";
            this.txt_magvsv.Size = new System.Drawing.Size(100, 20);
            this.txt_magvsv.TabIndex = 6;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(320, 108);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(100, 20);
            this.txt_maphong.TabIndex = 7;
            // 
            // txt_thu
            // 
            this.txt_thu.Location = new System.Drawing.Point(320, 149);
            this.txt_thu.Name = "txt_thu";
            this.txt_thu.Size = new System.Drawing.Size(100, 20);
            this.txt_thu.TabIndex = 8;
            // 
            // txt_buoi
            // 
            this.txt_buoi.Location = new System.Drawing.Point(320, 195);
            this.txt_buoi.Name = "txt_buoi";
            this.txt_buoi.Size = new System.Drawing.Size(100, 20);
            this.txt_buoi.TabIndex = 9;
            // 
            // grd_dangki
            // 
            this.grd_dangki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dangki.Location = new System.Drawing.Point(147, 242);
            this.grd_dangki.Name = "grd_dangki";
            this.grd_dangki.Size = new System.Drawing.Size(501, 150);
            this.grd_dangki.TabIndex = 10;
            // 
            // btn_dangki
            // 
            this.btn_dangki.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangki.Location = new System.Drawing.Point(448, 56);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(136, 32);
            this.btn_dangki.TabIndex = 11;
            this.btn_dangki.Text = "ĐĂNG KÍ";
            this.btn_dangki.UseVisualStyleBackColor = false;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(448, 100);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(136, 32);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(448, 149);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(136, 32);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(448, 195);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 32);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taomoi.Location = new System.Drawing.Point(606, 102);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(136, 32);
            this.btn_taomoi.TabIndex = 15;
            this.btn_taomoi.Text = "TẠO MỚI";
            this.btn_taomoi.UseVisualStyleBackColor = false;
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // btn_quay
            // 
            this.btn_quay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_quay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quay.Location = new System.Drawing.Point(606, 163);
            this.btn_quay.Name = "btn_quay";
            this.btn_quay.Size = new System.Drawing.Size(136, 32);
            this.btn_quay.TabIndex = 16;
            this.btn_quay.Text = "QUAY LẠI";
            this.btn_quay.UseVisualStyleBackColor = false;
            this.btn_quay.Click += new System.EventHandler(this.btn_quay_Click);
            // 
            // frmdangkilop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 456);
            this.Controls.Add(this.btn_quay);
            this.Controls.Add(this.btn_taomoi);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.grd_dangki);
            this.Controls.Add(this.txt_buoi);
            this.Controls.Add(this.txt_thu);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.txt_magvsv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdangkilop";
            this.Text = "frmdangkilop";
            this.Load += new System.EventHandler(this.frmdangkilop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_dangki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_magvsv;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_thu;
        private System.Windows.Forms.TextBox txt_buoi;
        private System.Windows.Forms.DataGridView grd_dangki;
        private System.Windows.Forms.Button btn_dangki;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_taomoi;
        private System.Windows.Forms.Button btn_quay;
    }
}