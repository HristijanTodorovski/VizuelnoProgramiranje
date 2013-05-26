using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using WallJumper.Properties;

namespace WallJumper
{
    class music
    {
        public SoundPlayer holetime;

        public music()
        {
            holetime = new SoundPlayer(Resources.Wwe_motorhead_triple_h_theme_play_the_game_);
        }
        public void playmusic()
        {
            holetime.PlayLooping();
        }
    }


}
