namespace QLGD
{
    partial class sinhvien_lop
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
            this.lblmalop = new System.Windows.Forms.Label();
            this.lbltenlop = new System.Windows.Forms.Label();
            this.lblmagv = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btn_muon = new System.Windows.Forms.Button();
            this.DataGvLop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông Tin Lớp";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmalop.Location = new System.Drawing.Point(27, 39);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(57, 18);
            this.lblmalop.TabIndex = 11;
            this.lblmalop.Text = "Mã lớp:";
            // 
            // lbltenlop
            // 
            this.lbltenlop.AutoSize = true;
            this.lbltenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenlop.Location = new System.Drawing.Point(27, 83);
            this.lbltenlop.Name = "lbltenlop";
            this.lbltenlop.Size = new System.Drawing.Size(61, 18);
            this.lbltenlop.TabIndex = 12;
            this.lbltenlop.Text = "Tên lớp:";
            // 
            // lblmagv
            // 
            this.lblmagv.AutoSize = true;
            this.lblmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmagv.Location = new System.Drawing.Point(27, 127);
            this.lblmagv.Name = "lblmagv";
            this.lblmagv.Size = new System.Drawing.Size(102, 18);
            this.lblmagv.TabIndex = 13;
            this.lblmagv.Text = "Mã giảng viên:";
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(148, 40);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(183, 20);
            this.txtmalop.TabIndex = 14;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(148, 81);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(183, 20);
            this.txttenlop.TabIndex = 15;
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(148, 125);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(183, 20);
            this.txtmagv.TabIndex = 16;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(426, 39);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(90, 32);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btn_muon
            // 
            this.btn_muon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muon.Location = new System.Drawing.Point(426, 101);
            this.btn_muon.Name = "btn_muon";
            this.btn_muon.Size = new System.Drawing.Size(90, 32);
            this.btn_muon.TabIndex = 18;
            this.btn_muon.Text = "MƯỢN LỚP";
            this.btn_muon.UseVisualStyleBackColor = true;
            // 
            // DataGvLop
            // 
            this.DataGvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGvLop.Location = new System.Drawing.Point(30, 172);
            this.DataGvLop.Name = "DataGvLop";
            this.DataGvLop.Size = new System.Drawing.Size(597, 214);
            this.DataGvLop.TabIndex = 19;
            // 
            // sinhvien_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 454);
            this.Controls.Add(this.DataGvLop);
            this.Controls.Add(this.btn_muon);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.lblmagv);
            this.Controls.Add(this.lbltenlop);
            this.Controls.Add(this.lblmalop);
            this.Controls.Add(this.label1);
            this.Name = "sinhvien_lop";
            this.Text = "sinhvien_lop";
            ((System.ComponentModel.ISupportInitialize)(this.DataGvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label lbltenlop;
        private System.Windows.Forms.Label lblmagv;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btn_muon;
        private System.Windows.Forms.DataGridView DataGvLop;
    }
}