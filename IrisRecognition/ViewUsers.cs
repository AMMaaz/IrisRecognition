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
    public partial class ViewUsers : Form
    {
        public ViewUsers(int admin)
        {
            InitializeComponent();
            loggedin = admin;
        }

        int loggedin;
        IrisDatabaseDataContext db = new IrisDatabaseDataContext();

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = from u in db.Persons
                                           select new
                                           {
                                               u.PersonID,
                                               u.ID,
                                               First_Name = u.FName,
                                               Last_Name = u.LName,
                                               u.Gender,
                                               u.Address,
                                               u.CNIC,
                                               u.Phone,
                                               u.Mobile,
                                               u.Email,
                                               Date_of_Birth = u.DoB,
                                               u.Designation,
                                               u.Department,
                                               u.Province,
                                               Registered_By = u.RegisteredBy,
                                           };
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu(loggedin);
            this.Owner = mm;
            mm.Show();
        }
    }
}
