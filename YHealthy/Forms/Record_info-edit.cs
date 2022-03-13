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

        YHealthyDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter = new YHealthyDataSetTableAdapters.DoctorsTableAdapter();
        YHealthyDataSet.DoctorsDataTable dbDoc;
        YHealthyDataSetTableAdapters.PatientTableAdapter patientTableAdapter = new YHealthyDataSetTableAdapters.PatientTableAdapter();
        YHealthyDataSet.PatientDataTable dbPac;
        YHealthyDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new YHealthyDataSetTableAdapters.UsersTableAdapter();
        YHealthyDataSet.UsersDataTable dbUser;

        YHealthyDataSet.DoctorsRow doctorsRow;
        YHealthyDataSet.PatientRow patientRow;

        private void Record_info_edit_Load(object sender, EventArgs e)
        {
            if (ClassTotal.edit == true)
            {
                buttonSave.Visible = true;
                radioButtonPat.Visible = false;
                radioButtonDoc.Visible = false;
                if (ClassTotal.selectDoc == true)
                {
                    groupBoxDoc.Visible = true;
                    groupBoxPat.Visible = false;
                }
                else if (ClassTotal.selectPat == true)
                {
                    groupBoxDoc.Visible = false;
                    groupBoxPat.Visible = true;
                }
            }
            else if (ClassTotal.creating == true)
            {
                buttonSave.Visible = true;
                textBoxLogin.Visible = true;
                textBoxPas.Visible = true;
                label17.Visible = true;
                label16.Visible = true;
            }

            dateTimePickerRecord.Format = DateTimePickerFormat.Custom;
            dateTimePickerRecord.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            if (ClassTotal.creating == false)
            {
                if (ClassTotal.edit != true)
                {
                    UploadInfoDoc();
                    UploadInfoPat();
                }
                else if (ClassTotal.selectDoc == true)
                {
                    UploadInfoDoc();
                }
                else if (ClassTotal.selectPat == true)
                {
                    UploadInfoPat();
                }
            }
            else
            {
                if (ClassTotal.selectDoc == true)
                {
                    radioButtonDoc.Visible = false;
                    radioButtonPat.Visible = false;
                    label3.Visible = false;
                    dateTimePickerRecord.Visible = false;
                    groupBoxPat.Visible = false;
                    groupBoxDoc.Visible = true;
                }
                else if (ClassTotal.selectPat == true)
                {
                    radioButtonDoc.Visible = false;
                    radioButtonPat.Visible = false;
                    label3.Visible = false;
                    dateTimePickerRecord.Visible = false;
                    groupBoxPat.Visible = true;
                    groupBoxDoc.Visible = false;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ClassTotal.creating == true)
            {
                if (ClassTotal.selectDoc == true)
                {
                    CreateDoc();
                }
                else if (ClassTotal.selectPat == true)
                {
                    CreatePat();
                }
            }
            else if (ClassTotal.edit == true)
            {
                if (ClassTotal.selectDoc == true)
                {
                    EditDoc();
                }
                else if (ClassTotal.selectPat == true)
                {
                    EditPat();
                }
            }
            
        }

        private void CreateDoc()
        {
            DateTime birthdayDoc = dateTimePickerDoc.Value;

            try
            {
                usersTableAdapter.Insert(
                    textBoxLogin.Text,
                    textBoxPas.Text,
                    2);
                doctorsTableAdapter.Insert(
                    txFioDoc.Text,
                    txGenderDoc.Text,
                    birthdayDoc,
                    txPositionDoc.Text,
                    txPhoneDoc.Text,
                    Convert.ToInt32(txPriceDoc.Text),
                    Convert.ToInt32(txCashDoc.Text),
                    textBoxLogin.Text);

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
                patientTableAdapter.Insert(
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
            DateTime birthdayPat = dateTimePickerPat.Value;

            try
            {
                patientRow.full_name = txFioPat.Text;
                patientRow.gender = txGenderPat.Text;
                patientRow.birthday = birthdayPat;
                patientRow.phone = txPhonePat.Text;
                patientRow.passport_ser_num = txPassportPat.Text;
                patientRow.inn = txInnPat.Text;
                patientRow.cash = Convert.ToInt32(txCashPat.Text);

                patientTableAdapter.Update(patientRow);
                MessageBox.Show("Ваш профиль добавлен в систему");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при обновлении профиля \n" + e);
            }
        }

        private void EditDoc()
        {

        }

        private void UploadInfoDoc()
        {
            dbDoc = doctorsTableAdapter.GetData();
            doctorsRow = dbDoc.FindByid(ClassTotal.id_doc);
            txFioDoc.Text = doctorsRow.full_name.ToString();
            txPhoneDoc.Text = doctorsRow.phone.ToString();
            txPositionDoc.Text = doctorsRow.position.ToString();
            txPriceDoc.Text = doctorsRow.price.ToString();
            txGenderDoc.Text = doctorsRow.gender.ToString();
            txCashDoc.Text = doctorsRow.cash.ToString();
            if (ClassTotal.edit == false)
                dateTimePickerDoc.Value = doctorsRow.birthday;
        }

        private void UploadInfoPat()
        {
                dbPac = patientTableAdapter.GetData();
                patientRow = dbPac.FindByid(ClassTotal.id_pat);
                txFioPat.Text = patientRow.full_name.ToString();
                txPhonePat.Text = patientRow.phone.ToString();
                txInnPat.Text = patientRow.inn.ToString();
                txPassportPat.Text = patientRow.passport_ser_num.ToString();
                txGenderPat.Text = patientRow.gender.ToString();
                dateTimePickerPat.Value = patientRow.birthday;
                txCashPat.Text = patientRow.cash.ToString();
            if (ClassTotal.edit == false)
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
