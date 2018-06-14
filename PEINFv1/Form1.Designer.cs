namespace PEINFv1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkCursorPosition = new System.Windows.Forms.Timer(this.components);
            this.TempTextbox = new System.Windows.Forms.TextBox();
            this.Point00 = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.PointMoon = new System.Windows.Forms.PictureBox();
            this.Point01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).BeginInit();
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
            this.Point00.Location = new System.Drawing.Point(0, 0);
            this.Point00.Name = "Point00";
            this.Point00.Size = new System.Drawing.Size(20, 40);
            this.Point00.TabIndex = 2;
            this.Point00.TabStop = false;
            // 
            // Background
            // 
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(800, 600);
            this.Background.TabIndex = 3;
            this.Background.TabStop = false;
            // 
            // PointMoon
            // 
            this.PointMoon.BackColor = System.Drawing.Color.Transparent;
            this.PointMoon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PointMoon.BackgroundImage")));
            this.PointMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PointMoon.Location = new System.Drawing.Point(758, 12);
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
            this.Point01.Location = new System.Drawing.Point(390, 279);
            this.Point01.Name = "Point01";
            this.Point01.Size = new System.Drawing.Size(20, 40);
            this.Point01.TabIndex = 5;
            this.Point01.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.Point00);
            this.Controls.Add(this.Point01);
            this.Controls.Add(this.PointMoon);
            this.Controls.Add(this.TempTextbox);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Point00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Point01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer checkCursorPosition;
        private System.Windows.Forms.TextBox TempTextbox;
        private System.Windows.Forms.PictureBox Point00;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox PointMoon;
        private System.Windows.Forms.PictureBox Point01;
    }
}

