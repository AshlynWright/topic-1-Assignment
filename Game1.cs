using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace topic_1_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D backgroundTexture;

        Texture2D dinoTexture;
        Texture2D sonicTexture;
        Texture2D pikachuTexture;
        Texture2D marioTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            this.Window.Title = "My first mongame project";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("dino");
            sonicTexture = Content.Load<Texture2D>("sonic");
            pikachuTexture = Content.Load<Texture2D>("pikachu");
            marioTexture = Content.Load<Texture2D>("mario");


            backgroundTexture = Content.Load<Texture2D>("background");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Lavender);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, window, Color.White);

            _spriteBatch.Draw(dinoTexture, new Vector2(270, 170), Color.White);
            _spriteBatch.Draw(sonicTexture, new Vector2(600, 300), Color.White);
            _spriteBatch.Draw(pikachuTexture, new Vector2(560, 130), Color.White);
            _spriteBatch.Draw(marioTexture, new Vector2(100, 300), Color.White);
         

            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
