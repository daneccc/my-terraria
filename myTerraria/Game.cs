using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    class Game
    {
        World world;

        public Game()
        {
            world = new World();
        }

        public void Update()
        {

        }

        public void Draw()
        {
            Program.Window.Draw(world);
        }
    }

    
}
