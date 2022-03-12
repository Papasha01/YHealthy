using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace YHealthy.Forms
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        YHealthyDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new YHealthyDataSetTableAdapters.UsersTableAdapter();
        YHealthyDataSet.UsersDataTable dbuser;
        YHealthyDataSetTableAdapters.RecordTableAdapter recordTableAdapter = new YHealthyDataSetTableAdapters.RecordTableAdapter();
        YHealthyDataSet.RecordDataTable dbrecord;

        private void SignIn_Click(object sender, EventArgs e)
        {
            SinglIn();
        }

        private void SinglIn()
        {
            string log, pas;
            pas = TBPassword.Text;
            log = TBEmail.Text;

            dbuser = usersTableAdapter.GetData();
            dbrecord = recordTableAdapter.GetData();

            var filter = dbuser.Where(x => x.login == log && x.pass == pas);
            if (filter.Count() != 0)
            {
                ClassTotal.idRole = filter.ElementAt(0).id_role;
                ClassTotal.login = filter.ElementAt(0).login;
                ClassTotal.idUser = filter.ElementAt(0).id;

                switch (ClassTotal.idRole)
                {
                    case 1:     //admin
                        Menu rl1 = new Menu();
                        Hide();
                        rl1.ShowDialog();
                        Show();
                        break;
                    case 2:     //doc
                        Menu rl2 = new Menu();
                        Hide();
                        rl2.ShowDialog();
                        Show();
                        break;
                    case 3:     //pac
                        Menu rl3 = new Menu();
                        Hide();
                        rl3.ShowDialog();
                        Show();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Логин или пароль неверный");
                TBEmail.Clear();
                TBPassword.Clear();
            }
        }

        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                SinglIn();
            }
        }
    }
}
