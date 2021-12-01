using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
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