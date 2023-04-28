using Project.Domain;
using Project.Infrastructure;

namespace Project.Application
{
    public class EntityRepository : IEntityRepository
    {
        private readonly ProjectDBContext projectDbContext;

        public EntityRepository(ProjectDBContext projectDBContext)
        {
            this.projectDbContext = projectDBContext;
        }

        public Entity? AddEntity(Entity entity)
        {
            projectDbContext.Entities.Add(entity);
            projectDbContext.SaveChanges();
            var newEntity = projectDbContext.Entities.SingleOrDefault(e => e.Id == entity.Id);
            return newEntity;
        }

        bool IEntityRepository.DeleteEntity(int id)
        {
            Entity? entity = projectDbContext.Entities.SingleOrDefault(e => e.Id == id);
            if(entity is not  null)
            {
                projectDbContext.Entities.Remove(entity);
                return true;
            }
            return false;
           
        }

        List<Entity> IEntityRepository.GetAllEntities()
        {
            return projectDbContext.Entities.ToList();   
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
