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
            //Inicijalizacija na najbitnite raboti za igricata ssidovi , mrezi i jumperot

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
        List <Enemy>listaneprijateli=new List<Enemy>();
        List<Enemy> listaneprijateli2 = new List<Enemy>();
        public Bitmap gameo = new Bitmap(Resources.game_over_7984137cdd72912f86dd6d11c5b3c6b5,new Size (650,700));
        //public Bitmap end=Resources.game_over_7984137cdd72912f86dd6d11c5b3c6b5;
        
      

       
      

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            sound = new music();
            sound.playmusic();
           // listaneprijateli.Add(new Class1());
            generateenemy();
           
        }
        //Glavnata logika za igricata se sodrzi ovde 
        /*koaga  e 0 igricata e vo pocetna pozicija i se iscrtuva pocetnata forma kade dobivate slikica koja direkno ve vodi kon igricata
         * faza 1 e startot na igrata i celoto dvizenje niz nea od neprijateli i kako niv gi izbegnuvate  
         *  faza 2 e igricata e vo gameover sostojba i togas vie ste zavrsile so igranjeto     
         * 
         * */
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (igrica == 0)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(slikaprva, 0, 0);
            }
            else if (igrica == 1)
            {

                //Iscrtuvanje na pozadinata na igrata
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
             // mestenje na jumperot na tocnite pozicii od koga ke izvrsi skok
                if (state == 1 && jump.positionx > 450) this.state = 2;
                if (state == 3 && jump.positionx < 80) this.state = 0;
                //State na koja strana i kako se dvizi jumperot 
                switch (state)
                {
                    case 0: { jump.trcalevo(); isHit(); break; }
                    case 1: { jump.pomestiNaDesnaStrana(); break; }
                    case 2: { jump.trcadesno();isHit(); break; }
                    case 3: { jump.pomestiNaLevaStrana(); break; }

                }
                //Dvizenje na neprijatelite vo samata igra
                foreach( Enemy en in listaneprijateli)
                {
                    en.enemymove();
                    e.Graphics.DrawImage(en.enem, en.positionx, en.positiony);
                    
                }
                //brsenje na neprijateli vo slucaj da ne se potrebni
                foreach (Enemy en in listaneprijateli)
                {
                    if (en.positiony > 800) listaneprijateli2.Add(en);
                        
                }
                //Nivno brisenje
                foreach (Enemy en in listaneprijateli2)
                {
                    listaneprijateli.Remove(en);
                }
                listaneprijateli2.Clear();
                //Vo slucaj da nema vise neprijateli vo igricata da se dodadat novi 
                generateenemy();
                //Iscrtuvanje na jumpman
                e.Graphics.DrawImage(jump.JumpMan, jump.positionx, jump.positiony);
                e.Graphics.DrawImage(m.slika, m.positionx, m.positiony);
                m.mrezamove();
              



                //System za resultattot
                resultat += kacuva;
                ts.Text = "Score: " + resultat.ToString();
            }
                //Faza 2 gameovder nekolku stafki sto da se sluci ako vi zavrsi igricata
            else if (igrica == 2)
            {
                gameover();
                //e.Graphics.DrawImage(end, 0, 0);
                e.Graphics.DrawImage(gameo, 0, 0);

            }
           // this.Invalidate();

        }
        //Kreiranje na nova igra
        public void newgame()
        {
            state = 0;
            timer.Start();
            this.jump = new Jumper();
            resultat = -50;
            m.positiony = 0;
            listaneprijateli.Clear();
            igrica = 1;
          

        }
        //izvrsuvanje na gameover se zapisuva rezultatot i se zaveduva ako e pogolem od toa sto e vo file
        public void gameover()
        {
            Res k = new Res();
            k.writes(resultat);

           
        }

        //Timer za inicijalizacija

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        //Button Quit
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Button NEW GAME 
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
        //Iscituvanje na SPACE t.e da se menja fazata na igracot dali trca ili skoka
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

        //Slusac koga ke udrite vo neprijatel da vi izleze deka ste izgubile
        public void isHit()
        {
            foreach (Enemy en in listaneprijateli)
            {
                int i = en.radius + jump.radius;
                double d = Math.Sqrt((en.positionx - jump.positionx) * (en.positionx - jump.positionx) + ((en.positiony - jump.positiony) * (en.positiony - jump.positiony)));
                d = d * 4;
                if (i > d)
                {
                    igrica = 2;
                    return ;
                }
            }
            igrica = 1;

            
        }

        //Funkcijata za generiranje na neprijateli
        public void generateenemy()
        {
            if (listaneprijateli.Count > 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < 10;i++ )
                {
                    listaneprijateli.Add(new Class1());
                }
                for (int i = 0; i < 10; i++)
                {
                    listaneprijateli.Add(new enemy2());
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            timer.Stop();
            sound.holetime.Stop();
            HELPcs forma = new HELPcs();

            if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                timer.Start();
                sound.holetime.Play();
            }

        }
    }
}
