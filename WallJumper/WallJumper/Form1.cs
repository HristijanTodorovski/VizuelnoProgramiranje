using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Threading;


namespace WallJumper
{
    public partial class Form1 : Form
    {
            

        Background zaz = new Background();
        Walls sid = new Walls(-6,-10);
        Walls sid1 = new Walls(563, -10);
        Walls sid2 = new Walls(-6, -700);
        Walls sid3 = new Walls(563, -700);


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

          //  Thread.Sleep(50);      
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(zaz.Backpicture, 0, 0);
            e.Graphics.DrawImage(sid.getWall(),sid.getX(),sid.getY());
            sid.Wallsmove();
            e.Graphics.DrawImage(sid1.getWall(), sid1.getX(), sid1.getY());
            sid1.Wallsmove();
            e.Graphics.DrawImage(sid2.getWall(), sid2.getX(), sid2.getY());
            sid2.Wallsmove();
            e.Graphics.DrawImage(sid3.getWall(), sid3.getX(), sid3.getY());
            sid3.Wallsmove();
            
           // this.Invalidate();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }  
    }
}
