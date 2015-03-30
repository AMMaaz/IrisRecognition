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
    public partial class DeleteUser : Form
    {
        public DeleteUser(int admin)
        {
            InitializeComponent();
            loggedin = admin;
        }

        int loggedin;
        IrisDatabaseDataContext db = new IrisDatabaseDataContext();

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Person p = db.Persons.First(person => person.PersonID == Convert.ToInt32(textBox1.Text));
            db.Persons.DeleteOnSubmit(p);
            Iris_Image ii = db.Iris_Images.First(Iris_Image => Iris_Image.PersonID == Convert.ToInt32(textBox1.Text));
            db.Iris_Images.DeleteOnSubmit(ii);
            db.SubmitChanges();
            MessageBox.Show("User Deleted");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(loggedin);
            this.Owner = mm;
            mm.Show();
        }
    }
}
