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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

        YHealthyDataSetTableAdapters.PatientTableAdapter recordTableAdapter = new YHealthyDataSetTableAdapters.PatientTableAdapter();
        YHealthyDataSet.RecordDataTable dbrecord;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void Create()
        {
            DateTime birthday = dtPickerBirthday.Value;

            try
            {
                recordTableAdapter.Insert(textBoxName.Text, cbGenders.Text, birthday, textBoxPhone.Text, TextBoxPassport.Text, TextBoxINN.Text, 0);
                
                MessageBox.Show("Ваш профиль добавлен в систему");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при добавлении профиля \n" + e);
            }
            
        }
    }
}
