using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application;
using Project.Domain;


namespace Project.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : Controller
    {
       
        private readonly IEntityService entityService;
        public EntityController(IEntityService entityService) 
        {
            this.entityService = entityService;
        }

        [HttpGet("{id}")]
        // GET: EntityController/Details/5
        public ActionResult<Entity> Details(int id)
        {
            return entityService.GetEntityById(id);
        }

        [HttpGet]
        public ActionResult<List<Entity>> GetAll()
        {
            return entityService.GetAllEntities();
        }

        [HttpPost]
        public ActionResult<Entity> Create([FromBody] Entity entity)
        {
            return entityService.AddEntity(entity);
        }
        
        [HttpPatch]
        // GET: EntityController/Edit/5
        public ActionResult<Entity?> Edit([FromBody] Entity entity)
        {
            return entityService.UpdateEntity(entity);    
        }

        [HttpDelete("{id}")]
        // GET: EntityController/Delete/5
        public ActionResult<bool> Delete(int id)
        {
            return entityService.DeleteEntity(id);
        }
    }
}
