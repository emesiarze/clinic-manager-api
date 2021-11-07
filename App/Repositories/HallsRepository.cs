using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
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