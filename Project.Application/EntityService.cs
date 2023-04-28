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
        Entity IEntityService.AddEntity(Entity entity)
        {
            throw new NotImplementedException();
        }

        bool IEntityService.DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        List<Entity> IEntityService.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        Entity IEntityService.GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        Entity IEntityService.UpdateEntity(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
