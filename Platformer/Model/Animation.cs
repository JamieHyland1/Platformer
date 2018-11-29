using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Sprites
{
    public class Animation
    {
        public int currentFrame { get; set; }

        public int frameCount { get; private set; }

        public int FrameHeight { get { return Texture.Height; } }

        public float frameSpeed { get; set; }

        public int FrameWidth { get { return Texture.Width / frameCount; } }

        public bool isLooping { get; set; }

        public Texture2D Texture { get; private set; }

        public Animation()
        {

        }

        public Animation (Texture2D texture, int frameCount)
        {
            Texture = texture;
            this.frameCount = frameCount;
            isLooping = true;
            frameSpeed = 0.2f;

        }
    }
}
