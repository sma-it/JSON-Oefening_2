using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_03
{
    public class GameConfig
    {
        public string GameTitle;
        public float MusicVolume;
        public bool Fullscreen;
        public Resolution ScreenResolution;
        public List<Player> Players;

        public class Resolution
        {
            public int Width;
            public int Height;
        }

        public class Player
        {
            public string Name;
            public int Level;
            public float Health;
        }
    }
}
