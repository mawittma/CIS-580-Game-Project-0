using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Game_Project_0
{
    /// <summary>
    /// Class to represent the Battle Axe Sprite
    /// </summary>
    public class BattleAxeSprite
    {
        private Texture2D texture;

        private double animationTimer;

        private short animationFrame = 0;
        /// <summary>
        /// Vector2 to represent the position of the battle axe
        /// </summary>
        public Vector2 Position; 
        /// <summary>
        /// loads the content of the battleaxe-sheet
        /// </summary>
        /// <param name="content">Content manager for project</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("battleaxe-sheet");
        }

        
        /// <summary>
        /// Draws the animated axe sprite
        /// </summary>
        /// <param name="gameTime">the game time</param>
        /// <param name="spriteBatch">The spritebatch to draw with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //update animation timer
            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

            //update animation frame
            if(animationTimer > .3)
            {
                animationFrame++;
                if (animationFrame >7) animationFrame = 0;
                animationTimer -= .3;
            }

            // draw the sprite
            var source = new Rectangle(animationFrame*16, 0, 16, 16);
            spriteBatch.Draw(texture, Position, source, Color.White, 0f, new Vector2(0,0), 2f, new SpriteEffects(), 0);

        }
    }
}
