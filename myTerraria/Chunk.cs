using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    class Chunk
    {
        public const int CHUNK_SIZE = 25;

        Tile[][] tiles;

        public Chunk()
        {
            tiles = new Tile[CHUNK_SIZE][];

            for(int i = 0; i < CHUNK_SIZE; i++)
            {
                tiles[i] = new Tile[CHUNK_SIZE]; 
            }
        }
    }
}
