
using System;
using System.Collections.Generic;

namespace CinemaManagerApi.Repositories
{
  public interface IRepository<IIdentifiable>
  {
    string AddItem(IIdentifiable item);
    string DeleteItem(Guid id);
    IEnumerable<IIdentifiable> GetAllItems();
    IIdentifiable GetSingleItem(Guid id);
    string UpdateItem(IIdentifiable item);
  }
}