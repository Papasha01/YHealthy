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
            if (ClassTotal.idRole == 2)
            {
                dataGridView1.DataSource = dbrecord.Where(x => x.id_doc == ClassTotal.id_doc);
            }
            else if (ClassTotal.idRole == 3)
            {
                dataGridView1.DataSource = dbrecord.Where(x => x.id_pat == ClassTotal.id_pat);
            }
            
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
            DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            recordRow = (YHealthyDataSet.RecordRow)dtRow.Row;
            try
            {
            recordTableAdapter.Delete(recordRow.id, recordRow.id_doc, recordRow.id_pat, recordRow.date);
                MessageBox.Show("Успешно!");
                UpdateDGV();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                throw;
            }
            
        }

        private void InfoRecord()
        {
            DataRowView dtRow = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            recordRow = (YHealthyDataSet.RecordRow)dtRow.Row;
            //MessageBox.Show(Convert.ToString(recordRow.id_doc));

            ClassTotal.id_doc = Convert.ToInt32(recordRow.id_doc);
            ClassTotal.id_pat = Convert.ToInt32(recordRow.id_pat);
            ClassTotal.dateRecord = recordRow.date;


            Record_info_edit x = new Record_info_edit();
            Hide();
            ClassTotal.edit = false;
            x.ShowDialog();
            Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InfoRecord();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            InfoRecord();
        }
    }
}
