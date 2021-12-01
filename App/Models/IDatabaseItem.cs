using System;

namespace clinic_manager_api.Models
{
  public interface IDatabaseItem<T>
  {
    Guid id { get; init; }

    void Update(T item);
  }
}