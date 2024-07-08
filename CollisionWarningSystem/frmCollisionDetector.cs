using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using lobe;
using lobe.ImageSharp;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Patagames.Ocr;
using SixLabors.ImageSharp.PixelFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollisionWarningSystem
{
    public partial class frmCollisionDetector : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bnsvPNJq9Pwl3GbOIj6XYkolleGDZOkIyCCljbXr",
            BasePath = "https://mysmarthome-5b759.firebaseio.com/"
        };

        private IFirebaseClient client;

        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;

        public frmCollisionDetector()
        {
            InitializeComponent();

            //Open camera
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);
        }

        private void frmCollisionDetector_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
        }

        private void lblCamera_MouseLeave(object sender, EventArgs e)
        {
            this.lblCamera.BackColor = SystemColors.GradientActiveCaption;
            this.lblCamera.ForeColor = SystemColors.MenuHighlight;
            this.lblCamera.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblCamera_MouseEnter(object sender, EventArgs e)
        {
            this.lblCamera.BackColor = Color.FromArgb(51, 153, 255);
            this.lblCamera.ForeColor = Color.White;
            this.lblCamera.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUpload_MouseLeave(object sender, EventArgs e)
        {
            this.lblUpload.BackColor = SystemColors.GradientActiveCaption;
            this.lblUpload.ForeColor = SystemColors.MenuHighlight;
            this.lblUpload.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.lblOCR.BackColor = SystemColors.GradientActiveCaption;
            this.lblOCR.ForeColor = SystemColors.MenuHighlight;
            this.lblOCR.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblUpload_MouseEnter(object sender, EventArgs e)
        {
            this.lblUpload.BackColor = Color.FromArgb(51, 153, 255);
            this.lblUpload.ForeColor = Color.White;
            this.lblUpload.BorderStyle = BorderStyle.Fixed3D;
        }


        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.lblOCR.BackColor = Color.FromArgb(51, 153, 255);
            this.lblOCR.ForeColor = Color.White;
            this.lblOCR.BorderStyle = BorderStyle.Fixed3D;
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            ////IFirebaseClient client = new FirebaseClient(config);
            //if (client != null)
            //{
            //    MessageBox.Show("Connection is established.");
            //}
            //var data = new Data
            //{
            //    ComputerUseTime = "120",
            //    KeywordFilter = "1",
            //    ProhibitInternetUse = "1",
            //    SoftwareProhibit = "1"
            //};
            //SetResponse response = await client.SetTaskAsync<Data>("ParentalControl", data);
            //Data result = response.ResultAs<Data>();
            //if (result != null)
            //{
            //    MessageBox.Show(result.KeywordFilter + "-" + result.ProhibitInternetUse + "-" + result.ComputerUseTime);
            //}
        }

        private async void label2_Click(object sender, EventArgs e)
        {
            //if (client != null)
            //{
            //    MessageBox.Show("Connection is established.");
            //}

            //FirebaseResponse response = await client.GetTaskAsync("ParentalControl/");
            //Data result = response.ResultAs<Data>();
            //if (result != null)
            //{
            //    MessageBox.Show(result.KeywordFilter + "-" + result.ProhibitInternetUse + "-" + result.ComputerUseTime);
            //}
        }

        private void lblCamera_Click(object sender, EventArgs e)
        {
            try
            {
                string imagePath = "img" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                pictureBox1.Image.Save(imagePath);
                string label = Predict(imagePath);
                this.lblInformation.Text = label;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void lblOCR_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    this.lblInformation.Text = fileName;
                }
                //Resize image
                string imagePath = "img" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
                FileStream fs = new FileStream(fileName, FileMode.Open);
                Image originalImage = System.Drawing.Image.FromStream(fs, true, true);
                Image resizedImage = originalImage.GetThumbnailImage(499, (499 * originalImage.Height) / originalImage.Width, null, IntPtr.Zero);
                resizedImage.Save(imagePath, ImageFormat.Png);

                if (this.lblInformation.Text.Length != 0)
                {
                    using (var api = OcrApi.Create())
                    {
                        api.Init(Patagames.Ocr.Enums.Languages.Vietnamese, "../../../tessdata");
                        string text = api.GetTextFromImage(imagePath);
                        lblInformation.Text = text;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private string Predict(string fileName)
        {
            try
            {
                string signatureFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../../model/signature.json");
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

        private void lblUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog1.FileName;
                    string label = Predict(filename);
                    this.lblInformation.Text = label;

                    SoundPlayer player = new SoundPlayer();
                    string sound = "";
                    if (label.Contains("xanh"))
                    {
                        sound = "../../../../audio/green.mp3";
                    }
                    else
                    {
                        sound = "../../../../audio/red.mp3";
                    }
                    player.SoundLocation = sound;
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
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

        //Resize image
        private string ImageResize(string path, int newW, int newH)
        {
            string imagePath = Guid.NewGuid().ToString();
            FileStream fs = new FileStream(path, FileMode.Open);
            Image originalImage = System.Drawing.Image.FromStream(fs, true, true);
            Image resizedImage = originalImage.GetThumbnailImage(newW, (newW * originalImage.Height) / originalImage.Width, null, IntPtr.Zero);
            resizedImage.Save(imagePath, ImageFormat.Png);
            return imagePath;
        }
    }
}
