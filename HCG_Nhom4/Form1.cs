using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCG_Nhom4
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private Color Selectmau()
        {
            int index = random.Next(Colors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Colors.ColorList.Count);
            }

            tempIndex = index;
            string color = Colors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    DisableButton();
                    Color color = Selectmau();
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                    panel2.BackColor = color;
                    panel3.BackColor = Colors.ChangeColorBrightness(color, -0.3);
                    Colors.PrimaryColor = color;
                    Colors.SecondaryColor = Colors.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
                }
            }
        }

        private void btntuvan_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Tư Vấn";
            ActivateButton(sender);
            panelview.Controls.Clear();
            TuVan frmtuvan = new TuVan() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmtuvan);
            frmtuvan.FormBorderStyle = FormBorderStyle.None;
            frmtuvan.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            panelview.Controls.Clear();
            TuVan frmtuvan = new TuVan() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmtuvan);
            frmtuvan.BringToFront();
            frmtuvan.FormBorderStyle = FormBorderStyle.None;
            frmtuvan.Show();
        }

        private void btnsukien_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Sự Kiện";
            ActivateButton(sender);
            panelview.Controls.Clear();
            SuKien frmsukien = new SuKien() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmsukien);
            frmsukien.FormBorderStyle = FormBorderStyle.None;
            frmsukien.Show();
            frmsukien.load();
        }

        private void btntapluat_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Tập Luật";
            ActivateButton(sender);
            panelview.Controls.Clear();
            TapLuat frmtapluat = new TapLuat() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmtapluat);
            frmtapluat.FormBorderStyle = FormBorderStyle.None;
            frmtapluat.Show();
            frmtapluat.load();
        }
    }
}