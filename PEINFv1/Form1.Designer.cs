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
            this.PopupText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCursorPosition
            // 
            this.checkCursorPosition.Interval = 200;
            this.checkCursorPosition.Tick += new System.EventHandler(this.checkCursorPosition_Tick);
            // 
            // TempTextbox
            // 
            this.TempTextbox.Enabled = false;
            this.TempTextbox.Location = new System.Drawing.Point(700, 580);
            this.TempTextbox.Name = "TempTextbox";
            this.TempTextbox.ReadOnly = true;
            this.TempTextbox.Size = new System.Drawing.Size(100, 20);
            this.TempTextbox.TabIndex = 1;
            // 
            // Point00
            // 
            this.Point00.BackColor = System.Drawing.Color.Transparent;
            this.Point00.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point00.BackgroundImage")));
            this.Point00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Point00.Location = new System.Drawing.Point(12, 12);
            this.Point00.Name = "Point00";
            this.Point00.Size = new System.Drawing.Size(20, 40);
            this.Point00.TabIndex = 2;
            this.Point00.TabStop = false;
            this.Point00.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Point00_MouseClick);
            // 
            // BackgroundPB
            // 
            this.BackgroundPB.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPB.Name = "BackgroundPB";
            this.BackgroundPB.Size = new System.Drawing.Size(600, 600);
            this.BackgroundPB.TabIndex = 3;
            this.BackgroundPB.TabStop = false;
            // 
            // PointMoon
            // 
            this.PointMoon.BackColor = System.Drawing.Color.Transparent;
            this.PointMoon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PointMoon.BackgroundImage")));
            this.PointMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PointMoon.Location = new System.Drawing.Point(529, 1);
            this.PointMoon.Name = "PointMoon";
            this.PointMoon.Size = new System.Drawing.Size(20, 40);
            this.PointMoon.TabIndex = 4;
            this.PointMoon.TabStop = false;
            // 
            // Point01
            // 
            this.Point01.BackColor = System.Drawing.Color.Transparent;
            this.Point01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point01.BackgroundImage")));
            this.Point01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Point01.Location = new System.Drawing.Point(38, 12);
            this.Point01.Name = "Point01";
            this.Point01.Size = new System.Drawing.Size(20, 40);
            this.Point01.TabIndex = 5;
            this.Point01.TabStop = false;
            // 
            // Moon
            // 
            this.Moon.BackColor = System.Drawing.Color.Transparent;
            this.Moon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Moon.BackgroundImage")));
            this.Moon.Location = new System.Drawing.Point(495, 12);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(64, 64);
            this.Moon.TabIndex = 6;
            this.Moon.TabStop = false;
            // 
            // PopupBackground
            // 
            this.PopupBackground.BackColor = System.Drawing.Color.White;
            this.PopupBackground.Location = new System.Drawing.Point(284, 231);
            this.PopupBackground.Name = "PopupBackground";
            this.PopupBackground.Size = new System.Drawing.Size(328, 276);
            this.PopupBackground.TabIndex = 7;
            this.PopupBackground.TabStop = false;
            this.PopupBackground.Visible = false;
            // 
            // PopupTitle
            // 
            this.PopupTitle.AutoSize = true;
            this.PopupTitle.BackColor = System.Drawing.Color.White;
            this.PopupTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupTitle.ForeColor = System.Drawing.Color.Black;
            this.PopupTitle.Location = new System.Drawing.Point(294, 240);
            this.PopupTitle.Name = "PopupTitle";
            this.PopupTitle.Size = new System.Drawing.Size(53, 25);
            this.PopupTitle.TabIndex = 8;
            this.PopupTitle.Text = "Titel";
            this.PopupTitle.Visible = false;
            // 
            // PopupText
            // 
            this.PopupText.AutoSize = true;
            this.PopupText.BackColor = System.Drawing.Color.White;
            this.PopupText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopupText.Location = new System.Drawing.Point(299, 278);
            this.PopupText.Name = "PopupText";
            this.PopupText.Size = new System.Drawing.Size(28, 15);
            this.PopupText.TabIndex = 9;
            this.PopupText.Text = "Text";
            this.PopupText.Visible = false;
            // 
            // PEINF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 598);
            this.Controls.Add(this.PopupText);
            this.Controls.Add(this.PopupTitle);
            this.Controls.Add(this.PopupBackground);
            this.Controls.Add(this.PointMoon);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Point00);
            this.Controls.Add(this.Point01);
            this.Controls.Add(this.TempTextbox);
            this.Controls.Add(this.BackgroundPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PEINF";
            this.Text = "PEINF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupBackground)).EndInit();
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
        private System.Windows.Forms.Label PopupText;
    }
}

