using System;

namespace CinemaManagerApi.Models
{
  public class Hall : IDatabaseItem<Hall>
  {
    public Hall(int number)
    {
      this.id = Guid.NewGuid();
      this.number = number;
    }

    public Guid id { get; init; }
    public int number { get; set; }

    public void Update(Hall item)
    {
      this.number = number;
    }
  }
}