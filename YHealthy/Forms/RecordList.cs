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
        YHealthyDataSet.RecordRow recordRow;

        private void Record_List_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        public void UpdateDGV()
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

        private void RecordList_VisibleChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            recordRow = (YHealthyDataSet.RecordRow)dtRow.Row;
            //MessageBox.Show(Convert.ToString(recordRow.id_doc));

            ClassTotal.id_doc = Convert.ToInt32(recordRow.id_doc);
            ClassTotal.id_pac = Convert.ToInt32(recordRow.id_pat);
            ClassTotal.dateRecord = recordRow.date;


            Record_info_edit rll = new Record_info_edit();
            Hide();
            rll.edit = false;
            rll.ShowDialog();
            Show();
        }
    }
}
