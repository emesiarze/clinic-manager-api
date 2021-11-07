using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
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
      return items.Find(item => item.id.Equals(id));
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
      T itemToUpdate = items.Find(itm => itm.id.Equals(item.id));
      itemToUpdate.Update(item);
      return "success";
    }

    public string DeleteItem(Guid id)
    {
      try
      {
        T selectedItem = items.Find(item => item.id.Equals(id));
        int index = items.IndexOf(selectedItem);
        items.RemoveAt(index);
        return "success";
      }
      catch
      {
        return "not_found";
      }
    }
  }
}