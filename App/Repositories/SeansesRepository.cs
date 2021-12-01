using System;
using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  public class SeansesRepository : GenericRepository<Diagnose>
  {
    public override List<Diagnose> items
    {
      get
      {
        return SeansesData.items;
      }
    }

    override public IEnumerable<Diagnose> GetAllItems()
    {
      this.items.ForEach((Action<Diagnose>)(item =>
      {
        Symptom hall = HallsData.items.Find((Predicate<Symptom>)(h => (bool)h.id.Equals(item.symptomId)));
        Symptom movie = MoviesData.items.Find((Predicate<Symptom>)(m => (bool)m.id.Equals(item.diseaseId)));

        item.hall = hall;
        item.movie = movie;
      }));

      return items;
    }

    override public Diagnose GetSingleItem(Guid id)
    {
      Diagnose item = base.GetSingleItem(id);
      Symptom hall = HallsData.items.Find(h => h.id.Equals(item.symptomId));
      Symptom movie = MoviesData.items.Find(m => m.id.Equals(item.diseaseId));

      item.hall = hall;
      item.movie = movie;

      return item;
    }
  }
}