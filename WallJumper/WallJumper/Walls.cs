using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WallJumper.Properties;

namespace WallJumper
{
    class Walls
    {
        private Bitmap Wall { get; set; }
        private float positionx { get; set; }
        private float positiony { get; set; }
        private float speed { get; set; }
        public Walls(int x,int y)
        {
            Wall = Resources.Wall;
           

            positionx = x;
            positiony = y;
            speed = 20;
        }
        public void Wallsmove()
        {
            if (positiony >= 600) positiony = -800;
            else
            {
                positiony = positiony + speed;
            }
        }




        public Bitmap getWall()
        {
            return Wall;
        }
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
