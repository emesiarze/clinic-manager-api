using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class SeanseData
  {
    public static List<Seanse> items = new List<Seanse>() {
      new Seanse(1, 1, DateTime.Now),
      new Seanse(2, 2, DateTime.Now),
      new Seanse(3, 3, DateTime.Now),
    };
  }
}
