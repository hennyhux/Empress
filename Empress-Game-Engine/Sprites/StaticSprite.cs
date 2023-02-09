using Empress_Game_Engine.Interface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Empress_Game_Engine.Sprites;

public class StaticSprite : ISprite
{
    private Texture2D texture;

    private Rectangle sourceRectangle;

    public StaticSprite(Texture2D texture, Rectangle sourceRectangle)
    {
        this.texture = texture;
        this.sourceRectangle = sourceRectangle;
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        spriteBatch.Draw(texture, location, sourceRectangle, Color.White);
    }

    public void Update(GameTime gametime)
    {
        throw new System.NotImplementedException();
    }
}