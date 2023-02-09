using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Empress_Game_Engine.Interface;

public interface IEntity
{
    public void Draw(SpriteBatch spriteBatch);
    public void Update(GameTime gametime);
}