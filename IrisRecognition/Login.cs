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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int loggedin;
        IrisDatabaseDataContext db = new IrisDatabaseDataContext();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var result = (from x in db.Administrators
                          where x.Username.Equals(textBoxUsername.Text)
                          & x.Password.Equals(textBoxPassword.Text)
                          select x).FirstOrDefault();
            if (result != null)
            {
                //this.Close();
                //Application.Run(new MainMenu());

                loggedin = result.AdminID;
                MainMenu mm = new MainMenu(loggedin);
                mm.Show();
                this.Owner = mm;
                this.Hide();
            }
            else
            {
                textBoxPassword.Clear();
                MessageBox.Show("Username or Password is incorrect\nPlease re-enter");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
