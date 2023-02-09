using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Empress_Game_Engine.Interface;

public interface ISprite
{
    void Draw(SpriteBatch spriteBatch, Vector2 location);
    void Update(GameTime gametime);
}