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
    public partial class AddIrisImage : Form
    {
        public AddIrisImage()
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
            Iris_Image ii = new Iris_Image();

            ImageConverter converter = new ImageConverter();
            byte[] img = (byte[])converter.ConvertTo(pictureBoxIris.Image, typeof(byte[]));

            ii.ImagePattern = img;

            db.Iris_Images.InsertOnSubmit(ii);
            db.SubmitChanges();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBoxIris.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
