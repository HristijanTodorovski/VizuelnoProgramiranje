using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WallJumper.Properties;
using System.Timers;

namespace WallJumper
{
    class Jumper
    {
       public int positionx { get; set; }
       public int positiony { get; set; }
       public bool shield { get; set; }
       public Bitmap JumpMan { get; set; }
       public int faza = 0;
       public int strana = 0;
       public int radius = 70;
       public Bitmap slika1 = Resources.prvcekor;
       public Bitmap slika2 = Resources.vtorcekor;
       public Bitmap slika3 = Resources.tretcekor;
       public Bitmap slikarotacija1 = Resources.rotacija1;
       public Bitmap slikarotacija2 = Resources.rotacija2;
       public Bitmap slikarotacija3=Resources.rotacija3;
       public Bitmap slikadesno1 = Resources.vtorcekor2;
       public Bitmap slikadesno2 = Resources.tretcekor2;


       public Jumper()
       {
           positionx = 60;
           positiony = 500;
           faza = 0;
           strana = 0;
           slika2.MakeTransparent(Color.White);
           slika3.MakeTransparent(Color.White);
           slika1.MakeTransparent(Color.White);
           slikarotacija1.MakeTransparent(Color.White);
           slikarotacija2.MakeTransparent(Color.White);
           slikarotacija3.MakeTransparent(Color.White);
           slikadesno1.MakeTransparent(Color.White);
           slikadesno2.MakeTransparent(Color.White);


       }


        public float getX()
        {
            return positionx;
        }
        public float getY()
        {
            return positiony+4;

        }

        public void trcalevo()
        {
            positionx = 60;
            positiony = 500;
            
            if (faza == 0) JumpMan = slika1;
            else if (faza == 1) JumpMan = slika2;
            else  if (faza == 2) JumpMan = slika3; 
            faza = (++faza) % 3;
            //e.Graphics.DrawImage(JumpMan, positionx, positiony);
            

        }

        public void trcadesno()
        {
            positionx = 475;
            positiony = 500;
            if (faza == 0) JumpMan = slikadesno1;
            else if (faza == 1) JumpMan = slikadesno2;
            else if (faza == 2) JumpMan = slikadesno2;
            faza = (++faza) % 3;
   

        }

        public void skoka()
        {
        }

        public void ispravi()
        {
            JumpMan = slikarotacija1;

        }

        public void iskrivi()
        {
            JumpMan = slikarotacija3;
        }

        public void pomestiNaDesnaStrana()
        {
            if (faza == 0) JumpMan = slikarotacija1;
            else if (faza == 1) JumpMan = slikarotacija2;
            else if (faza == 2) JumpMan = slikarotacija3;
            faza = (++faza) % 3;

            positionx += 25;
            //if (positionx < 470) 
            //    positionx += 25;
            //if (positionx < 320)
            //    positiony++;
            //else
            //    positiony--;

            if (positionx > 270)
                positiony += 25;
            else
                positiony -= 25;

            
        }
        public void pomestiNaLevaStrana()
        {

            if (faza == 0) JumpMan = slikarotacija1;
            else if (faza == 1) JumpMan = slikarotacija2;
            else if (faza == 2) JumpMan = slikarotacija3;
            faza = (++faza) % 3;


            positionx -= 25;
            if (positionx < 270)
                positiony+=25;
            else
                positiony-=25;

            
        }
    }
}
