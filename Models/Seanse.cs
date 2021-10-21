using System;

namespace CinemaManagerApi.Models
{
  public class Seanse
  {
    public int id { get; set; }
    public int movieId { get; set; }
    public int hallId { get; set; }
    public DateTime startTime { get; set; }
  }
}