using System;

namespace CinemaManagerApi.Models
{
  public class Reservation : IDatabaseItem<Reservation>
  {
    public Reservation(int userId, int seanseId, int seatNumber, DateTime startTime, bool isPermanent)
    {
      this.id = Guid.NewGuid();
      this.userId = userId;
      this.seanseId = seanseId;
      this.seatNumber = seatNumber;
      this.startTime = startTime;
      this.isPermanent = isPermanent;
    }

    public Guid id { get; init; }
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