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

    [HttpGet]
    public async Task<ActionResult<List<Project>>> Get()
    {
      return await _dbContext.Projects.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("projects/{id}")]
    public async Task<ActionResult<Project>> Get(int id)
    {
      return await _dbContext.Projects.FindAsync(id);
    }
    
    // [HttpGet]
    // public async Task<ActionResult<List<Coordinator>>> Get()
    // {
    //   return await _dbContext.Coordinators.ToListAsync();
    // }

    // GET api/foodrecords/5
    [HttpGet("coordinators/{id2}")]
    public async Task<ActionResult<Coordinator>> Get(int id2)
    {
      return await _dbContext.Coordinators.FindAsync(id2);
    }
  }
}