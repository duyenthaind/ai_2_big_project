
namespace HCG_Nhom4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelview = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btntuvan = new System.Windows.Forms.Button();
            this.btnsukien = new System.Windows.Forms.Button();
            this.btntapluat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 81);
            this.panel2.TabIndex = 5;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbltitle.Location = new System.Drawing.Point(407, 28);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(122, 37);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Tư Vấn";
            // 
            // panelview
            // 
            this.panelview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelview.Location = new System.Drawing.Point(208, 0);
            this.panelview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelview.Name = "panelview";
            this.panelview.Padding = new System.Windows.Forms.Padding(15, 41, 0, 0);
            this.panelview.Size = new System.Drawing.Size(754, 552);
            this.panelview.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (40)))), ((int) (((byte) (74)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 81);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm 4";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (76)))));
            this.panelmenu.Controls.Add(this.panel3);
            this.panelmenu.Controls.Add(this.btntuvan);
            this.panelmenu.Controls.Add(this.btnsukien);
            this.panelmenu.Controls.Add(this.btntapluat);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(208, 552);
            this.panelmenu.TabIndex = 3;
            // 
            // btntuvan
            // 
            this.btntuvan.FlatAppearance.BorderSize = 0;
            this.btntuvan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntuvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btntuvan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntuvan.Image = ((System.Drawing.Image) (resources.GetObject("btntuvan.Image")));
            this.btntuvan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntuvan.Location = new System.Drawing.Point(0, 81);
            this.btntuvan.Margin = new System.Windows.Forms.Padding(0);
            this.btntuvan.Name = "btntuvan";
            this.btntuvan.Size = new System.Drawing.Size(208, 81);
            this.btntuvan.TabIndex = 1;
            this.btntuvan.Text = "Tư Vấn";
            this.btntuvan.UseVisualStyleBackColor = true;
            this.btntuvan.Click += new System.EventHandler(this.btntuvan_Click);
            // 
            // btnsukien
            // 
            this.btnsukien.FlatAppearance.BorderSize = 0;
            this.btnsukien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnsukien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsukien.Image = ((System.Drawing.Image) (resources.GetObject("btnsukien.Image")));
            this.btnsukien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsukien.Location = new System.Drawing.Point(0, 162);
            this.btnsukien.Margin = new System.Windows.Forms.Padding(0);
            this.btnsukien.Name = "btnsukien";
            this.btnsukien.Size = new System.Drawing.Size(208, 81);
            this.btnsukien.TabIndex = 2;
            this.btnsukien.Text = "Sự Kiện";
            this.btnsukien.UseVisualStyleBackColor = true;
            this.btnsukien.Click += new System.EventHandler(this.btnsukien_Click);
            // 
            // btntapluat
            // 
            this.btntapluat.FlatAppearance.BorderSize = 0;
            this.btntapluat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntapluat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btntapluat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntapluat.Image = ((System.Drawing.Image) (resources.GetObject("btntapluat.Image")));
            this.btntapluat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntapluat.Location = new System.Drawing.Point(0, 243);
            this.btntapluat.Margin = new System.Windows.Forms.Padding(0);
            this.btntapluat.Name = "btntapluat";
            this.btntapluat.Size = new System.Drawing.Size(208, 81);
            this.btntapluat.TabIndex = 3;
            this.btntapluat.Text = "Tập Luật";
            this.btntapluat.UseVisualStyleBackColor = true;
            this.btntapluat.Click += new System.EventHandler(this.btntapluat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelview);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelmenu;
        private System.Windows.Forms.Button btntuvan;
        private System.Windows.Forms.Button btnsukien;
        private System.Windows.Forms.Button btntapluat;
    }
}

