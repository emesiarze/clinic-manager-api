using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Data
{
  public static class ReservationsData
  {
    public static List<Reservation> items = new List<Reservation>() {
      new Reservation(1, 1, 1, DateTime.Now, false),
      new Reservation(1, 1, 2, DateTime.Now, false),
      new Reservation(2, 2, 2, DateTime.Now, false),
      new Reservation(2, 2, 3, DateTime.Now, false),
      new Reservation(3, 3, 4, DateTime.Now, false),
      new Reservation(3, 4, 5, DateTime.Now, false),
      new Reservation(3, 4, 6, DateTime.Now, false),
    };
  }
}
