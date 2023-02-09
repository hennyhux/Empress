using Empress_Game_Engine.Factories;
using Empress_Game_Engine.Interface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Empress_Game_Engine
{
    public class GameRoot : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private ISprite character;
        private ISprite singleCharacter;
        private ISprite walkingCharacter;
        private SpriteFactory spriteFactory;

        public GameRoot()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            spriteFactory = new SpriteFactory(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            character = spriteFactory.getCharacterSprite();
            singleCharacter = spriteFactory.getSingleCharacterSprite();
            walkingCharacter = spriteFactory.getWalkingCharacterSprite();

        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            character = spriteFactory.getCharacterSprite();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            walkingCharacter.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
            character.Draw(spriteBatch, new Vector2(0, 0));
            singleCharacter.Draw(spriteBatch, new Vector2(300, 100));
            walkingCharacter.Draw(spriteBatch, new Vector2(500, 100));
            spriteBatch.End();
        }
    }
}