using Microsoft.Xna.Framework;

namespace Pong.Renderers
{
    public class EntityRenderer : DrawableGameComponent
    {
        public EntityRenderer(Game game) : base(game)
        {
            Services.EntityManager
        }

        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            
            base.Draw(gameTime);
        }
    }
}