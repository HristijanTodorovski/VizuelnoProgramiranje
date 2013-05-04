using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WallJumper
{
    class Background
    {
        public Bitmap Backpicture { get; set; }
        private float positionx { get; set; }
        private float positiony { get; set; }

        public Background()
        {
            
            Backpicture = new Bitmap("C:\\Users\\Hristjan\\Documents\\GitHub\\VizuelnoProgramiranje\\WallJumper\\WallJumper\\Resource\\image\\War.png");
            positionx = 0;
            positiony = 0;
            
              //  C:\Users\Hristjan\Documents\GitHub\VizuelnoProgramiranje\WallJumper\WallJumper\Resource\image
        }
    }
}
