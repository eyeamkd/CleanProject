using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository entityRepository;

        public EntityService(IEntityRepository entityRepository)
        { 
            this.entityRepository = entityRepository;
            
        }
        public Entity? AddEntity(Entity entity)
        {
            return entityRepository.AddEntity(entity);
        }

        public bool DeleteEntity(int id)
        {
            return entityRepository.DeleteEntity(id);
        }

        public List<Entity> GetAllEntities()
        {
            return entityRepository.GetAllEntities();
        }

        public Entity? GetEntityById(int id)
        {
            return entityRepository.GetEntityById(id);
        }

        public Entity? UpdateEntity(Entity entity)
        {
            return entityRepository.UpdateEntity(entity);
        }
    }
}
