using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace verzijapacman
{

    class Pacmancs
    {
        public enum nasoka
        {
            levo,
            desno,
            gore,
            dole
        };

        public int pozicija_X { get; set; }
        public int pozicija_Y { get; set; }
        public int nas = (int)nasoka.desno;
        public int RADIUS = 20;
        private bool open { get; set; }
        public Brush cetka = new SolidBrush(Color.Yellow);


        public Pacmancs()
        {
            pozicija_X = 7;
            pozicija_Y = 5;
            nas = (int)nasoka.desno;
            open = false;


        }


        internal void Draw(Graphics g)
        {
            if (!open)
                g.FillPie(cetka, pozicija_X * RADIUS * 2, pozicija_Y * RADIUS * 2, RADIUS*2, RADIUS*2, 0, 360);
            else
            {
                switch (nas)
                {
                    case (int)nasoka.desno:
                        g.FillPie(cetka, pozicija_X * RADIUS * 2, pozicija_Y * RADIUS * 2, RADIUS*2, RADIUS*2, 45, 315);
                        break;

                    case (int)nasoka.levo:

                        g.FillPie(cetka, pozicija_X * RADIUS * 2, pozicija_Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 225, 135);
                        break;

                    case (int)nasoka.dole:
                        g.FillPie(cetka, pozicija_X * RADIUS * 2, pozicija_Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 300, 250);

                        break;
                    case (int)nasoka.gore:
                        g.FillPie(cetka, pozicija_X * RADIUS * 2, pozicija_Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 135, 45);
                        break;

                }


            }
        }

        internal void Move(int WORLD_WIDTH, int WORLD_HEIGHT)
        {
          //  if (open) open = false;
           // else open = true;
            open=!open;
            
            switch (nas)
            {
                case (int)nasoka.desno:
                    pozicija_X++;
                    if (pozicija_X >= WORLD_WIDTH)
                        pozicija_X = 0;
                    
                    break;

                case (int)nasoka.levo:

                    pozicija_X--;
                    if (pozicija_X <= 0)
                        pozicija_X = WORLD_WIDTH;
                    break;

                case (int)nasoka.dole:
                    pozicija_Y++;
                    if (pozicija_Y > WORLD_HEIGHT)
                        pozicija_Y = 0;
                    break;
                case (int) nasoka.gore:
                    pozicija_Y--;
                    if (pozicija_Y < 0)
                        pozicija_Y = WORLD_HEIGHT;
                    break;

            }


        }
        public void ChangeDirection(nasoka direction)
        {
            nas = (int)direction;
        }
    }
}
