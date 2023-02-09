using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empress_Game_Engine.Interface;
using Empress_Game_Engine.Sprites;
using EmptyKeys.UserInterface;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Empress_Game_Engine.Factories
{
    public class SpriteFactory
    {
        #region textures

        private static Texture2D questionBlock;
        private static Texture2D character;

        #endregion

        public SpriteFactory(ContentManager content)
        {
            questionBlock = content.Load<Texture2D>("Blocks/HiddenBlock");
            character = content.Load<Texture2D>("Char/charaset");
        }

        public static ISprite getCharacterSprite()
        {
            return new StaticSprite(character, new Rectangle(0, 0, character.Width, character.Height));
        }

        public static ISprite getSingleCharacterSprite()
        {
            return new StaticSprite(character, new Rectangle(0, 0, 48, 64));
        }

        public static ISprite getWalkingCharacterSprite()
        {
            return new AnimatedSprite(character);
        }
    }
}