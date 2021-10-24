using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class SeansesRepository : GenericRepository<Seanse>
  {
    public override List<Seanse> items
    {
      get
      {
        return new List<Seanse>() {
          new Seanse(1, 1, 1, DateTime.Now),
          new Seanse(2, 2, 2, DateTime.Now),
          new Seanse(3, 3, 3, DateTime.Now),
          // { id: 4, movieId: 3, hallId: 3, startTime: "2021-11-24T20:25:16.9902582+02:00" }
        };
      }
    }
  }
}