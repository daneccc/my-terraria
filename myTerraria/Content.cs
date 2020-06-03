using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    class Content
    {
        public const string CONTENT_DIR = "..\\Content\\";

        //will store the texture of earthen tiles
        public static Texture texTile0;

        //static method for loading compurer memory resources
        public static void Load()
        {
            texTile0 = new Texture(CONTENT_DIR + "Tiles_0.png");
        }


    }
}
