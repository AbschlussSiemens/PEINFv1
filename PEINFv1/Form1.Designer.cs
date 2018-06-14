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
            this.Point1 = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Point1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
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
            // Point1
            // 
            this.Point1.BackColor = System.Drawing.Color.Transparent;
            this.Point1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Point1.BackgroundImage")));
            this.Point1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Point1.Location = new System.Drawing.Point(0, 0);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(20, 40);
            this.Point1.TabIndex = 2;
            this.Point1.TabStop = false;
            // 
            // Background
            // 
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(800, 600);
            this.Background.TabIndex = 3;
            this.Background.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.Point1);
            this.Controls.Add(this.TempTextbox);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Point1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer checkCursorPosition;
        private System.Windows.Forms.TextBox TempTextbox;
        private System.Windows.Forms.PictureBox Point1;
        private System.Windows.Forms.PictureBox Background;
    }
}

