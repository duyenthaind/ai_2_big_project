﻿using System;
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
    public partial class TapLuat : Form
    {
        private EventDAO eventDao = new EventDAO();
        private RuleDAO ruleDao = new RuleDAO();

        public TapLuat()
        {
            InitializeComponent();
        }

        public void load()
        {
            var dataTableEventContent = eventDao.GetOnlyEventData();
            dgvsukien2.DataSource = dataTableEventContent;
            var dataTableRule = ruleDao.GetAllData();
            dgvluat.DataSource = dataTableRule;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            ruleDao.Insert(txtluat.Text, txtmota.Text);
            TapLuat_Load(sender, e);
        }
        private void TapLuat_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            ruleDao.Update(txtluat.Text, txtmota.Text);
            TapLuat_Load(sender, e);
        }

        private void dgvluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                txtluat.Text = dgvluat.Rows[index].Cells[0].Value.ToString();
                txtmota.Text = dgvluat.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (rdoluat.Checked == false && rdosukien.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm");
                return;
            }
            if (txttimkiem.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập thông tin tìm kiếm");
                return;
            }
            if (rdoluat.Checked)
            {
                var ruleFounds = ruleDao.GetDataByKey(txttimkiem.Text);
                dgvluat.DataSource = ruleFounds;
            }
            else
            {
                var eventFounds = eventDao.GetDataByKey(txttimkiem.Text);
                dgvsukien2.DataSource = eventFounds;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            ruleDao.Delete(txtluat.Text);
            TapLuat_Load(sender, e);
        }
    }
}
