using System.Collections.Generic;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  class DiseasesRepository : GenericRepository<Disease, DiseaseDto>
  {
    public override List<Disease> items
    {
      get
      {
        return DiseasesData.items;
      }
    }
  }
}