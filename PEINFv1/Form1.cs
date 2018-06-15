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

//Stationen festlegen



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
                pointLocation[0, i, 1] = 290;
            }

            pointLocation[0, 11, 0] = 21;
            pointLocation[0, 12, 0] = 50;
            pointLocation[0, 13, 0] = 98;
            pointLocation[0, 14, 0] = 162;
            pointLocation[0, 15, 0] = 233;
            pointLocation[0, 16, 0] = 312;
            pointLocation[0, 17, 0] = 390;
            pointLocation[0, 18, 0] = 461;
            pointLocation[0, 19, 0] = 521;
            pointLocation[0, 20, 0] = 570;
            pointLocation[0, 21, 0] = 598;


            //Point 1

            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[1, i, 1] = 155;
            }

            pointLocation[1, 22, 0] = 82;
            pointLocation[1, 23, 0] = 112;
            pointLocation[1, 24, 0] = 157;
            pointLocation[1, 1, 0] = 213;
            pointLocation[1, 2, 0] = 277;
            pointLocation[1, 3, 0] = 339;
            pointLocation[1, 4, 0] = 401;
            pointLocation[1, 5, 0] = 458;
            pointLocation[1, 6, 0] = 500;
            pointLocation[1, 7, 0] = 534;

            #endregion

            TurnEarth(true);
            checkCursorPosition.Start();


            
        }

        private void checkCursorPosition_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X - Location.X > 550 && ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                TurnEarth(false);
            }

            if (Cursor.Position.X - Location.X < 50 && ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                TurnEarth(true);
            }
            
            TempTextbox.Text = (Cursor.Position.X - this.Location.X).ToString() + "   " + (Cursor.Position.Y - this.Location.Y).ToString() + "   " + currentFrame.ToString();
        }

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
        }

        private void reLocate(PictureBox PictureBox, int X, int Y)
        {
            PictureBox.Location = new Point(X - 17, Y - 70);
        }

        private void Visibility()
        {
            if (pointLocation[1, currentFrame, 0] == 0)
            {
                Point01.Visible = false;
            }
            else
            {
                Point01.Visible = true;
            }


            if (pointLocation[0, currentFrame, 0] == 0)
            {
                Point00.Visible = false;
            }
            else
            {
                Point00.Visible = true;
            }
        }

        private void MakePopup(string title, string text, int X, int Y)
        {
            X += 10;
            Y -= 70;

            PopupText.Text = text;
            PopupTitle.Text = title;

            PopupBackground.Location = new Point(X,Y);
            PopupTitle.Location = new Point(X + 15,Y + 10);
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

    }
}
