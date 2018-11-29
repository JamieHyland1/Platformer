using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Platformer.Model;
using Platformer.Sprites;

namespace Platformer.Managers
{
    class AnimationManager
    {
        private Animation _animation;
        private float _timer;
        public Vector2 Position { get; set; }
        
        //default constructor
        public AnimationManager() {  }

        public AnimationManager(Animation animation)
        {
            _animation = animation;
        }

        public void Draw(SpriteBatch spriteBatch) {

            spriteBatch.Draw(_animation.Texture,
                        Position,
                        new Rectangle(_animation.currentFrame * _animation.FrameWidth,
                                      0,
                                      _animation.FrameWidth,
                                      _animation.FrameHeight),
                        Color.White);
        }

        public void Play(Animation animation)
        {
            if(_animation == animation)
            {
                _animation.currentFrame = 0;
                _timer = 0f;
            }
        }

        public void Stop()
        {
            _timer = 0f;
            _animation.currentFrame = 0;
        }

        public void update(GameTime gameTime) {
            _timer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if(_timer > _animation.frameSpeed)
            {
                _timer = 0f;
                _animation.currentFrame++;
                if(_animation.currentFrame >= _animation.frameCount)
                {
                    _animation.currentFrame = 0;
                }
            }
        }


    }
}
