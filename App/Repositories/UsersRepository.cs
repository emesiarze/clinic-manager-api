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
        return UsersData.items;
      }
    }
  }
}