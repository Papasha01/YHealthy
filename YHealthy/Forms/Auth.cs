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

        private void SignIn_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = TBPassword.Text;
            log = TBEmail.Text;
            dbuser = usersTableAdapter.GetData();
            var filter = dbuser.Where(qwe => qwe.login == log && qwe.pass == pas);
            if (filter.Count() != 0)
            {
                dataGridView1.DataSource = dbuser;
            }
        }
    }
}
