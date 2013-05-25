using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WallJumper.Properties;

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
       public Bitmap slika1 = Resources.prvcekor;
       public Bitmap slika2 = Resources.vtorcekor;
       public Bitmap slika3 = Resources.tretcekor;

       public Jumper()
       {
           positionx = 60;
           positiony = 500;
           faza = 0;
           strana = 0;
           slika2.MakeTransparent();
           slika3.MakeTransparent();
           slika1.MakeTransparent();
          


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
            
            if (faza == 0) JumpMan = slika1;
            else if (faza == 1) JumpMan = slika2;
            else  if (faza == 2) JumpMan = slika3; 
            faza = (++faza) % 3;
            //e.Graphics.DrawImage(JumpMan, positionx, positiony);
            

        }
        public void trcadesno()
        {
        }
        public void skoka()
        {
        }


    }
}
