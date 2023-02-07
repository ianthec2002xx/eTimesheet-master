using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TeamMemberController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public TeamMemberController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<TeamMember>>> Get()
    {
      return await _dbContext.TeamMembers.ToListAsync();
    }
  }
}