using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProjectController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public ProjectController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<Project>>> Get()
    {
      return await _dbContext.Projects.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Project>> Get(int id)
    {
      return await _dbContext.Projects.FindAsync(id);
    }
  [HttpGet]
    public async Task<ActionResult<List<Coordinator>>> Get()
    {
      return await _dbContext.Coordinators.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Coordinator>> Get(int id)
    {
      return await _dbContext.Coordinators.FindAsync(id);
    }
    // POST api/foodrecords
    [HttpPost]
    public async Task Post(Project model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Project model)
    {
      var exists = await _dbContext.Projects.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.Projects.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
       // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.Projects.FindAsync(id);

      _dbContext.Projects.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}