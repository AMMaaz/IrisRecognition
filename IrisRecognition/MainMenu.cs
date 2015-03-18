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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
            AddUser au = new AddUser();
            au.Show();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteUser du = new DeleteUser();
            du.Show();
        }

        private void buttonViewLogFiles_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewLogFiles vlf = new ViewLogFiles();
            vlf.Show();
        }
    }
}
