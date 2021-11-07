using System.Collections.Generic;
using cinema_manager_api.Data;
using cinema_manager_api.Models;

namespace cinema_manager_api.Repositories
{
  public class HallsRepository : GenericRepository<Hall>
  {
    public override List<Hall> items
    {
      get
      {
        return HallsData.items;
      }
    }
  }
}