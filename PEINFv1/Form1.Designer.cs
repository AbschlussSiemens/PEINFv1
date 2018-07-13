namespace PEINFv1
{
    partial class PEINF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PEINF));
            this.checkCursorPosition = new System.Windows.Forms.Timer(this.components);
            this.TempTextbox = new System.Windows.Forms.TextBox();
            this.Point00 = new System.Windows.Forms.PictureBox();
            this.BackgroundPB = new System.Windows.Forms.PictureBox();
            this.PointMoon = new System.Windows.Forms.PictureBox();
            this.Point01 = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.PopupBackground = new System.Windows.Forms.PictureBox();
            this.PopupTitle = new System.Windows.Forms.Label();
            this.Point02 = new System.Windows.Forms.PictureBox();
            this.Point03 = new System.Windows.Forms.PictureBox();
            this.ISS = new System.Windows.Forms.PictureBox();
            this.PointISS = new System.Windows.Forms.PictureBox();
            this.Point06 = new System.Windows.Forms.PictureBox();
            this.Point05 = new System.Windows.Forms.PictureBox();
            this.Point04 = new System.Windows.Forms.PictureBox();
            this.PopupCloseButton = new System.Windows.Forms.Button();
            this.Timeout = new System.Windows.Forms.Timer(this.components);
            this.Turn = new System.Windows.Forms.Timer(this.components);
            this.PopupText = new System.Windows.Forms.RichTextBox();
            this.PopupImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointISS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCursorPosition
            // 
            this.checkCursorPosition.Interval = 200;
            this.checkCursorPosition.Tick += new System.EventHandler(this.checkCursorPosition_Tick);
            // 
            // TempTextbox
            // 
            this.TempTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TempTextbox.Enabled = false;
            this.TempTextbox.Location = new System.Drawing.Point(-3, 642);
            this.TempTextbox.Name = "TempTextbox";
            this.TempTextbox.ReadOnly = true;
            this.TempTextbox.Size = new System.Drawing.Size(100, 20);
            this.TempTextbox.TabIndex = 1;
            this.TempTextbox.Visible = false;
            // 
            // Point00
            // 
            this.Point00.BackColor = System.Drawing.Color.Transparent;
            this.Point00.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point00.BackgroundImage")));
            this.Point00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point00.Location = new System.Drawing.Point(49, 10);
            this.Point00.Name = "Point00";
            this.Point00.Size = new System.Drawing.Size(15, 30);
            this.Point00.TabIndex = 2;
            this.Point00.TabStop = false;
            this.Point00.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Point00_Click);
            // 
            // BackgroundPB
            // 
            this.BackgroundPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackgroundPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPB.BackgroundImage")));
            this.BackgroundPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackgroundPB.Location = new System.Drawing.Point(101, 29);
            this.BackgroundPB.Name = "BackgroundPB";
            this.BackgroundPB.Size = new System.Drawing.Size(599, 600);
            this.BackgroundPB.TabIndex = 3;
            this.BackgroundPB.TabStop = false;
            // 
            // PointMoon
            // 
            this.PointMoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PointMoon.BackColor = System.Drawing.Color.Transparent;
            this.PointMoon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PointMoon.BackgroundImage")));
            this.PointMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PointMoon.Location = new System.Drawing.Point(714, 30);
            this.PointMoon.Name = "PointMoon";
            this.PointMoon.Size = new System.Drawing.Size(15, 30);
            this.PointMoon.TabIndex = 4;
            this.PointMoon.TabStop = false;
            this.PointMoon.Visible = false;
            this.PointMoon.Click += new System.EventHandler(this.PointMoon_Click);
            // 
            // Point01
            // 
            this.Point01.BackColor = System.Drawing.Color.Transparent;
            this.Point01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point01.BackgroundImage")));
            this.Point01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point01.Location = new System.Drawing.Point(70, 10);
            this.Point01.Name = "Point01";
            this.Point01.Size = new System.Drawing.Size(15, 30);
            this.Point01.TabIndex = 5;
            this.Point01.TabStop = false;
            this.Point01.Click += new System.EventHandler(this.Point01_Click);
            // 
            // Moon
            // 
            this.Moon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Moon.BackColor = System.Drawing.Color.Transparent;
            this.Moon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Moon.BackgroundImage")));
            this.Moon.Location = new System.Drawing.Point(680, 41);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(64, 64);
            this.Moon.TabIndex = 6;
            this.Moon.TabStop = false;
            // 
            // PopupBackground
            // 
            this.PopupBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PopupBackground.BackColor = System.Drawing.Color.White;
            this.PopupBackground.Location = new System.Drawing.Point(155, 102);
            this.PopupBackground.Name = "PopupBackground";
            this.PopupBackground.Size = new System.Drawing.Size(386, 547);
            this.PopupBackground.TabIndex = 7;
            this.PopupBackground.TabStop = false;
            this.PopupBackground.Visible = false;
            // 
            // PopupTitle
            // 
            this.PopupTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PopupTitle.AutoSize = true;
            this.PopupTitle.BackColor = System.Drawing.Color.White;
            this.PopupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupTitle.ForeColor = System.Drawing.Color.Black;
            this.PopupTitle.Location = new System.Drawing.Point(160, 121);
            this.PopupTitle.Name = "PopupTitle";
            this.PopupTitle.Size = new System.Drawing.Size(53, 25);
            this.PopupTitle.TabIndex = 8;
            this.PopupTitle.Text = "Titel";
            this.PopupTitle.Visible = false;
            // 
            // Point02
            // 
            this.Point02.BackColor = System.Drawing.Color.Transparent;
            this.Point02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point02.BackgroundImage")));
            this.Point02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point02.Location = new System.Drawing.Point(91, 10);
            this.Point02.Name = "Point02";
            this.Point02.Size = new System.Drawing.Size(15, 30);
            this.Point02.TabIndex = 10;
            this.Point02.TabStop = false;
            this.Point02.Click += new System.EventHandler(this.Point02_Click);
            // 
            // Point03
            // 
            this.Point03.BackColor = System.Drawing.Color.Transparent;
            this.Point03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point03.BackgroundImage")));
            this.Point03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point03.Location = new System.Drawing.Point(112, 10);
            this.Point03.Name = "Point03";
            this.Point03.Size = new System.Drawing.Size(15, 30);
            this.Point03.TabIndex = 11;
            this.Point03.TabStop = false;
            this.Point03.Click += new System.EventHandler(this.Point03_Click);
            // 
            // ISS
            // 
            this.ISS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ISS.BackColor = System.Drawing.Color.Transparent;
            this.ISS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ISS.BackgroundImage")));
            this.ISS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ISS.Location = new System.Drawing.Point(702, 151);
            this.ISS.Name = "ISS";
            this.ISS.Size = new System.Drawing.Size(32, 32);
            this.ISS.TabIndex = 12;
            this.ISS.TabStop = false;
            // 
            // PointISS
            // 
            this.PointISS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PointISS.BackColor = System.Drawing.Color.Transparent;
            this.PointISS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PointISS.BackgroundImage")));
            this.PointISS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PointISS.Location = new System.Drawing.Point(710, 121);
            this.PointISS.Name = "PointISS";
            this.PointISS.Size = new System.Drawing.Size(15, 30);
            this.PointISS.TabIndex = 13;
            this.PointISS.TabStop = false;
            this.PointISS.Click += new System.EventHandler(this.PointISS_Click);
            // 
            // Point06
            // 
            this.Point06.BackColor = System.Drawing.Color.Transparent;
            this.Point06.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point06.BackgroundImage")));
            this.Point06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point06.Location = new System.Drawing.Point(175, 10);
            this.Point06.Name = "Point06";
            this.Point06.Size = new System.Drawing.Size(15, 30);
            this.Point06.TabIndex = 14;
            this.Point06.TabStop = false;
            this.Point06.Visible = false;
            this.Point06.Click += new System.EventHandler(this.Point06_Click);
            // 
            // Point05
            // 
            this.Point05.BackColor = System.Drawing.Color.Transparent;
            this.Point05.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point05.BackgroundImage")));
            this.Point05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point05.Location = new System.Drawing.Point(154, 10);
            this.Point05.Name = "Point05";
            this.Point05.Size = new System.Drawing.Size(15, 30);
            this.Point05.TabIndex = 15;
            this.Point05.TabStop = false;
            this.Point05.Visible = false;
            this.Point05.Click += new System.EventHandler(this.Point05_Click);
            // 
            // Point04
            // 
            this.Point04.BackColor = System.Drawing.Color.Transparent;
            this.Point04.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point04.BackgroundImage")));
            this.Point04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Point04.Location = new System.Drawing.Point(133, 10);
            this.Point04.Name = "Point04";
            this.Point04.Size = new System.Drawing.Size(15, 30);
            this.Point04.TabIndex = 16;
            this.Point04.TabStop = false;
            this.Point04.Click += new System.EventHandler(this.Point04_Click);
            // 
            // PopupCloseButton
            // 
            this.PopupCloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PopupCloseButton.BackColor = System.Drawing.Color.Red;
            this.PopupCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PopupCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PopupCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PopupCloseButton.FlatAppearance.BorderSize = 2;
            this.PopupCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.PopupCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.PopupCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopupCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupCloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PopupCloseButton.Location = new System.Drawing.Point(507, 111);
            this.PopupCloseButton.Name = "PopupCloseButton";
            this.PopupCloseButton.Size = new System.Drawing.Size(24, 23);
            this.PopupCloseButton.TabIndex = 17;
            this.PopupCloseButton.Text = "X";
            this.PopupCloseButton.UseVisualStyleBackColor = false;
            this.PopupCloseButton.Visible = false;
            this.PopupCloseButton.Click += new System.EventHandler(this.PopupCloseButton_Click);
            this.PopupCloseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // Timeout
            // 
            this.Timeout.Interval = 60000;
            this.Timeout.Tick += new System.EventHandler(this.Timeout_Tick);
            // 
            // Turn
            // 
            this.Turn.Interval = 1500;
            this.Turn.Tick += new System.EventHandler(this.Turn_Tick);
            // 
            // PopupText
            // 
            this.PopupText.BackColor = System.Drawing.Color.White;
            this.PopupText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PopupText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PopupText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupText.Location = new System.Drawing.Point(165, 162);
            this.PopupText.Name = "PopupText";
            this.PopupText.ReadOnly = true;
            this.PopupText.Size = new System.Drawing.Size(366, 279);
            this.PopupText.TabIndex = 18;
            this.PopupText.Text = " ";
            // 
            // PopupImage
            // 
            this.PopupImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PopupImage.BackgroundImage")));
            this.PopupImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PopupImage.Location = new System.Drawing.Point(195, 447);
            this.PopupImage.Name = "PopupImage";
            this.PopupImage.Size = new System.Drawing.Size(297, 182);
            this.PopupImage.TabIndex = 19;
            this.PopupImage.TabStop = false;
            // 
            // PEINF
            // 
            this.AcceptButton = this.PopupCloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.PopupCloseButton;
            this.ClientSize = new System.Drawing.Size(808, 661);
            this.Controls.Add(this.PopupImage);
            this.Controls.Add(this.PopupText);
            this.Controls.Add(this.PopupCloseButton);
            this.Controls.Add(this.Point04);
            this.Controls.Add(this.Point05);
            this.Controls.Add(this.Point06);
            this.Controls.Add(this.PopupTitle);
            this.Controls.Add(this.PopupBackground);
            this.Controls.Add(this.PointISS);
            this.Controls.Add(this.ISS);
            this.Controls.Add(this.Point03);
            this.Controls.Add(this.Point02);
            this.Controls.Add(this.PointMoon);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Point00);
            this.Controls.Add(this.Point01);
            this.Controls.Add(this.TempTextbox);
            this.Controls.Add(this.BackgroundPB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(824, 637);
            this.Name = "PEINF";
            this.Text = "PEINF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.PEINF_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PEINF_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointISS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer checkCursorPosition;
        private System.Windows.Forms.TextBox TempTextbox;
        private System.Windows.Forms.PictureBox Point00;
        private System.Windows.Forms.PictureBox BackgroundPB;
        private System.Windows.Forms.PictureBox PointMoon;
        private System.Windows.Forms.PictureBox Point01;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox PopupBackground;
        private System.Windows.Forms.Label PopupTitle;
        private System.Windows.Forms.PictureBox Point02;
        private System.Windows.Forms.PictureBox Point03;
        private System.Windows.Forms.PictureBox ISS;
        private System.Windows.Forms.PictureBox PointISS;
        private System.Windows.Forms.PictureBox Point06;
        private System.Windows.Forms.PictureBox Point05;
        private System.Windows.Forms.PictureBox Point04;
        private System.Windows.Forms.Button PopupCloseButton;
        private System.Windows.Forms.Timer Timeout;
        private System.Windows.Forms.Timer Turn;
        private System.Windows.Forms.RichTextBox PopupText;
        private System.Windows.Forms.PictureBox PopupImage;
    }
}

