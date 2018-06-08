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
#endregion



namespace PEINFv1
{
    public partial class Form1 : Form
    {

        #region Variablen

        int currentFrame = 1;

        Bitmap[] frames = new Bitmap[25];

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

            Random rnd = new Random();
            currentFrame = rnd.Next(24);

            TurnEarth(true);
            checkCursorPosition.Start();            
        }

        private void checkCursorPosition_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X - Location.X > 600 && Cursor.Position.X > Size.Width)
            {
                TurnEarth(false);
            }

            if (Cursor.Position.X - Location.X < 200)//&& Cursor.Position.X < Size.Width
            {
                TurnEarth(true);
            }
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

            pictureBox1.Image = frames[currentFrame];
        }

        #endregion

    }
}
