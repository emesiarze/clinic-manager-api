using System;

namespace cinema_manager_api.Models
{
  public interface IDatabaseItem<T>
  {
    Guid id { get; init; }

    void Update(T item);
  }
}