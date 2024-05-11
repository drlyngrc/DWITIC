using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWITIC
{
    public partial class Scan : Form
    {
        bool _streaming;
        Capture _capture;

        public Scan()
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

        private void Scan_Load(object sender, EventArgs e)
        {
            _streaming = true;
            StartCamera();
        }

        private void StartCamera()
        {
            _capture = new Capture();
            Application.Idle += ProcessFrame;
        }

        private void StopCamera()
        {
            if (_capture != null)
            {
                Application.Idle -= ProcessFrame;
                _capture.Dispose();
            }
        }

        private void btnUploadNow_Click(object sender, EventArgs e)
        {
            if (_streaming)
            {
                CaptureImage();
                StopCamera();
                _streaming = false;
            }
            else
            {
                StartCamera();
                _streaming = true;
            }
        }

        private void CaptureImage()
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            picBoxUpload.Image = bmp;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_streaming)
            {
                CaptureImage();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            base.OnFormClosing(e);
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (picBoxUpload.Image == null)
            {
                MessageBox.Show("Please capture an image first.");
                return;
            }

            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                picBoxUpload.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }

            DWITIC.ScanModel.ModelInput sampleData = new DWITIC.ScanModel.ModelInput()
            {
                ImageSource = imageBytes,
            };

            var result = DWITIC.ScanModel.Predict(sampleData);

            var labelInfo = LabelData.Labels.FirstOrDefault(label => label.Label.Equals(result.PredictedLabel, StringComparison.OrdinalIgnoreCase));

            if (labelInfo != null)
            {
                string message = $"{labelInfo.Label} {labelInfo.Classification}";
                string info = $"{labelInfo.Description}";
                string sdg = $"{labelInfo.SDG}";

                foreach (string imagePath in labelInfo.ImagePaths)
                {
                    if (File.Exists(imagePath))
                    {
                        picBoxSDG.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show($"Image not found: {imagePath}");
                    }
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
