using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using verzijapacman.Properties;
using System.Resources;
namespace verzijapacman
{
    public partial class Form1 : Form
    {
       
        Pacmancs pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
       
        Image foodImage;
        bool[][] foodWorld;
        public Form1()
        {

            InitializeComponent();
            foodImage = Resources.food;
            DoubleBuffered = true;
            newGame();
        }
        private void newGame()
        {
            pacman = new Pacmancs();
            this.Width = pacman.RADIUS * 2 * (WORLD_WIDTH+1);
            this.Height = pacman.RADIUS * 2 * (WORLD_HEIGHT+1);
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
                for (int j = 0; j < WORLD_WIDTH; j++)
                {
                    foodWorld[i][j] = true;
                }
            }



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * pacman.RADIUS * 2 + (pacman.RADIUS * 2 - foodImage.Height) / 2, i * pacman.RADIUS * 2 + (pacman.RADIUS * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           // не заборавајте да го додадете настанот на самата форма
      // вашиот код овде
            if (e.KeyCode == Keys.Right)
            {
                //pacman.nas=
            }

      Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            foodWorld[pacman.pozicija_Y][pacman.pozicija_X] = false;
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);

            Invalidate();
        }

       
    }
}
