
using System;
using System.Collections.Generic;

namespace clinic_manager_api.Repositories
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