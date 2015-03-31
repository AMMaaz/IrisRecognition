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
    public partial class ViewLogFiles : Form
    {
        public ViewLogFiles(int admin)
        {
            InitializeComponent();
            loggedin = admin;
        }

        int loggedin;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(loggedin);
            this.Owner = mm;
            mm.Show();
        }
    }
}
