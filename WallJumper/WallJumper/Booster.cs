using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WallJumper
{
    class Booster
    {
        private Bitmap Boost { get; set; }
        private float positionx { get; set; }
        private float positiony { get; set; }

        public float getX()
        {
            return positionx;
        }
        public float getY()
        {
            return positiony;

        }
    }
}
