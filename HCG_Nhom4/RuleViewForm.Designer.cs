
namespace HCG_Nhom4
{
    partial class RuleViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleViewForm));
            this.dgvluat = new System.Windows.Forms.DataGridView();
            this.maluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvsukien2 = new System.Windows.Forms.DataGridView();
            this.masukien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtRuleContent = new System.Windows.Forms.TextBox();
            this.txtRuleId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdosukien = new System.Windows.Forms.RadioButton();
            this.rdoluat = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvluat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvsukien2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvluat
            // 
            this.dgvluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.maluat, this.nd});
            this.dgvluat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvluat.Location = new System.Drawing.Point(2, 19);
            this.dgvluat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvluat.Name = "dgvluat";
            this.dgvluat.RowHeadersWidth = 51;
            this.dgvluat.RowTemplate.Height = 24;
            this.dgvluat.Size = new System.Drawing.Size(469, 243);
            this.dgvluat.TabIndex = 0;
            this.dgvluat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvluat_CellClick);
            // 
            // maluat
            // 
            this.maluat.DataPropertyName = "id";
            this.maluat.HeaderText = "Luật";
            this.maluat.MinimumWidth = 6;
            this.maluat.Name = "maluat";
            this.maluat.Width = 200;
            // 
            // nd
            // 
            this.nd.DataPropertyName = "content";
            this.nd.HeaderText = "mô tả";
            this.nd.MinimumWidth = 6;
            this.nd.Name = "nd";
            this.nd.Width = 400;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvluat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(473, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách luật";
            // 
            // dgvsukien2
            // 
            this.dgvsukien2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsukien2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.masukien, this.noidung});
            this.dgvsukien2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsukien2.Location = new System.Drawing.Point(2, 19);
            this.dgvsukien2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvsukien2.Name = "dgvsukien2";
            this.dgvsukien2.RowHeadersWidth = 51;
            this.dgvsukien2.RowTemplate.Height = 24;
            this.dgvsukien2.Size = new System.Drawing.Size(469, 216);
            this.dgvsukien2.TabIndex = 4;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvsukien2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(9, 364);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(473, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sự kiện";
            // 
            // btnupdate
            // 
            this.btnupdate.Image = ((System.Drawing.Image) (resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(139, 150);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 40);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnremove
            // 
            this.btnremove.Image = ((System.Drawing.Image) (resources.GetObject("btnremove.Image")));
            this.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremove.Location = new System.Drawing.Point(240, 150);
            this.btnremove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(81, 40);
            this.btnremove.TabIndex = 2;
            this.btnremove.Text = "Xóa";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image) (resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(29, 150);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(81, 40);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtRuleContent
            // 
            this.txtRuleContent.Location = new System.Drawing.Point(112, 89);
            this.txtRuleContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRuleContent.Name = "txtRuleContent";
            this.txtRuleContent.Size = new System.Drawing.Size(183, 23);
            this.txtRuleContent.TabIndex = 1;
            // 
            // txtRuleId
            // 
            this.txtRuleId.Location = new System.Drawing.Point(112, 54);
            this.txtRuleId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRuleId.Name = "txtRuleId";
            this.txtRuleId.Size = new System.Drawing.Size(183, 23);
            this.txtRuleId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Luật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(72, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập thông tin tìm kiếm";
            // 
            // rdosukien
            // 
            this.rdosukien.AutoSize = true;
            this.rdosukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rdosukien.Location = new System.Drawing.Point(75, 61);
            this.rdosukien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdosukien.Name = "rdosukien";
            this.rdosukien.Size = new System.Drawing.Size(131, 21);
            this.rdosukien.TabIndex = 3;
            this.rdosukien.TabStop = true;
            this.rdosukien.Text = "Tìm kiếm sự kiện";
            this.rdosukien.UseVisualStyleBackColor = true;
            // 
            // rdoluat
            // 
            this.rdoluat.AutoSize = true;
            this.rdoluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rdoluat.Location = new System.Drawing.Point(75, 27);
            this.rdoluat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoluat.Name = "rdoluat";
            this.rdoluat.Size = new System.Drawing.Size(109, 21);
            this.rdoluat.TabIndex = 2;
            this.rdoluat.TabStop = true;
            this.rdoluat.Text = "Tìm kiếm luật";
            this.rdoluat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btntimkiem.Image = ((System.Drawing.Image) (resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(88, 162);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(116, 36);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.rdosukien);
            this.groupBox4.Controls.Add(this.rdoluat);
            this.groupBox4.Controls.Add(this.btntimkiem);
            this.groupBox4.Controls.Add(this.txttimkiem);
            this.groupBox4.Location = new System.Drawing.Point(528, 383);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(326, 217);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txttimkiem.Location = new System.Drawing.Point(75, 121);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(156, 23);
            this.txttimkiem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 613);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btnremove);
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Controls.Add(this.txtRuleContent);
            this.groupBox3.Controls.Add(this.txtRuleId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.Location = new System.Drawing.Point(528, 109);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(326, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin luật";
            // 
            // RuleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 613);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RuleViewForm";
            this.Text = "RuleViewForm";
            ((System.ComponentModel.ISupportInitialize) (this.dgvluat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvsukien2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn nd;
        private System.Windows.Forms.DataGridView dgvluat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn masukien;
        private System.Windows.Forms.DataGridView dgvsukien2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtRuleContent;
        private System.Windows.Forms.TextBox txtRuleId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdosukien;
        private System.Windows.Forms.RadioButton rdoluat;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}