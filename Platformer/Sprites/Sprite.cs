using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Platformer.Model;
using Platformer.Managers;
using Microsoft.Xna.Framework;

namespace Platformer.Sprites
{
    class Sprite
    {
        protected Texture2D _texture;

        public Input input;
        public Vector2 position;
        public float speed = 1f;
        public Vector2 Velocity;

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, Color.White);
        }
    }
}
