using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application
{
    public interface IEntityRepository
    {
        Entity? AddEntity(Entity entity); 
        Entity? GetEntityById(int id);
        List<Entity> GetAllEntities();
        Entity? UpdateEntity(Entity entity);
        bool DeleteEntity(int id);
    }
}
