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
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private Color SelectRandomColor()
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
                    var color = SelectRandomColor();
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

        private void btnAdvise_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Tư Vấn";
            ActivateButton(sender);
            panelview.Controls.Clear();
            var frmAdvisorView = new AdvisorViewForm() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmAdvisorView);
            frmAdvisorView.FormBorderStyle = FormBorderStyle.None;
            frmAdvisorView.Show();
            frmAdvisorView.load();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            random = new Random();
            panelview.Controls.Clear();
            var frmAdvisorView = new AdvisorViewForm() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frmAdvisorView);
            frmAdvisorView.BringToFront();
            frmAdvisorView.FormBorderStyle = FormBorderStyle.None;
            frmAdvisorView.Show();
            frmAdvisorView.load();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Sự Kiện";
            ActivateButton(sender);
            panelview.Controls.Clear();
            var frameEventView = new EventViewForm() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frameEventView);
            frameEventView.FormBorderStyle = FormBorderStyle.None;
            frameEventView.Show();
            frameEventView.load();
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Tập Luật";
            ActivateButton(sender);
            panelview.Controls.Clear();
            var frameRuleView = new RuleViewForm() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            panelview.Controls.Add(frameRuleView);
            frameRuleView.FormBorderStyle = FormBorderStyle.None;
            frameRuleView.Show();
            frameRuleView.load();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}