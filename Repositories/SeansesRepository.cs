using System;
using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class SeansesRepository : GenericRepository<Seanse>
  {
    public override List<Seanse> items
    {
      get
      {
        return SeanseData.items;
      }
    }
  }
}