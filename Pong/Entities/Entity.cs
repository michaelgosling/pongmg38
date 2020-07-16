using Microsoft.Xna.Framework;

namespace Pong.Entities
{
    public abstract class Entity
    {
        public string Tag { get; private set; }
        public Vector2 Location { get; private set; }

        public float X => Location.X;

        public float Y => Location.Y;
        public bool IsActive { get; private set; }
        public bool IsHidden { get; private set; }

        protected Entity(Vector2 location, string tag, bool isActive, bool isHidden)
        {
            Tag = tag;
            Location = location;
            IsActive = isActive;
            IsHidden = isHidden;
        }
    }
}