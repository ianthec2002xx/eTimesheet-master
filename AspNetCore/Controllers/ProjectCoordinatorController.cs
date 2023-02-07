using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProjectCoordinatorController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public ProjectCoordinatorController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<ProjectCoordinator>>> Get()
    {
      return await _dbContext.ProjectCoordinators.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectCoordinator>> Get(int id)
    {
      return await _dbContext.ProjectCoordinators.FindAsync(id);
    }

    // POST api/foodrecords
    [HttpPost]
    public async Task Post(ProjectCoordinator model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, ProjectCoordinator model)
    {
      var exists = await _dbContext.ProjectCoordinators.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.ProjectCoordinators.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
       // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.ProjectCoordinators.FindAsync(id);

      _dbContext.ProjectCoordinators.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}