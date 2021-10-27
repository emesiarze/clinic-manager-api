using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class HallsData
  {
    public static List<Hall> items = new List<Hall>() {
      new Hall(1),
      new Hall(2),
      new Hall(3),
      new Hall(4),
    };
  }
}
