using System;
using System.Collections.Generic;
using System.Linq;
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

    public override DiseaseDto GetSingleItemDto(Guid id)
    {
      Disease disease = base.GetSingleItem(id);
      IEnumerable<Symptom> symptoms = disease.symptomsIds.Select(symptomId =>
      {
        Symptom symptomObject = SymptomsData.items.Find((Predicate<Symptom>)(symptom => symptom.id.Equals(symptomId)));
        return symptomObject;
      });

      return new DiseaseDto(disease.name, symptoms.ToList());
    }

    public override IEnumerable<DiseaseDto> GetAllItemsDto()
    {
      IEnumerable<Disease> diseases = base.GetAllItems();

      IEnumerable<DiseaseDto> diseasesDto = diseases.Select(disease =>
      {
        IEnumerable<Symptom> symptoms = disease.symptomsIds.Select(symptomId =>
        {
          Symptom symptomObject = SymptomsData.items.Find((Predicate<Symptom>)(symptom => symptom.id.Equals(symptomId)));
          return symptomObject;
        });
        return new DiseaseDto(disease.name, symptoms.ToList());
      });

      return diseasesDto;
    }
  }
}