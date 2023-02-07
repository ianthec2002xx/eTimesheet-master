using System;

namespace AspNetCore
{
  public class Hour
  {
  public int Id { get; set; } 
  public string? Task { get; set; }
  public string? Description { get; set; }
  public int Hours { get; set; }
  public int Minutes { get; set; }
  public DateOnly Date { get; set; }
  }
}