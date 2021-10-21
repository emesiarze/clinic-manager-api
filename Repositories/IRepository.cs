
using System.Collections.Generic;

namespace CinemaManagerApi.Repositories
{
  public interface IRepository<T>
  {
    void AddItem(T item);
    void DeleteItem(int id);
    IEnumerable<T> GetAllItems();
    T GetSingleItem(int id);
    void UpdateItem(T item);
  }
}