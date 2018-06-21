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

//Text und Titel für Stationen

//Popup relativ

//Stationen festlegen WIP



#endregion



namespace PEINFv1
{
    public partial class PEINF : Form
    {

        #region Variablen

        int currentFrame = 1;

        Bitmap Pointer = new Bitmap("..\\..\\Assets\\Sonnst\\Point.png");
        Bitmap[] frames = new Bitmap[25];


        //pointLocation[Nummer des Pointer, Frame, X = 0 oder Y = 1]
        int[,,] pointLocation = new int[4, 25, 2];

        #endregion

        #region Events

        public PEINF()
        {
            InitializeComponent();

            Moon.Controls.Add(PointMoon);


            BackgroundPB.Controls.Add(Point00);
            BackgroundPB.Controls.Add(Point01);
            BackgroundPB.Controls.Add(Point02);



            //Point Moon
            PointMoon.Location = new Point(23, 5);
            PointMoon.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                frames[i] = new Bitmap("..\\..\\Assets\\Erde\\frame (" + i + ").bmp");
            }

            this.BackgroundPB.Image = new Bitmap("..\\..\\Assets\\Sonnst\\Point.png");


            Random rnd = new Random();
            currentFrame = rnd.Next(24);

            #region fill array

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
                pointLocation[0, i, 1] = 210;
            }

            pointLocation[0, 12, 0] = 30;
            pointLocation[0, 13, 0] = 54;
            pointLocation[0, 14, 0] = 86;
            pointLocation[0, 15, 0] = 135;
            pointLocation[0, 16, 0] = 196;
            pointLocation[0, 17, 0] = 261;
            pointLocation[0, 18, 0] = 333;
            pointLocation[0, 19, 0] = 402;
            pointLocation[0, 20, 0] = 465;
            pointLocation[0, 21, 0] = 516;
            pointLocation[0, 22, 0] = 556;


            //Point 1

            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[1, i, 1] = 104;
            }

            pointLocation[1, 17, 0] = 127;
            pointLocation[1, 18, 0] = 155;
            pointLocation[1, 19, 0] = 191;
            pointLocation[1, 20, 0] = 236;
            pointLocation[1, 21, 0] = 284;
            pointLocation[1, 22, 0] = 336;
            pointLocation[1, 23, 0] = 387;
            pointLocation[1, 24, 0] = 430;
            pointLocation[1, 1, 0] = 466;
            pointLocation[1, 2, 0] = 491;

            //Point 2
            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[2, i, 1] = 121;
            }

            pointLocation[2, 22, 0] = 107;
            pointLocation[2, 23, 0] = 135;
            pointLocation[2, 24, 0] = 174;
            pointLocation[2, 1, 0] = 223;
            pointLocation[2, 2, 0] = 277;
            pointLocation[2, 3, 0] = 335;
            pointLocation[2, 4, 0] = 389;
            pointLocation[2, 5, 0] = 439;
            pointLocation[2, 6, 0] = 479;
            pointLocation[2, 7, 0] = 509;

            //Point03
            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[3, i, 1] = 160;
            }
            
            pointLocation[3, 24, 0] = 70;
            pointLocation[3, 1, 0] = 106;
            pointLocation[3, 2, 0] = 149;
            pointLocation[3, 3, 0] = 199;
            pointLocation[3, 4, 0] = 267;
            pointLocation[3, 5, 0] = 327;
            pointLocation[3, 6, 0] = 392;
            pointLocation[3, 7, 0] = 456;
            pointLocation[3, 8, 0] = 504;
            pointLocation[3, 9, 0] = 541;

            #endregion

            TurnEarth(true);
            checkCursorPosition.Start();

        }

        private void checkCursorPosition_Tick(object sender, EventArgs e)
        {/*
            if (Cursor.Position.X - Location.X > 950 && ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                TurnEarth(false);
            }

            if (Cursor.Position.X - Location.X < 50 && ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                TurnEarth(true);
            }*/

            TempTextbox.Text = (Cursor.Position.X - this.Location.X).ToString() + "   " + (Cursor.Position.Y - this.Location.Y).ToString() + "   " + currentFrame.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    TurnEarth(false);
                    break;

                case Keys.Right:
                    TurnEarth(true);
                    break;
            }
        }

        private void Point00_MouseClick(object sender, MouseEventArgs e)
        {
            MakePopup("Ich Titel", "Ich text", pointLocation[0, currentFrame, 0], pointLocation[0, currentFrame, 1]);
        }

        #endregion

        #region Methoden

        private void TurnEarth(bool turnRight)
        {
            ClosePopup();

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

            Visibility();

            //Changes Background from Form and Picturebox
            BackgroundPB.Image = frames[currentFrame];
            this.BackgroundImage = frames[currentFrame];

            reLocate(Point00, pointLocation[0, currentFrame, 0], pointLocation[0, currentFrame, 1]);
            reLocate(Point01, pointLocation[1, currentFrame, 0], pointLocation[1, currentFrame, 1]);
            reLocate(Point02, pointLocation[2, currentFrame, 0], pointLocation[2, currentFrame, 1]);
            reLocate(Point03, pointLocation[3, currentFrame, 0], pointLocation[3, currentFrame, 1]);
        }

        private void reLocate(PictureBox PictureBox, int X, int Y)
        {
            PictureBox.Location = new Point(X - 17, Y - 60);
        }

        private void Visibility()
        {
            //Point00
            if (pointLocation[0, currentFrame, 0] == 0)
            {
                Point00.Visible = false;
            }
            else
            {
                Point00.Visible = true;
            }

            //Point01
            if (pointLocation[1, currentFrame, 0] == 0)
            {
                Point01.Visible = false;
            }
            else
            {
                Point01.Visible = true;
            }

            //Point02
            if (pointLocation[2, currentFrame, 0] == 0)
            {
                Point02.Visible = false;
            }
            else
            {
                Point02.Visible = true;
            }

            //Point03
            if (pointLocation[3, currentFrame, 0] == 0)
            {
                Point03.Visible = false;
            }
            else
            {
                Point03.Visible = true;
            }
        }

        private void MakePopup(string title, string text, int X, int Y)
        {
            X += 10;
            Y -= 70;

            PopupText.Text = text;
            PopupTitle.Text = title;

            PopupBackground.Location = new Point(X, Y);
            PopupTitle.Location = new Point(X + 15, Y + 10);
            PopupText.Location = new Point(X + 15, Y + 40);

            PopupText.Visible = true;
            PopupTitle.Visible = true;
            PopupBackground.Visible = true;
        }

        private void ClosePopup()
        {
            PopupBackground.Visible = false;
            PopupTitle.Visible = false;
            PopupText.Visible = false;
        }

        #endregion

        private void Point01_Click(object sender, EventArgs e)
        {

        }

        private void Point02_Click(object sender, EventArgs e)
        {

        }

        private void Point03_Click(object sender, EventArgs e)
        {

        }

        private void PointISS_Click(object sender, EventArgs e)
        {

        }

        private void PointMoon_Click(object sender, EventArgs e)
        {

        }
    }
}
