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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            btnOCR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1122, 91);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1044, 853);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(814, 963);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(220, 95);
            button1.TabIndex = 1;
            button1.Text = "Capture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(525, 963);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(220, 95);
            button2.TabIndex = 2;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(55, 36);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(987, 908);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 59);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(971, 841);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(971, 854);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1122, 963);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1047, 95);
            textBox1.TabIndex = 4;
            // 
            // btnOCR
            // 
            btnOCR.Location = new Point(233, 966);
            btnOCR.Name = "btnOCR";
            btnOCR.Size = new Size(150, 92);
            btnOCR.TabIndex = 5;
            btnOCR.Text = "OCR";
            btnOCR.UseVisualStyleBackColor = true;
            btnOCR.Click += btnOCR_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2230, 1104);
            Controls.Add(btnOCR);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button btnOCR;
    }
}