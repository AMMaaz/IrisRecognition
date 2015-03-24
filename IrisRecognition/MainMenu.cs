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
        public MainMenu(string username)
        {
            InitializeComponent();
            labelUsername.Text = "Welcome! " + username;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser au = new AddUser();
            this.Owner = au;
            au.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser du = new DeleteUser();
            this.Owner = du;
            du.Show();
        }

        private void buttonViewLogFiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLogFiles vlf = new ViewLogFiles();
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
    }
}
