using System;

namespace cinema_manager_api.Models
{
  public class Movie : IDatabaseItem<Movie>
  {
    public Movie(string director, string title, int duration)
    {
      this.id = Guid.NewGuid();
      this.director = director;
      this.title = title;
      this.duration = duration;
    }

    public Guid id { get; init; }
    public string director { get; set; }
    public string title { get; set; }
    public int duration { get; set; }

    public void Update(Movie item)
    {
      this.director = item.director;
      this.title = item.title;
      this.duration = item.duration;
    }
  }
}