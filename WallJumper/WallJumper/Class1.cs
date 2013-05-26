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
    class Class1 : Enemy
    {
        
        public Class1()
        {
            this.enem = new Bitmap(Resources.Isaac_in_All_Stars_Battle_Royale, new Size(100, 100));

         
            Random k = new Random();
            if (k.Next(100, 200) < 150)
            {
                positionx = 60;
            }
            else { positionx = 460; }
            //positiony = -800;
            positiony=- k.Next(800,5600);
            speed = 10;

        }

        override public void enemymove()
        {
            positiony += 25;
        }

        
    }
}
