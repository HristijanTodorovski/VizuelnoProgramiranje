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
    class Enemy
    {
        public Bitmap enem { get; set; }
        public int positionx { get; set; }
        public int positiony { get; set; }
        public int speed{get;set;}
        public int radius = 100;

        public Enemy()
        {         
        }

        public float getX()
        {
            return positionx;
        }
        public float getY()
        {
            return positiony;

        }
         public virtual void enemymove()
        {

        }
    }
}
