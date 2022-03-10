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


        private void RecordAdd_Load(object sender, EventArgs e)
        {
            dbRecord = RecordTableAdapter.GetData();
            
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
        }

        private void textBoxDoc_TextChanged(object sender, EventArgs e)
        {
            dbDoctors = DoctorsTableAdapter.GetData();
            //var filter = dbDoctors.Where(x => x.patronymic.Contains(textBoxDoc.Text));
            //listBox1.Items.Add(filter);

        }

        private void textBoxPat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
