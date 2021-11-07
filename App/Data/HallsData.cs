using System.Collections.Generic;
using cinema_manager_api.Models;

namespace cinema_manager_api.Data
{
  public static class HallsData
  {
    public static List<Hall> items = new List<Hall>() {
      new Hall("1"),
      new Hall("2"),
      new Hall("3"),
      new Hall("4"),
    };
  }
}
