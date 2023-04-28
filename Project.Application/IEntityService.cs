using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application
{
    public interface IEntityService
    {
        Entity AddEntity(Entity entity);
        List<Entity> GetAllEntities();
        Entity GetEntityById(int id);
        Entity UpdateEntity(Entity entity);
        bool DeleteEntity(int id);
    }
}
