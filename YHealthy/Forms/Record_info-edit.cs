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
    public partial class Record_info_edit : Form
    {
        public Record_info_edit()
        {
            InitializeComponent();
        }

        YHealthyDataSetTableAdapters.DoctorsTableAdapter DoctorsTableAdapter = new YHealthyDataSetTableAdapters.DoctorsTableAdapter();
        YHealthyDataSet.DoctorsDataTable dbDoc;
        YHealthyDataSetTableAdapters.PatientTableAdapter PatientTableAdapter = new YHealthyDataSetTableAdapters.PatientTableAdapter();
        YHealthyDataSet.PatientDataTable dbPac;

        YHealthyDataSet.DoctorsRow doctorsRow;
        YHealthyDataSet.PatientRow patientRow;

        public bool edit = false, doc = false, pat = false, creating = false;

        private void Record_info_edit_Load(object sender, EventArgs e)
        {
            if (edit == true)
            {
                buttonSave.Visible = true;
                radioButtonPat.Visible = false;
                radioButtonDoc.Visible = false;
                if (doc == true)
                {
                    groupBoxDoc.Visible = true;
                    groupBoxPat.Visible = false;
                }
                else if (pat == true)
                {
                    groupBoxDoc.Visible = false;
                    groupBoxPat.Visible = true;
                }
            }

            else
                buttonSave.Visible = false;


            dateTimePickerRecord.Format = DateTimePickerFormat.Custom;
            dateTimePickerRecord.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            UploadInfo();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (creating == true)
            {
                if (doc == true)
                {
                    CreatePat();
                }
                else if (pat == true)
                {
                    CreateDoc();
                }
            }
            else if (edit == true)
            {
                if (doc == true)
                {
                    EditPat();
                }
                else if (pat == true)
                {
                    EditDoc();
                }
            }
            
        }

        private void CreateDoc()
        {
            DateTime birthdayDoc = dateTimePickerDoc.Value;

            try
            {
                DoctorsTableAdapter.Insert(txFioDoc.Text, 
                    txGenderDoc.Text, 
                    birthdayDoc, 
                    txPositionDoc.Text, 
                    txPhoneDoc.Text, 
                    Convert.ToInt32(txPriceDoc.Text), 
                    Convert.ToInt32(txCashDoc.Text)); 

                MessageBox.Show("Ваш профиль добавлен в систему");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при добавлении профиля \n" + e);
            }
        }

        private void CreatePat()
        {
            DateTime birthdayPat = dateTimePickerPat.Value;

            try
            {
                PatientTableAdapter.Insert(
                    txFioPat.Text,
                    txGenderPat.Text,
                    birthdayPat, 
                    txPhonePat.Text, 
                    txPassportPat.Text, 
                    txInnPat.Text, 
                    Convert.ToInt32(txCashPat.Text));

                MessageBox.Show("Ваш профиль добавлен в систему");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при добавлении профиля \n" + e);
            }
        }

        private void EditPat()
        {

        }

        private void EditDoc()
        {

        }

        private void UploadInfo()
        {
            dbDoc = DoctorsTableAdapter.GetData();
            dbPac = PatientTableAdapter.GetData();

            doctorsRow = dbDoc.FindByid(ClassTotal.id_doc);
            txFioDoc.Text = doctorsRow.full_name.ToString();
            txPhoneDoc.Text = doctorsRow.phone.ToString();
            txPositionDoc.Text = doctorsRow.position.ToString();
            txPriceDoc.Text = doctorsRow.price.ToString();
            txGenderDoc.Text = doctorsRow.gender.ToString();
            dateTimePickerDoc.Value = doctorsRow.birthday;

            patientRow = dbPac.FindByid(ClassTotal.id_pac);
            txFioPat.Text = patientRow.full_name.ToString();
            txPhonePat.Text = patientRow.phone.ToString();
            txInnPat.Text = patientRow.inn.ToString();
            txPassportPat.Text = patientRow.passport_ser_num.ToString();
            txGenderPat.Text = patientRow.gender.ToString();
            dateTimePickerPat.Value = patientRow.birthday;

            dateTimePickerRecord.Value = ClassTotal.dateRecord;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPat.Checked == true)
            {
                groupBoxPat.Visible = true;
                groupBoxDoc.Visible = false;
            }
            else
            {
                groupBoxPat.Visible = false;
                groupBoxDoc.Visible = true;
            }
        }
    }
}
