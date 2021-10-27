using System;
using System.Collections.Generic;
using CinemaManagerApi.Data;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public class ReservationsRepository : GenericRepository<Reservation>
  {
    public override List<Reservation> items
    {
      get
      {
        return ReservationsData.items;
      }
    }
  }
}