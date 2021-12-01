using System;
using System.Collections.Generic;

namespace clinic_manager_api.Models
{
  public class Disease : IDatabaseItem<Disease>
  {
    public Disease(string name, List<Guid> symptomsIds)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptomsIds = symptomsIds;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public List<Guid> symptomsIds { get; set; }

    public void Update(Disease item)
    {
      this.name = item.name;
      this.symptomsIds = item.symptomsIds;
    }
  }

  public class DiseaseDto : IDataTransferObject
  {
    public DiseaseDto(string name, List<Symptom> symptoms)
    {
      this.id = Guid.NewGuid();
      this.name = name;
      this.symptoms = symptoms;
    }

    public Guid id { get; init; }
    public string name { get; set; }
    public List<Symptom> symptoms { get; set; }
  }
}