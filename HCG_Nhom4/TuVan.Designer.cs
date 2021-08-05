
namespace HCG_Nhom4
{
    partial class TuVan
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
            this.lstdulieu = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstketqua = new System.Windows.Forms.ListBox();
            this.btntuvan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdulieu = new System.Windows.Forms.DataGridView();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomsukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvdulieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lstdulieu
            // 
            this.lstdulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdulieu.FormattingEnabled = true;
            this.lstdulieu.Location = new System.Drawing.Point(2, 16);
            this.lstdulieu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstdulieu.Name = "lstdulieu";
            this.lstdulieu.Size = new System.Drawing.Size(325, 179);
            this.lstdulieu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnchitiet);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btntuvan);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnchon);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 643);
            this.panel1.TabIndex = 1;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(599, 554);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(110, 37);
            this.btnchitiet.TabIndex = 1;
            this.btnchitiet.Text = "Chi Tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(419, 351);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(409, 19);
            this.progressBar.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstketqua);
            this.groupBox3.Location = new System.Drawing.Point(417, 374);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(413, 167);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // lstketqua
            // 
            this.lstketqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstketqua.FormattingEnabled = true;
            this.lstketqua.Location = new System.Drawing.Point(2, 16);
            this.lstketqua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstketqua.Name = "lstketqua";
            this.lstketqua.Size = new System.Drawing.Size(409, 148);
            this.lstketqua.TabIndex = 0;
            this.lstketqua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstketqua_MouseClick);
            // 
            // btntuvan
            // 
            this.btntuvan.Location = new System.Drawing.Point(599, 293);
            this.btntuvan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btntuvan.Name = "btntuvan";
            this.btntuvan.Size = new System.Drawing.Size(110, 36);
            this.btntuvan.TabIndex = 6;
            this.btntuvan.Text = "Tư Vấn";
            this.btntuvan.UseVisualStyleBackColor = true;
            this.btntuvan.Click += new System.EventHandler(this.btntuvan_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(401, 209);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(74, 32);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(401, 154);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(74, 30);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(401, 97);
            this.btnchon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(74, 30);
            this.btnchon.TabIndex = 9;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstdulieu);
            this.groupBox2.Location = new System.Drawing.Point(503, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(329, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdulieu);
            this.groupBox1.Location = new System.Drawing.Point(2, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(361, 449);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các dữ liệu";
            // 
            // dgvdulieu
            // 
            this.dgvdulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdulieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.masukien, this.noidung, this.nhomsukien});
            this.dgvdulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdulieu.Location = new System.Drawing.Point(2, 16);
            this.dgvdulieu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvdulieu.Name = "dgvdulieu";
            this.dgvdulieu.RowHeadersVisible = false;
            this.dgvdulieu.RowHeadersWidth = 51;
            this.dgvdulieu.RowTemplate.Height = 24;
            this.dgvdulieu.Size = new System.Drawing.Size(357, 430);
            this.dgvdulieu.TabIndex = 4;
            // 
            // masukien
            // 
            this.masukien.DataPropertyName = "masukien";
            this.masukien.FillWeight = 70F;
            this.masukien.HeaderText = "Sự kiên";
            this.masukien.MinimumWidth = 6;
            this.masukien.Name = "masukien";
            this.masukien.Width = 70;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "Mô tả";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.Width = 150;
            // 
            // nhomsukien
            // 
            this.nhomsukien.DataPropertyName = "nhomsukien";
            this.nhomsukien.HeaderText = "Nhóm Sự kiện";
            this.nhomsukien.MinimumWidth = 6;
            this.nhomsukien.Name = "nhomsukien";
            this.nhomsukien.Width = 130;
            // 
            // TuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 643);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TuVan";
            this.Text = "TuVan";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvdulieu)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstdulieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstketqua;
        private System.Windows.Forms.Button btntuvan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdulieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomsukien;
    }
}