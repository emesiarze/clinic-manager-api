using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class ReservationsRepository : GenericRepository<Reservation>
  {
    public override List<Reservation> items
    {
      get
      {
        return new List<Reservation>() {
          new Reservation(1, 1, 1, 1, DateTime.Now, false),
          new Reservation(2, 1, 1, 2, DateTime.Now, false),
          new Reservation(3, 2, 2, 2, DateTime.Now, false),
          new Reservation(4, 2, 2, 3, DateTime.Now, false),
          new Reservation(5, 3, 3, 4, DateTime.Now, false),
          new Reservation(6, 3, 4, 5, DateTime.Now, false),
          new Reservation(7, 3, 4, 6, DateTime.Now, false),
          
          // { id: 8, userId: 3, seanseId: 4, seatNumber: 8, startTime: new DateTime(), isPermanent: false },
        };
      }
    }
  }
}