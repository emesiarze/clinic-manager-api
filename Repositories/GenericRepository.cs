using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{

  public abstract class GenericRepository<T> : IRepository<T> where T : IDatabaseItem<T>
  {
    abstract public List<T> items { get; }

    public IEnumerable<T> GetAllItems()
    {
      return items;
    }

    public T GetSingleItem(Guid id)
    {
      return items.Find(item => item.id == id);
    }

    public void AddItem(T item)
    {
      items.Add(item);
    }

    public void UpdateItem(T item)
    {
      T itemToUpdate = items.Find(itm => itm.id.Equals(item.id));
      itemToUpdate.Update(item);
    }

    public void DeleteItem(Guid id)
    {
      T selectedItem = items.Find(item => item.id.Equals(id));
      int index = items.IndexOf(selectedItem);
      items.RemoveAt(index);
    }
  }
}
