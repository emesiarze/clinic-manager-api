using System;

namespace CinemaManagerApi.Models
{
  public class Reservation
  {
    public int id { get; set; }
    public int userId { get; set; }
    public int seanseId { get; set; }
    public int seatNumber { get; set; }
    public DateTime startTime { get; set; }
    public bool isPermanent { get; set; }
  }
}