
using System.Collections.Generic;

namespace CinemaManagerApi.Repositories
{
  public interface IRepository<IIdentifiable>
  {
    void AddItem(IIdentifiable item);
    void DeleteItem(int id);
    IEnumerable<IIdentifiable> GetAllItems();
    IIdentifiable GetSingleItem(int id);
    void UpdateItem(IIdentifiable item);
  }
}