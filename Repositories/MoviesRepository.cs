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
          new Movie(1, "Jan Makłowicz", "Ratatuj", 123),
          new Movie(2, "Stefan Gragóra", "Łocz dis", 160),
          new Movie(3, "Adam Handler", "Togres", 95),
          new Movie(4, "Swift Kieliver", "S.J.O.T.", 102),
          // { id: 5, director: "Podman Chabit", title: "WH1TE", duration: 113 },
        };
      }
    }
  }
}