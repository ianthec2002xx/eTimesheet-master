using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MemberController : ControllerBase
  {
    private readonly ApplicationDbContext _dbContext;

    public MemberController(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<Member>>> Get()
    {
      return await _dbContext.Members.ToListAsync();
    }
  }
}