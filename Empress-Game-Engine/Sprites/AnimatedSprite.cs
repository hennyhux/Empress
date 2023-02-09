using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empress_Game_Engine.Interface;
using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Empress_Game_Engine.Sprites
{
    public class AnimatedSprite : ISprite
    {
        private Texture2D texture;

        //timer that stores the milliseconds
        private float timer;

        //int that is the threshold of the timer
        private int threshold;

        //Rectangle array that holds source rects
        Rectangle[] rects;

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        byte previousAnimationIndex;
        byte currentAnimationIndex;

        public AnimatedSprite(Texture2D texture)
        {
            timer = 0;
            threshold = 250;
            rects = new Rectangle[3];
            rects[0] = new Rectangle(0, 128, 48, 64);
            rects[1] = new Rectangle(48, 128, 48, 64);
            rects[2] = new Rectangle(96, 128, 48, 64);
            // This tells the animation to start on the left-side sprite.
            previousAnimationIndex = 2;
            currentAnimationIndex = 1;
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Draw(texture, location, rects[currentAnimationIndex], Color.White);
        }

        public void Update(GameTime gametime)
        {
            // Check if the timer has exceeded the threshold.
            if (timer > threshold)
            {
                // If Alex is in the middle sprite of the animation.
                if (currentAnimationIndex == 1)
                {
                    // If the previous animation was the left-side sprite, then the next animation should be the right-side sprite.
                    if (previousAnimationIndex == 0)
                    {
                        currentAnimationIndex = 2;
                    }
                    else
                        // If not, then the next animation should be the left-side sprite.
                    {
                        currentAnimationIndex = 0;
                    }
                    // Track the animation.
                    previousAnimationIndex = currentAnimationIndex;
                }
                // If Alex was not in the middle sprite of the animation, he should return to the middle sprite.
                else
                {
                    currentAnimationIndex = 1;
                }
                // Reset the timer.
                timer = 0;
            }
            // If the timer has not reached the threshold, then add the milliseconds that have past since the last Update() to the timer.
            else
            {
                timer += (float)gametime.ElapsedGameTime.TotalMilliseconds;
            }
        }
    }
}