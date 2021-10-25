using System;
using System.Collections.Generic;

namespace CinemaManagerApi.Repositories
{
  public class MongoDbUsersRepository : IRepository<UsersRepository>
  {
    public void AddItem(UsersRepository item)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteItem(Guid id)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<UsersRepository> GetAllItems()
    {
      throw new System.NotImplementedException();
    }

    public UsersRepository GetSingleItem(Guid id)
    {
      throw new System.NotImplementedException();
    }

    public void UpdateItem(UsersRepository item)
    {
      throw new System.NotImplementedException();
    }
  }
}