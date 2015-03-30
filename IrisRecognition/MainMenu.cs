using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrisRecognition
{
    public partial class MainMenu : Form
    {
        public MainMenu(int admin)
        {
            InitializeComponent();
            var result = (from x in db.Administrators
                         where x.AdminID.Equals(admin)
                         select x).FirstOrDefault();

            labelUsername.Text = "Welcome! " + result.FName + " " + result.LName;
            loggedin = admin;
        }

        int loggedin;
        IrisDatabaseDataContext db = new IrisDatabaseDataContext();

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser au = new AddUser(loggedin);
            this.Owner = au;
            au.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser du = new DeleteUser(loggedin);
            this.Owner = du;
            du.Show();
        }

        private void buttonViewLogFiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLogFiles vlf = new ViewLogFiles(loggedin);
            this.Owner = vlf;
            vlf.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //labelUsername.Text = "Welcome" + 

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewUsers vu = new ViewUsers(loggedin);
            this.Owner = vu;
            vu.Show();
        }
    }
}
