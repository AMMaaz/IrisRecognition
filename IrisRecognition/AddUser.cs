using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace IrisRecognition
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        IrisDatabaseDataContext db = new IrisDatabaseDataContext();

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            //p.PersonID = '4';
            p.ID = comboBoxGender.SelectedIndex.ToString() +
                dateTimePickerDateOfBirth.Value.Year.ToString() +
                dateTimePickerDateOfBirth.Value.Month.ToString() +
                dateTimePickerDateOfBirth.Value.Day.ToString() +
                comboBoxDepartment.SelectedIndex.ToString() +
                comboBoxProvince.SelectedIndex.ToString() +
                comboBoxDesignation.SelectedIndex.ToString();

            p.FName = textBoxFName.Text;
            p.LName = textBoxLName.Text;
            p.Phone = textBoxPhone.Text;
            p.Mobile = textBoxMobile.Text;
            
            ImageConverter convert = new ImageConverter();
            byte[] img = (byte[])convert.ConvertTo(pictureBox2.Image, typeof(byte[]));
            p.Photo = img;

            p.DoB = dateTimePickerDateOfBirth.Value;
            p.CNIC = textBoxCNIC.Text;
            p.Address = textBoxAddress.Text;
            p.Department = comboBoxDepartment.Text;
            p.Designation = comboBoxDesignation.Text;
            p.Email = textBoxEmail.Text;
            p.Gender = comboBoxGender.Text;
            p.Province = comboBoxProvince.Text;

            //Iris_Image newIrisImage = new Iris_Image();
            //newIrisImage.ImageID = textBox1.Text;

            //ImageConverter converter = new ImageConverter();
            //byte[] img = (byte[])converter.ConvertTo(pictureBox2.Image, typeof(byte[]));
            //newIrisImage.ImagePattern = (img);

            //newIrisImage.PersonID = Convert.ToInt32(textBox2.Text);
            
            db.Persons.InsertOnSubmit(p);
            db.SubmitChanges();

            AddIrisImage aii = new AddIrisImage(p.PersonID);
            aii.ShowDialog();

            //storing image in iris_image table
            //Iris_Image ii = new Iris_Image();
            ////ii.ImageID = '1';
            ////ii.PersonID = '4';
            
            //ImageConverter converter = new ImageConverter();
            //byte[] imge = (byte[])converter.ConvertTo(pictureBox2.Image, typeof(byte[]));

            //ii.ImagePattern = imge;
            //db.Iris_Images.InsertOnSubmit(ii);
            //db.SubmitChanges();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
        }

        int intgr = 1;

        private void button1_Click(object sender, EventArgs e)
        {

            Iris_Image ii = db.Iris_Images.First(i => i.ImageID == Convert.ToInt32(intgr));

            intgr = intgr + 1;

            //one way
            //idon'tknowwhatiamdoing
            //var bytes = ii.ImagePattern;
            //byte[] trueBytes = bytes.ToArray();
            //if (trueBytes != null)
            //{
            //    using (var ms = new MemoryStream(trueBytes))
            //    {
            //        using (var image = Image.FromStream(ms))
            //        {
            //            pictureBox2.Image = (Image)image.Clone();
            //        }
            //    }
            //}


            //otherway
            MemoryStream mss = new MemoryStream(ii.ImagePattern.ToArray());
            Image img = Image.FromStream(mss);
            

            //doesn't work
            //
            //ImageConverter converter = new ImageConverter();
            //Image img  = (Image)converter.ConvertTo(ii.ImagePattern, typeof(Image));

            pictureBox2.Image = img;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu("anwar");
            this.Owner = mm;
            mm.Show();
        }
    }
}
