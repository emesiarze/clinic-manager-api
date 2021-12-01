using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
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