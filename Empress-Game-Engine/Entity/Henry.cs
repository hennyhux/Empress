using Empress_Game_Engine.Factories;
using Empress_Game_Engine.Interface;
using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.Input.InputListeners;

namespace Empress_Game_Engine.Entity;

public class Henry : IEntity
{
    private ISprite sprite;
    private readonly KeyboardListener keyboardListener;
    public Henry()
    {
        this.sprite = SpriteFactory.getWalkingCharacterSprite();
        keyboardListener = new KeyboardListener();
        keyboardListener.KeyPressed += (sender, args) => { Window.Title = $"Key {args.Key} Pressed"; };
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, new Vector2());
    }

    public void Update(GameTime gametime)
    {
        sprite.Update(gametime);
        keyboardListener.Update(gametime);
    }
}