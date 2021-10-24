using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class HallsRepository : GenericRepository<Hall>
  {
    public override List<Hall> items
    {
      get
      {
        return new List<Hall>() {
          new Hall(1, 1),
          new Hall(2, 2),
          new Hall(3, 3),
          new Hall(4, 4),
          // { id: 5, number: 5 },
        };
      }
    }
  }
}