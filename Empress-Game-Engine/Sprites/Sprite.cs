using Empress_Game_Engine.Interface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Empress_Game_Engine.Sprites;

public abstract class Sprite : ISprite
{
    protected int currentFrame;
    protected int totalFrames;
    protected int frameHeight;
    protected int frameWidth;
    protected int startingPointX;
    protected int startingPointY;
    protected int offsetX;
    protected int rows;
    protected int columns;
    protected Vector2 location;

    protected int timeSinceLastFrame;
    protected int milliSecondsPerFrame;

    protected bool isVisible;

    protected Point frameOrigin;
    protected Point frameSize;
    protected Point atlasSize;
    protected Point currentFramePoint;
    protected internal SpriteEffects Facing { get; set; }
    public Texture2D Texture { get; set; }

    public Sprite()
    {
        Facing = SpriteEffects.None;
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        int width = Texture.Width / frameWidth;
        int height = Texture.Height / frameHeight;
        int row = currentFrame / frameWidth;
        int column = currentFrame % frameWidth;

        Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
        Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 2, height * 2);
        spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0, 0), Facing, 0);
    }

    public void Update(GameTime gametime)
    {
        timeSinceLastFrame += gametime.ElapsedGameTime.Milliseconds;
        if (timeSinceLastFrame > milliSecondsPerFrame)
        {
            timeSinceLastFrame -= milliSecondsPerFrame;

            currentFrame += 1;

            if (currentFrame >= totalFrames)
            {
                currentFrame = 0;
            }

            if (currentFramePoint.X < totalFrames)
            {
                currentFramePoint.X++;
            }

            if (currentFramePoint.X >= totalFrames)
            {
                currentFramePoint.X = startingPointX;
            }
        }
    }
}