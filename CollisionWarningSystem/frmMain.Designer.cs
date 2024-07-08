namespace CollisionWarningSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnOCR = new Button();
            btnFromImage = new Button();
            btnFromVideo = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(39, 40);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1531, 828);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(8, 59);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1515, 761);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Collision Warning System";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(4, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btnOCR);
            splitContainer1.Panel1.Controls.Add(btnFromImage);
            splitContainer1.Panel1.Controls.Add(btnFromVideo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1507, 753);
            splitContainer1.SplitterDistance = 519;
            splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 605);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 95);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 524);
            label1.Name = "label1";
            label1.Size = new Size(157, 45);
            label1.TabIndex = 8;
            label1.Text = "Thông tin";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(36, 448);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 22);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnOCR
            // 
            btnOCR.Location = new Point(30, 301);
            btnOCR.Name = "btnOCR";
            btnOCR.Size = new Size(443, 92);
            btnOCR.TabIndex = 6;
            btnOCR.Text = "O C R";
            btnOCR.UseVisualStyleBackColor = true;
            btnOCR.Click += btnOCR_Click;
            // 
            // btnFromImage
            // 
            btnFromImage.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnFromImage.Location = new Point(30, 173);
            btnFromImage.Margin = new Padding(4);
            btnFromImage.Name = "btnFromImage";
            btnFromImage.Size = new Size(443, 95);
            btnFromImage.TabIndex = 3;
            btnFromImage.Text = "From image";
            btnFromImage.UseVisualStyleBackColor = true;
            btnFromImage.Click += btnFromImage_Click;
            // 
            // btnFromVideo
            // 
            btnFromVideo.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnFromVideo.Location = new Point(30, 44);
            btnFromVideo.Margin = new Padding(4);
            btnFromVideo.Name = "btnFromVideo";
            btnFromVideo.Size = new Size(443, 95);
            btnFromVideo.TabIndex = 2;
            btnFromVideo.Text = "From Video";
            btnFromVideo.UseVisualStyleBackColor = true;
            btnFromVideo.Click += btnFromVideo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 753);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 908);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Text = "Collision Warning System";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private OpenFileDialog openFileDialog1;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnOCR;
        private Button btnFromImage;
        private Button btnFromVideo;
        private PictureBox pictureBox1;
    }
}