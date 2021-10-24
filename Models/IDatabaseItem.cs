namespace CinemaManagerApi.Models
{
  public interface IDatabaseItem<T>
  {
    int id { get; set; }

    void Update(T item);
  }
}