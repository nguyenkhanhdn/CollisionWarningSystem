namespace CollisionWarningSystem
{
    partial class frmCollisionDetector
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
            panel2 = new Panel();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lblOCR = new Label();
            lblUpload = new Label();
            lblCamera = new Label();
            pnlMain = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2069, 95);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Maroon;
            btnClose.Location = new Point(1987, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(73, 67);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblOCR);
            panel1.Controls.Add(lblUpload);
            panel1.Controls.Add(lblCamera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 1045);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(6, 479);
            label1.Name = "label1";
            label1.Size = new Size(447, 85);
            label1.TabIndex = 3;
            label1.Text = "Firebase";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblOCR
            // 
            lblOCR.BackColor = SystemColors.GradientActiveCaption;
            lblOCR.BorderStyle = BorderStyle.FixedSingle;
            lblOCR.Cursor = Cursors.Hand;
            lblOCR.FlatStyle = FlatStyle.Flat;
            lblOCR.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblOCR.ForeColor = SystemColors.MenuHighlight;
            lblOCR.Location = new Point(7, 230);
            lblOCR.Name = "lblOCR";
            lblOCR.Size = new Size(447, 85);
            lblOCR.TabIndex = 2;
            lblOCR.Text = "O C R";
            lblOCR.TextAlign = ContentAlignment.MiddleCenter;
            lblOCR.MouseEnter += label2_MouseEnter;
            lblOCR.MouseLeave += label2_MouseLeave;
            // 
            // lblUpload
            // 
            lblUpload.BackColor = SystemColors.GradientActiveCaption;
            lblUpload.BorderStyle = BorderStyle.Fixed3D;
            lblUpload.Cursor = Cursors.Hand;
            lblUpload.FlatStyle = FlatStyle.Flat;
            lblUpload.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpload.ForeColor = SystemColors.MenuHighlight;
            lblUpload.Location = new Point(7, 125);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(447, 85);
            lblUpload.TabIndex = 1;
            lblUpload.Text = "Upload image";
            lblUpload.TextAlign = ContentAlignment.MiddleCenter;
            lblUpload.MouseEnter += lblUpload_MouseEnter;
            lblUpload.MouseLeave += lblUpload_MouseLeave;
            // 
            // lblCamera
            // 
            lblCamera.BackColor = SystemColors.GradientActiveCaption;
            lblCamera.BorderStyle = BorderStyle.Fixed3D;
            lblCamera.Cursor = Cursors.Hand;
            lblCamera.FlatStyle = FlatStyle.Flat;
            lblCamera.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamera.ForeColor = SystemColors.MenuHighlight;
            lblCamera.Location = new Point(6, 21);
            lblCamera.Name = "lblCamera";
            lblCamera.Size = new Size(447, 85);
            lblCamera.TabIndex = 0;
            lblCamera.Text = "Video capture";
            lblCamera.TextAlign = ContentAlignment.MiddleCenter;
            lblCamera.MouseEnter += lblCamera_MouseEnter;
            lblCamera.MouseLeave += lblCamera_MouseLeave;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(461, 95);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1608, 1045);
            pnlMain.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Tahoma", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(7, 599);
            label2.Name = "label2";
            label2.Size = new Size(447, 85);
            label2.TabIndex = 4;
            label2.Text = "Firebase";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // frmCollisionDetector
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2069, 1140);
            ControlBox = false;
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCollisionDetector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collision Warning System";
            TopMost = true;
            Load += frmCollisionDetector_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label lblCamera;
        private Button btnClose;
        private Panel pnlMain;
        private Label lblOCR;
        private Label lblUpload;
        private Label label1;
        private Label label2;
    }
}