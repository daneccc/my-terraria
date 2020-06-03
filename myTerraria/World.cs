using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    class World : Transformable, Drawable
    {
        public const int WORLD_SIZE = 5;

        Chunk[][] chunks;

        public World()
        {
            chunks = new Chunk[WORLD_SIZE][];

            for (int i = 0; i < WORLD_SIZE; i++)
            {
                chunks[i] = new Chunk[WORLD_SIZE];
            }

            chunks[0][0] = new Chunk();
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            for(int x = 0; x < WORLD_SIZE; x++)
            {
                for (int y = 0; y < WORLD_SIZE; y++)
                {
                    if (chunks[x][y] == null) continue;

                    target.Draw(chunks[x][y]);
                }
            }
        }
    }
}
