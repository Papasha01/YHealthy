using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YHealthy.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonRecList_Click(object sender, EventArgs e)
        {
            RecordList x = new RecordList();
            Hide();
            x.ShowDialog();
            Show();
        }

        private void buttonAddDoc_Click(object sender, EventArgs e)
        {
            Record_info_edit x = new Record_info_edit();
            Hide();
            x.creating = true;
            x.doc = true;
            x.ShowDialog();
            Show();
        }

        private void buttonAddPat_Click(object sender, EventArgs e)
        {
            Record_info_edit x = new Record_info_edit();
            Hide();
            x.creating = true;
            x.pat = true;
            x.ShowDialog();
            Show();
        }

        private void buttonEditDoc_Click(object sender, EventArgs e)
        {
            Record_info_edit x = new Record_info_edit();
            Hide();
            x.edit = true;
            x.doc = true;
            x.ShowDialog();
            Show();
        }

        private void buttonEditPat_Click(object sender, EventArgs e)
        {
            Record_info_edit x = new Record_info_edit();
            Hide();
            x.edit = true;
            x.pat = true;
            x.ShowDialog();
            Show();
        }
    }
}
