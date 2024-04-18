using lobe;
using lobe.ImageSharp;
using Microsoft.ML.OnnxRuntime;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Patagames.Ocr;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollisionWarningSystem
{
    public partial class frmMain : Form
    {
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;

        public frmMain()
        {
            InitializeComponent();

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
        }
        private string Predict(string fileName)
        {
            try
            {
                string signatureFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../model/signature.json");
                var imageToClassify = fileName;//File ảnh cần chẩn đoán

                lobe.ImageClassifier.Register("onnx", () => new OnnxImageClassifier());
                var classifier = ImageClassifier.CreateFromSignatureFile(new FileInfo(signatureFilePath));

                //Phân loại ảnh  
                var results = classifier.Classify(SixLabors.ImageSharp.Image.Load(imageToClassify).CloneAs<Rgb24>());
                return results.Prediction.Label;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (capture.IsOpened())
            {
                capture.Read(frame);
                image = BitmapConverter.ToBitmap(frame);
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string label = Predict(filename);
                this.textBox1.Text = label;
            }
        }
        private string ImageResize(string path, int newW, int newH)
        {
            string imagePath = Guid.NewGuid().ToString();
            FileStream fs = new FileStream(path, FileMode.Open);
            Image originalImage = System.Drawing.Image.FromStream(fs, true, true);
            Image resizedImage = originalImage.GetThumbnailImage(newW, (newW * originalImage.Height) / originalImage.Width, null, IntPtr.Zero);
            resizedImage.Save(imagePath, ImageFormat.Png);
            return imagePath;
        }
        private void btnOCR_Click(object sender, EventArgs e)
        {
            var fileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                this.textBox1.Text = fileName;
            }
            //Resize image
            string imagePath = "img" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png"; 
            FileStream fs = new FileStream(fileName, FileMode.Open);
            Image originalImage = System.Drawing.Image.FromStream(fs, true, true);
            Image resizedImage = originalImage.GetThumbnailImage(499, (499 * originalImage.Height) / originalImage.Width, null, IntPtr.Zero);
            resizedImage.Save(imagePath, ImageFormat.Png);

            if (this.textBox1.Text.Length != 0)
            {
                using (var api = OcrApi.Create())
                {
                    api.Init(Patagames.Ocr.Enums.Languages.Vietnamese,"../../../tessdata");
                    string text = api.GetTextFromImage(imagePath);
                    textBox1.Text = text;
                }
            }
        }
    }
}
