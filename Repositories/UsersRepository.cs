using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class UsersRepository : IRepository<User>
  {
    private readonly List<User> items = new()
    {
      new User { id = 1, fullName = "Jan Kowalski", login = "jankow", password = "qwer", isWorker = false },
      new User { id = 2, fullName = "Tomasz Malinowski", login = "tommal", password = "qwer", isWorker = false },
      new User { id = 3, fullName = "Jerzy Gwóźdź", login = "jegwoz", password = "qwer", isWorker = true }
      // User for adding
      // new User { id = 4, fullName = "Nick Adams", login = "nicada", password = "qwer", isWorker = false }    
    };

    public IEnumerable<User> GetAllItems()
    {
      return items;
    }

    public User GetSingleItem(int id)
    {
      return items.Find(item => item.id.Equals(id));
    }

    public void AddItem(User item)
    {
      items.Add(item);
    }

    public void UpdateItem(User item)
    {
      User itemToUpdate = items.Find(usr => usr.id.Equals(item.id));

      itemToUpdate.fullName = item.fullName;
      itemToUpdate.isWorker = item.isWorker;
      itemToUpdate.password = item.password;
    }

    public void DeleteItem(int id)
    {
      User selectedItem = items.Find(item => item.id.Equals(id));
      int index = items.IndexOf(selectedItem);
      items.RemoveAt(index);
    }
  }
}