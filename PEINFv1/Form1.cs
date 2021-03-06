﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//  von Tim, Nikita und Jakob

namespace PEINFv1
{
    public partial class PEINF : Form
    {

        #region Variablen

        int currentFrame = 1;

        Bitmap Pointer = new Bitmap("..\\..\\Assets\\Sonnst\\Point.png");
        Bitmap[] frames = new Bitmap[25];
        Bitmap[] proof = new Bitmap[9];


        //pointLocation[Nummer des Pointer, Frame, X = 0 oder Y = 1]
        int[,,] pointLocation = new int[7, 25, 2];

        #endregion

        #region Events

        public PEINF()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);

            Moon.Controls.Add(PointMoon);

            BackgroundPB.Controls.Add(Point00);
            BackgroundPB.Controls.Add(Point01);
            BackgroundPB.Controls.Add(Point02);
            BackgroundPB.Controls.Add(Point03);
            BackgroundPB.Controls.Add(Point04);
            BackgroundPB.Controls.Add(Point05);
            BackgroundPB.Controls.Add(Point06);

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\InfosPoint.mdf; Integrated Security = True";
                con.Open();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Konnte keine Verbindung zum SQL Server eingehen");
                this.Close();
            }

            //Point Moon
            /* 
            PointMoon.Location = new Point(23, 5);
            PointMoon.BackColor = Color.Transparent;
            */
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                try
                {
                    frames[i] = new Bitmap("..\\..\\Assets\\Erde\\frame (" + i + ").bmp");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erde Frame mit der ID: " + i + " fehlt.");
                }
            }

            for (int i = 0; i <= 8; i++)
            {
                if (i != 5 && i != 6 && i != 8)
                {
                    try
                    {
                        proof[i] = new Bitmap("..\\..\\Assets\\Beweise\\Image (" + i + ").bmp");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Beweis Datei mit der ID: " + i + " fehlt.");
                    }
                }
            }



            Random rnd = new Random();
            currentFrame = rnd.Next(24);

            FillArray();

            TurnEarth(true);

            checkCursorPosition.Start();
            Timeout.Start();

        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Timeout.Stop();
            Timeout.Start();
            Turn.Stop();

            Visibility();
        }

        private void PEINF_MouseDown(object sender, MouseEventArgs e)
        {
            Timeout.Stop();
            Timeout.Start();
            Turn.Stop();

            Visibility();
        }

        private void checkCursorPosition_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X - Location.X > this.Width - 50 && ClientRectangle.Contains(PointToClient(Control.MousePosition)) && PopupBackground.Visible == false)
            {
                Timeout.Stop();
                Timeout.Start();
                Turn.Stop();

                TurnEarth(false);
            }

            if (Cursor.Position.X - Location.X < 50 && ClientRectangle.Contains(PointToClient(Control.MousePosition)) && PopupBackground.Visible == false)
            {
                Timeout.Stop();
                Timeout.Start();
                Turn.Stop();

                TurnEarth(true);
            }

            //TempTextbox.Text = (Cursor.Position.X - this.Location.X).ToString() + "   " + (Cursor.Position.Y - this.Location.Y).ToString() + "   " + currentFrame.ToString();
        }

        private void PopupCloseButton_Click(object sender, EventArgs e)
        {
            ClosePopup();
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

                case Keys.Enter:
                    ClosePopup();
                    break;

                case Keys.Escape:
                    if (FormBorderStyle == FormBorderStyle.None && PopupBackground.Visible == false)
                    {
                        FormBorderStyle = FormBorderStyle.Sizable;
                        WindowState = FormWindowState.Normal;
                    }
                    ClosePopup();
                    break;

                case Keys.F11:
                    changeFullscreen();
                    break;

            }
        }

        private void PEINF_SizeChanged(object sender, EventArgs e)
        {
            ClosePopup();
        }

        private void Timeout_Tick(object sender, EventArgs e)
        {
            Point00.Visible = false;
            Point01.Visible = false;
            Point02.Visible = false;
            Point03.Visible = false;
            Point04.Visible = false;
            Point05.Visible = false;
            Point06.Visible = false;
            PointISS.Visible = false;
            PointMoon.Visible = false;

            Turn.Start();
            Timeout.Stop();
        }

        private void Turn_Tick(object sender, EventArgs e)
        {
            TurnEarth(true);
        }


        #region PointXX_Klick

        private void Point00_Click(object sender, MouseEventArgs e)
        {
            string[] DataArray = getData(0);

            MakePopup(DataArray[0], DataArray[1], 0);
        }

        private void Point01_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(1);

            MakePopup(DataArray[0], DataArray[1], 1);
        }

        private void Point02_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(2);

            MakePopup(DataArray[0], DataArray[1], 2);
        }

        private void Point03_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(3);

            MakePopup(DataArray[0], DataArray[1], 3);
        }

        private void Point04_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(4);

            MakePopup(DataArray[0], DataArray[1], 4);
        }

        private void Point05_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(5);

            MakePopup(DataArray[0], DataArray[1], 5);
        }

        private void Point06_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(6);

            MakePopup(DataArray[0], DataArray[1], 6);
        }

        private void PointISS_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(7);

            MakePopup(DataArray[0], DataArray[1], 622, 165);
        }

        private void PointMoon_Click(object sender, EventArgs e)
        {
            string[] DataArray = getData(8);

            MakePopup(DataArray[0], DataArray[1], 644, 91);
        }

        #endregion

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

            reLocate(Point00, pointLocation[0, currentFrame, 0], pointLocation[0, currentFrame, 1]);
            reLocate(Point01, pointLocation[1, currentFrame, 0], pointLocation[1, currentFrame, 1]);
            reLocate(Point02, pointLocation[2, currentFrame, 0], pointLocation[2, currentFrame, 1]);
            reLocate(Point03, pointLocation[3, currentFrame, 0], pointLocation[3, currentFrame, 1]);
            reLocate(Point04, pointLocation[4, currentFrame, 0], pointLocation[4, currentFrame, 1]);
            reLocate(Point05, pointLocation[5, currentFrame, 0], pointLocation[5, currentFrame, 1]);
            reLocate(Point06, pointLocation[6, currentFrame, 0], pointLocation[6, currentFrame, 1]);
        }

        private void reLocate(PictureBox PictureBox, int X, int Y)
        {
            PictureBox.Location = new Point(X - 17, Y - 60);
        }

        private void Visibility()
        {
            if (Turn.Enabled == false)
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

                //Point04
                if (pointLocation[4, currentFrame, 0] == 0)
                {
                    Point04.Visible = false;
                }
                else
                {
                    Point04.Visible = true;
                }

                //Point05
                /*if (pointLocation[5, currentFrame, 0] == 0)
                {
                    Point05.Visible = false;
                }
                else
                {
                    Point05.Visible = true;
                }

                //Point06
                if (pointLocation[6, currentFrame, 0] == 0)
                {
                    Point06.Visible = false;
                }
                else
                {
                    Point06.Visible = true;
                }*/


                PointISS.Visible = true;
                //PointMoon.Visible = true;
            }
        }

        private void MakePopup(string title, string text, int PointNr, int Y = 0)
        {
            int X;

            if (Y != 0)
            {
                X = PointNr;
                PointNr = 7;
            }
            else
            {
                X = pointLocation[PointNr, currentFrame, 0];
                Y = pointLocation[PointNr, currentFrame, 1];
            }
            
            X += 10;
            Y -= 68;

            X += BackgroundPB.Location.X;

            Y += BackgroundPB.Location.Y;

            int[] XYint = AdjustPopup(X, Y);

            X = XYint[0];
            Y = XYint[1];

            PopupText.Text = StringTransformation(text);
            PopupTitle.Text = title;
            PopupImage.BackgroundImage = proof[PointNr];

            using (Graphics g = CreateGraphics())
            {
                PopupText.Height = (int)g.MeasureString(PopupText.Text, PopupText.Font, PopupText.Width).Height;
            }
                 

            PopupBackground.Location = new Point(X, Y);
            PopupTitle.Location = new Point(X + 12, Y + 14);
            PopupText.Location = new Point(X + 16, Y + 44);
            PopupCloseButton.Location = new Point(X + 352, Y + 9); //350
            PopupImage.Location = new Point(X + 40, Y + 54 + PopupText.Height);

            PopupBackground.Height = 268 + PopupText.Height;

            PopupText.Visible = true;
            PopupTitle.Visible = true;
            PopupImage.Visible = true;
            PopupCloseButton.Visible = true;
            PopupBackground.Visible = true;

            Timeout.Stop();
        }

        int[] AdjustPopup(int X, int Y)
        {
            if (X + 333 > this.Width)
            {
                X -= 365;
            }
            if (Y + 427 > this.Height)
            {
                Y = 160;
            }

            int[] returnInt = new int[2] { X, Y };
            return returnInt;
        }

        private void ClosePopup()
        {
            PopupBackground.Visible = false;
            PopupTitle.Visible = false;
            PopupText.Visible = false;
            PopupCloseButton.Visible = false;
            PopupImage.Visible = false;

            Timeout.Start();
        }

        private void FillArray()
        {
            //Array mit 0 Füllen
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

            pointLocation[0, 12, 0] = 36;
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

            //Point 3
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

            //Point 4
            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[4, i, 1] = 185;
            }

            pointLocation[4, 14, 0] = 49;
            pointLocation[4, 15, 0] = 69;
            pointLocation[4, 16, 0] = 106;
            pointLocation[4, 17, 0] = 155;
            pointLocation[4, 18, 0] = 220;
            pointLocation[4, 19, 0] = 291;
            pointLocation[4, 20, 0] = 357;
            pointLocation[4, 21, 0] = 427;
            pointLocation[4, 22, 0] = 483;
            pointLocation[4, 23, 0] = 523;
            pointLocation[4, 24, 0] = 554;

            //Point 5
            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[5, i, 1] = 90;
            }

            pointLocation[5, 7, 0] = 140;
            pointLocation[5, 8, 0] = 172;
            pointLocation[5, 9, 0] = 201;
            pointLocation[5, 10, 0] = 243;
            pointLocation[5, 11, 0] = 285;
            pointLocation[5, 12, 0] = 335;
            pointLocation[5, 13, 0] = 382;
            pointLocation[5, 14, 0] = 421;
            pointLocation[5, 15, 0] = 456;
            pointLocation[5, 16, 0] = 483;

            //Point 6
            for (int i = 0; i < pointLocation.GetLength(1); i++)
            {
                pointLocation[6, i, 1] = 501;
            }

            pointLocation[6, 5, 0] = 70;
            pointLocation[6, 6, 0] = 102;
            pointLocation[6, 7, 0] = 143;
            pointLocation[6, 8, 0] = 199;
            pointLocation[6, 9, 0] = 256;
            pointLocation[6, 10, 0] = 320;
            pointLocation[6, 11, 0] = 386;
            pointLocation[6, 12, 0] = 442;
            pointLocation[6, 13, 0] = 493;
            pointLocation[6, 14, 0] = 528;
            pointLocation[6, 15, 0] = 550;

        }

        string[] getData(int Id)
        {
            string[] returnValue = new string[2] { "", "" };
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\InfosPoint.mdf; Integrated Security = True";
                con.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Infos WHERE Id =" + Id, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    returnValue[0] = reader["Titel"].ToString();
                    returnValue[1] = reader["Text"].ToString();
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Konnte keine Verbindung zum SQL Server eingehen");
            }

            return returnValue;
        }

        private void changeFullscreen()
        {
            if (FormBorderStyle.ToString() == "Sizable")
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        private string StringTransformation(string input)
        {
            char[] charInput = input.ToCharArray();

            int spaceIndex = 0;
            int savei2;
            int counter = 0;

            do
            {
                savei2 = 52;
                for (int i2 = 52; charInput[spaceIndex + i2 - 1 * counter] != ' ' ; i2--)
                {
                    savei2--;
                }
                spaceIndex += savei2 ;

                input = input.Insert(spaceIndex + 1, "\n");

                counter++;
            } while (input.Length - 53 > spaceIndex);

            return input;
        }

        #endregion

    }
}