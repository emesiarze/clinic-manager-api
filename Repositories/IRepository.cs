
using System;
using System.Collections.Generic;

namespace CinemaManagerApi.Repositories
{
  public interface IRepository<IIdentifiable>
  {
    void AddItem(IIdentifiable item);
    void DeleteItem(Guid id);
    IEnumerable<IIdentifiable> GetAllItems();
    IIdentifiable GetSingleItem(Guid id);
    void UpdateItem(IIdentifiable item);
  }
}