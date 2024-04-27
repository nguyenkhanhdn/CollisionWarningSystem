using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace CollisionWarningSystem
{
    public partial class frmCollisionDetector : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bnsvPNJq9Pwl3GbOIj6XYkolleGDZOkIyCCljbXr",
            BasePath = "https://mysmarthome-5b759.firebaseio.com/"
        };

        IFirebaseClient client;
        public frmCollisionDetector()
        {
            InitializeComponent();
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
    }
}
