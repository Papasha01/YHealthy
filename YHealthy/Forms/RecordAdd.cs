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
    public partial class RecordAdd : Form
    {
        public RecordAdd()
        {
            InitializeComponent();
        }

        YHealthyDataSetTableAdapters.RecordTableAdapter RecordTableAdapter = new YHealthyDataSetTableAdapters.RecordTableAdapter();
        YHealthyDataSet.RecordDataTable dbRecord;

        YHealthyDataSetTableAdapters.DoctorsTableAdapter DoctorsTableAdapter = new YHealthyDataSetTableAdapters.DoctorsTableAdapter();
        YHealthyDataSet.DoctorsDataTable dbDoctors;

        YHealthyDataSetTableAdapters.PatientTableAdapter PatientTableAdapter = new YHealthyDataSetTableAdapters.PatientTableAdapter();
        YHealthyDataSet.PatientDataTable dbPatient;

        int idDoc, idPat;

        private void RecordAdd_Load(object sender, EventArgs e)
        {
            dbRecord = RecordTableAdapter.GetData();
            dbDoctors = DoctorsTableAdapter.GetData();
            dbPatient = PatientTableAdapter.GetData();
            dataGridViewDoc.DataSource = dbDoctors;
            dataGridViewPat.DataSource = dbPatient;

            idDoc = 1;
            idPat = 1;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            //dbDoctors = (YHealthyDataSet.DoctorsDataTable)dataGridViewDoc.CurrentRow.DataBoundItem;
            //dbPatient = (YHealthyDataSet.PatientDataTable)dataGridViewPat.CurrentRow.DataBoundItem;
            DateTime birthday = dateTimePicker1.Value;
            RecordTableAdapter.Insert(idDoc, idPat, birthday, false);
            MessageBox.Show("Успешно!");
            this.Close();
        }

        private void textBoxDoc_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewDoc.DataSource as DataTable).DefaultView.RowFilter = String.Format("full_name like '*{0}*'", textBoxDoc.Text);
        }

        private void dataGridViewDoc_MouseClick(object sender, MouseEventArgs e)
        {
            idDoc = Convert.ToInt32(dataGridViewDoc[0, dataGridViewDoc.CurrentRow.Index].Value);
        }

        private void dataGridViewPat_MouseClick(object sender, MouseEventArgs e)
        {
            idPat = Convert.ToInt32(dataGridViewPat[0, dataGridViewPat.CurrentRow.Index].Value);
        }

        private void textBoxPat_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewPat.DataSource as DataTable).DefaultView.RowFilter = String.Format("full_name like '*{0}*'", textBoxPat.Text);
        }
    }
}
