namespace CinemaManagerApi.Models
{
  public class Movie : IDatabaseItem<Movie>
  {
    public Movie(int id, string director, string title, int duration)
    {
      this.id = id;
      this.director = director;
      this.title = title;
      this.duration = duration;
    }

    public int id { get; set; }
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