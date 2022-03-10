using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YHealthy.YHealthyDataSetTableAdapters;

namespace YHealthy.Forms
{
    public partial class RecordList : Form
    {
        public RecordList()
        {
            InitializeComponent();
        }

        YHealthyDataSetTableAdapters.RecordTableAdapter recordTableAdapter = new YHealthyDataSetTableAdapters.RecordTableAdapter();
        YHealthyDataSet.RecordDataTable dbrecord;

        private void Record_List_Load(object sender, EventArgs e)
        {
            dbrecord = recordTableAdapter.GetData();
            dataGridView1.DataSource = dbrecord;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            Hide();
            p.ShowDialog();
            Show();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            RecordAdd r = new RecordAdd();
            Hide();
            r.ShowDialog();
            Show();
        }
    }
}
