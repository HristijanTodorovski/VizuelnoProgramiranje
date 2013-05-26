using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WallJumper.Properties;

namespace WallJumper
{
    class enemy2:Enemy
    {
       // public int radius = 100;
        int side = 0;
        public enemy2()
        {
            this.enem = new Bitmap(Resources.Rygar_arcade_enemy_death, new Size(100, 100));
            enem.MakeTransparent();

         
            Random k = new Random();
            if (k.Next(100, 200) < 150)
            {
                positionx = 60;
                side = 0;
            }
            else { positionx = 460; side = 1; }
            //positiony = -800;
            positiony=- k.Next(800,5600);
            speed = 10;

        }
         

        override public void enemymove()
        {
            if (positiony > 0 && side == 0)
            {

                positionx += 17;
            }
            else if (positiony > 0 && side == 1)
            {
                positionx -= 17;
            }
            positiony += 25;
        }
    }
}
