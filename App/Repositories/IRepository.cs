
using System;
using System.Collections.Generic;

namespace clinic_manager_api.Repositories
{
  public interface IRepository<T, TDto>
  {
    string AddItem(T item);
    string DeleteItem(Guid id);
    IEnumerable<T> GetAllItems();
    T GetSingleItem(Guid id);
    IEnumerable<TDto> GetAllItemsDto();
    TDto GetSingleItemDto(Guid id);
    string UpdateItem(T item);
  }
}