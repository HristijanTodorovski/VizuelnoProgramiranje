using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using WallJumper.Properties;

namespace WallJumper
{
    class mreza
    {
        public Bitmap slika { get; set; }
        public int positionx { get; set; }
        public int positiony { get; set; }
        public int speed = 15;


        public mreza()
        {

            slika = Resources.black_net_wallpaper;
            slika.MakeTransparent();
            positionx = 0;
            positiony = 0;
        
        }
        public void mrezamove()
        {


            if (positiony >= 1200)
            {
                positiony = 1200;
               
            }
            else
            {
                positiony = positiony + speed;
            }
        }

    }
}
