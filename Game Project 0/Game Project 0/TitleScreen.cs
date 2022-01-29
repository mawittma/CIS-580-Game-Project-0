using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_Project_0
{
    public class TitleScreen : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont earthboundBig;
        private SpriteFont earthboundSmall;
        private BattleAxeSprite[] axes;
        private Texture2D atlas;

        /// <summary>
        /// class initilaizer 
        /// </summary>
        public TitleScreen()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        /// <summary>
        /// initialize battleaxe sprites in an array
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //
            axes = new BattleAxeSprite[]
            {
                new BattleAxeSprite() {Position = new Vector2(100,50)},
                new BattleAxeSprite() {Position = new Vector2(600,400)},
                new BattleAxeSprite() {Position = new Vector2(100,400)},
                new BattleAxeSprite() {Position = new Vector2(600,50)},
            };
            base.Initialize();
        }
        /// <summary>
        /// Load contents of class
        /// </summary>
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            earthboundBig = Content.Load<SpriteFont>("EarthboundBig");
            earthboundSmall = Content.Load<SpriteFont>("EarthboundSmall");
            foreach (var axe in axes) axe.LoadContent(Content);
            atlas = Content.Load<Texture2D>("colored_packed");
            // TODO: use this.Content to load your game content here
        }
        /// <summary>
        /// updates the game
        /// </summary>
        /// <param name="gameTime">gameTime variable</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
             
            base.Update(gameTime);
        }
        /// <summary>
        /// Drawing the spritebatch 
        /// </summary>
        /// <param name="gameTime">gameTime variable</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            _spriteBatch.Begin();
            _spriteBatch.DrawString(earthboundBig, "Casino", new Vector2(275, 150), Color.Red);
            _spriteBatch.DrawString(earthboundBig, "Royale", new Vector2(275, 220), Color.Black);

            _spriteBatch.DrawString(earthboundSmall, "Hit 'ESC' on keyboard or 'back' on controller to exit", new Vector2(15,450), Color.Black);
            foreach (var axe in axes) axe.Draw(gameTime, _spriteBatch);

            _spriteBatch.Draw(atlas, new Vector2(325, 50),new Rectangle(20*16, 16*16, 16, 16), Color.Red,.25f, new Vector2(0,0), 3f, new SpriteEffects(),0 );
            _spriteBatch.Draw(atlas, new Vector2(330, 90), new Rectangle(32 * 16, 8 * 16, 16, 16), Color.Black, -1f, new Vector2(0, 0), 3f, new SpriteEffects(), 1);
            _spriteBatch.Draw(atlas, new Vector2(325, 350), new Rectangle(20 * 16, 19 * 16, 16, 16), Color.Black, .25f, new Vector2(0, 0), 3f, new SpriteEffects(), 0);
            _spriteBatch.Draw(atlas, new Vector2(330, 390), new Rectangle(33 * 16, 2 * 16, 16, 16), Color.Red, -1f, new Vector2(0, 0), 3f, new SpriteEffects(), 1);

            _spriteBatch.Draw(atlas, new Vector2(100, 200), new Rectangle(20 * 16, 17 * 16, 16, 16), Color.Red, .25f, new Vector2(0, 0), 3f, new SpriteEffects(), 0);
            _spriteBatch.Draw(atlas, new Vector2(105, 240), new Rectangle(37 * 16, 7 * 16, 16, 16), Color.Black, -1f, new Vector2(0, 0), 3f, new SpriteEffects(), 1);
            _spriteBatch.Draw(atlas, new Vector2(600, 200), new Rectangle(20 * 16, 18 * 16, 16, 16), Color.Black, .25f, new Vector2(0, 0), 3f, new SpriteEffects(), 0);
            _spriteBatch.Draw(atlas, new Vector2(605, 240), new Rectangle(42 * 16, 8 * 16, 16, 16), Color.Red, -1f, new Vector2(0, 0), 3f, new SpriteEffects(), 1);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
