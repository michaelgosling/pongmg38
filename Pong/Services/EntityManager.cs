using System.Collections.Generic;
using Pong.Entities;

namespace Pong.Services
{
    public class EntityManager
    {
        private Dictionary<string, List<Entity>> _entities;
        

        public EntityManager()
        {
            
        }

        public void AddEntity(Entity entity)
        {
            _entities.TryGetValue(entity.Tag);
            _entities[entity.Tag][entity.GetHashCode()] = entity;
        }

        public void RemoveEntity(string tag)
        {
            
        }
        
    }
}