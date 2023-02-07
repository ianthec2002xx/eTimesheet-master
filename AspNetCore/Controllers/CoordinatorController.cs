using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CoordinatorController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public CoordinatorController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
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
    public async Task Post(Coordinator model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Coordinator model)
    {
      var exists = await _dbContext.Coordinators.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.Coordinators.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
       // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.Coordinators.FindAsync(id);

      _dbContext.Coordinators.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}