using Project.Domain;

namespace Project.Application
{
    public class EntityRepository : IEntityRepository
    {
        Entity IEntityRepository.AddEntity(Entity entity)
        {
            throw new NotImplementedException();
        }

        bool IEntityRepository.DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        List<Entity> IEntityRepository.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        Entity IEntityRepository.GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        Entity IEntityRepository.UpdateEntity(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
