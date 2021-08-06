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
    public partial class RuleViewForm : Form
    {
        private EventDAO eventDao = new EventDAO();
        private RuleDAO ruleDao = new RuleDAO();

        public RuleViewForm()
        {
            InitializeComponent();
        }

        public void load()
        {
            var dataTableEventContent = eventDao.GetOnlyEventData();
            dgvEvent.DataSource = dataTableEventContent;
            var dataTableRule = ruleDao.GetAllData();
            dgvRule.DataSource = dataTableRule;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            ruleDao.Insert(txtRuleId.Text, txtRuleContent.Text);
            load();
        }
        private void RuleViewForm_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            ruleDao.Update(txtRuleId.Text, txtRuleContent.Text);
            load();
        }

        private void dgvluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                txtRuleId.Text = dgvRule.Rows[index].Cells[0].Value.ToString();
                txtRuleContent.Text = dgvRule.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (rdoRule.Checked == false && rdoEvent.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm");
                return;
            }
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập thông tin tìm kiếm");
                return;
            }
            if (rdoRule.Checked)
            {
                var ruleFounds = ruleDao.GetDataByKey(txtSearch.Text);
                dgvRule.DataSource = ruleFounds;
            }
            else
            {
                var eventFounds = eventDao.GetDataByKey(txtSearch.Text);
                dgvEvent.DataSource = eventFounds;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            ruleDao.Delete(txtRuleId.Text);
            load();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
