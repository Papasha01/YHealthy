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
            ClassTotal.creating = true;
            ClassTotal.selectDoc = true;
            x.ShowDialog();
            Show();
        }

        private void buttonAddPat_Click(object sender, EventArgs e)
        {
            Record_info_edit x = new Record_info_edit();
            Hide();
            ClassTotal.creating = true;
            ClassTotal.selectPat = true;
            x.ShowDialog();
            Show();
        }

        private void buttonEditDoc_Click(object sender, EventArgs e)
        {
            //Record_info_edit x = new Record_info_edit();
            //Hide();
            //x.edit = true;
            //x.doc = true;
            //x.ShowDialog();
            //Show();
            RecordAdd x = new RecordAdd();
            Hide();
            ClassTotal.edit = true;
            ClassTotal.selectDoc = true;
            x.ShowDialog();
            Show();
        }

        private void buttonEditPat_Click(object sender, EventArgs e)
        {
            RecordAdd x = new RecordAdd();
            Hide();
            ClassTotal.edit = true;
            ClassTotal.selectPat = true;
            x.ShowDialog();
            Show();
        }

        private void Menu_VisibleChanged(object sender, EventArgs e)
        {
            ClassTotal.edit = false;
            ClassTotal.creating = false;
            ClassTotal.selectDoc = false;
            ClassTotal.selectPat = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (ClassTotal.idRole == 3)
            {
                buttonAddDoc.Visible = false;
                buttonEditDoc.Visible = false;
                buttonAddPat.Visible = false;
                buttonEditPat.Visible = false;
            }
            else if (ClassTotal.idRole == 2)
            {
                buttonAddDoc.Visible = false;
                buttonEditDoc.Visible = false;
            }
        }
    }
}
