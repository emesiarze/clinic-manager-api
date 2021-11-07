using System;

namespace CinemaManagerApi.Models
{
  public class Reservation : IDatabaseItem<Reservation>
  {
    public Reservation()
    {
      this.id = Guid.NewGuid();
    }

    public Reservation(Guid userId, Guid seanseId, int seatNumber, DateTime startTime, bool isPermanent)
    {
      this.id = Guid.NewGuid();
      this.userId = userId;
      this.seanseId = seanseId;
      this.seatNumber = seatNumber;
      this.startTime = DateTime.Now;
      this.isPermanent = isPermanent;
    }

    public Reservation(Reservation reservation)
    {
      this.id = Guid.NewGuid();
      this.userId = reservation.userId;
      this.seanseId = reservation.seanseId;
      this.seatNumber = reservation.seatNumber;
      this.startTime = DateTime.Now;
      this.isPermanent = reservation.isPermanent;
    }

    public Guid id { get; init; }
    public Guid userId { get; set; }
    public Guid seanseId { get; set; }
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