using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pong.Entities;
using Pong.Services;

namespace Pong
{
    public class PongGame : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private static readonly Color BackgroundColor = new Color(123, 207, 169, 1);
        private Paddle _paddle;

        public PongGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Services.AddService(typeof(InputManager), new InputManager());
            Services.AddService(typeof(StateManager), new StateManager());
            Services.AddService(typeof(EntityManager), new EntityManager());

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            var paddleTexture = Content.Load<Texture2D>("Textures/paddle");
            _paddle = new Paddle(paddleTexture, spriteBatch, new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2));

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            _paddle.Update(gameTime);
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(BackgroundColor);
            
            spriteBatch.Begin();
            _paddle.Draw(gameTime);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}