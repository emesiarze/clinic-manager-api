using System;

namespace CinemaManagerApi.Models
{
  public interface IDatabaseItem<T>
  {
    Guid id { get; init; }

    void Update(T item);
  }
}