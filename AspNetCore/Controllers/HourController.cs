using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HourController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public HourController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<Hour>>> Get()
    {
      return await _dbContext.Hours.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Hour>> Get(string id)
    {
      return await _dbContext.Hours.FindAsync(id);
    }

    // POST api/foodrecords
    [HttpPost]
    public async Task Post(Hour model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Hour model)
    {
      var exists = await _dbContext.Hours.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.Hours.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
       // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.Hours.FindAsync(id);

      _dbContext.Hours.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}