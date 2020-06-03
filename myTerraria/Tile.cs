using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTerraria
{
    enum TileType
    {
        NONE,
        GROUND
    }
    class Tile : Transformable, Drawable
    {
        public const int TILE_SIZE = 16;

        TileType type = TileType.GROUND;
        RectangleShape rectShape;

        public Tile()
        {
            //creating rectangular shape 
            rectShape = new RectangleShape(new Vector2f(TILE_SIZE, TILE_SIZE));

            switch (type)
            {
                case TileType.GROUND:
                    rectShape.Texture = Content.texTile0;
                    //now we need to specify a fragment of the texture. for now, take the first fragment
                    rectShape.TextureRect = new IntRect(0, 0, TILE_SIZE, TILE_SIZE);
                    break;
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            states.Transform *= Transform;

            target.Draw(rectShape, states);
        }
    }
}
