using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//
//  PEINFv1
//
//  von Tim Nikita und Köbi


#region TODO

    //////////////////// 
    //      TODO      //
    ////////////////////
        
    // Punkte

    //Nur drehen, wenn die Erde angewählt
    
     
#endregion



namespace PEINFv1
{
    public partial class Form1 : Form
    {

        #region Variablen

        int currentFrame = 1;

        Bitmap Pointer = new Bitmap("..\\..\\Assets\\Sonnst\\Point.png");
        Bitmap[] frames = new Bitmap[25];


        //pointLocation[Nummer des Pointer, Frame, X = 0 oder Y = 1]
        int[,,] pointLocation = new int[2,25, 2];

        #endregion

        #region Events

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                frames[i] = new Bitmap("..\\..\\Assets\\Erde\\frame (" + i + ").bmp"); 
            }

            Point1.Image = Pointer;

            Random rnd = new Random();
            currentFrame = rnd.Next(24);

            TurnEarth(true);
            checkCursorPosition.Start();

            for (int i = 0; i < pointLocation.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < pointLocation.GetLength(1); i2++)
                {
                    for (int i3 = 0; i3 < pointLocation.GetLength(2); i3++)
                    {
                        pointLocation[i, i2, i3] = 0;
                    }
                }
            }

            //Point 0

            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[0, i, 1] = 290;
            }

            pointLocation[0, 12, 0] = 26;
            pointLocation[0, 13, 0] = 67;
            pointLocation[0, 14, 0] = 132;
            pointLocation[0, 15, 0] = 214;
            pointLocation[0, 16, 0] = 311;
            pointLocation[0, 17, 0] = 413;
            pointLocation[0, 18, 0] = 517;
            pointLocation[0, 19, 0] = 611;
            pointLocation[0, 20, 0] = 755;
            pointLocation[0, 21, 0] = 792;


        }

        private void checkCursorPosition_Tick(object sender, EventArgs e)
        {
            /*if (Cursor.Position.X - Location.X > 600)//&& Cursor.Position.X > Size.Width
            {
                TurnEarth(false);
            }

            if (Cursor.Position.X - Location.X < 200)//&& Cursor.Position.X < Size.Width
            {
                TurnEarth(true);
            }*/

            TempTextbox.Text =   (Cursor.Position.X - this.Location.X).ToString() + "   " + (Cursor.Position.Y - this.Location.Y).ToString() + "   " + currentFrame.ToString();
        }

        #endregion

        #region Methoden

        private void TurnEarth(bool turnRight)
        {
            if (turnRight)
            {
                currentFrame++;
            }
            else
            {
                currentFrame--;
            }

            if (currentFrame > 24)
            {
                currentFrame = 1;
            }

            if (currentFrame < 1)
            {
                currentFrame = 24;
            }

            this.BackgroundImage = frames[currentFrame];

            if (pointLocation[0, currentFrame, 0] == 0)
            {
                Point1.Visible = false;
            }
            else
            {
                Point1.Visible = true;
            }

            Point1.Location = new Point(pointLocation[0, currentFrame, 0] + 60 , pointLocation[0, currentFrame, 1] -60);

        }

        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    TurnEarth(true);
                    break;

                case Keys.Right:
                    TurnEarth(false);
                    break;
            }
        }
    }
}
