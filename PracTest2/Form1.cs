using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracTest2
{
    public partial class Form1 : Form
    {
        //Name: Cameron Nepe
        //ID  : 1262199

        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320;
        const int DISPLAY_HEIGHT = 600;

        //NOTE: If the display looks wrong in your screen resolution, 
        //please check that the picture box is 400 x 730 pixels in size
        //and adjust the form to be slightly larger than that.
        //Stupid Visual Studio changes the form size based on your screen resolution - gah!

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = PracTest2.Properties.Resources.iPhone;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear the textbox and set the focus
            textBoxNumLottoBalls.Clear();
            textBoxNumLottoBalls.Focus();
            //Refresh the picture display
            pictureBoxDisplay.Refresh();
        }

        private void buttonDrawBalls_Click(object sender, EventArgs e)
        {
            //Variables
            int numLottoBalls;
            Random rand = new Random();

            //Graphics
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.Red);
            int x = DISPLAY_LEFT;
            int y = DISPLAY_TOP;
            int f = 0;

            try
            {
                //GET number of lotto balls from user input
                numLottoBalls = int.Parse(textBoxNumLottoBalls.Text);
                //CHECK if numLottoBalls will fit the display
                if ((BALL_SIZE + GAP_SIZE) * numLottoBalls <= DISPLAY_WIDTH)
                {

                    for (int i = 1; i <= numLottoBalls; i++)
                    {
                        while ((BALL_SIZE + GAP_SIZE) + y <= DISPLAY_HEIGHT)
                        {
                            //CALCULATE how many balls can be displayed
                            f = rand.Next(1, 41);
                            if (f < 10)
                            {
                                br = new SolidBrush(Color.Blue);
                            }
                            else if (f < 20)
                            {
                                br = new SolidBrush(Color.Orange);
                            }
                            else if (f < 30)
                            {
                                br = new SolidBrush(Color.Green);
                            }
                            else if (f < 40)
                            {
                                br = new SolidBrush(Color.Red);
                            }
                            else
                            {
                                br = new SolidBrush(Color.Purple);
                            }
                            //DRAW grid of balls in various colors in smartphone display
                            paper.FillEllipse(br, x, y, BALL_SIZE, BALL_SIZE);
                            y += BALL_SIZE + GAP_SIZE;
                        }
                        y = DISPLAY_TOP;
                        x += BALL_SIZE + GAP_SIZE;
                    }
                   
                }



                //IF the number is too large, no balls should be DRAWN, error message displayed
                else
                {
                    //DISPLAY error message
                    MessageBox.Show("Number will not fit in display");
                }

            }

            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
                //Clear the textbox and set the focus
                textBoxNumLottoBalls.Clear();
                textBoxNumLottoBalls.Focus();
                //Refresh the picture display
                pictureBoxDisplay.Refresh();
            }
        }
    }
}
