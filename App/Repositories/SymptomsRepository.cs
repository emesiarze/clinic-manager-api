using System;
using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  public class SymptomsRepository : GenericRepository<Symptom, Symptom>
  {
    public override List<Symptom> items
    {
      get
      {
        return SymptomsData.items;
      }
    }

    public override IEnumerable<Symptom> GetAllItemsDto()
    {
      return base.GetAllItems();
    }

    public override Symptom GetSingleItemDto(Guid id)
    {
      return base.GetSingleItem(id);
    }
  }
}