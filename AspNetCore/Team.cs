using System;

namespace AspNetCore
{
  public class Team
  {
  public int Id { get; set; } 
  public int CoordinatorId { get; set; }
  public string? Name { get; set; }
  }
}