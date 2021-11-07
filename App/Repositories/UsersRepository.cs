using System.Collections.Generic;
using cinema_manager_api.Data;
using cinema_manager_api.Models;

namespace cinema_manager_api.Repositories
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