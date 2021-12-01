using System;
using System.Linq;
using System.Collections.Generic;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{

  public abstract class GenericRepository<T> : IRepository<T> where T : IDatabaseItem<T>
  {
    abstract public List<T> items { get; }

    public virtual IEnumerable<T> GetAllItems()
    {
      return items;
    }

    public virtual T GetSingleItem(Guid id)
    {
      var singleItemQuery = from qItem in items
                            where qItem.id == id
                            select qItem;

      return singleItemQuery.FirstOrDefault<T>();
    }

    public virtual string AddItem(T item)
    {
      try
      {
        items.Add(item);
        return "success";
      }
      catch
      {
        return "error";
      }
    }

    public virtual string UpdateItem(T item)
    {
      try
      {
        var itemToUpdateQuery = from qItem in items
                                where qItem.id == item.id
                                select qItem;

        T itemToUpdate = itemToUpdateQuery.FirstOrDefault<T>();
        itemToUpdate.Update(item);
        return "success";
      }
      catch
      {
        return "error";
      }
    }

    public string DeleteItem(Guid id)
    {
      try
      {
        var itemToDeleteQuery = from qItem in items
                                where qItem.id == id
                                select qItem;

        T selectedItem = items.Find(item => item.id.Equals(id));
        int index = items.IndexOf(selectedItem);
        items.RemoveAt(index);
        return "success";
      }
      catch
      {
        return "error";
      }
    }
  }
}
