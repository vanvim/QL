namespace QLGD
{
    partial class frm_timkiem_tkb
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.grdtimkiem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÌM KIẾM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHẬP MÃ PHÒNG,THỨ,BUỔI,TÌNH TRẠNG :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(458, 80);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(167, 26);
            this.txt_timkiem.TabIndex = 9;
            // 
            // grdtimkiem
            // 
            this.grdtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtimkiem.Location = new System.Drawing.Point(51, 217);
            this.grdtimkiem.Name = "grdtimkiem";
            this.grdtimkiem.Size = new System.Drawing.Size(509, 190);
            this.grdtimkiem.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(426, 138);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(105, 32);
            this.btn_thoat.TabIndex = 16;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(51, 138);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(105, 32);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "TÌM KIẾM";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Location = new System.Drawing.Point(241, 138);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(105, 32);
            this.btn_quaylai.TabIndex = 20;
            this.btn_quaylai.Text = "QUAY LẠI";
            this.btn_quaylai.UseVisualStyleBackColor = false;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // frm_timkiem_tkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 444);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdtimkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_timkiem_tkb";
            this.Text = "frm_timkiem";
            ((System.ComponentModel.ISupportInitialize)(this.grdtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView grdtimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_quaylai;
    }
}