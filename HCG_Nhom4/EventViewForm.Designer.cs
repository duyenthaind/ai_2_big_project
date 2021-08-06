
namespace HCG_Nhom4
{
    partial class EventViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewForm));
            this.txtsukien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvsukien = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomsukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvsukien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsukien
            // 
            this.txtsukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtsukien.Location = new System.Drawing.Point(246, 115);
            this.txtsukien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsukien.Name = "txtsukien";
            this.txtsukien.Size = new System.Drawing.Size(362, 23);
            this.txtsukien.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.dgvsukien);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.txtmota);
            this.panel1.Controls.Add(this.txtsukien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 552);
            this.panel1.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(246, 206);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(362, 25);
            this.cbCategory.TabIndex = 4;
            // 
            // dgvsukien
            // 
            this.dgvsukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsukien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.masukien, this.noidung, this.nhomsukien});
            this.dgvsukien.Location = new System.Drawing.Point(30, 289);
            this.dgvsukien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvsukien.Name = "dgvsukien";
            this.dgvsukien.RowHeadersWidth = 51;
            this.dgvsukien.RowTemplate.Height = 24;
            this.dgvsukien.Size = new System.Drawing.Size(790, 278);
            this.dgvsukien.TabIndex = 3;
            this.dgvsukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsukien_CellClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnupdate.Image = ((System.Drawing.Image) (resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(694, 163);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(92, 34);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnremove.Image = ((System.Drawing.Image) (resources.GetObject("btnremove.Image")));
            this.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremove.Location = new System.Drawing.Point(694, 207);
            this.btnremove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(92, 32);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Xóa";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnadd.Image = ((System.Drawing.Image) (resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(694, 115);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 35);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtmota.Location = new System.Drawing.Point(246, 158);
            this.txtmota.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(362, 23);
            this.txtmota.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhóm sự kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sự kiện";
            // 
            // masukien
            // 
            this.masukien.DataPropertyName = "id";
            this.masukien.HeaderText = "Sự kiên";
            this.masukien.MinimumWidth = 6;
            this.masukien.Name = "masukien";
            this.masukien.Width = 200;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "content";
            this.noidung.HeaderText = "Mô tả";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.Width = 400;
            // 
            // nhomsukien
            // 
            this.nhomsukien.DataPropertyName = "categoryId";
            this.nhomsukien.HeaderText = "Nhóm sự kiện";
            this.nhomsukien.MinimumWidth = 6;
            this.nhomsukien.Name = "nhomsukien";
            this.nhomsukien.Width = 400;
            // 
            // EventViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 552);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventViewForm";
            this.Text = "EventViewForm";
            this.Load += new System.EventHandler(this.EventViewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvsukien)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cbCategory;

        #endregion

        private System.Windows.Forms.TextBox txtsukien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvsukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomsukien;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}