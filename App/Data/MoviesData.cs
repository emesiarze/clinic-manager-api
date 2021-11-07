using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class MoviesData
  {
    public static List<Movie> items = new List<Movie>() {
      new Movie("Jan Makłowicz", "Ratatuj", 123),
      new Movie("Stefan Gragóra", "Łocz dis", 160),
      new Movie("Adam Handler", "Togres", 95),
      new Movie("Swift Kieliver", "S.J.O.T.", 102),
    };
  }
}
