using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            Wall=new Bitmap("C:\\Users\\Hristjan\\Documents\\GitHub\\VizuelnoProgramiranje\\WallJumper\\WallJumper\\Resource\\image\\Wall.png");
            positionx = x;
            positiony = y;
            speed = 5;
        }
        public void Wallsmove()
        {
            if (positiony >= 700) positiony = -700;
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
