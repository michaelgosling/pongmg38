using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong.Entities
{
    public class Paddle : Entity
    {
        private readonly Texture2D _texture;
        private readonly SpriteBatch _spriteBatch;

        public Paddle(Texture2D texture, SpriteBatch spriteBatch, Vector2 initLocation, string tag, bool isActive, bool isHidden) : base(initLocation, tag, isActive, isHidden)
        {
            _texture = texture;
            _spriteBatch = spriteBatch;
        }

        public void Update(GameTime gameTime) {}

        public void Draw(GameTime gameTime)
        {
            _spriteBatch.Draw(_texture, Location, Color.White);
        }

    }
}