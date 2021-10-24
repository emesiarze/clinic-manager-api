using System;

namespace CinemaManagerApi.Models
{
  public class Reservation : IDatabaseItem<Reservation>
  {
    public Reservation(int id, int userId, int seanseId, int seatNumber, DateTime startTime, bool isPermanent)
    {
      this.id = id;
      this.userId = userId;
      this.seanseId = seanseId;
      this.seatNumber = seatNumber;
      this.startTime = startTime;
      this.isPermanent = isPermanent;
    }

    public int id { get; set; }
    public int userId { get; set; }
    public int seanseId { get; set; }
    public int seatNumber { get; set; }
    public DateTime startTime { get; set; }
    public bool isPermanent { get; set; }

    public void Update(Reservation item)
    {
      this.userId = item.userId;
      this.seanseId = item.seanseId;
      this.seatNumber = item.seatNumber;
      this.startTime = item.startTime;
      this.isPermanent = item.isPermanent;
    }
  }
}