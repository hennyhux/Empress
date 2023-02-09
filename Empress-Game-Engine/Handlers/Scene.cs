using Empress_Game_Engine.Entity;
using Empress_Game_Engine.Factories;
using Empress_Game_Engine.Interface;
using Microsoft.Xna.Framework.Graphics;

namespace Empress_Game_Engine.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;

public class Scene
{
    private Dictionary<int, ISprite> sceneSprites = new Dictionary<int, ISprite>();
    private IEntity henry;

    public Scene()
    {
        henry = new Henry(); 
    }

    public void render(SpriteBatch spriteBatch)
    {
        henry.Draw(spriteBatch);
    }

    public void update(GameTime gametime)
    {
        henry.Update(gametime);
    }

}
