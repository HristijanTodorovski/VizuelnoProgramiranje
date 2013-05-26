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
using WallJumper.Properties;


namespace WallJumper
{
    public partial class Form1 : Form
    {
            

        Background zaz = new Background();
        Walls sid = new Walls(-6,-10);
        Walls sid1 = new Walls(563, -10);
        Walls sid2 = new Walls(-6, -700);
        Walls sid3 = new Walls(563, -700);
        mreza m = new mreza();
        Jumper jump = new Jumper();
        int state = 0;
        int resultat = 0;
        public int kacuva=6;
        music sound ;
        public int igrica = 0;
        public Bitmap slikaprva = new Bitmap(Resources._2);
      

       
      

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            sound = new music();
            sound.playmusic();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (igrica == 0)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(slikaprva, 0, 0);
            }
            else if (igrica == 1)
            {

                //  Thread.Sleep(50);      
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(zaz.Backpicture, 0, 0);
                e.Graphics.DrawImage(sid.getWall(), sid.getX(), sid.getY());
                sid.Wallsmove();
                e.Graphics.DrawImage(sid1.getWall(), sid1.getX(), sid1.getY());
                sid1.Wallsmove();
                e.Graphics.DrawImage(sid2.getWall(), sid2.getX(), sid2.getY());
                sid2.Wallsmove();
                e.Graphics.DrawImage(sid3.getWall(), sid3.getX(), sid3.getY());
                sid3.Wallsmove();
                // jump.trcalevo();
                if (state == 1 && jump.positionx > 450) this.state = 2;
                if (state == 3 && jump.positionx < 80) this.state = 0;

                switch (state)
                {
                    case 0: { jump.trcalevo(); break; }
                    case 1: { jump.pomestiNaDesnaStrana(); break; }
                    case 2: { jump.trcadesno(); break; }
                    case 3: { jump.pomestiNaLevaStrana(); break; }

                }

                e.Graphics.DrawImage(jump.JumpMan, jump.positionx, jump.positiony);
                e.Graphics.DrawImage(m.slika, m.positionx, m.positiony);
                m.mrezamove();
                //jump.pomestiNaDesnaStrana();




                resultat += kacuva;
                ts.Text = "Score: " + resultat.ToString();
            }
           // this.Invalidate();

        }
        public void newgame()
        {
            state = 0;
            this.jump = new Jumper();
            resultat = -50;
            m.positiony = 0;
            igrica = 1;
          

        }



        private void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newgame();
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Thread.Sleep(9000);  
            Score forma = new Score();
            
           
            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //timer.Stop();
            }
              
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)32 && state == 0)
                state = 1;
            else if (e.KeyChar == (char)32 && state == 2)
                state = 3;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sound.holetime.Stop();
            Form3 forma = new Form3();

            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                timer.Start();
                sound.holetime.Play();
            }
            
        }  
    }
}
