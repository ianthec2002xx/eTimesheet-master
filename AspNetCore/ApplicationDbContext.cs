using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Hour> Hours { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Coordinator> Coordinators {get; set; }
    public DbSet<ProjectCoordinator> ProjectCoordinators { get; set; }
  }
}