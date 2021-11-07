using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  class MoviesRepository : GenericRepository<Movie>
  {
    public override List<Movie> items
    {
      get
      {
        return MoviesData.items;
      }
    }
  }
}