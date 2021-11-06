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

    public override IEnumerable<Reservation> GetAllItems()
    {
      this.items.ForEach(item =>
      {
        User user = UsersData.items.Find(h => h.id.Equals(item.userId));
        Seanse seanse = SeansesData.items.Find(m => m.id.Equals(item.seanseId));
      });

      return items;
    }

    public override Reservation GetSingleItem(Guid id)
    {
      Reservation item = base.GetSingleItem(id);

      User user = UsersData.items.Find(h => h.id.Equals(item.userId));
      Seanse seanse = SeansesData.items.Find(m => m.id.Equals(item.seanseId));

      return item;
    }
  }
}