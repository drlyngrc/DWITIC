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
using System.Net.NetworkInformation;
using System.Drawing.Drawing2D;

namespace DWITIC
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Size = new Size(1188, 656);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

        }

        private void btnUploadNow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != null)
            {
                picBoxUpload.ImageLocation = ofd.FileName;
            }
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(picBoxUpload.ImageLocation))
            {
                MessageBox.Show("Please upload an image first.");
                return;
            }

            var imageBytes = File.ReadAllBytes(picBoxUpload.ImageLocation);
            UploadModel.ModelInput sampleData = new UploadModel.ModelInput()
            {
                ImageSource = imageBytes,
            };

            var result = UploadModel.Predict(sampleData);

            var labelInfo = LabelData.Labels.FirstOrDefault(label => label.Label == result.PredictedLabel);

            if (labelInfo != null)
            {
                string message = $"{labelInfo.Label} {labelInfo.Classification}";
                string info = $"{labelInfo.Description}";
                string sdg = $"{labelInfo.SDG}";

                foreach (string imagePath in labelInfo.ImagePaths)
                {
                    picBoxSDG.Image = Image.FromFile(imagePath);
                }
                textBox1.Text = info;
                textBox2.Text = message;
                textBoxSDG.Text = sdg;
            }
            else
            {
                MessageBox.Show("Label information not found.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
