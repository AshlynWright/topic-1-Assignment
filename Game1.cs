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

        Texture2D dinoTexture;
        Texture2D sonictexture;
        //add more textures here
        //add more textures here

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
            sonictexture = Content.Load<Texture2D>("sonic");
            //load more textures here
            //load more textures here

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

            _spriteBatch.Draw(dinoTexture, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(100, 200), Color.White);
            _spriteBatch.Draw(sonictexture, new Vector2(500, 400), Color.White);
            _spriteBatch.Draw(sonictexture, new Vector2(300, 100), Color.White);
            _spriteBatch.Draw(sonictexture, new Vector2(200, 300), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(600, 150), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(400, 350), Color.White);
            //draw more textures here
            //draw more textures here






            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
