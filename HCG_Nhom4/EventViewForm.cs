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
    public partial class EventViewForm : Form
    {
        private EventDAO eventDao = new EventDAO();
        private CategoryDAO categoryDao = new CategoryDAO();

        public EventViewForm()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            eventDao.Insert(txtsukien.Text, txtmota.Text, cbCategory.SelectedValue.ToString());
            load();
        }

        private void EventViewForm_Load(object sender, EventArgs e)
        {
           load();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            eventDao.Update(txtsukien.Text, txtmota.Text, cbCategory.SelectedValue.ToString());
            load();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            eventDao.Delete(txtsukien.Text);
            load();
        }

        private void dgvsukien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                txtsukien.Text = dgvsukien.Rows[index].Cells[0].Value.ToString();
                txtmota.Text = dgvsukien.Rows[index].Cells[1].Value.ToString();
                cbCategory.SelectedValue = dgvsukien.Rows[index].Cells[2].Value.ToString();
            }
        }

        public void load()
        {
            var dataTable = eventDao.GetDisplayData();
            dgvsukien.DataSource = dataTable;
            cbCategory.DataSource = categoryDao.GetAllData();
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "id";
            cbCategory.SelectedItem = null;
        }
    }
}