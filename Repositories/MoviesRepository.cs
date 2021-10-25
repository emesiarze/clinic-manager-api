using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  class MoviesRepository : GenericRepository<Movie>
  {
    public override List<Movie> items
    {
      get
      {
        return new List<Movie>() {
          new Movie("Jan Makłowicz", "Ratatuj", 123),
          new Movie("Stefan Gragóra", "Łocz dis", 160),
          new Movie("Adam Handler", "Togres", 95),
          new Movie("Swift Kieliver", "S.J.O.T.", 102),
          // { id: 5, director: "Podman Chabit", title: "WH1TE", duration: 113 },
        };
      }
    }
  }
}