using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong.Entities
{
    public class Paddle
    {
        private readonly Texture2D _texture;
        private readonly SpriteBatch _spriteBatch;
        private Vector2 position;

        public Paddle(Texture2D texture, SpriteBatch spriteBatch, Vector2 initLocation)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
            position = initLocation;
        }

        public void Update(GameTime gameTime) {}

        public void Draw(GameTime gameTime)
        {
            _spriteBatch.Draw(_texture, position, Color.White);
        }

    }
}