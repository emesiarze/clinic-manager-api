using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class UsersRepository : GenericRepository<User>
  {
    public override List<User> items
    {
      get
      {
        return UsersData.users;
      }
    }

    User login(string login, string password)
    {
      return items.Find(user => user.login == login && user.password == password);
    }
  }
}