using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TeamController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public TeamController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<Team>>> Get()
    {
      return await _dbContext.Teams.ToListAsync();
    }

    // // GET api/foodrecords/5
    // [HttpGet("{id}")]
    // public async Task<ActionResult<Team>> Get(int id)
    // {
    //   return await _dbContext.Teams.FindAsync(id);
    // }

    // POST api/foodrecords
    [HttpPost]
    public async Task Post(Team model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Team model)
    {
      var exists = await _dbContext.Teams.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.Teams.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
       // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.Teams.FindAsync(id);

      _dbContext.Teams.Remove(entity);
       
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
     // GET api/foodrecords/5
    [HttpGet("{projectId}")]
    public async Task<ActionResult<Team>> Get(int projectId)
    {
      // return await _dbContext.Teams.FindAsync(projectId).Where(id => id.project == projectId);
        // return await _dbContext.Teams..Where(x => x.ProjectId == projectId);
        return await _dbContext.Teams.FindAsync(projectId);

    }
  }
}