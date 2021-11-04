using System;

namespace CinemaManagerApi.Models
{
  public class Seanse : IDatabaseItem<Seanse>
  {
    public Seanse(Guid movieId, Guid hallId, DateTime startTime)
    {
      this.id = Guid.NewGuid();
      this.movieId = movieId;
      this.hallId = hallId;
      this.startTime = startTime;
    }

    public Guid id { get; init; }
    public Guid hallId { get; set; }
    public Guid movieId { get; set; }
    public Hall hall { get; set; }
    public Movie movie { get; set; }
    public DateTime startTime { get; set; }

    public void Update(Seanse item)
    {
      this.movieId = item.movieId;
      this.hallId = item.hallId;
      this.startTime = item.startTime;
    }
  }
}